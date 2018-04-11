using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOProdutoEstoque : IDAODatado<ProdutoEstoque>, IDAORemovivel<ProdutoEstoque>
    {
        #region Implementação

        public bool Atualizar(ProdutoEstoque entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public ProdutoEstoque Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoEstoque> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoEstoque> BuscarPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public ProdutoEstoque Inserir(ProdutoEstoque entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoEstoque> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(ProdutoEstoque entidade, ulong usuario)
        {
            return Remover(entidade.Codigo, usuario);
        }

        public bool Remover(ulong codigo, ulong usuario)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
