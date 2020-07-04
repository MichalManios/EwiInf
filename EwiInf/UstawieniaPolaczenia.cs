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
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Threading;

namespace EwiInf
{
    public partial class UstawieniaPolaczenia : UserControl
    {
        ConnectionAndUser con = new ConnectionAndUser();
        bool bSearch = false;

        public UstawieniaPolaczenia()
        {
            InitializeComponent();
        }

        private void ClearFullSettings()
        {
            bSearch = false;
            iconButtonSave.Enabled = false;

            textBoxNameServer.ForeColor = Color.Gray;
            textBoxNameServer.Font = new Font(textBoxNameServer.Font, FontStyle.Italic);
            textBoxNameServer.Text = "Nazwa serwera";

            comboBoxInstance.Items.Clear();
            comboBoxInstance.Items.Add("Instancja serwera SQL");
            comboBoxInstance.ForeColor = Color.Gray;
            comboBoxInstance.Font = new Font(comboBoxBase.Font, FontStyle.Italic);
            comboBoxInstance.SelectedIndex = 0;

            comboBoxBase.Items.Clear();
            comboBoxBase.Items.Add("Nazwa bazy danych");
            comboBoxBase.ForeColor = Color.Gray;
            comboBoxBase.Font = new Font(comboBoxBase.Font, FontStyle.Italic);
            comboBoxBase.SelectedIndex = 0;

            textBoxUser.ForeColor = Color.Gray;
            textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
            textBoxUser.Text = "Użytkownik";

            textBoxHaslo.PasswordChar = '\0';
            textBoxHaslo.ForeColor = Color.Gray;
            textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
            textBoxHaslo.Text = "Hasło";
        }

        private void UstawieniaPolaczenia_Load(object sender, EventArgs e)
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
        }

        private void textBoxNameServer_Enter(object sender, EventArgs e)
        {
            iconButtonSave.Enabled = false;
            ClearFullSettings();
            textBoxNameServer.Text = "";
            textBoxNameServer.ForeColor = Color.FromArgb(249, 118, 176);
            textBoxNameServer.Font = new Font(textBoxNameServer.Font, FontStyle.Bold);  
        }

        private void textBoxNameServer_Leave(object sender, EventArgs e)
        {
            if (textBoxNameServer.Text == "")
            {
                textBoxNameServer.ForeColor = Color.Gray;
                textBoxNameServer.Font = new Font(textBoxNameServer.Font, FontStyle.Italic);
                textBoxNameServer.Text = "Nazwa serwera";
            }
        }

        private void UstawieniaPolaczenia_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                if(con.NotEmpty()==true)
                {
                    bSearch = true;
                    textBoxNameServer.ForeColor = Color.FromArgb(249, 118, 176);
                    textBoxNameServer.Font = new Font(textBoxNameServer.Font, FontStyle.Bold);
                    comboBoxInstance.ForeColor = Color.FromArgb(249, 118, 176);
                    comboBoxInstance.Font = new Font(comboBoxInstance.Font, FontStyle.Bold);
                    comboBoxBase.ForeColor = Color.FromArgb(249, 118, 176);
                    comboBoxBase.Font = new Font(comboBoxBase.Font, FontStyle.Bold);
                    textBoxUser.ForeColor = Color.FromArgb(249, 118, 176);
                    textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Bold);
                    textBoxHaslo.ForeColor = Color.FromArgb(249, 118, 176);
                    textBoxHaslo.Font = new Font(textBoxHaslo.Font, FontStyle.Bold);
                    textBoxHaslo.PasswordChar = '*';

                    textBoxNameServer.Text = con.ServerName;
                    comboBoxInstance.Items.Clear();
                    comboBoxInstance.Items.Add(con.ServerSQLinstance);
                    comboBoxInstance.SelectedIndex = 0;
                    comboBoxBase.Items.Clear();
                    comboBoxBase.Items.Add(con.DatabaseName);
                    comboBoxBase.SelectedIndex = 0;
                    textBoxUser.Text = con.User;
                    textBoxHaslo.Text = con.Password;
                }
                else
                {
                    bSearch = false;
                    textBoxNameServer.ForeColor = Color.Gray;
                    textBoxNameServer.Font = new Font(textBoxNameServer.Font, FontStyle.Italic);
                    textBoxNameServer.Text = "Nazwa serwera";

                    comboBoxInstance.Items.Clear();
                    comboBoxInstance.Items.Add("Instancja serwera SQL");
                    comboBoxInstance.SelectedIndex = 0;
                    comboBoxInstance.ForeColor = Color.Gray;
                    comboBoxInstance.Font = new Font(textBoxNameServer.Font, FontStyle.Italic);

                    comboBoxBase.Items.Clear();
                    comboBoxBase.Items.Add("Nazwa bazy danych");
                    comboBoxBase.SelectedIndex = 0;
                    comboBoxBase.ForeColor = Color.Gray;
                    comboBoxBase.Font = new Font(comboBoxBase.Font, FontStyle.Italic);


                    textBoxUser.ForeColor = Color.Gray;
                    textBoxUser.Font = new Font(textBoxUser.Font, FontStyle.Italic);
                    textBoxUser.Text = "Użytkownik";

                    textBoxHaslo.ForeColor = Color.Gray;
                    textBoxHaslo.Font = new Font(textBoxNameServer.Font, FontStyle.Italic);
                    textBoxHaslo.PasswordChar = '\0';
                    textBoxHaslo.Text = "Hasło";
                }
            }
            /*if (Visible == false)
            {
                textBoxNewPassword.ForeColor = Color.Gray;
                textBoxNewPassword.Font = new Font(textBoxNewPassword.Font, FontStyle.Italic);
                textBoxNewPassword.Text = "Nowe hasło";
                textBoxConfirmNewPassword.ForeColor = Color.Gray;
                textBoxConfirmNewPassword.Font = new Font(textBoxConfirmNewPassword.Font, FontStyle.Italic);
                textBoxConfirmNewPassword.Text = "Potwierdź nowe hasło";
            }*/
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            iconButtonSave.Enabled = false;

            textBoxHaslo.PasswordChar = '\0';
            textBoxHaslo.ForeColor = Color.Gray;
            textBoxHaslo.Font = new Font(textBoxUser.Font, FontStyle.Italic);
            textBoxHaslo.Text = "Hasło";

            textBoxUser.Text = "";
            textBoxUser.ForeColor = Color.FromArgb(249, 118, 176);
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
            iconButtonSave.Enabled = false;

            textBoxHaslo.PasswordChar = '*';
            textBoxHaslo.Text = "";
            textBoxHaslo.ForeColor = Color.FromArgb(249, 118, 176);
            textBoxHaslo.Font = new Font(textBoxHaslo.Font, FontStyle.Bold);
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

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            con.SetFields(textBoxUser.Text, textBoxHaslo.Text, textBoxNameServer.Text, comboBoxInstance.Text, comboBoxBase.Text);
            //serializacja
            using (Stream output = File.Create("Setting.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, con);
            }
            iconButtonSave.Enabled = false;
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
            iconButtonSearch.Text = "SZUKAM...";
            iconButtonSearch.Enabled = false;
            if (textBoxNameServer.Text != "Nazwa serwera" && textBoxNameServer.Text != "")
            {
                try
                {
                    //instancja serwera sql
                    RegistryKey baseKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, textBoxNameServer.Text, RegistryView.Registry64);
                    RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");
                    comboBoxInstance.Items.Clear();
                    foreach (string s in key.GetValueNames())
                    {
                        comboBoxInstance.Items.Add(s);
                    }

                    key.Close();
                    baseKey.Close();
                    iconButtonSearch.Enabled = true;
                    iconButtonSearch.Text = "Szukaj";
                    iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
                    comboBoxInstance.ForeColor = Color.FromArgb(249, 118, 176);
                    comboBoxInstance.Font = new Font(comboBoxInstance.Font, FontStyle.Bold);
                    comboBoxInstance.SelectedIndex = 0;
                    bSearch = true;
                    
                }
                catch(Exception ex)
                {
                    iconButtonSearch.Enabled = true;
                    iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                iconButtonSearch.Enabled = true;
                iconButtonSearch.Text = "Szukaj";
                iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
                MessageBox.Show("Musisz podać nazwę serwera!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void comboBoxInstance_SelectedIndexChanged(object sender, EventArgs e)
        {
            iconButtonSave.Enabled = false;
            if (bSearch == true)
            {
                //nazwa bazy danynych
                try
                {
                    comboBoxBase.Items.Clear();
                    string connectionString = "Data Source=" + textBoxNameServer.Text + "\\" + comboBoxInstance.Text + "; Integrated Security = True; ";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    comboBoxBase.Items.Add(dr[0].ToString());
                                }
                            }
                        }
                    }
                    comboBoxBase.ForeColor = Color.FromArgb(249, 118, 176);
                    comboBoxBase.Font = new Font(comboBoxBase.Font, FontStyle.Bold);
                    comboBoxBase.SelectedIndex = 0;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool IsServerConnected()
        {
            
            string sConnectionString = "Data Source=" + textBoxNameServer.Text + "\\" + comboBoxInstance.Text + ";Initial Catalog=" + comboBoxBase.Text + ";User ID=" + textBoxUser.Text + ";Password=" + textBoxHaslo.Text + ";";
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

        private void iconButtonTest_Click(object sender, EventArgs e)
        {
            iconButtonTest.Text = "TESTUJĘ...";
            iconButtonTest.Enabled = false;
            
            iconButtonTest.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
            if (IsServerConnected())
            {
                iconButtonTest.Enabled = true;
                iconButtonTest.Text = "Testuj połączenie";
                iconButtonTest.IconChar = FontAwesome.Sharp.IconChar.Vial;
                iconButtonSave.Enabled = true;
                MessageBox.Show("Test połączenia zakończony SUKCESEM!!!", "INFORMACJA!", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
            else
            {
                iconButtonTest.Enabled = true;
                iconButtonTest.Text = "Testuj połączenie";
                iconButtonTest.IconChar = FontAwesome.Sharp.IconChar.Vial;
                iconButtonSave.Enabled = false;
                MessageBox.Show("Test połączenia zakończony NIEPOWODZENIEM!!!", "INFORMACJA!", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private void textBoxNameServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
                iconButtonSearch.Enabled = false;
                if (textBoxNameServer.Text != "Nazwa serwera" && textBoxNameServer.Text != "")
                {
                    try
                    {
                        //instancja serwera sql
                        RegistryKey baseKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, textBoxNameServer.Text, RegistryView.Registry64);
                        RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");
                        comboBoxInstance.Items.Clear();
                        foreach (string s in key.GetValueNames())
                        {
                            comboBoxInstance.Items.Add(s);
                        }

                        key.Close();
                        baseKey.Close();
                        iconButtonSearch.Enabled = true;
                        iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
                        comboBoxInstance.ForeColor = Color.FromArgb(249, 118, 176);
                        comboBoxInstance.Font = new Font(comboBoxInstance.Font, FontStyle.Bold);
                        comboBoxInstance.SelectedIndex = 0;
                        bSearch = true;

                    }
                    catch (Exception ex)
                    {
                        iconButtonSearch.Enabled = true;
                        iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
                        MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    iconButtonSearch.Enabled = true;
                    iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
                    MessageBox.Show("Musisz podać nazwę serwera!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            iconButtonSave.Enabled = false;
        }
    }
}
