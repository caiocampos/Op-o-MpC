using Controle;
using System;
using System.Collections.Generic;
using Modelo;
using OpcaoMPCServidor.DAL;

namespace OpcaoMPCServidor.Controle
{
    class CtrlFuncionarioS : ICtrlFuncionario
    {
        private static DAOFuncionario daoFunc = new DAOFuncionario();

        public bool Atualizar(Funcionario entidade, ulong usuario)
        {
            return entidade == null 
                ? false : daoFunc.Atualizar(entidade, usuario);
        }

        public Funcionario Buscar(ulong codigo)
        {
            return daoFunc.Buscar(codigo);
        }

        public List<Funcionario> Buscar()
        {
            List<Funcionario> lFunc = daoFunc.ListarTodos();

            if (lFunc == null)
            {
                return null;
            }
            return lFunc.Count > 0 
                ? lFunc : null;
        }

        public List<Funcionario> Buscar(string nome)
        {
            List<Funcionario> lFunc = daoFunc.BuscarPorNome(nome);

            if (lFunc == null)
            {
                return null;
            }
            return lFunc.Count > 0 
                ? lFunc : null;
        }

        public Funcionario Inserir(Funcionario entidade, ulong usuario)
        {
            return entidade == null 
                ? null : daoFunc.Inserir(entidade, usuario);
        }

        public bool Remover(Funcionario entidade, ulong usuario)
        {
            return entidade == null 
                ? false : daoFunc.Remover(entidade, usuario);
        }

        public bool Remover(ulong codigo, ulong usuario)
        {
            return daoFunc.Remover(codigo, usuario);
        }
    }
}
