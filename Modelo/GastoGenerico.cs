using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class GastoGenerico
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public String Nome { get; set; } = String.Empty;
        public Single Valor { get; set; } = 0f;
        public String Descrição { get; set; } = String.Empty;
        public DateTime Data { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public GastoGenerico()
        { }
        #endregion
    }
}
