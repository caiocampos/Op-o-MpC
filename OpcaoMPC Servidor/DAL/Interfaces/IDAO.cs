using System;
using System.Collections.Generic;

namespace OpcaoMPCServidor.DAL.Interfaces
{
    public interface IDAO<T>
        where T: class, new()
    {
        T Inserir(T entidade, UInt64 usuario);
        bool Atualizar(T entidade, UInt64 usuario);
        T Buscar(UInt64 codigo);
        List<T> ListarTodos();
    }
}
