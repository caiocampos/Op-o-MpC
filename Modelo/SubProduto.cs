using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class SubProduto
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public UInt64 CodigoProduto { get; set; }
        public String Nome { get; set; } = String.Empty;
        public Single Fracao { get; set; } = Single.Epsilon;
        public String CaminhoImagem { get; set; } = String.Empty;
        public Boolean Ativo { get; set; } = true;

        #endregion

        #region Construtores

        public SubProduto()
        { }

        public SubProduto(UInt64 produto)
        {
            CodigoProduto = produto;
        }

        public SubProduto(Produto produto)
        {
            CodigoProduto = produto.Codigo;
        }
        #endregion
    }
}
