using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL.Interfaces
{
    public interface IDAODatado<T>: IDAO<T>
        where T : class, new()
    {
        List<T> BuscarPorData(DateTime data);
        List<T> BuscarEntreDatas(DateTime inicio, DateTime fim);
    }
}
