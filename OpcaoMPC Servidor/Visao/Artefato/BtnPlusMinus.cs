using System.Drawing;
using System.Windows.Forms;

namespace OpcaoMPCServidor.Visao.Artefato
{
    using recursos = Properties.Resources;

    public class BtnPlusMinus : Button
    {
        private int situacao = Situacao.Adcionando;

        public int Indice { get; }

        public BtnPlusMinus(int indice)
        {
            Indice = indice;

            SetBotaoMais();

            BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(20, 20);
        }

        public void SetBotaoMais()
        {
            BackgroundImage = recursos.Mais;
            situacao = Situacao.Adcionando;
        }

        public void SetBotaoMenos()
        {
            BackgroundImage = recursos.Menos;
            situacao = Situacao.Removendo;
        }

        public int getSituacao()
        {
            return situacao;
        }
    }
    
    internal static class Situacao
    {
        public const int Adcionando = 0;
        public const int Removendo = 1;
    }
}
