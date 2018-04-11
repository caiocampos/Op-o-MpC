using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Compra
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public UInt64 CodigoProdutoEstoque { get; set; }
        public Single Quantidade { get; set; } = 0f;
        public Single ValorPago { get; set; } = 0f;
        public DateTime Data { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public Compra()
        { }
        #endregion
    }
}
