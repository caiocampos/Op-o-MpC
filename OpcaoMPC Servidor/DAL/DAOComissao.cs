using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOComissao : IDAODatado<Comissao>
    {
        #region Implementação
        
        public bool Atualizar(Comissao entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public Comissao Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<Comissao> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }

        public List<Comissao> BuscarPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public Comissao Inserir(Comissao entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<Comissao> ListarTodos()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
