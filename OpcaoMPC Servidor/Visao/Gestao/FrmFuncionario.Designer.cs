namespace OpcaoMPCServidor.Visao.Gestao
{
    partial class FrmFuncionario
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
            this.btnBloqueio = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnFunc = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnSUsr = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBloqueio
            // 
            this.btnBloqueio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBloqueio.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Cadeado;
            this.btnBloqueio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloqueio.Location = new System.Drawing.Point(47, 551);
            this.btnBloqueio.Margin = new System.Windows.Forms.Padding(38, 3, 38, 3);
            this.btnBloqueio.Name = "btnBloqueio";
            this.btnBloqueio.Size = new System.Drawing.Size(80, 80);
            this.btnBloqueio.TabIndex = 100;
            this.ttpInfo.SetToolTip(this.btnBloqueio, "Bloquear o programa");
            this.btnBloqueio.UseVisualStyleBackColor = true;
            this.btnBloqueio.Click += new System.EventHandler(this.BtnBloqueioClick);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo4;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 33;
            this.picLogo.TabStop = false;
            // 
            // btnFunc
            // 
            this.btnFunc.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.Location = new System.Drawing.Point(12, 118);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(150, 40);
            this.btnFunc.TabIndex = 3;
            this.btnFunc.Text = "Novo \r\nFuncionário";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.BtnFuncClick);
            // 
            // lstResultados
            // 
            this.lstResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.HorizontalScrollbar = true;
            this.lstResultados.Location = new System.Drawing.Point(168, 118);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(644, 511);
            this.lstResultados.TabIndex = 1;
            this.lstResultados.DoubleClick += new System.EventHandler(this.LstResultadosDoubleClick);
            this.lstResultados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstResultadosKeyDown);
            // 
            // btnSUsr
            // 
            this.btnSUsr.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnSUsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSUsr.Location = new System.Drawing.Point(12, 164);
            this.btnSUsr.Name = "btnSUsr";
            this.btnSUsr.Size = new System.Drawing.Size(150, 40);
            this.btnSUsr.TabIndex = 4;
            this.btnSUsr.Text = "Atualizar\r\nSuper-Usuário";
            this.btnSUsr.UseVisualStyleBackColor = true;
            this.btnSUsr.Click += new System.EventHandler(this.BtnSUsrClick);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(168, 66);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(710, 20);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisaTextChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(168, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(160, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Digite para filtrar os funcionários:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Edicao;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(818, 118);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 60);
            this.btnEditar.TabIndex = 10;
            this.ttpInfo.SetToolTip(this.btnEditar, "Editar funcionário selecionado");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
            // 
            // btnApagar
            // 
            this.btnApagar.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Lixeira;
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagar.Location = new System.Drawing.Point(818, 250);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(60, 60);
            this.btnApagar.TabIndex = 12;
            this.ttpInfo.SetToolTip(this.btnApagar, "Remover funcionário selecionado");
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Pagamento;
            this.btnPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagamento.Location = new System.Drawing.Point(818, 184);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(60, 60);
            this.btnPagamento.TabIndex = 11;
            this.ttpInfo.SetToolTip(this.btnPagamento, "Pagar funcionário selecionado");
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.BtnPagamentoClick);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 643);
            this.Controls.Add(this.btnPagamento);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnSUsr);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnBloqueio);
            this.Controls.Add(this.picLogo);
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBloqueio;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnSUsr;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}