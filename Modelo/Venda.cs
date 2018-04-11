using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Venda
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public UInt64 CodigoFuncionario { get; set; }
        public UInt64 CodigoCliente { get; set; }
        public UInt64 CodigoComissao { get; set; }
        public String NomeFuncionario { get; set; }
        public String NomeCliente { get; set; }
        public Single Desconto { get; set; } = 0f;
        public Single Frete { get; set; } = 0f;
        public Single ValorCobrado { get; set; } = 0f;
        public String FormaPagamento { get; set; } = String.Empty;
        public Boolean Cancelada { get; set; } = false;
        public DateTime Data { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public Venda()
        { }
        #endregion
    }
}
