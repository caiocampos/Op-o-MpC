using System.ComponentModel;

namespace Controle
{
    public class LogSistema
    {
        private static BindingList<string> eventos;

        private static void VerificarLog()
        {
            eventos = eventos ?? new BindingList<string>
            {
                AllowRemove = false,
                AllowNew = false,
                AllowEdit = false
            };
        }

        public static void AdicionarEvento(string evento)
        {
            VerificarLog();

            eventos.AllowEdit = true;
            eventos.AllowNew = true;

            eventos.Add(evento);

            eventos.AllowEdit = false;
            eventos.AllowNew = false;
        }

        public static BindingList<string> GetEventos()
        {
            VerificarLog();

            return eventos;
        }
    }
}
