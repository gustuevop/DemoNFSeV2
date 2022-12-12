using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using NFSeDataSetX;
using NFSeX;

namespace DemoNFSeV2
{
    public partial class frmPrincipal : Form
    {

        private spdNFSeX NFSe = new spdNFSeX();
        private spdNFSeDataSetX vNFSeDataSet = new spdNFSeDataSetX();
        private XmlDocument xDoc = new XmlDocument();
        public OpenFileDialog AbrirArquivo = new OpenFileDialog();

        public frmPrincipal()
        {
            InitializeComponent();
            NFSe.ConfigurarSoftwareHouse("08187168000160", "uR4BwzifCN2t7Nuf7IOlo4Z0Vbnojlroa13x3dVu");
            PreencherComboCertificado();
        }

        private void IncluirLinha(RichTextBox MemoAux, string pTexto)
        {
            MemoAux.Text = MemoAux.Text + (pTexto) + Environment.NewLine;
        }
        private void PreencherComboCertificado()
        {
            try
            {
                string[] vetor;
                string certificado = "";

                certificado = NFSe.ListarCertificados();

                if (certificado != "" & certificado != null)
                {
                    vetor = certificado.Split('|');
                    cb_Certificado.Items.Clear();

                    for (int i = 0; i <= vetor.Length - 1; i++)
                    {
                        if (vetor[i] != "")
                            cb_Certificado.Items.Add(vetor[i]);
                    }
                }

                if (cb_Certificado.Items.Count > 0)
                    cb_Certificado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SalvarConfiguracoes()
        {
            NFSe.CNPJ = tb_CNPJ.Text.Trim();
            NFSe.InscricaoMunicipal = tb_InscricaoMunicipal.Text.ToUpper().Trim();
            NFSe.ParametrosExtras = "Login=" + tb_Login.Text + "Senha=" + tb_Senha.Text;
            NFSe.NomeCertificado = cb_Certificado.Text;
            NFSe.TipoCertificado = TipoCertificado.ckFileX;
            NFSe.DiretorioLog = "C:\\Log";
            NFSe.Arquivos = "C:\\Program Files\\TecnoSpeed\\NFSe\\Arquivos";
            ConfiguraCidade();
            
            
        }
        private void ConfiguraAmbiente()
        {
            if (rbt_Producao.Checked)
            {
                NFSe.Ambiente = Ambiente.akProducao;
                MessageBox.Show("Configurações salvas em ambiente de Produção!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                NFSe.Ambiente = Ambiente.akHomologacao;
                MessageBox.Show("Configurações salvas em ambiente de Homologação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ConfiguraCidade()
        {
            try
            {
                NFSe.Cidade = tb_Cidade.Text.ToUpper().Trim();
                NFSe.AtualizarArquivos();
                ConfiguraAmbiente();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvarConfiguracoes();
        }
        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string XMLAux = BuscarArquivo("Selecionar XML para envio.", "TX2 (*.tx2)|*.tx2");

            if (XMLAux != "")
            {
                try
                {
                    NFSe.Enviar(XMLAux);
                    RetornoV2Tipado();
                    RetornoV2Json();
                }
                catch (Exception ex)
                {
                    tb_XMLEnvio.Clear();
                    tb_XMLEnvio.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar um arquivo TX2", "Atenção", MessageBoxButtons.OK);
            }
        }
        private void btn_ConsultarNFSe_Click(object sender, EventArgs e)
        {
            NFSe.Consultar(tb_NumeroNFSe.Text, tb_NumeroRPS.Text, tb_SerieRPS.Text, tb_TipoRPS.Text, tb_Protocolo.Text);
            RetornoV2Tipado();
            RetornoV2Json();
        }
        private void btn_CancelarNFSe_Click(object sender, EventArgs e)
        {
            NFSe.CancelarNota(tb_ChaveCancelamento.Text);
            RetornoV2Tipado();
            RetornoV2Json();
        }
        public string BuscarArquivo(string Titulo, string tipoArquivo)
        {
            AbrirArquivo.Title = Titulo;
            AbrirArquivo.Filter = tipoArquivo;
            AbrirArquivo.FileName = "";
            AbrirArquivo.InitialDirectory = Application.StartupPath;

            DialogResult dr1 = AbrirArquivo.ShowDialog();
            if (dr1 == System.Windows.Forms.DialogResult.OK)
                return AbrirArquivo.FileName;
            else
                return "";
        }
        private void RetornoV2Tipado()
        {
            int vTotal;
            tb_Tipado.Clear();
            tb_Tipado.Multiline = true;

            vTotal = NFSe.RetornoWS.Count();

            for (int i = 0; i < vTotal; i++)
            {
                IncluirLinha(tb_Tipado, "Status: " + NFSe.RetornoWS.Items(i).Status);

                if (NFSe.RetornoWS.Items(i).Status == "EMPROCESSAMENTO")
                {
                    IncluirLinha(tb_Tipado, "Protocolo: " + NFSe.RetornoWS.Items(i).Protocolo);
                    if (NFSe.RetornoWS.Items(i).Protocolo != "")
                    {
                        tb_Protocolo.Text = NFSe.RetornoWS.Items(i).Protocolo;
                    }
                }
                else
                if (NFSe.RetornoWS.Items(i).Status == "ERRO")
                {
                    IncluirLinha(tb_Tipado, "Motivo: " + NFSe.RetornoWS.Items(i).Motivo);
                }
                else
                {
                    IncluirLinha(tb_Tipado, "Protocolo: " + NFSe.RetornoWS.Items(i).Protocolo);
                    IncluirLinha(tb_Tipado, "CNPJ: " + NFSe.RetornoWS.Items(i).CNPJ);
                    IncluirLinha(tb_Tipado, "Inscricao Municipal: " + NFSe.RetornoWS.Items(i).InscricaoMunicipal);
                    IncluirLinha(tb_Tipado, "Serie do RPS: " + NFSe.RetornoWS.Items(i).SerieRps);
                    IncluirLinha(tb_Tipado, "Número do RPS: " + NFSe.RetornoWS.Items(i).NumeroRps);
                    IncluirLinha(tb_Tipado, "Número da NFS-e: " + NFSe.RetornoWS.Items(i).NumeroNFSe);
                    IncluirLinha(tb_Tipado, "Data de Emissão: " + NFSe.RetornoWS.Items(i).DataEmissaoNFSe);
                    IncluirLinha(tb_Tipado, "Código de Verificação: " + NFSe.RetornoWS.Items(i).CodVerificacao);
                    IncluirLinha(tb_Tipado, "Situação: " + NFSe.RetornoWS.Items(i).Situacao);
                    IncluirLinha(tb_Tipado, "Data De Cancelamento: " + NFSe.RetornoWS.Items(i).DataCancelamento);
                    IncluirLinha(tb_Tipado, "Chave de Cancelamento: " + NFSe.RetornoWS.Items(i).ChaveCancelamento);
                    IncluirLinha(tb_Tipado, "Tipo: " + NFSe.RetornoWS.Items(i).Tipo);
                    IncluirLinha(tb_Tipado, "Motivo: " + NFSe.RetornoWS.Items(i).Motivo);
                    IncluirLinha(tb_Tipado, "XML: " + NFSe.RetornoWS.Items(i).XmlImpressao);
                    IncluirLinha(tb_Tipado, "Data de Autorização: " + NFSe.RetornoWS.Items(i).DataAutorizacao);
                    IncluirLinha(tb_Tipado, "");
                    IncluirLinha(tb_Tipado, "================================================");
                    IncluirLinha(tb_Tipado, "");
                }
                //Tratamentos somente para Demo
                if (NFSe.RetornoWS.Items(i).Protocolo != "")
                {
                    tb_Protocolo.Text = NFSe.RetornoWS.Items(i).Protocolo;
                }
                tb_NumeroRPS.Text = NFSe.RetornoWS.Items(i).NumeroRps;
                tb_SerieRPS.Text = NFSe.RetornoWS.Items(i).SerieRps;
                tb_TipoRPS.Text = NFSe.RetornoWS.Items(i).Tipo;
                tb_NFSe.Text = NFSe.RetornoWS.Items(i).NumeroNFSe;
                tb_ChaveCancelamento.Text = NFSe.RetornoWS.Items(i).ChaveCancelamento;
                tb_XML.Text = NFSe.RetornoWS.Items(i).XmlImpressao;
            }
        }
        public void RetornoV2Json()
        {
            tb_JSON.Clear();
            IncluirLinha(tb_JSON, NFSe.RetornoJson());
        }


    }
}
