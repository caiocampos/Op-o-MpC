namespace OpcaoMPCServidor.Visao.Cadastro
{
    partial class FrmCadFuncionario
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
            this.components = new System.ComponentModel.Container();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.chbComissionado = new System.Windows.Forms.CheckBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.numSalario = new System.Windows.Forms.NumericUpDown();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.lblConf = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.lblAtual = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.chbSenha = new System.Windows.Forms.CheckBox();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(91, 271);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(381, 20);
            this.txtSenha.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 274);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha*:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(91, 144);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(381, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 147);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário*:";
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(12, 356);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(220, 17);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Erro: usuário ou senha incorretos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(397, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuar.Location = new System.Drawing.Point(316, 376);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuarClick);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(91, 118);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(381, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 121);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome*:";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncao.Location = new System.Drawing.Point(91, 170);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(381, 20);
            this.txtFuncao.TabIndex = 3;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(12, 173);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(50, 13);
            this.lblFuncao.TabIndex = 0;
            this.lblFuncao.Text = "Função*:";
            // 
            // chbComissionado
            // 
            this.chbComissionado.AutoSize = true;
            this.chbComissionado.Location = new System.Drawing.Point(15, 222);
            this.chbComissionado.Name = "chbComissionado";
            this.chbComissionado.Size = new System.Drawing.Size(91, 17);
            this.chbComissionado.TabIndex = 5;
            this.chbComissionado.Text = "Comissionado";
            this.chbComissionado.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 198);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário:";
            // 
            // numSalario
            // 
            this.numSalario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSalario.DecimalPlaces = 2;
            this.numSalario.Location = new System.Drawing.Point(91, 196);
            this.numSalario.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numSalario.Name = "numSalario";
            this.numSalario.Size = new System.Drawing.Size(381, 20);
            this.numSalario.TabIndex = 4;
            this.numSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConf
            // 
            this.txtConf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConf.Location = new System.Drawing.Point(91, 297);
            this.txtConf.Name = "txtConf";
            this.txtConf.PasswordChar = '*';
            this.txtConf.Size = new System.Drawing.Size(381, 20);
            this.txtConf.TabIndex = 9;
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Location = new System.Drawing.Point(12, 300);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(73, 13);
            this.lblConf.TabIndex = 0;
            this.lblConf.Text = "Confirmação*:";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo4;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Liberation Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(118, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(240, 85);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Cadastro de Funcionários\r\n\r\nPor favor preencha todos os \r\ncampos marcados com ast" +
    "erisco \r\ne clique em continuar";
            // 
            // txtAtual
            // 
            this.txtAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtual.Location = new System.Drawing.Point(91, 245);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.PasswordChar = '*';
            this.txtAtual.Size = new System.Drawing.Size(381, 20);
            this.txtAtual.TabIndex = 7;
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(12, 248);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(72, 13);
            this.lblAtual.TabIndex = 0;
            this.lblAtual.Text = "Senha Atual*:";
            // 
            // btnApagar
            // 
            this.btnApagar.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Lixeira;
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagar.Location = new System.Drawing.Point(366, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 100;
            this.ttpInfo.SetToolTip(this.btnApagar, "Remover este funcionário");
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Visible = false;
            this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
            // 
            // chbSenha
            // 
            this.chbSenha.AutoSize = true;
            this.chbSenha.Location = new System.Drawing.Point(112, 222);
            this.chbSenha.Name = "chbSenha";
            this.chbSenha.Size = new System.Drawing.Size(100, 17);
            this.chbSenha.TabIndex = 6;
            this.chbSenha.Text = "Atualizar Senha";
            this.chbSenha.UseVisualStyleBackColor = true;
            this.chbSenha.Visible = false;
            this.chbSenha.CheckedChanged += new System.EventHandler(this.ChbSenhaCheckedChanged);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Pagamento;
            this.btnPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagamento.Location = new System.Drawing.Point(422, 12);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(50, 50);
            this.btnPagamento.TabIndex = 101;
            this.ttpInfo.SetToolTip(this.btnPagamento, "Pagar este funcionário");
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.BtnPagamentoClick);
            // 
            // FrmCadFuncionario
            // 
            this.AcceptButton = this.btnContinuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.chbSenha);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.numSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.chbComissionado);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "FrmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.CheckBox chbComissionado;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.NumericUpDown numSalario;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.CheckBox chbSenha;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}