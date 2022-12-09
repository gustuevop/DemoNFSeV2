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

        public string CNPJSH = "08187168000160";
        public string TokenSH = "";

        public frmPrincipal()
        {
            InitializeComponent();
            NFSe.ConfigurarSoftwareHouse(CNPJSH, TokenSH);
            PreencherComboCertificado();
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
                NFSe.Enviar(XMLAux);
                //RetornoV2Tipado();
                //RetornoV2Json();
            }
            else
            {
                MessageBox.Show("Favor selecionar um arquivo TX2", "Atenção", MessageBoxButtons.OK);
            }
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
    }
}
