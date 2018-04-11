using System;

namespace Modelo
{
    public class Comissao
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public UInt64 CodigoFuncionario { get; set; }
        public Single Valor { get; set; } = 0f;
        public DateTime Data { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public Comissao()
        { }

        public Comissao(UInt64 funcionario)
        {
            CodigoFuncionario = funcionario;
        }

        public Comissao(Funcionario funcionario)
        {
            CodigoFuncionario = funcionario.Codigo;
        }
        #endregion
    }
}
