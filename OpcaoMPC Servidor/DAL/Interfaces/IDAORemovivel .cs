using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL.Interfaces
{
    public interface IDAORemovivel<T>: IDAO<T>
        where T : class, new()
    {
        bool Remover(T entidade, UInt64 usuario);
        bool Remover(UInt64 codigo, UInt64 usuario);
    }
}
