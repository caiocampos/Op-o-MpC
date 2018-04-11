namespace OpcaoMPCServidor.Visao.Artefato
{
    partial class UCtrlItemVenda
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.numQtd = new System.Windows.Forms.NumericUpDown();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblEstqDisp = new System.Windows.Forms.Label();
            this.lblEstqDispQtd = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.AutoCompleteCustomSource.AddRange(new string[] {
            "Abacate",
            "Abobora",
            "Banana"});
            this.txtNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNomeProduto.Location = new System.Drawing.Point(56, 3);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(200, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // numQtd
            // 
            this.numQtd.DecimalPlaces = 2;
            this.numQtd.Location = new System.Drawing.Point(36, 29);
            this.numQtd.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numQtd.Name = "numQtd";
            this.numQtd.Size = new System.Drawing.Size(75, 20);
            this.numQtd.TabIndex = 2;
            this.numQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQtd.ValueChanged += new System.EventHandler(this.numQtdValueChanged);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(3, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblProduto.Size = new System.Drawing.Size(47, 18);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(3, 26);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblQuantidade.Size = new System.Drawing.Size(27, 18);
            this.lblQuantidade.TabIndex = 0;
            this.lblQuantidade.Text = "Qtd:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(306, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 0;
            this.txtPreco.Text = "0,00";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(262, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblPreco.Size = new System.Drawing.Size(38, 18);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço:";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstqDisp
            // 
            this.lblEstqDisp.AutoSize = true;
            this.lblEstqDisp.Location = new System.Drawing.Point(117, 26);
            this.lblEstqDisp.Name = "lblEstqDisp";
            this.lblEstqDisp.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblEstqDisp.Size = new System.Drawing.Size(101, 18);
            this.lblEstqDisp.TabIndex = 0;
            this.lblEstqDisp.Text = "Estoque disponível:";
            // 
            // lblEstqDispQtd
            // 
            this.lblEstqDispQtd.AutoSize = true;
            this.lblEstqDispQtd.Location = new System.Drawing.Point(224, 26);
            this.lblEstqDispQtd.Name = "lblEstqDispQtd";
            this.lblEstqDispQtd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblEstqDispQtd.Size = new System.Drawing.Size(13, 18);
            this.lblEstqDispQtd.TabIndex = 0;
            this.lblEstqDispQtd.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblProduto);
            this.flowLayoutPanel1.Controls.Add(this.txtNomeProduto);
            this.flowLayoutPanel1.Controls.Add(this.lblPreco);
            this.flowLayoutPanel1.Controls.Add(this.txtPreco);
            this.flowLayoutPanel1.Controls.Add(this.lblQuantidade);
            this.flowLayoutPanel1.Controls.Add(this.numQtd);
            this.flowLayoutPanel1.Controls.Add(this.lblEstqDisp);
            this.flowLayoutPanel1.Controls.Add(this.lblEstqDispQtd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // UCtrlItemVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCtrlItemVenda";
            this.Size = new System.Drawing.Size(448, 58);
            ((System.ComponentModel.ISupportInitialize)(this.numQtd)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.NumericUpDown numQtd;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstqDisp;
        private System.Windows.Forms.Label lblEstqDispQtd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
