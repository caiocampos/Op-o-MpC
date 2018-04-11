using Controle;
using Modelo;
using OpcaoMPCServidor.Controle;
using OpcaoMPCServidor.Visao.Cadastro;
using OpcaoMPCServidor.Visao.Validacao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Gestao
{
    public partial class FrmFuncionario : Form
    {
        private List<Funcionario> lDados = null;
        private CtrlFuncionarioS ctrlFunc = new CtrlFuncionarioS();

        public FrmFuncionario()
        {
            InitializeComponent();
            
            lDados = ctrlFunc.Buscar() ?? new List<Funcionario>();

            Procurar();
        }

        private void BtnSUsrClick(object sender, EventArgs e)
        {
            FrmAutenticacaoSuper aSuper = new FrmAutenticacaoSuper(FrmAutenticacaoSuper.Atualizacao);
            
            aSuper.ShowDialog();

            aSuper.Dispose();
        }

        private void BtnFuncClick(object sender, EventArgs e)
        {
            FrmCadFuncionario cadFunc = new FrmCadFuncionario();
            
            cadFunc.ShowDialog();

            cadFunc.Dispose();

            Procurar();
        }

        private void Procurar()
        {
            lDados = string.IsNullOrWhiteSpace(txtPesquisa.Text)
                ? ctrlFunc.Buscar() : ctrlFunc.Buscar(txtPesquisa.Text);

            lDados = lDados ?? new List<Funcionario>();

            lDados = (
                from item in lDados
                orderby item.Nome ascending
                select item
                ).ToList();
            
            lstResultados.DataSource = (
                from item in lDados
                select item.Nome
                ).ToList();
        }

        private void TxtPesquisaTextChanged(object sender, EventArgs e)
        {
            Procurar();
        }

        private void LstResultadosDoubleClick(object sender, EventArgs e)
        {
            AlterarSelecionado();
        }

        private void BtnEditarClick(object sender, EventArgs e)
        {
            AlterarSelecionado();
        }

        private void LstResultadosKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                AlterarSelecionado();
            }
        }

        private void AlterarSelecionado()
        {
            int nItens = lDados.Count;
            int sel = lstResultados.SelectedIndex;

            FrmCadFuncionario cadFunc = new FrmCadFuncionario(lDados[sel]);

            cadFunc.ShowDialog();

            cadFunc.Dispose();

            Procurar();

            if (lDados.Count >= nItens)
            {
                lstResultados.SelectedIndex = sel;
            }
        }

        private void BtnApagarClick(object sender, EventArgs e)
        {
            Funcionario funci = lDados[lstResultados.SelectedIndex];

            ulong id = ControleDeUsuario.Id;
            string msg = string.Empty;

            if (id == funci.Codigo)
            {
                msg = "Você não pode apagar seu próprio usuário";
            }
            else
            {
                CtrlFuncionarioS ctrlFuncionario = new CtrlFuncionarioS();

                FrmAutenticacaoSuper aSuper = new FrmAutenticacaoSuper();

                aSuper.ShowDialog();

                if (!aSuper.Valido)
                {
                    aSuper.Dispose();

                    return;
                }
                aSuper.Dispose();

                bool res = ctrlFuncionario.Remover(funci, id);

                msg = res
                    ? "Funcionário excluído com sucesso" : "A operação não pôde ser concluída";
            }
            MessageBox.Show(
                msg,
                "Confirmação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Procurar();
        }

        private void BtnBloqueioClick(object sender, EventArgs e)
        {
            CtrlBloqueioTela.BloquearTela();
        }

        private void BtnPagamentoClick(object sender, EventArgs e)
        {

        }
    }
}
