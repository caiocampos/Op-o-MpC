using System;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Artefato
{
    public partial class UCtrlItemVenda : UserControl
    {
        private double valorProduto = 0;

        public int Indice { get; }
        
        public UCtrlItemVenda(int indice)
        {
            Indice = indice;

            InitializeComponent();
        }

        public void AdcionarEventoPreco(EventHandler ev)
        {
            txtPreco.TextChanged += ev;
        }

        public void RemoverEventoPreco(EventHandler ev)
        {
            txtPreco.TextChanged -= ev;
        }

        public float GetParcialPreco()
        {
            return Convert.ToSingle(txtPreco.Text);
        }

        public float GetQtdProduto()
        {
            return Convert.ToSingle(numQtd.Value);
        }

        public void RecalcularParcialPreco()
        {
            double parcial = valorProduto * GetQtdProduto();
            txtPreco.Text = parcial.ToString("F");
        }

        private void numQtdValueChanged(object sender, EventArgs e)
        {
            RecalcularParcialPreco();
        }
    }
}
