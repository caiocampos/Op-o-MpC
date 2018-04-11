using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL.Interfaces
{
    public interface IDAONomeado<T> : IDAO<T>
        where T : class, new()
    {
        List<T> BuscarPorNome(String nome);
    }
}
