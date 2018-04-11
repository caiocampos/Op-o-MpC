using Controle;
using OpcaoMPCServidor.Visao.Artefato;
using OpcaoMPCServidor.Visao.Gestao;
using OpcaoMPCServidor.Visao.Validacao;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao
{
    using TuplaItemVenda = Tuple<BtnPlusMinus, UCtrlItemVenda>;

    public partial class FrmGerencia : Form
    {
        private const int PosXBotao    = 10;
        private const int PosXItVenda  = 40;
        private const int PosYInicial  = 10;
        private const int TamanhoLinha = 60;
        private const int MetadeLinha  = 15;

        private List<TuplaItemVenda> listItVenda = new List<TuplaItemVenda>();
        private int indice = 1;

        private FrmCliente gstCliente         = null;
        private FrmEstoque gstEstoque         = null;
        private FrmFinanca gstFinanca         = null;
        private FrmFornecedor gstFornecedor   = null;
        private FrmFuncionario gstFuncionario = null;
        private FrmVenda gstVenda             = null;

        public FrmGerencia()
        {
            InitializeComponent();

            BtnPlusMinus pmButton = new BtnPlusMinus(indice)
            {
                Location = new Point(PosXBotao, PosYInicial + MetadeLinha)
            };
            UCtrlItemVenda itVenda = new UCtrlItemVenda(indice)
            {
                Location = new Point(PosXItVenda, PosYInicial)
            };
            pmButton.Click += new EventHandler(NumLinhasAlterado);
            itVenda.AdcionarEventoPreco(new EventHandler(ParcialAlterado));
            
            pnlVenda.Controls.Add(pmButton);
            pnlVenda.Controls.Add(itVenda);

            listItVenda.Add(new TuplaItemVenda(pmButton, itVenda));
            
            LogSistema.AdicionarEvento("Sistema de gerência aberto");
        }

        private void NumLinhasAlterado(object sender, EventArgs e)
        {
            BtnPlusMinus evPmButton = (BtnPlusMinus) sender;

            if (evPmButton == null)
            {
                return;
            }

            if (evPmButton.getSituacao() == Situacao.Adcionando)
            {
                int pos = listItVenda.Last().Item2.Location.Y;
                pos += TamanhoLinha;

                indice++;

                BtnPlusMinus pmButton = new BtnPlusMinus(indice)
                {
                    Location = new Point(PosXBotao, pos + MetadeLinha)
                };
                UCtrlItemVenda itVenda = new UCtrlItemVenda(indice)
                {
                    Location = new Point(PosXItVenda, pos)
                };
                pmButton.Click += new EventHandler(NumLinhasAlterado);
                itVenda.AdcionarEventoPreco(new EventHandler(ParcialAlterado));

                pnlVenda.Controls.Add(pmButton);
                pnlVenda.Controls.Add(itVenda);

                listItVenda.Add(new TuplaItemVenda(pmButton, itVenda));

                evPmButton.SetBotaoMenos();

                return;
            }
            
            if (evPmButton.getSituacao() == Situacao.Removendo)
            {
                int indiceEv = evPmButton.Indice;
                bool encontrou = false;
                TuplaItemVenda removida = null;

                foreach (TuplaItemVenda t in listItVenda)
                {
                    if (encontrou)
                    {
                        Point posItem1 = t.Item1.Location;
                        Point posItem2 = t.Item2.Location;

                        posItem1.Y -= TamanhoLinha;
                        t.Item1.Location = posItem1;
                        
                        posItem2.Y -= TamanhoLinha;
                        t.Item2.Location = posItem2;
                    }
                    else
                    {
                        if (t.Item1.Indice == evPmButton.Indice)
                        {
                            encontrou = true;

                            t.Item1.Click -= new EventHandler(NumLinhasAlterado);
                            t.Item2.RemoverEventoPreco(new EventHandler(ParcialAlterado));

                            pnlVenda.Controls.Remove(t.Item1);
                            pnlVenda.Controls.Remove(t.Item2);

                            removida = t;
                        }
                    }
                }

                if (removida != null)
                {
                    listItVenda.Remove(removida);

                    removida.Item1.Dispose();
                    removida.Item2.Dispose();
                }

                return;
            }
        }

        private void ParcialAlterado(object sender, EventArgs e)
        {
            double res = 0;

            foreach (TuplaItemVenda t in listItVenda)
            {
                res += t.Item2.GetParcialPreco();
            }

            lblTotalVendaValor.Text = res.ToString("R$ 0.00");
        }

        private void ChbDescontoCheckedChanged(object sender, EventArgs e)
        {
            numDesconto.Enabled = chbDesconto.Checked;
        }

        private void BtnBloqueioClick(object sender, EventArgs e)
        {
            BloquearTela();
        }

        public void BloquearTela()
        {
            pnlBloqueio.BringToFront();
            pnlBloqueio.Visible = true;
            pnlBloqueio.Enabled = true;

            gstCliente?.Hide();
            gstEstoque?.Hide();
            gstFinanca?.Hide();
            gstFornecedor?.Hide();
            gstFuncionario?.Hide();
            gstVenda?.Hide();
        }

        private void BtnDesbloqueioClick(object sender, EventArgs e)
        {
            DesbloquearTela();
        }

        public void DesbloquearTela()
        {
            FrmTesteUsuario validacao = new FrmTesteUsuario(ControleDeUsuario.NomeUsuario);

            while (!validacao.AcessoPermitido)
            {
                validacao.ShowDialog();
            }
            validacao.Dispose();

            pnlBloqueio.SendToBack();
            pnlBloqueio.Visible = false;
            pnlBloqueio.Enabled = false;

            gstCliente?.Show();
            gstEstoque?.Show();
            gstFinanca?.Show();
            gstFornecedor?.Show();
            gstFuncionario?.Show();
            gstVenda?.Show();
        }
        
        private void BtnCtrlVendasClick(object sender, EventArgs e)
        {
            if (gstVenda == null)
            {
                gstVenda = new FrmVenda();

                gstVenda.Show();
                gstVenda.Focus();

                gstVenda.FormClosed += delegate { gstVenda = null; };
            }
            else
            {
                gstVenda.Show();
                gstVenda.Focus();
            }
        }

        private void BtnCtrlEstoqueClick(object sender, EventArgs e)
        {
            if (gstEstoque == null)
            {
                gstEstoque = new FrmEstoque();

                gstEstoque.Show();
                gstEstoque.Focus();

                gstEstoque.FormClosed += delegate { gstEstoque = null; };
            }
            else
            {
                gstEstoque.Show();
                gstEstoque.Focus();
            }
        }

        private void BtnFuncClick(object sender, EventArgs e)
        {
            if (gstFuncionario == null)
            {
                gstFuncionario = new FrmFuncionario();

                gstFuncionario.Show();
                gstFuncionario.Focus();

                gstFuncionario.FormClosed += delegate { gstFuncionario = null; };
            }
            else
            {
                gstFuncionario.Show();
                gstFuncionario.Focus();
            }
        }

        private void BtnFornClick(object sender, EventArgs e)
        {
            if (gstFornecedor == null)
            {
                gstFornecedor = new FrmFornecedor();

                gstFornecedor.Show();
                gstFornecedor.Focus();

                gstFornecedor.FormClosed += delegate { gstFornecedor = null; };
            }
            else
            {
                gstFornecedor.Show();
                gstFornecedor.Focus();
            }
        }

        private void BtnClienteClick(object sender, EventArgs e)
        {
            if (gstCliente == null)
            {
                gstCliente = new FrmCliente();

                gstCliente.Show();
                gstCliente.Focus();

                gstCliente.FormClosed += delegate { gstCliente = null; };
            }
            else
            {
                gstCliente.Show();
                gstCliente.Focus();
            }
        }

        private void BtnFinancasClick(object sender, EventArgs e)
        {
            if (gstFinanca == null)
            {
                gstFinanca = new FrmFinanca();

                gstFinanca.Show();
                gstFinanca.Focus();

                gstFinanca.FormClosed += delegate { gstFinanca = null; };
            }
            else
            {
                gstFinanca.Show();
                gstFinanca.Focus();
            }
        }

        private void BtnNovoClienteClick(object sender, EventArgs e)
        {

        }

        private void BtnFinVendaClick(object sender, EventArgs e)
        {

        }
    }
}
