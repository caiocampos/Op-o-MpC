namespace OpcaoMPCServidor.Visao.Gestao
{
    partial class FrmFornecedor
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
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnForn = new System.Windows.Forms.Button();
            this.btnBloqueio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVenda
            // 
            this.pnlVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVenda.AutoScroll = true;
            this.pnlVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVenda.Location = new System.Drawing.Point(168, 118);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(849, 511);
            this.pnlVenda.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo4;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnForn
            // 
            this.btnForn.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnForn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForn.Location = new System.Drawing.Point(12, 118);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(150, 40);
            this.btnForn.TabIndex = 14;
            this.btnForn.Text = "Novo \r\nFornecedor";
            this.btnForn.UseVisualStyleBackColor = true;
            // 
            // btnBloqueio
            // 
            this.btnBloqueio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBloqueio.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Cadeado;
            this.btnBloqueio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloqueio.Location = new System.Drawing.Point(47, 549);
            this.btnBloqueio.Margin = new System.Windows.Forms.Padding(38, 3, 38, 3);
            this.btnBloqueio.Name = "btnBloqueio";
            this.btnBloqueio.Size = new System.Drawing.Size(80, 80);
            this.btnBloqueio.TabIndex = 32;
            this.btnBloqueio.UseVisualStyleBackColor = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 641);
            this.Controls.Add(this.btnBloqueio);
            this.Controls.Add(this.btnForn);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlVenda);
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.Name = "FrmFornecedor";
            this.Text = "FrmFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVenda;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.Button btnBloqueio;
    }
}