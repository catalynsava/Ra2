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
            DoLogin();
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

        private void DoLogin()
        {
            labelLogin.Text = "";
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = textServer.Text;
            builder.Database = ConfigurationManager.AppSettings["numeclient"] + "_" + textBazaDeDate.Text;
            builder.UserID = textUser.Text;
            builder.Password = textPassword.Text;
            builder.Port = uint.Parse(textPort.Text);
            builder.Pooling = false;

            try
            {
                using (var conn = new MySqlConnection(builder.ConnectionString))
                {
                    conn.Open(); // aici se face autentificarea cu MySQL
                    Program.port = uint.Parse(textPort.Text);
                    Program.server = textServer.Text;
                    Program.bazadedate = ConfigurationManager.AppSettings["numeclient"] + "_" + textBazaDeDate.Text;
                    Program.utilizator = textUser.Text;
                    Program.parola = Base64Compress.Encode(textPassword.Text);
                    Program.IsLoggedIn = true;
                    Debug.WriteLine("Conexiunea a fost realizata cu succes!");
                    labelLogin.Text = "Conexiunea a fost realizata cu succes!";
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Number:" + ex.Number + "\r\nMessage: " + ex.Message + "\r\nStackTrace:\r\n" + ex.StackTrace);
                labelLogin.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }
    }
}
