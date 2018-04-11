using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOCliente : IDAONomeado<Cliente>, IDAORemovivel<Cliente>
    {
        #region Implementação

        public bool Atualizar(Cliente entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public Cliente Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Cliente Inserir(Cliente entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(Cliente entidade, ulong usuario)
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
