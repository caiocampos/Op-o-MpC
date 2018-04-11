using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOFornecedor : IDAONomeado<Fornecedor>, IDAORemovivel<Fornecedor>
    {
        #region Implementação

        public bool Atualizar(Fornecedor entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public Fornecedor Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Fornecedor Inserir(Fornecedor entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(Fornecedor entidade, ulong usuario)
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
