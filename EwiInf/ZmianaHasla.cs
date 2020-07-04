using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EwiInf
{
    public partial class ZmianaHasla : UserControl
    {
        ConnectionAndUser con = new ConnectionAndUser();
        public ZmianaHasla()
        {
            InitializeComponent();
        }

        private void ZmianaHasla_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                textBoxNewPassword.PasswordChar = '\0';
                textBoxNewPassword.ForeColor = Color.Gray;
                textBoxNewPassword.Font = new Font(textBoxNewPassword.Font, FontStyle.Italic);
                textBoxNewPassword.Text = "Nowe hasło";
                textBoxConfirmNewPassword.PasswordChar = '\0';
                textBoxConfirmNewPassword.ForeColor = Color.Gray;
                textBoxConfirmNewPassword.Font = new Font(textBoxConfirmNewPassword.Font, FontStyle.Italic);
                textBoxConfirmNewPassword.Text = "Potwierdź nowe hasło";
            }
        }

        private void textBoxConfirmNewPassword_Enter(object sender, EventArgs e)
        {
            textBoxConfirmNewPassword.PasswordChar = '*';
            textBoxConfirmNewPassword.Text = "";
            textBoxConfirmNewPassword.ForeColor = Color.FromArgb(172, 126, 241);
            textBoxConfirmNewPassword.Font = new Font(textBoxConfirmNewPassword.Font, FontStyle.Bold);
        }

        private void textBoxConfirmNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxConfirmNewPassword.Text == "")
            {
                textBoxConfirmNewPassword.PasswordChar = '\0';
                textBoxConfirmNewPassword.ForeColor = Color.Gray;
                textBoxConfirmNewPassword.Font = new Font(textBoxConfirmNewPassword.Font, FontStyle.Italic);
                textBoxConfirmNewPassword.Text = "Potwierdź nowe hasło";
            }
        }

        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
            textBoxNewPassword.PasswordChar = '*';
            textBoxNewPassword.Text = "";
            textBoxNewPassword.ForeColor = Color.FromArgb(172, 126, 241);
            textBoxNewPassword.Font = new Font(textBoxNewPassword.Font, FontStyle.Bold);
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                textBoxNewPassword.PasswordChar = '\0';
                textBoxNewPassword.ForeColor = Color.Gray;
                textBoxNewPassword.Font = new Font(textBoxNewPassword.Font, FontStyle.Italic);
                textBoxNewPassword.Text = "Nowe hasło";
            }
        }

        private void ZmianaHasla_Load(object sender, EventArgs e)
        {

        }

        private void iconButtonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == textBoxConfirmNewPassword.Text)
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
                
                if (con.NotEmpty())
                {
                    SqlConnection.ChangePassword(con.ConnectionString, textBoxNewPassword.Text);
                    con.Password = textBoxNewPassword.Text;
                    con.SetFields(con.User, con.Password, con.ServerName, con.ServerSQLinstance, con.DatabaseName); ;
                    //serializacja
                    using (Stream output = File.Create("Setting.dat"))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(output, con);
                    }
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Nie masz zapisanych ustawień połączenia! Wpierw zapisz ustawienia!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Hasło w obu polach nie zgadza się! Spróbuj ustalić nowe hasło jeszcze raz!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxNewPassword.PasswordChar = '\0';
                textBoxNewPassword.ForeColor = Color.Gray;
                textBoxNewPassword.Font = new Font(textBoxNewPassword.Font, FontStyle.Italic);
                textBoxNewPassword.Text = "Nowe hasło";

                textBoxConfirmNewPassword.PasswordChar = '\0';
                textBoxConfirmNewPassword.ForeColor = Color.Gray;
                textBoxConfirmNewPassword.Font = new Font(textBoxConfirmNewPassword.Font, FontStyle.Italic);
                textBoxConfirmNewPassword.Text = "Potwierdź nowe hasło";
            }

        }
    }
}
