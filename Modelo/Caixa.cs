using System;

namespace Modelo
{
    public class Caixa
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public Single ValorEmCaixa { get; set; } = 0f;
        public DateTime Data { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public Caixa()
        { }

        public Caixa(Single valorEmCaixa, DateTime data)
        {
            ValorEmCaixa = valorEmCaixa;
            Data = data;
        }
        #endregion
    }
}
