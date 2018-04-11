using Modelo;
using System;
using System.Collections.Generic;

namespace Controle
{
    public interface ICtrlCaixa
    {
        Caixa GetCaixaAtual();
        Caixa Buscar(DateTime date);
        List<Caixa> Buscar();
        List<Caixa> Buscar(DateTime date1, DateTime date2);
        Caixa AddCaixa(float valor, ulong usuario);
    }
}
