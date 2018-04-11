namespace OpcaoMPCServidor.Visao.Validacao
{
    partial class FrmAutenticacaoSuper
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
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.lblConf = new System.Windows.Forms.Label();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.lblAtual = new System.Windows.Forms.Label();
            this.lblInformativo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(87, 253);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(285, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 256);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo2;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(360, 196);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(12, 302);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(343, 17);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Erro: a senha não pode ser diferente da confirmação";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(297, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuar.Location = new System.Drawing.Point(216, 326);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuarClick);
            // 
            // txtConf
            // 
            this.txtConf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConf.Location = new System.Drawing.Point(87, 279);
            this.txtConf.Name = "txtConf";
            this.txtConf.PasswordChar = '*';
            this.txtConf.Size = new System.Drawing.Size(285, 20);
            this.txtConf.TabIndex = 3;
            // 
            // lblConf
            // 
            this.lblConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConf.AutoSize = true;
            this.lblConf.Location = new System.Drawing.Point(12, 282);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(69, 13);
            this.lblConf.TabIndex = 0;
            this.lblConf.Text = "Confirmação:";
            // 
            // txtAtual
            // 
            this.txtAtual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAtual.Location = new System.Drawing.Point(87, 227);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.PasswordChar = '*';
            this.txtAtual.Size = new System.Drawing.Size(285, 20);
            this.txtAtual.TabIndex = 1;
            // 
            // lblAtual
            // 
            this.lblAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(12, 230);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(68, 13);
            this.lblAtual.TabIndex = 0;
            this.lblAtual.Text = "Senha Atual:";
            // 
            // lblInformativo
            // 
            this.lblInformativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.Location = new System.Drawing.Point(12, 211);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(296, 13);
            this.lblInformativo.TabIndex = 6;
            this.lblInformativo.Text = "Por favor entre com a senha de super-usuário para continuar:";
            // 
            // FrmAutenticacaoSuper
            // 
            this.AcceptButton = this.btnContinuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblInformativo);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmAutenticacaoSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super-usuário";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Label lblInformativo;
    }
}