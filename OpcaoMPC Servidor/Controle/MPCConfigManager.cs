using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;
using System.Configuration;
using System.Collections.Generic;

namespace OpcaoMPCServidor.Controle
{
    internal class MPCConfigManager
    {
        public static string GetDBOpcaoMPC()
        {
            #region Declarações

            AesCryptoServiceProvider provider;
            CryptoStream decryptor;
            MemoryStream mStream;
            string dbString;
            byte[] bText;
            string res;
            byte[] b1;
            byte[] b2;
            
            List<string> rl = GetRList();

            #endregion
            
            dbString = ConfigurationManager.ConnectionStrings["OpcaoMPC"].ConnectionString;

            #region Definições

            b2 = Encoding.UTF8.GetBytes(rl[5] + rl[2] + rl[0] + rl[4]);
            b1 = Encoding.UTF8.GetBytes(rl[3] + rl[1]);

            provider = new AesCryptoServiceProvider();
            mStream = new MemoryStream();

            provider.IV = b1;
            provider.Key = b2;

            #endregion

            bText = Convert.FromBase64String(dbString);
            // bText = Encoding.UTF8.GetBytes(dbString);

            decryptor = new CryptoStream(mStream, provider.CreateDecryptor(provider.Key, provider.IV), CryptoStreamMode.Write);
            // decryptor = new CryptoStream(mStream, provider.CreateEncryptor(provider.Key, provider.IV), CryptoStreamMode.Write);

            decryptor.Write(bText, 0, bText.Length);

            decryptor.FlushFinalBlock();

            res = Encoding.UTF8.GetString(mStream.ToArray());
            // res = Convert.ToBase64String(mStream.ToArray());

            return res;
        }

        public static string GetEsquemaPadrao()
        {
            return ConfigurationManager.AppSettings["EsquemaPadrao"].ToString();
        }
        
        public static string GerarSenha(string senha)
        {
            #region Declarações

            AesCryptoServiceProvider provider;
            CryptoStream decryptor;
            MemoryStream mStream;
            byte[] bText;
            string res;
            byte[] b1;
            byte[] b2;

            List<string> rl = GetRList();

            #endregion
            
            #region Definições

            b2 = Encoding.UTF8.GetBytes(rl[2] + rl[1] + rl[4] + rl[0]);
            b1 = Encoding.UTF8.GetBytes(rl[5] + rl[3]);

            provider = new AesCryptoServiceProvider();
            mStream = new MemoryStream();

            provider.IV = b1;
            provider.Key = b2;

            #endregion
            
            bText = Encoding.UTF8.GetBytes(senha);
            
            decryptor = new CryptoStream(mStream, provider.CreateEncryptor(provider.Key, provider.IV), CryptoStreamMode.Write);

            decryptor.Write(bText, 0, bText.Length);

            decryptor.FlushFinalBlock();
            
            res = Convert.ToBase64String(mStream.ToArray());

            return res;
        }

        private static List<string> GetRList()
        {
            List<string> rList = new List<string>();
            rList.Add(ConfigurationManager.AppSettings["R1"].ToString());
            rList.Add(ConfigurationManager.AppSettings["R2"].ToString());
            rList.Add(ConfigurationManager.AppSettings["R3"].ToString());
            rList.Add(ConfigurationManager.AppSettings["R4"].ToString());
            rList.Add(ConfigurationManager.AppSettings["R5"].ToString());
            rList.Add(ConfigurationManager.AppSettings["R6"].ToString());

            return rList;
        }

        public static void SetUsuarioPadrao(string nome)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["UsuarioPadrao"].Value = nome;
            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string GetUsuarioPadrao()
        {
            return ConfigurationManager.AppSettings["UsuarioPadrao"].ToString();
        }
    }
}
