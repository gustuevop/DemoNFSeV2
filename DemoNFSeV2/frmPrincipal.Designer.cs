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
            this.gb_Operacoes = new System.Windows.Forms.GroupBox();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.gb_NFSe = new System.Windows.Forms.GroupBox();
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.tc_Principal.SuspendLayout();
            this.tb_NFSe.SuspendLayout();
            this.gb_Operacoes.SuspendLayout();
            this.gb_NFSe.SuspendLayout();
            this.gb_Ambiente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gp_Autenticacao.SuspendLayout();
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
            this.tc_Principal.Size = new System.Drawing.Size(629, 709);
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
            this.tb_NFSe.Size = new System.Drawing.Size(621, 683);
            this.tb_NFSe.TabIndex = 0;
            this.tb_NFSe.Text = "NFSe";
            this.tb_NFSe.UseVisualStyleBackColor = true;
            // 
            // gb_Operacoes
            // 
            this.gb_Operacoes.Controls.Add(this.btn_Enviar);
            this.gb_Operacoes.Location = new System.Drawing.Point(9, 258);
            this.gb_Operacoes.Name = "gb_Operacoes";
            this.gb_Operacoes.Size = new System.Drawing.Size(598, 154);
            this.gb_Operacoes.TabIndex = 5;
            this.gb_Operacoes.TabStop = false;
            this.gb_Operacoes.Text = "Operações";
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(9, 19);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(116, 23);
            this.btn_Enviar.TabIndex = 4;
            this.btn_Enviar.Text = "Enviar RPS";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
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
            this.gb_NFSe.Size = new System.Drawing.Size(598, 252);
            this.gb_NFSe.TabIndex = 1;
            this.gb_NFSe.TabStop = false;
            this.gb_NFSe.Text = "Configurações";
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
            this.tp_Impressao.Location = new System.Drawing.Point(4, 22);
            this.tp_Impressao.Name = "tp_Impressao";
            this.tp_Impressao.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Impressao.Size = new System.Drawing.Size(621, 683);
            this.tp_Impressao.TabIndex = 1;
            this.tp_Impressao.Text = "Impressão";
            this.tp_Impressao.UseVisualStyleBackColor = true;
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 712);
            this.Controls.Add(this.tc_Principal);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Componente NFSe V2";
            this.tc_Principal.ResumeLayout(false);
            this.tb_NFSe.ResumeLayout(false);
            this.gb_Operacoes.ResumeLayout(false);
            this.gb_NFSe.ResumeLayout(false);
            this.gb_NFSe.PerformLayout();
            this.gb_Ambiente.ResumeLayout(false);
            this.gb_Ambiente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp_Autenticacao.ResumeLayout(false);
            this.gp_Autenticacao.PerformLayout();
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
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_Salvar;
    }
}

