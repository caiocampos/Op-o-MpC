using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOItemVenda : IDAO<ItemVenda>, IDAORemovivel<ItemVenda>
    {
        #region Implementação

        public bool Atualizar(ItemVenda entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public ItemVenda Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public ItemVenda Inserir(ItemVenda entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<ItemVenda> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Remover(ItemVenda entidade, ulong usuario)
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
