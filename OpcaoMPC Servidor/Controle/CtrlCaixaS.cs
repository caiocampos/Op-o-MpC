using System;
using Modelo;
using OpcaoMPCServidor.DAL;
using System.Collections.Generic;
using Controle;

namespace OpcaoMPCServidor.Controle
{
    public class CtrlCaixaS : ICtrlCaixa
    {
        private static DAOCaixa daoCx = new DAOCaixa();
        private static Caixa caixaDia;

        public bool IniciarCaixa()
        {
            if (caixaDia != null)
            {
                return true;
            }
            List<Caixa> lCx = daoCx.BuscarPorData(DateTime.Now);
            
            if (lCx != null)
            {
                if (lCx.Count != 0)
                {
                    caixaDia = lCx[0];

                    return true;
                }
            }

            Caixa caixaAnterior;
            
            lCx = daoCx.ListarTodos();
            
            if (lCx != null)
            {
                if (lCx.Count > 0)
                {
                    caixaAnterior = lCx[lCx.Count- 1];

                    caixaDia = daoCx.Inserir(new Caixa(caixaAnterior.ValorEmCaixa, DateTime.Now));
                    
                    return caixaDia == null 
                        ? false : true;
                }
            }
            return false;
        }

        public bool PrimeiroCaixa(float valorEmCaixa)
        {
            Caixa caixaAnterior;

            caixaAnterior = daoCx.Inserir(new Caixa(valorEmCaixa, DateTime.Now.AddDays(-1)));
            caixaDia      = daoCx.Inserir(new Caixa(valorEmCaixa, DateTime.Now));

            return caixaDia == null 
                ? false : true;
        }

        public Caixa GetCaixaAtual()
        {
            return caixaDia;
        }

        public Caixa Buscar(DateTime date)
        {
            List<Caixa> lCaixa = daoCx.BuscarPorData(date);

            if (lCaixa == null)
            {
                return null;
            }
            return lCaixa.Count > 0 
                ? lCaixa[0] : null;
        }

        public List<Caixa> Buscar()
        {
            List<Caixa> lCaixa = daoCx.ListarTodos();

            if (lCaixa == null)
            {
                return null;
            }
            return lCaixa.Count > 0
                ? lCaixa : null;
        }

        public List<Caixa> Buscar(DateTime date1, DateTime date2)
        {
            List<Caixa> lCaixa = daoCx.BuscarEntreDatas(date1, date2);

            if (lCaixa == null)
            {
                return null;
            }
            return lCaixa.Count > 0 
                ? lCaixa : null;
        }

        public Caixa AddCaixa(float valor, ulong usuario)
        {
            if (caixaDia == null)
            {
                return null;
            }
            float valorAnt = caixaDia.ValorEmCaixa;

            caixaDia.ValorEmCaixa += valor;

            if (daoCx.Atualizar(caixaDia, usuario))
            {
                return caixaDia;
            }
            caixaDia.ValorEmCaixa = valorAnt;

            return caixaDia;
        }
    }
}
