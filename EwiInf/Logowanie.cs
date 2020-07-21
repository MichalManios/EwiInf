using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;

namespace EwiInf
{
    public partial class Logowanie : UserControl
    {
        ConnectionAndUser con = new ConnectionAndUser();

        public Logowanie()
        {
            InitializeComponent();
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            textBoxUser.Text = "";
            textBoxUser.ForeColor = Color.FromArgb(172, 126, 241);
            textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Bold);
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                textBoxUser.ForeColor = Color.Gray;
                textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxUser.Text = "Użytkownik";
            }
        }

        private void textBoxHaslo_Enter(object sender, EventArgs e)
        {
            textBoxHaslo.Text = "";
            textBoxHaslo.PasswordChar = '*';
            textBoxHaslo.ForeColor = Color.FromArgb(172, 126, 241);
            textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Bold);
        }

        private void textBoxHaslo_Leave(object sender, EventArgs e)
        {
            if (textBoxHaslo.Text == "")
            {
                textBoxHaslo.PasswordChar = '\0';
                textBoxHaslo.ForeColor = Color.Gray;
                textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxHaslo.Text = "Hasło";
            }
        }

        private void Logowanie_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                textBoxUser.ForeColor = Color.Gray;
                textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxUser.Text = "Użytkownik";
                textBoxHaslo.PasswordChar = '\0';
                textBoxHaslo.ForeColor = Color.Gray;
                textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxHaslo.Text = "Hasło";
                zmianaHasla1.Visible = false;
            }
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonChangePassword_Click(object sender, EventArgs e)
        {
            //deserialicazja
            string SerializePath = Environment.CurrentDirectory + "\\Setting.dat";
            if (File.Exists(SerializePath))
            {
                using (Stream input = File.OpenRead("Setting.dat"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    con = (ConnectionAndUser)formatter.Deserialize(input);
                }
            }
            if (textBoxUser.Text == "Użytkownik" || textBoxUser.Text == "" || textBoxHaslo.Text == "Hasło" || textBoxHaslo.Text == "")
            {
                MessageBox.Show("Aby zmienić hasło użytkownika musisz wpierw podać prawidłowy LOGIN i HASŁO!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxUser.ForeColor = Color.Gray;
                textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxUser.Text = "Użytkownik";

                textBoxHaslo.PasswordChar = '\0';
                textBoxHaslo.ForeColor = Color.Gray;
                textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxHaslo.Text = "Hasło";
            }
            else
            {
                if (con.CheckUserAndPassword(textBoxUser.Text, textBoxHaslo.Text))
                {
                    textBoxUser.ForeColor = Color.Gray;
                    textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                    textBoxUser.Text = "Użytkownik";

                    textBoxHaslo.PasswordChar = '\0';
                    textBoxHaslo.ForeColor = Color.Gray;
                    textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                    textBoxHaslo.Text = "Hasło";

                    zmianaHasla1.Visible = true;
                    zmianaHasla1.BringToFront();
                }
                else
                {
                    MessageBox.Show("Błędna nazwa użytkownika lub niepoprawne hasło!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textBoxUser.ForeColor = Color.Gray;
                    textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                    textBoxUser.Text = "Użytkownik";

                    textBoxHaslo.PasswordChar = '\0';
                    textBoxHaslo.ForeColor = Color.Gray;
                    textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                    textBoxHaslo.Text = "Hasło";
                }
            }
        }

        public bool IsServerConnected()
        {

            string sConnectionString = "Data Source=" + con.ServerName + "\\" + con.ServerSQLinstance + ";Initial Catalog=" + con.DatabaseName + ";User ID=" + con.User + ";Password=" + con.Password + ";";
            using (var l_oConnection = new SqlConnection(sConnectionString))
            {
                try
                {

                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        private void iconButtonLogin_Click(object sender, EventArgs e)
        {
            //deserialicazja
            string SerializePath = Environment.CurrentDirectory + "\\Setting.dat";
            if (File.Exists(SerializePath))
            {
                using (Stream input = File.OpenRead("Setting.dat"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    con = (ConnectionAndUser)formatter.Deserialize(input);
                }
            }
            if (con.NotEmpty() && IsServerConnected())
            {
                if (con.CheckUserAndPassword(textBoxUser.Text, textBoxHaslo.Text))
                {
                    TopLevelControl.Hide();
                    Form1 Form1 = new Form1();
                    Form1.Show();                  
                }
                else
                {
                    MessageBox.Show("Błędna nazwa użytkownika lub niepoprawne hasło!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if(con.NotEmpty()==false) MessageBox.Show("Wpierw musisz zapisać ustawienia połączenia!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Wprowadź ponownie wszystkie ustawienia w oknie Ustawienia połączenia i przetestuj to połączenie. Następnie spróbuj się zalogować.", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxUser.ForeColor = Color.Gray;
                textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxUser.Text = "Użytkownik";

                textBoxHaslo.PasswordChar = '\0';
                textBoxHaslo.ForeColor = Color.Gray;
                textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                textBoxHaslo.Text = "Hasło";
            }
        }

        private void zmianaHasla1_Load(object sender, EventArgs e)
        {

        }

        private void zmianaHasla1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
