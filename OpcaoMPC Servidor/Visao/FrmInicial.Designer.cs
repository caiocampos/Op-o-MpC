namespace OpcaoMPCServidor.Visao
{
    partial class FrmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notiOMPC = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuBandeja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitemMenuBandejaMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.sepMenuBandeja = new System.Windows.Forms.ToolStripSeparator();
            this.mitemMenuBandejaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerSis = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblEventos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLogEstoque = new System.Windows.Forms.ListBox();
            this.menuBandeja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // notiOMPC
            // 
            this.notiOMPC.ContextMenuStrip = this.menuBandeja;
            this.notiOMPC.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.notiOMPC.Text = "OpcaoMPC Servidor\r\nExecutando...";
            this.notiOMPC.Visible = true;
            this.notiOMPC.DoubleClick += new System.EventHandler(this.NotiOMPCDoubleClick);
            // 
            // menuBandeja
            // 
            this.menuBandeja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemMenuBandejaMostrar,
            this.sepMenuBandeja,
            this.mitemMenuBandejaSair});
            this.menuBandeja.Name = "menuBandeja";
            this.menuBandeja.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuBandeja.Size = new System.Drawing.Size(116, 54);
            // 
            // mitemMenuBandejaMostrar
            // 
            this.mitemMenuBandejaMostrar.Name = "mitemMenuBandejaMostrar";
            this.mitemMenuBandejaMostrar.Size = new System.Drawing.Size(115, 22);
            this.mitemMenuBandejaMostrar.Text = "Mostrar";
            this.mitemMenuBandejaMostrar.Click += new System.EventHandler(this.MitemMenuBandejaMostrarClick);
            // 
            // sepMenuBandeja
            // 
            this.sepMenuBandeja.Name = "sepMenuBandeja";
            this.sepMenuBandeja.Size = new System.Drawing.Size(112, 6);
            // 
            // mitemMenuBandejaSair
            // 
            this.mitemMenuBandejaSair.Name = "mitemMenuBandejaSair";
            this.mitemMenuBandejaSair.Size = new System.Drawing.Size(115, 22);
            this.mitemMenuBandejaSair.Text = "Sair";
            this.mitemMenuBandejaSair.Click += new System.EventHandler(this.MenuBandejaSairClick);
            // 
            // btnGerSis
            // 
            this.btnGerSis.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnGerSis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerSis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerSis.Location = new System.Drawing.Point(12, 118);
            this.btnGerSis.Name = "btnGerSis";
            this.btnGerSis.Size = new System.Drawing.Size(150, 40);
            this.btnGerSis.TabIndex = 1;
            this.btnGerSis.Text = "Gerenciar \r\nSistema";
            this.btnGerSis.UseVisualStyleBackColor = true;
            this.btnGerSis.Click += new System.EventHandler(this.BtnGerSisClick);
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.Location = new System.Drawing.Point(12, 185);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(560, 264);
            this.lstLog.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo4;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Location = new System.Drawing.Point(12, 169);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(49, 13);
            this.lblEventos.TabIndex = 0;
            this.lblEventos.Text = "Eventos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos de Estoque:";
            // 
            // lstLogEstoque
            // 
            this.lstLogEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLogEstoque.FormattingEnabled = true;
            this.lstLogEstoque.HorizontalScrollbar = true;
            this.lstLogEstoque.Location = new System.Drawing.Point(168, 25);
            this.lstLogEstoque.Name = "lstLogEstoque";
            this.lstLogEstoque.Size = new System.Drawing.Size(404, 147);
            this.lstLogEstoque.TabIndex = 3;
            // 
            // FrmInicial
            // 
            this.AcceptButton = this.btnGerSis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lstLogEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnGerSis);
            this.DoubleBuffered = true;
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerência Opção Materias p/ Construção";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicialFormClosing);
            this.Load += new System.EventHandler(this.FrmInicialLoad);
            this.menuBandeja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notiOMPC;
        private System.Windows.Forms.ContextMenuStrip menuBandeja;
        private System.Windows.Forms.ToolStripMenuItem mitemMenuBandejaSair;
        private System.Windows.Forms.ToolStripMenuItem mitemMenuBandejaMostrar;
        private System.Windows.Forms.ToolStripSeparator sepMenuBandeja;
        private System.Windows.Forms.Button btnGerSis;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLogEstoque;
    }
}

