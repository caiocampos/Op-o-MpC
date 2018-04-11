namespace OpcaoMPCServidor.Visao.Cadastro
{
    partial class FrmNovoCaixa
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.numCaixa = new System.Windows.Forms.NumericUpDown();
            this.lblCaixa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo2;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(260, 182);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinuar.Location = new System.Drawing.Point(105, 226);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(80, 23);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuarClick);
            // 
            // numCaixa
            // 
            this.numCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCaixa.DecimalPlaces = 2;
            this.numCaixa.Location = new System.Drawing.Point(97, 200);
            this.numCaixa.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numCaixa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCaixa.Name = "numCaixa";
            this.numCaixa.Size = new System.Drawing.Size(175, 20);
            this.numCaixa.TabIndex = 11;
            this.numCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCaixa.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // lblCaixa
            // 
            this.lblCaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Location = new System.Drawing.Point(12, 202);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(79, 13);
            this.lblCaixa.TabIndex = 12;
            this.lblCaixa.Text = "Valor em caixa:";
            // 
            // FrmNovoCaixa
            // 
            this.AcceptButton = this.btnContinuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.numCaixa);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.picLogo);
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "FrmNovoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valor em Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.NumericUpDown numCaixa;
        private System.Windows.Forms.Label lblCaixa;
    }
}