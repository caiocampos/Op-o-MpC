using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Fornecedor
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public String Nome { get; set; } = String.Empty;
        public String NomeFantasia { get; set; } = String.Empty;
        public String CNPJCPF { get; set; } = String.Empty;
        public String Telefone1 { get; set; } = String.Empty;
        public String Telefone2 { get; set; } = String.Empty;
        public String Telefone3 { get; set; } = String.Empty;
        public String Endereço { get; set; } = String.Empty;
        public Int32 CEP { get; set; } = 0;
        public Int32 Numero { get; set; } = 0;
        public String Cidade { get; set; } = String.Empty;
        public String Estado { get; set; } = String.Empty;

        #endregion

        #region Construtores

        public Fornecedor()
        { }

        public Fornecedor(String nome)
        {
            Nome = nome;
        }
        #endregion
    }
}
