namespace DemoNFSeV2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Principal = new System.Windows.Forms.TabControl();
            this.tb_NFSe = new System.Windows.Forms.TabPage();
            this.tc_Retorno = new System.Windows.Forms.TabControl();
            this.tsXML = new System.Windows.Forms.TabPage();
            this.tb_XMLEnvio = new System.Windows.Forms.RichTextBox();
            this.tsXMLFormatado = new System.Windows.Forms.TabPage();
            this.tb_XML = new System.Windows.Forms.RichTextBox();
            this.tsJSON = new System.Windows.Forms.TabPage();
            this.tb_JSON = new System.Windows.Forms.RichTextBox();
            this.tsFormatado = new System.Windows.Forms.TabPage();
            this.tb_Tipado = new System.Windows.Forms.RichTextBox();
            this.gb_Operacoes = new System.Windows.Forms.GroupBox();
            this.btn_CancelarNFSe = new System.Windows.Forms.Button();
            this.btn_ConsultarNFSe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_NumeroNFSe = new System.Windows.Forms.Label();
            this.tb_NumeroNFSe = new System.Windows.Forms.TextBox();
            this.tb_Protocolo = new System.Windows.Forms.TextBox();
            this.tb_ChaveCancelamento = new System.Windows.Forms.TextBox();
            this.lbl_TipoRPS = new System.Windows.Forms.Label();
            this.lbl_Protocolo = new System.Windows.Forms.Label();
            this.lbl_SerieRPS = new System.Windows.Forms.Label();
            this.lbl_NumeroRPS = new System.Windows.Forms.Label();
            this.tb_TipoRPS = new System.Windows.Forms.TextBox();
            this.tb_SerieRPS = new System.Windows.Forms.TextBox();
            this.tb_NumeroRPS = new System.Windows.Forms.TextBox();
            this.btn_EnviarRPS = new System.Windows.Forms.Button();
            this.gb_NFSe = new System.Windows.Forms.GroupBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.gb_Ambiente = new System.Windows.Forms.GroupBox();
            this.rbt_Producao = new System.Windows.Forms.RadioButton();
            this.rbt_Homologacao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.tb_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_InscricaoMunicipal = new System.Windows.Forms.Label();
            this.tb_CNPJ = new System.Windows.Forms.TextBox();
            this.lbl_CNPJ = new System.Windows.Forms.Label();
            this.tb_InscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.gp_Autenticacao = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Certificado = new System.Windows.Forms.ComboBox();
            this.tp_Impressao = new System.Windows.Forms.TabPage();
            this.gb_Impressao = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_CamposCustomizados = new System.Windows.Forms.Label();
            this.tb_CamposCustomizados = new System.Windows.Forms.TextBox();
            this.btn_LogoEmitente = new System.Windows.Forms.Button();
            this.lbl_LogoEmitente = new System.Windows.Forms.Label();
            this.tb_LogoEmitente = new System.Windows.Forms.TextBox();
            this.gb_Acoes = new System.Windows.Forms.GroupBox();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.tc_Principal.SuspendLayout();
            this.tb_NFSe.SuspendLayout();
            this.tc_Retorno.SuspendLayout();
            this.tsXML.SuspendLayout();
            this.tsXMLFormatado.SuspendLayout();
            this.tsJSON.SuspendLayout();
            this.tsFormatado.SuspendLayout();
            this.gb_Operacoes.SuspendLayout();
            this.gb_NFSe.SuspendLayout();
            this.gb_Ambiente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gp_Autenticacao.SuspendLayout();
            this.tp_Impressao.SuspendLayout();
            this.gb_Impressao.SuspendLayout();
            this.gb_Acoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Principal
            // 
            this.tc_Principal.Controls.Add(this.tb_NFSe);
            this.tc_Principal.Controls.Add(this.tp_Impressao);
            this.tc_Principal.ItemSize = new System.Drawing.Size(172, 18);
            this.tc_Principal.Location = new System.Drawing.Point(3, 2);
            this.tc_Principal.Name = "tc_Principal";
            this.tc_Principal.SelectedIndex = 0;
            this.tc_Principal.Size = new System.Drawing.Size(629, 393);
            this.tc_Principal.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tc_Principal.TabIndex = 0;
            // 
            // tb_NFSe
            // 
            this.tb_NFSe.Controls.Add(this.gb_Operacoes);
            this.tb_NFSe.Controls.Add(this.gb_NFSe);
            this.tb_NFSe.Location = new System.Drawing.Point(4, 22);
            this.tb_NFSe.Name = "tb_NFSe";
            this.tb_NFSe.Padding = new System.Windows.Forms.Padding(3);
            this.tb_NFSe.Size = new System.Drawing.Size(621, 367);
            this.tb_NFSe.TabIndex = 0;
            this.tb_NFSe.Text = "NFSe";
            this.tb_NFSe.UseVisualStyleBackColor = true;
            // 
            // tc_Retorno
            // 
            this.tc_Retorno.Controls.Add(this.tsXML);
            this.tc_Retorno.Controls.Add(this.tsXMLFormatado);
            this.tc_Retorno.Controls.Add(this.tsJSON);
            this.tc_Retorno.Controls.Add(this.tsFormatado);
            this.tc_Retorno.Location = new System.Drawing.Point(3, 397);
            this.tc_Retorno.Name = "tc_Retorno";
            this.tc_Retorno.SelectedIndex = 0;
            this.tc_Retorno.Size = new System.Drawing.Size(625, 313);
            this.tc_Retorno.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tc_Retorno.TabIndex = 6;
            // 
            // tsXML
            // 
            this.tsXML.Controls.Add(this.tb_XMLEnvio);
            this.tsXML.Location = new System.Drawing.Point(4, 22);
            this.tsXML.Name = "tsXML";
            this.tsXML.Padding = new System.Windows.Forms.Padding(3);
            this.tsXML.Size = new System.Drawing.Size(617, 287);
            this.tsXML.TabIndex = 0;
            this.tsXML.Text = "XML envio, somente para impressão";
            this.tsXML.UseVisualStyleBackColor = true;
            // 
            // tb_XMLEnvio
            // 
            this.tb_XMLEnvio.Location = new System.Drawing.Point(2, 1);
            this.tb_XMLEnvio.Name = "tb_XMLEnvio";
            this.tb_XMLEnvio.Size = new System.Drawing.Size(615, 288);
            this.tb_XMLEnvio.TabIndex = 0;
            this.tb_XMLEnvio.Text = "";
            // 
            // tsXMLFormatado
            // 
            this.tsXMLFormatado.Controls.Add(this.tb_XML);
            this.tsXMLFormatado.Location = new System.Drawing.Point(4, 22);
            this.tsXMLFormatado.Name = "tsXMLFormatado";
            this.tsXMLFormatado.Padding = new System.Windows.Forms.Padding(3);
            this.tsXMLFormatado.Size = new System.Drawing.Size(617, 287);
            this.tsXMLFormatado.TabIndex = 1;
            this.tsXMLFormatado.Text = "XML";
            this.tsXMLFormatado.UseVisualStyleBackColor = true;
            // 
            // tb_XML
            // 
            this.tb_XML.Location = new System.Drawing.Point(3, 2);
            this.tb_XML.Name = "tb_XML";
            this.tb_XML.Size = new System.Drawing.Size(614, 300);
            this.tb_XML.TabIndex = 1;
            this.tb_XML.Text = "";
            // 
            // tsJSON
            // 
            this.tsJSON.Controls.Add(this.tb_JSON);
            this.tsJSON.Location = new System.Drawing.Point(4, 22);
            this.tsJSON.Name = "tsJSON";
            this.tsJSON.Padding = new System.Windows.Forms.Padding(3);
            this.tsJSON.Size = new System.Drawing.Size(617, 287);
            this.tsJSON.TabIndex = 2;
            this.tsJSON.Text = "JSON";
            this.tsJSON.UseVisualStyleBackColor = true;
            // 
            // tb_JSON
            // 
            this.tb_JSON.Location = new System.Drawing.Point(3, 2);
            this.tb_JSON.Name = "tb_JSON";
            this.tb_JSON.Size = new System.Drawing.Size(614, 300);
            this.tb_JSON.TabIndex = 1;
            this.tb_JSON.Text = "";
            // 
            // tsFormatado
            // 
            this.tsFormatado.Controls.Add(this.tb_Tipado);
            this.tsFormatado.Location = new System.Drawing.Point(4, 22);
            this.tsFormatado.Name = "tsFormatado";
            this.tsFormatado.Padding = new System.Windows.Forms.Padding(3);
            this.tsFormatado.Size = new System.Drawing.Size(617, 287);
            this.tsFormatado.TabIndex = 3;
            this.tsFormatado.Text = "Campos Formatados";
            this.tsFormatado.UseVisualStyleBackColor = true;
            // 
            // tb_Tipado
            // 
            this.tb_Tipado.Location = new System.Drawing.Point(3, 2);
            this.tb_Tipado.Name = "tb_Tipado";
            this.tb_Tipado.Size = new System.Drawing.Size(614, 289);
            this.tb_Tipado.TabIndex = 1;
            this.tb_Tipado.Text = "";
            // 
            // gb_Operacoes
            // 
            this.gb_Operacoes.Controls.Add(this.btn_CancelarNFSe);
            this.gb_Operacoes.Controls.Add(this.btn_ConsultarNFSe);
            this.gb_Operacoes.Controls.Add(this.label9);
            this.gb_Operacoes.Controls.Add(this.lbl_NumeroNFSe);
            this.gb_Operacoes.Controls.Add(this.tb_NumeroNFSe);
            this.gb_Operacoes.Controls.Add(this.tb_Protocolo);
            this.gb_Operacoes.Controls.Add(this.tb_ChaveCancelamento);
            this.gb_Operacoes.Controls.Add(this.lbl_TipoRPS);
            this.gb_Operacoes.Controls.Add(this.lbl_Protocolo);
            this.gb_Operacoes.Controls.Add(this.lbl_SerieRPS);
            this.gb_Operacoes.Controls.Add(this.lbl_NumeroRPS);
            this.gb_Operacoes.Controls.Add(this.tb_TipoRPS);
            this.gb_Operacoes.Controls.Add(this.tb_SerieRPS);
            this.gb_Operacoes.Controls.Add(this.tb_NumeroRPS);
            this.gb_Operacoes.Controls.Add(this.btn_EnviarRPS);
            this.gb_Operacoes.Location = new System.Drawing.Point(9, 258);
            this.gb_Operacoes.Name = "gb_Operacoes";
            this.gb_Operacoes.Size = new System.Drawing.Size(608, 107);
            this.gb_Operacoes.TabIndex = 5;
            this.gb_Operacoes.TabStop = false;
            this.gb_Operacoes.Text = "Operações";
            // 
            // btn_CancelarNFSe
            // 
            this.btn_CancelarNFSe.Location = new System.Drawing.Point(9, 76);
            this.btn_CancelarNFSe.Name = "btn_CancelarNFSe";
            this.btn_CancelarNFSe.Size = new System.Drawing.Size(116, 23);
            this.btn_CancelarNFSe.TabIndex = 34;
            this.btn_CancelarNFSe.Text = "Cancelar NFSe";
            this.btn_CancelarNFSe.UseVisualStyleBackColor = true;
            this.btn_CancelarNFSe.Click += new System.EventHandler(this.btn_CancelarNFSe_Click);
            // 
            // btn_ConsultarNFSe
            // 
            this.btn_ConsultarNFSe.Location = new System.Drawing.Point(9, 48);
            this.btn_ConsultarNFSe.Name = "btn_ConsultarNFSe";
            this.btn_ConsultarNFSe.Size = new System.Drawing.Size(116, 23);
            this.btn_ConsultarNFSe.TabIndex = 33;
            this.btn_ConsultarNFSe.Text = "Consultar NFSe";
            this.btn_ConsultarNFSe.UseVisualStyleBackColor = true;
            this.btn_ConsultarNFSe.Click += new System.EventHandler(this.btn_ConsultarNFSe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(408, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Chave Cancelamento";
            // 
            // lbl_NumeroNFSe
            // 
            this.lbl_NumeroNFSe.AutoSize = true;
            this.lbl_NumeroNFSe.Location = new System.Drawing.Point(307, 81);
            this.lbl_NumeroNFSe.Name = "lbl_NumeroNFSe";
            this.lbl_NumeroNFSe.Size = new System.Drawing.Size(34, 13);
            this.lbl_NumeroNFSe.TabIndex = 31;
            this.lbl_NumeroNFSe.Text = "NFSe";
            // 
            // tb_NumeroNFSe
            // 
            this.tb_NumeroNFSe.Location = new System.Drawing.Point(347, 81);
            this.tb_NumeroNFSe.Name = "tb_NumeroNFSe";
            this.tb_NumeroNFSe.Size = new System.Drawing.Size(59, 20);
            this.tb_NumeroNFSe.TabIndex = 29;
            // 
            // tb_Protocolo
            // 
            this.tb_Protocolo.Location = new System.Drawing.Point(520, 35);
            this.tb_Protocolo.Name = "tb_Protocolo";
            this.tb_Protocolo.Size = new System.Drawing.Size(84, 20);
            this.tb_Protocolo.TabIndex = 9;
            // 
            // tb_ChaveCancelamento
            // 
            this.tb_ChaveCancelamento.Location = new System.Drawing.Point(520, 9);
            this.tb_ChaveCancelamento.Name = "tb_ChaveCancelamento";
            this.tb_ChaveCancelamento.Size = new System.Drawing.Size(84, 20);
            this.tb_ChaveCancelamento.TabIndex = 30;
            // 
            // lbl_TipoRPS
            // 
            this.lbl_TipoRPS.AutoSize = true;
            this.lbl_TipoRPS.Location = new System.Drawing.Point(310, 58);
            this.lbl_TipoRPS.Name = "lbl_TipoRPS";
            this.lbl_TipoRPS.Size = new System.Drawing.Size(28, 13);
            this.lbl_TipoRPS.TabIndex = 28;
            this.lbl_TipoRPS.Text = "Tipo";
            // 
            // lbl_Protocolo
            // 
            this.lbl_Protocolo.AutoSize = true;
            this.lbl_Protocolo.Location = new System.Drawing.Point(422, 38);
            this.lbl_Protocolo.Name = "lbl_Protocolo";
            this.lbl_Protocolo.Size = new System.Drawing.Size(92, 13);
            this.lbl_Protocolo.TabIndex = 10;
            this.lbl_Protocolo.Text = "Número Protocolo";
            // 
            // lbl_SerieRPS
            // 
            this.lbl_SerieRPS.AutoSize = true;
            this.lbl_SerieRPS.Location = new System.Drawing.Point(310, 35);
            this.lbl_SerieRPS.Name = "lbl_SerieRPS";
            this.lbl_SerieRPS.Size = new System.Drawing.Size(31, 13);
            this.lbl_SerieRPS.TabIndex = 27;
            this.lbl_SerieRPS.Text = "Série";
            // 
            // lbl_NumeroRPS
            // 
            this.lbl_NumeroRPS.AutoSize = true;
            this.lbl_NumeroRPS.Location = new System.Drawing.Point(312, 12);
            this.lbl_NumeroRPS.Name = "lbl_NumeroRPS";
            this.lbl_NumeroRPS.Size = new System.Drawing.Size(29, 13);
            this.lbl_NumeroRPS.TabIndex = 26;
            this.lbl_NumeroRPS.Text = "RPS";
            // 
            // tb_TipoRPS
            // 
            this.tb_TipoRPS.Location = new System.Drawing.Point(347, 55);
            this.tb_TipoRPS.Name = "tb_TipoRPS";
            this.tb_TipoRPS.Size = new System.Drawing.Size(59, 20);
            this.tb_TipoRPS.TabIndex = 25;
            // 
            // tb_SerieRPS
            // 
            this.tb_SerieRPS.Location = new System.Drawing.Point(347, 32);
            this.tb_SerieRPS.Name = "tb_SerieRPS";
            this.tb_SerieRPS.Size = new System.Drawing.Size(59, 20);
            this.tb_SerieRPS.TabIndex = 24;
            // 
            // tb_NumeroRPS
            // 
            this.tb_NumeroRPS.Location = new System.Drawing.Point(347, 9);
            this.tb_NumeroRPS.Name = "tb_NumeroRPS";
            this.tb_NumeroRPS.Size = new System.Drawing.Size(59, 20);
            this.tb_NumeroRPS.TabIndex = 23;
            // 
            // btn_EnviarRPS
            // 
            this.btn_EnviarRPS.Location = new System.Drawing.Point(9, 19);
            this.btn_EnviarRPS.Name = "btn_EnviarRPS";
            this.btn_EnviarRPS.Size = new System.Drawing.Size(116, 23);
            this.btn_EnviarRPS.TabIndex = 4;
            this.btn_EnviarRPS.Text = "Enviar RPS";
            this.btn_EnviarRPS.UseVisualStyleBackColor = true;
            this.btn_EnviarRPS.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // gb_NFSe
            // 
            this.gb_NFSe.Controls.Add(this.btn_Salvar);
            this.gb_NFSe.Controls.Add(this.gb_Ambiente);
            this.gb_NFSe.Controls.Add(this.groupBox1);
            this.gb_NFSe.Controls.Add(this.gp_Autenticacao);
            this.gb_NFSe.Controls.Add(this.label1);
            this.gb_NFSe.Controls.Add(this.cb_Certificado);
            this.gb_NFSe.Location = new System.Drawing.Point(9, 0);
            this.gb_NFSe.Name = "gb_NFSe";
            this.gb_NFSe.Size = new System.Drawing.Size(608, 252);
            this.gb_NFSe.TabIndex = 1;
            this.gb_NFSe.TabStop = false;
            this.gb_NFSe.Text = "Configurações";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(476, 220);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(116, 23);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "Salvar Configurações";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // gb_Ambiente
            // 
            this.gb_Ambiente.Controls.Add(this.rbt_Producao);
            this.gb_Ambiente.Controls.Add(this.rbt_Homologacao);
            this.gb_Ambiente.Location = new System.Drawing.Point(418, 61);
            this.gb_Ambiente.Name = "gb_Ambiente";
            this.gb_Ambiente.Size = new System.Drawing.Size(174, 153);
            this.gb_Ambiente.TabIndex = 3;
            this.gb_Ambiente.TabStop = false;
            this.gb_Ambiente.Text = "Ambiente";
            // 
            // rbt_Producao
            // 
            this.rbt_Producao.AutoSize = true;
            this.rbt_Producao.Location = new System.Drawing.Point(6, 42);
            this.rbt_Producao.Name = "rbt_Producao";
            this.rbt_Producao.Size = new System.Drawing.Size(71, 17);
            this.rbt_Producao.TabIndex = 1;
            this.rbt_Producao.Text = "Produção";
            this.rbt_Producao.UseVisualStyleBackColor = true;
            // 
            // rbt_Homologacao
            // 
            this.rbt_Homologacao.AutoSize = true;
            this.rbt_Homologacao.Checked = true;
            this.rbt_Homologacao.Location = new System.Drawing.Point(6, 19);
            this.rbt_Homologacao.Name = "rbt_Homologacao";
            this.rbt_Homologacao.Size = new System.Drawing.Size(91, 17);
            this.rbt_Homologacao.TabIndex = 0;
            this.rbt_Homologacao.TabStop = true;
            this.rbt_Homologacao.Text = "Homologação";
            this.rbt_Homologacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Cidade);
            this.groupBox1.Controls.Add(this.tb_Cidade);
            this.groupBox1.Controls.Add(this.lbl_InscricaoMunicipal);
            this.groupBox1.Controls.Add(this.tb_CNPJ);
            this.groupBox1.Controls.Add(this.lbl_CNPJ);
            this.groupBox1.Controls.Add(this.tb_InscricaoMunicipal);
            this.groupBox1.Location = new System.Drawing.Point(6, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestador";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(6, 16);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(66, 13);
            this.lbl_Cidade.TabIndex = 5;
            this.lbl_Cidade.Text = "Cidade + UF";
            // 
            // tb_Cidade
            // 
            this.tb_Cidade.Location = new System.Drawing.Point(6, 32);
            this.tb_Cidade.Name = "tb_Cidade";
            this.tb_Cidade.Size = new System.Drawing.Size(100, 20);
            this.tb_Cidade.TabIndex = 2;
            this.tb_Cidade.Text = "MARINGAPR";
            // 
            // lbl_InscricaoMunicipal
            // 
            this.lbl_InscricaoMunicipal.AutoSize = true;
            this.lbl_InscricaoMunicipal.Location = new System.Drawing.Point(6, 94);
            this.lbl_InscricaoMunicipal.Name = "lbl_InscricaoMunicipal";
            this.lbl_InscricaoMunicipal.Size = new System.Drawing.Size(98, 13);
            this.lbl_InscricaoMunicipal.TabIndex = 7;
            this.lbl_InscricaoMunicipal.Text = "Inscrição Municipal";
            // 
            // tb_CNPJ
            // 
            this.tb_CNPJ.Location = new System.Drawing.Point(6, 71);
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(100, 20);
            this.tb_CNPJ.TabIndex = 3;
            this.tb_CNPJ.Text = "08187168000160";
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.Location = new System.Drawing.Point(6, 55);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbl_CNPJ.TabIndex = 6;
            this.lbl_CNPJ.Text = "CNPJ";
            // 
            // tb_InscricaoMunicipal
            // 
            this.tb_InscricaoMunicipal.Location = new System.Drawing.Point(6, 109);
            this.tb_InscricaoMunicipal.Name = "tb_InscricaoMunicipal";
            this.tb_InscricaoMunicipal.Size = new System.Drawing.Size(100, 20);
            this.tb_InscricaoMunicipal.TabIndex = 4;
            // 
            // gp_Autenticacao
            // 
            this.gp_Autenticacao.Controls.Add(this.label3);
            this.gp_Autenticacao.Controls.Add(this.label2);
            this.gp_Autenticacao.Controls.Add(this.tb_Senha);
            this.gp_Autenticacao.Controls.Add(this.tb_Login);
            this.gp_Autenticacao.Location = new System.Drawing.Point(212, 61);
            this.gp_Autenticacao.Name = "gp_Autenticacao";
            this.gp_Autenticacao.Size = new System.Drawing.Size(200, 153);
            this.gp_Autenticacao.TabIndex = 0;
            this.gp_Autenticacao.TabStop = false;
            this.gp_Autenticacao.Text = "Autenticação Prefeitura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login";
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(6, 71);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(188, 20);
            this.tb_Senha.TabIndex = 6;
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(6, 32);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(188, 20);
            this.tb_Login.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Certificado";
            // 
            // cb_Certificado
            // 
            this.cb_Certificado.FormattingEnabled = true;
            this.cb_Certificado.Location = new System.Drawing.Point(6, 34);
            this.cb_Certificado.Name = "cb_Certificado";
            this.cb_Certificado.Size = new System.Drawing.Size(586, 21);
            this.cb_Certificado.TabIndex = 0;
            // 
            // tp_Impressao
            // 
            this.tp_Impressao.Controls.Add(this.gb_Acoes);
            this.tp_Impressao.Controls.Add(this.gb_Impressao);
            this.tp_Impressao.Location = new System.Drawing.Point(4, 22);
            this.tp_Impressao.Name = "tp_Impressao";
            this.tp_Impressao.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Impressao.Size = new System.Drawing.Size(621, 367);
            this.tp_Impressao.TabIndex = 1;
            this.tp_Impressao.Text = "Impressão";
            this.tp_Impressao.UseVisualStyleBackColor = true;
            // 
            // gb_Impressao
            // 
            this.gb_Impressao.Controls.Add(this.linkLabel1);
            this.gb_Impressao.Controls.Add(this.lbl_CamposCustomizados);
            this.gb_Impressao.Controls.Add(this.tb_CamposCustomizados);
            this.gb_Impressao.Controls.Add(this.btn_LogoEmitente);
            this.gb_Impressao.Controls.Add(this.lbl_LogoEmitente);
            this.gb_Impressao.Controls.Add(this.tb_LogoEmitente);
            this.gb_Impressao.Location = new System.Drawing.Point(5, 6);
            this.gb_Impressao.Name = "gb_Impressao";
            this.gb_Impressao.Size = new System.Drawing.Size(610, 145);
            this.gb_Impressao.TabIndex = 1;
            this.gb_Impressao.TabStop = false;
            this.gb_Impressao.Text = "Configurações";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(142, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Consultar Documentação";
            // 
            // lbl_CamposCustomizados
            // 
            this.lbl_CamposCustomizados.AutoSize = true;
            this.lbl_CamposCustomizados.Location = new System.Drawing.Point(23, 60);
            this.lbl_CamposCustomizados.Name = "lbl_CamposCustomizados";
            this.lbl_CamposCustomizados.Size = new System.Drawing.Size(113, 13);
            this.lbl_CamposCustomizados.TabIndex = 4;
            this.lbl_CamposCustomizados.Text = "Campos Customizados";
            // 
            // tb_CamposCustomizados
            // 
            this.tb_CamposCustomizados.Location = new System.Drawing.Point(21, 76);
            this.tb_CamposCustomizados.Multiline = true;
            this.tb_CamposCustomizados.Name = "tb_CamposCustomizados";
            this.tb_CamposCustomizados.Size = new System.Drawing.Size(575, 63);
            this.tb_CamposCustomizados.TabIndex = 3;
            // 
            // btn_LogoEmitente
            // 
            this.btn_LogoEmitente.Location = new System.Drawing.Point(565, 30);
            this.btn_LogoEmitente.Name = "btn_LogoEmitente";
            this.btn_LogoEmitente.Size = new System.Drawing.Size(31, 23);
            this.btn_LogoEmitente.TabIndex = 2;
            this.btn_LogoEmitente.Text = "...";
            this.btn_LogoEmitente.UseVisualStyleBackColor = true;
            this.btn_LogoEmitente.Click += new System.EventHandler(this.btnLogoEmitente_Click);
            // 
            // lbl_LogoEmitente
            // 
            this.lbl_LogoEmitente.AutoSize = true;
            this.lbl_LogoEmitente.Location = new System.Drawing.Point(23, 17);
            this.lbl_LogoEmitente.Name = "lbl_LogoEmitente";
            this.lbl_LogoEmitente.Size = new System.Drawing.Size(92, 13);
            this.lbl_LogoEmitente.TabIndex = 1;
            this.lbl_LogoEmitente.Text = "Logotipo Emitente";
            // 
            // tb_LogoEmitente
            // 
            this.tb_LogoEmitente.Location = new System.Drawing.Point(21, 32);
            this.tb_LogoEmitente.Name = "tb_LogoEmitente";
            this.tb_LogoEmitente.Size = new System.Drawing.Size(537, 20);
            this.tb_LogoEmitente.TabIndex = 0;
            // 
            // gb_Acoes
            // 
            this.gb_Acoes.Controls.Add(this.btn_Visualizar);
            this.gb_Acoes.Controls.Add(this.btn_Exportar);
            this.gb_Acoes.Controls.Add(this.btn_Editar);
            this.gb_Acoes.Controls.Add(this.btn_Imprimir);
            this.gb_Acoes.Location = new System.Drawing.Point(6, 157);
            this.gb_Acoes.Name = "gb_Acoes";
            this.gb_Acoes.Size = new System.Drawing.Size(609, 75);
            this.gb_Acoes.TabIndex = 2;
            this.gb_Acoes.TabStop = false;
            this.gb_Acoes.Text = "Ações";
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(454, 25);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(140, 23);
            this.btn_Visualizar.TabIndex = 3;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btVisualizar_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(308, 25);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(140, 23);
            this.btn_Exportar.TabIndex = 2;
            this.btn_Exportar.Text = "Exportar Para PDF";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(162, 25);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(140, 23);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(16, 25);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(140, 23);
            this.btn_Imprimir.TabIndex = 0;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 712);
            this.Controls.Add(this.tc_Retorno);
            this.Controls.Add(this.tc_Principal);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Componente NFSe V2";
            this.tc_Principal.ResumeLayout(false);
            this.tb_NFSe.ResumeLayout(false);
            this.tc_Retorno.ResumeLayout(false);
            this.tsXML.ResumeLayout(false);
            this.tsXMLFormatado.ResumeLayout(false);
            this.tsJSON.ResumeLayout(false);
            this.tsFormatado.ResumeLayout(false);
            this.gb_Operacoes.ResumeLayout(false);
            this.gb_Operacoes.PerformLayout();
            this.gb_NFSe.ResumeLayout(false);
            this.gb_NFSe.PerformLayout();
            this.gb_Ambiente.ResumeLayout(false);
            this.gb_Ambiente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp_Autenticacao.ResumeLayout(false);
            this.gp_Autenticacao.PerformLayout();
            this.tp_Impressao.ResumeLayout(false);
            this.gb_Impressao.ResumeLayout(false);
            this.gb_Impressao.PerformLayout();
            this.gb_Acoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Principal;
        private System.Windows.Forms.TabPage tb_NFSe;
        private System.Windows.Forms.TabPage tp_Impressao;
        private System.Windows.Forms.GroupBox gb_NFSe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Certificado;
        private System.Windows.Forms.Label lbl_CNPJ;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.TextBox tb_InscricaoMunicipal;
        private System.Windows.Forms.TextBox tb_CNPJ;
        private System.Windows.Forms.TextBox tb_Cidade;
        private System.Windows.Forms.Label lbl_InscricaoMunicipal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gp_Autenticacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.GroupBox gb_Ambiente;
        private System.Windows.Forms.RadioButton rbt_Producao;
        private System.Windows.Forms.RadioButton rbt_Homologacao;
        private System.Windows.Forms.GroupBox gb_Operacoes;
        private System.Windows.Forms.Button btn_EnviarRPS;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.TabControl tc_Retorno;
        private System.Windows.Forms.TabPage tsXML;
        private System.Windows.Forms.RichTextBox tb_XMLEnvio;
        private System.Windows.Forms.TabPage tsXMLFormatado;
        private System.Windows.Forms.RichTextBox tb_XML;
        private System.Windows.Forms.TabPage tsJSON;
        private System.Windows.Forms.RichTextBox tb_JSON;
        private System.Windows.Forms.TabPage tsFormatado;
        private System.Windows.Forms.RichTextBox tb_Tipado;
        private System.Windows.Forms.Label lbl_Protocolo;
        private System.Windows.Forms.TextBox tb_Protocolo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_NumeroNFSe;
        private System.Windows.Forms.TextBox tb_NumeroNFSe;
        private System.Windows.Forms.TextBox tb_ChaveCancelamento;
        private System.Windows.Forms.Label lbl_TipoRPS;
        private System.Windows.Forms.Label lbl_SerieRPS;
        private System.Windows.Forms.Label lbl_NumeroRPS;
        private System.Windows.Forms.TextBox tb_TipoRPS;
        private System.Windows.Forms.TextBox tb_SerieRPS;
        private System.Windows.Forms.TextBox tb_NumeroRPS;
        private System.Windows.Forms.Button btn_CancelarNFSe;
        private System.Windows.Forms.Button btn_ConsultarNFSe;
        private System.Windows.Forms.GroupBox gb_Acoes;
        private System.Windows.Forms.Button btn_Visualizar;
        private System.Windows.Forms.Button btn_Exportar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.GroupBox gb_Impressao;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_CamposCustomizados;
        private System.Windows.Forms.TextBox tb_CamposCustomizados;
        private System.Windows.Forms.Button btn_LogoEmitente;
        private System.Windows.Forms.Label lbl_LogoEmitente;
        private System.Windows.Forms.TextBox tb_LogoEmitente;
    }
}

