using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Produto
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public String Nome { get; set; } = String.Empty;
        public String Localizacao { get; set; } = String.Empty;
        public Single LimiteMinimo { get; set; } = 0f;
        public String CaminhoImagem { get; set; } = String.Empty;
        public Boolean Ativo { get; set; } = true;

        #endregion

        #region Construtores

        public Produto()
        { }
        #endregion
    }
}
