namespace OpcaoMPCServidor.Visao
{
    partial class FrmGerencia
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCtrlVendas = new System.Windows.Forms.Button();
            this.btnCtrlEstoque = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnForn = new System.Windows.Forms.Button();
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.btnFinVenda = new System.Windows.Forms.Button();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.chbOrcamento = new System.Windows.Forms.CheckBox();
            this.chbImprimir = new System.Windows.Forms.CheckBox();
            this.numDesconto = new System.Windows.Forms.NumericUpDown();
            this.chbDesconto = new System.Windows.Forms.CheckBox();
            this.lblDescMax = new System.Windows.Forms.Label();
            this.lblDescMaxValor = new System.Windows.Forms.Label();
            this.lblTotalVendaValor = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.numFrete = new System.Windows.Forms.NumericUpDown();
            this.pnlValores = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlFinalizacao = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.cbbCliente = new System.Windows.Forms.ComboBox();
            this.btnFinancas = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnBloqueio = new System.Windows.Forms.Button();
            this.pnlBloqueio = new System.Windows.Forms.Panel();
            this.btnDesbloqueio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBloqueio = new System.Windows.Forms.Label();
            this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrete)).BeginInit();
            this.pnlValores.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlFinalizacao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBloqueio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::OpcaoMPCServidor.Properties.Resources.Logo4;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnCtrlVendas
            // 
            this.btnCtrlVendas.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnCtrlVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCtrlVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrlVendas.Location = new System.Drawing.Point(12, 118);
            this.btnCtrlVendas.Name = "btnCtrlVendas";
            this.btnCtrlVendas.Size = new System.Drawing.Size(150, 40);
            this.btnCtrlVendas.TabIndex = 10;
            this.btnCtrlVendas.Text = "Controle de \r\nVendas";
            this.btnCtrlVendas.UseVisualStyleBackColor = true;
            this.btnCtrlVendas.Click += new System.EventHandler(this.BtnCtrlVendasClick);
            // 
            // btnCtrlEstoque
            // 
            this.btnCtrlEstoque.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnCtrlEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCtrlEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCtrlEstoque.Location = new System.Drawing.Point(12, 164);
            this.btnCtrlEstoque.Name = "btnCtrlEstoque";
            this.btnCtrlEstoque.Size = new System.Drawing.Size(150, 40);
            this.btnCtrlEstoque.TabIndex = 11;
            this.btnCtrlEstoque.Text = "Controle de \r\nEstoque";
            this.btnCtrlEstoque.UseVisualStyleBackColor = true;
            this.btnCtrlEstoque.Click += new System.EventHandler(this.BtnCtrlEstoqueClick);
            // 
            // btnFunc
            // 
            this.btnFunc.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.Location = new System.Drawing.Point(12, 210);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(150, 40);
            this.btnFunc.TabIndex = 12;
            this.btnFunc.Text = "Gestão de Usuários   \r\ne Funcionários";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.BtnFuncClick);
            // 
            // btnForn
            // 
            this.btnForn.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnForn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForn.Location = new System.Drawing.Point(12, 256);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(150, 40);
            this.btnForn.TabIndex = 13;
            this.btnForn.Text = "Gestão de \r\nFornecedores";
            this.btnForn.UseVisualStyleBackColor = true;
            this.btnForn.Click += new System.EventHandler(this.BtnFornClick);
            // 
            // pnlVenda
            // 
            this.pnlVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVenda.AutoScroll = true;
            this.pnlVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVenda.Location = new System.Drawing.Point(168, 12);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(504, 360);
            this.pnlVenda.TabIndex = 1;
            // 
            // btnFinVenda
            // 
            this.btnFinVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinVenda.Location = new System.Drawing.Point(3, 49);
            this.btnFinVenda.Name = "btnFinVenda";
            this.btnFinVenda.Size = new System.Drawing.Size(100, 23);
            this.btnFinVenda.TabIndex = 7;
            this.btnFinVenda.Text = "Concluir";
            this.btnFinVenda.UseVisualStyleBackColor = true;
            this.btnFinVenda.Click += new System.EventHandler(this.BtnFinVendaClick);
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(3, 2);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTotalVenda.Size = new System.Drawing.Size(61, 18);
            this.lblTotalVenda.TabIndex = 14;
            this.lblTotalVenda.Text = "Valor Total:";
            // 
            // chbOrcamento
            // 
            this.chbOrcamento.AutoSize = true;
            this.chbOrcamento.Location = new System.Drawing.Point(3, 3);
            this.chbOrcamento.Name = "chbOrcamento";
            this.chbOrcamento.Size = new System.Drawing.Size(78, 17);
            this.chbOrcamento.TabIndex = 5;
            this.chbOrcamento.Text = "Orçamento";
            this.chbOrcamento.UseVisualStyleBackColor = true;
            // 
            // chbImprimir
            // 
            this.chbImprimir.AutoSize = true;
            this.chbImprimir.Location = new System.Drawing.Point(3, 26);
            this.chbImprimir.Name = "chbImprimir";
            this.chbImprimir.Size = new System.Drawing.Size(61, 17);
            this.chbImprimir.TabIndex = 6;
            this.chbImprimir.Text = "Imprimir";
            this.chbImprimir.UseVisualStyleBackColor = true;
            // 
            // numDesconto
            // 
            this.numDesconto.DecimalPlaces = 2;
            this.numDesconto.Enabled = false;
            this.numDesconto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDesconto.Location = new System.Drawing.Point(84, 5);
            this.numDesconto.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDesconto.Name = "numDesconto";
            this.numDesconto.Size = new System.Drawing.Size(70, 20);
            this.numDesconto.TabIndex = 3;
            this.numDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chbDesconto
            // 
            this.chbDesconto.AutoSize = true;
            this.chbDesconto.Location = new System.Drawing.Point(3, 6);
            this.chbDesconto.Name = "chbDesconto";
            this.chbDesconto.Size = new System.Drawing.Size(75, 17);
            this.chbDesconto.TabIndex = 2;
            this.chbDesconto.Text = "Desconto:";
            this.chbDesconto.UseVisualStyleBackColor = true;
            this.chbDesconto.CheckedChanged += new System.EventHandler(this.ChbDescontoCheckedChanged);
            // 
            // lblDescMax
            // 
            this.lblDescMax.AutoSize = true;
            this.lblDescMax.Location = new System.Drawing.Point(160, 7);
            this.lblDescMax.Name = "lblDescMax";
            this.lblDescMax.Size = new System.Drawing.Size(46, 13);
            this.lblDescMax.TabIndex = 20;
            this.lblDescMax.Text = "Máximo:";
            // 
            // lblDescMaxValor
            // 
            this.lblDescMaxValor.AutoSize = true;
            this.lblDescMaxValor.Location = new System.Drawing.Point(212, 7);
            this.lblDescMaxValor.Name = "lblDescMaxValor";
            this.lblDescMaxValor.Size = new System.Drawing.Size(45, 13);
            this.lblDescMaxValor.TabIndex = 21;
            this.lblDescMaxValor.Text = "R$ 0,00";
            // 
            // lblTotalVendaValor
            // 
            this.lblTotalVendaValor.AutoSize = true;
            this.lblTotalVendaValor.Location = new System.Drawing.Point(70, 2);
            this.lblTotalVendaValor.Name = "lblTotalVendaValor";
            this.lblTotalVendaValor.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblTotalVendaValor.Size = new System.Drawing.Size(45, 18);
            this.lblTotalVendaValor.TabIndex = 22;
            this.lblTotalVendaValor.Text = "R$ 0,00";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(3, 33);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(76, 13);
            this.lblFrete.TabIndex = 23;
            this.lblFrete.Text = "Valor do Frete:";
            // 
            // numFrete
            // 
            this.numFrete.DecimalPlaces = 2;
            this.numFrete.Location = new System.Drawing.Point(84, 31);
            this.numFrete.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFrete.Name = "numFrete";
            this.numFrete.Size = new System.Drawing.Size(70, 20);
            this.numFrete.TabIndex = 4;
            this.numFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlValores
            // 
            this.pnlValores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlValores.Controls.Add(this.pnlTotal);
            this.pnlValores.Controls.Add(this.lblDescMaxValor);
            this.pnlValores.Controls.Add(this.numFrete);
            this.pnlValores.Controls.Add(this.lblFrete);
            this.pnlValores.Controls.Add(this.numDesconto);
            this.pnlValores.Controls.Add(this.chbDesconto);
            this.pnlValores.Controls.Add(this.lblDescMax);
            this.pnlValores.Location = new System.Drawing.Point(168, 419);
            this.pnlValores.Name = "pnlValores";
            this.pnlValores.Size = new System.Drawing.Size(393, 80);
            this.pnlValores.TabIndex = 25;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotal.Controls.Add(this.lblTotalVenda);
            this.pnlTotal.Controls.Add(this.lblTotalVendaValor);
            this.pnlTotal.Location = new System.Drawing.Point(215, 33);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(175, 30);
            this.pnlTotal.TabIndex = 27;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente:";
            // 
            // pnlFinalizacao
            // 
            this.pnlFinalizacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFinalizacao.Controls.Add(this.chbOrcamento);
            this.pnlFinalizacao.Controls.Add(this.chbImprimir);
            this.pnlFinalizacao.Controls.Add(this.btnFinVenda);
            this.pnlFinalizacao.Location = new System.Drawing.Point(567, 419);
            this.pnlFinalizacao.Name = "pnlFinalizacao";
            this.pnlFinalizacao.Size = new System.Drawing.Size(105, 80);
            this.pnlFinalizacao.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnNovoCliente);
            this.panel1.Controls.Add(this.cbbCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(168, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 35);
            this.panel1.TabIndex = 28;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoCliente.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Mais;
            this.btnNovoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCliente.Location = new System.Drawing.Point(471, 3);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(30, 30);
            this.btnNovoCliente.TabIndex = 28;
            this.ttpInfo.SetToolTip(this.btnNovoCliente, "Criar novo cliente");
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.BtnNovoClienteClick);
            // 
            // cbbCliente
            // 
            this.cbbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbCliente.FormattingEnabled = true;
            this.cbbCliente.Location = new System.Drawing.Point(51, 9);
            this.cbbCliente.Name = "cbbCliente";
            this.cbbCliente.Size = new System.Drawing.Size(414, 21);
            this.cbbCliente.TabIndex = 27;
            // 
            // btnFinancas
            // 
            this.btnFinancas.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnFinancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancas.Location = new System.Drawing.Point(12, 348);
            this.btnFinancas.Name = "btnFinancas";
            this.btnFinancas.Size = new System.Drawing.Size(150, 40);
            this.btnFinancas.TabIndex = 29;
            this.btnFinancas.Text = "Gestão \r\nFinanceira";
            this.btnFinancas.UseVisualStyleBackColor = true;
            this.btnFinancas.Click += new System.EventHandler(this.BtnFinancasClick);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Botao;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(12, 302);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(150, 40);
            this.btnCliente.TabIndex = 30;
            this.btnCliente.Text = "Gestão de \r\nClientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
            // 
            // btnBloqueio
            // 
            this.btnBloqueio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBloqueio.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Cadeado;
            this.btnBloqueio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBloqueio.Location = new System.Drawing.Point(47, 419);
            this.btnBloqueio.Margin = new System.Windows.Forms.Padding(38, 3, 38, 3);
            this.btnBloqueio.Name = "btnBloqueio";
            this.btnBloqueio.Size = new System.Drawing.Size(80, 80);
            this.btnBloqueio.TabIndex = 31;
            this.ttpInfo.SetToolTip(this.btnBloqueio, "Bloquear o programa");
            this.btnBloqueio.UseVisualStyleBackColor = true;
            this.btnBloqueio.Click += new System.EventHandler(this.BtnBloqueioClick);
            // 
            // pnlBloqueio
            // 
            this.pnlBloqueio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBloqueio.Controls.Add(this.btnDesbloqueio);
            this.pnlBloqueio.Controls.Add(this.pictureBox1);
            this.pnlBloqueio.Controls.Add(this.lblBloqueio);
            this.pnlBloqueio.Enabled = false;
            this.pnlBloqueio.Location = new System.Drawing.Point(12, 12);
            this.pnlBloqueio.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBloqueio.Name = "pnlBloqueio";
            this.pnlBloqueio.Size = new System.Drawing.Size(660, 487);
            this.pnlBloqueio.TabIndex = 32;
            this.pnlBloqueio.Visible = false;
            // 
            // btnDesbloqueio
            // 
            this.btnDesbloqueio.BackgroundImage = global::OpcaoMPCServidor.Properties.Resources.Cadeado;
            this.btnDesbloqueio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesbloqueio.Location = new System.Drawing.Point(230, 145);
            this.btnDesbloqueio.Margin = new System.Windows.Forms.Padding(0);
            this.btnDesbloqueio.Name = "btnDesbloqueio";
            this.btnDesbloqueio.Size = new System.Drawing.Size(200, 200);
            this.btnDesbloqueio.TabIndex = 32;
            this.btnDesbloqueio.UseVisualStyleBackColor = true;
            this.btnDesbloqueio.Click += new System.EventHandler(this.BtnDesbloqueioClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::OpcaoMPCServidor.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(295, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lblBloqueio
            // 
            this.lblBloqueio.AutoSize = true;
            this.lblBloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloqueio.Location = new System.Drawing.Point(171, 119);
            this.lblBloqueio.Name = "lblBloqueio";
            this.lblBloqueio.Size = new System.Drawing.Size(331, 16);
            this.lblBloqueio.TabIndex = 33;
            this.lblBloqueio.Text = "Tela bloqueada, pressione o botão para desbloquear";
            // 
            // FrmGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.btnBloqueio);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFinancas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFinalizacao);
            this.Controls.Add(this.pnlValores);
            this.Controls.Add(this.pnlVenda);
            this.Controls.Add(this.btnForn);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnCtrlEstoque);
            this.Controls.Add(this.btnCtrlVendas);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnlBloqueio);
            this.DoubleBuffered = true;
            this.Icon = global::OpcaoMPCServidor.Properties.Resources.Icone4;
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "FrmGerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerência Opção Materias p/ Construção";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrete)).EndInit();
            this.pnlValores.ResumeLayout(false);
            this.pnlValores.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlFinalizacao.ResumeLayout(false);
            this.pnlFinalizacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBloqueio.ResumeLayout(false);
            this.pnlBloqueio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCtrlVendas;
        private System.Windows.Forms.Button btnCtrlEstoque;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.Panel pnlVenda;
        private System.Windows.Forms.Button btnFinVenda;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.CheckBox chbOrcamento;
        private System.Windows.Forms.CheckBox chbImprimir;
        private System.Windows.Forms.NumericUpDown numDesconto;
        private System.Windows.Forms.CheckBox chbDesconto;
        private System.Windows.Forms.Label lblDescMax;
        private System.Windows.Forms.Label lblDescMaxValor;
        private System.Windows.Forms.Label lblTotalVendaValor;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.NumericUpDown numFrete;
        private System.Windows.Forms.Panel pnlValores;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Panel pnlFinalizacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.ComboBox cbbCliente;
        private System.Windows.Forms.Button btnFinancas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnBloqueio;
        private System.Windows.Forms.Panel pnlBloqueio;
        private System.Windows.Forms.Button btnDesbloqueio;
        private System.Windows.Forms.Label lblBloqueio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip ttpInfo;
    }
}

