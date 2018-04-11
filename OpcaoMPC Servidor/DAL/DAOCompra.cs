using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOCompra : IDAODatado<Compra>
    {
        #region Implementação

        public bool Atualizar(Compra entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public Compra Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<Compra> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }

        public List<Compra> BuscarPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public Compra Inserir(Compra entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<Compra> ListarTodos()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
