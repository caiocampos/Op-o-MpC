using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class ItemVenda
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public UInt64 CodigoProduto { get; set; }
        public UInt64 CodigoSubProduto { get; set; }
        public UInt64 CodigoVenda { get; set; }
        public Single Quantidade { get; set; } = 0f;
        public Single Subtotal { get; set; } = 0f;

        #endregion

        #region Construtores

        public ItemVenda ()
        { }

        public ItemVenda (UInt64 produto)
        {
            CodigoProduto = produto;
            CodigoSubProduto = 0;
        }

        public ItemVenda(UInt64 produto, UInt64 subProduto)
        {
            CodigoProduto = produto;
            CodigoSubProduto = subProduto;
        }

        public ItemVenda(Produto produto)
        {
            CodigoProduto = produto.Codigo;
            CodigoSubProduto = 0;
        }

        public ItemVenda(SubProduto subProduto)
        {
            CodigoProduto = subProduto.CodigoProduto;
            CodigoSubProduto = subProduto.Codigo;
        }
        #endregion
    }
}
