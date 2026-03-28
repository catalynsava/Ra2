using MySqlConnector;
using Ra.Database;
using Ra.Design;

namespace Ra
{
    internal class Program
    {
        internal static string? bazadedate;
        internal static string? server;
        internal static uint port;
        internal static string? utilizator;
        internal static string? parola;
        public static MySqlConnection? Conexiune;
        public static bool IsLoggedIn;

        internal static frmLogin? frmlogin;
        internal static Mdira? mdiRa;
        internal static ucOpis? ucOpis;
        internal static ucButoane? ucButoane;
        internal static ucStatus? ucStatus;
        internal static ucPozitie? ucPozitie;
        internal static FormPozitie? formPozitie;

        [STAThread]
        static void Main()
        {
            frmlogin = new frmLogin();
            frmlogin.ShowDialog();

            if (IsLoggedIn)
            {
                mdiRa = new Mdira();
                mdiRa.ShowDialog();
            }
        }
    }
}
