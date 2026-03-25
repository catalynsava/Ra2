using MySqlConnector;
using Ra.Database;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;


namespace Ra.Design
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            textServer.Text = ConfigurationManager.AppSettings["server"];
            textPort.Text = ConfigurationManager.AppSettings["port"];
            textUser.Text = ConfigurationManager.AppSettings["utilizator"];
            textBazaDeDate.Text = ConfigurationManager.AppSettings["bazadedate"];
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;
            MySqlConnectionStringBuilder connectionBuilder = new MySqlConnectionStringBuilder();
            connectionBuilder.Server = textServer.Text;
            connectionBuilder.Database = ConfigurationManager.AppSettings["numeclient"] + "_" + textBazaDeDate.Text;
            connectionBuilder.UserID = textUser.Text;
            connectionBuilder.Password = textPassword.Text;
            connectionBuilder.Port = uint.Parse(textPort.Text);
            connectionBuilder.Pooling = false;

            try
            {
                conn = new MySqlConnection(connectionBuilder.ConnectionString);
                conn.Open();
                Program.port = uint.Parse(textPort.Text);
                Program.server = textServer.Text;
                Program.bazadedate = ConfigurationManager.AppSettings["numeclient"] + "_" + textBazaDeDate.Text;
                Program.utilizator = textUser.Text;
                Program.parola = Base64Compress.Encode(textPassword.Text);
                Program.IsLoggedIn = true;
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Number:" + ex.Number + "\r\nMessage: " + ex.Message + "\r\nStackTrace:\r\n" + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textUser.Text == "")
            {
                Program.utilizator = "";
            }
            if (textPassword.Text == "")
            {
                Program.parola = "";
            }
        }
    }
}
