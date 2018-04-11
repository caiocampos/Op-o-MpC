using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOProduto : IDAONomeado<Produto>, IDAORemovivel<Produto>
    {
        #region Implementação

        public bool Atualizar(Produto entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public Produto Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<Produto> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Produto Inserir(Produto entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(Produto entidade, ulong usuario)
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
