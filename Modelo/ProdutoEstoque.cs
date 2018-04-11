using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ProdutoEstoque
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public UInt64 CodigoProduto { get; set; }
        public UInt64 CodigoFornecedor { get; set; }
        public Single Preco { get; set; } = 0f;
        public Single PrecoVenda { get; set; } = 0f;
        public Single QuantidadeEstoque { get; set; } = 0f;
        public DateTime DataAdicao { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public ProdutoEstoque()
        { }
        #endregion
    }
}
