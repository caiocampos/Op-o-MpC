using System;
using System.Runtime.Serialization;

namespace Modelo
{
    [Serializable()]
    public class Funcionario : ISerializable
    {
        #region Propriedades

        public UInt64 Codigo { get; set; }
        public String Nome { get; set; } = String.Empty;
        public String Usuario { get; set; } = String.Empty;
        public String Senha { get; set; } = String.Empty;
        public Boolean Comissionado { get; set; } = false;
        public String Funcao { get; set; } = String.Empty;
        public Single Salario { get; set; } = 0f;
        public DateTime UltimoPagamento { get; set; } = DateTime.MinValue;

        #endregion

        #region Construtores

        public Funcionario()
        { }

        public Funcionario(String nome)
        {
            Nome = nome;
        }

        public Funcionario(SerializationInfo info, StreamingContext context)
        {
            Codigo          = info.GetUInt64("FuncionarioCodigo");
            Nome            = info.GetString("FuncionarioNome");
            Usuario         = info.GetString("FuncionarioUsuario");
            Senha           = info.GetString("FuncionarioSenha");
            Comissionado    = info.GetBoolean("FuncionarioComissionado");
            Funcao          = info.GetString("FuncionarioFuncao");
            Salario         = info.GetSingle("FuncionarioSalario");
            UltimoPagamento = info.GetDateTime("FuncionarioUltimoPagamento");
        }
        #endregion

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FuncionarioCodigo", Codigo);
            info.AddValue("FuncionarioNome", Nome);
            info.AddValue("FuncionarioUsuario", Usuario);
            info.AddValue("FuncionarioSenha", Senha);
            info.AddValue("FuncionarioComissionado", Comissionado);
            info.AddValue("FuncionarioFuncao", Funcao);
            info.AddValue("FuncionarioSalario", Salario);
            info.AddValue("FuncionarioUltimoPagamento", UltimoPagamento);
        }
    }
}
