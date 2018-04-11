using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOVenda : IDAODatado<Venda>
    {
        #region Implementação

        public bool Atualizar(Venda entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public Venda Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public Venda Inserir(Venda entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<Venda> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public bool Cancelar(Venda entidade, ulong usuario)
        {
            // Atualiza a Venda marcando ela como cancelada
            // e apaga os ItemVenda relacionados e a comissão (se existir)
            throw new NotImplementedException();
        }
        #endregion
    }
}
