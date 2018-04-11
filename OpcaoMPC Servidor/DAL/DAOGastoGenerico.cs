using OpcaoMPCServidor.DAL.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL
{
    public class DAOGastoGenerico : IDAONomeado<GastoGenerico>, IDAODatado<GastoGenerico>
    {
        #region Implementação

        public bool Atualizar(GastoGenerico entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public GastoGenerico Buscar(ulong codigo)
        {
            throw new NotImplementedException();
        }

        public List<GastoGenerico> BuscarEntreDatas(DateTime inicio, DateTime fim)
        {
            throw new NotImplementedException();
        }

        public List<GastoGenerico> BuscarPorData(DateTime data)
        {
            throw new NotImplementedException();
        }

        public List<GastoGenerico> BuscarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public GastoGenerico Inserir(GastoGenerico entidade, ulong usuario)
        {
            throw new NotImplementedException();
        }

        public List<GastoGenerico> ListarTodos()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
