using Modelo;
using System.Collections.Generic;

namespace Controle
{
    public interface ICtrlFuncionario
    {
        bool Atualizar(Funcionario entidade, ulong usuario);
        Funcionario Inserir(Funcionario entidade, ulong usuario);
        Funcionario Buscar(ulong codigo);
        List<Funcionario> Buscar();
        List<Funcionario> Buscar(string nome);
        bool Remover(Funcionario entidade, ulong usuario);
        bool Remover(ulong codigo, ulong usuario);
    }
}
