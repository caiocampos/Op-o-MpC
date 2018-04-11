using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOSubProduto : IDAONomeado<SubProduto>, IDAORemovivel<SubProduto>
    {
        #region Implementação

        public bool Atualizar(SubProduto entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public SubProduto Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<SubProduto> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public SubProduto Inserir(SubProduto entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<SubProduto> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(SubProduto entidade, ulong usuario)
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
