namespace OpcaoMPCServidor.DAL.Util
{
    public static class Acao
    {
        public const string INSERT = "INSERT";
        public const string UPDATE = "UPDATE";
        public const string DELETE = "DELETE";
    }

    public static class Tabela
    {
        public const string Caixa = "Caixa";
        public const string Cliente = "Cliente";
        public const string Comissao = "Comissao";
        public const string Compra = "Compra";
        public const string Fornecedor = "Fornecedor";
        public const string Funcionario = "Funcionario";
        public const string GastoGenerico = "GastoGenerico";
        public const string ItemVenda = "ItemVenda";
        public const string Produto = "Produto";
        public const string ProdutoEstoque = "ProdutoEstoque";
        public const string SubProduto = "SubProduto";
        public const string Venda = "Venda";
    }

    public static class Usuario
    {
        public const ulong SISTEMA = 9223372036854775805;
    }
}
