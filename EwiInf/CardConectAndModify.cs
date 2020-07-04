using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    class CardConectAndModify
    {
        //zmienne 
        SqlConnection connection;// = new SqlConnection(@"Data Source = DESKTOP-DOSSHB6\SQLEXPRESS; Initial Catalog = C:\USERS\1133183\SOURCE\REPOS\EWIINF\EWIINF\EWIDENCJA.MDF;User ID = Administrator; Password=789kaoz");//(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1133183\source\repos\EwiInf\EwiInf\Ewidencja.mdf;Integrated Security=True");
        public void ConnectionString(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
        }

        //zapis do bazy danych
        public void SaveData(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10,
                            TextBox textBox11, TextBox textBox12, TextBox textBox13, TextBox textBox14, TextBox textBox15,
                            TextBox textBox16, TextBox textBox17, TextBox textBox18, TextBox textBox19, TextBox textBox20, TextBox textBox21, TextBox textBox22)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Karta (Nr_karty, Nazwa_urzadzenia, Marka_urzadzenia, Model_urzadzenia, Numer_seryjny, Data_zakupu, Data_oddania_do_eksploatacji, Dodatkowe_akcesoria, Uzytkownik, Od_kiedy, Gdzie, Uzytkownik2, Od_kiedy2, Gdzie2, Uzytkownik3, Od_kiedy3, Gdzie3, Uzytkownik4, Od_kiedy4, Gdzie4, Data_zalozenia, Zalozyciel)" +
                    "VALUES(N'" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + textBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + textBox6.Text + "', N'" + textBox7.Text + "', N'" + textBox8.Text + "', N'" + textBox9.Text + "', N'" + textBox10.Text + "', N'" + textBox11.Text + "', N'" + textBox12.Text + "', N'" + textBox13.Text + "', N'" + textBox14.Text + "', N'" + textBox15.Text + "', N'" + textBox16.Text + "', N'" + textBox17.Text + "', N'" + textBox18.Text + "', N'" + textBox19.Text + "', N'" + textBox20.Text + "', N'" + textBox21.Text + "', N'" + textBox22.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Zapisano!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        //modyfikacja danych w bazie
        //zapis do bazy danych
        public void ModifyData(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, TextBox textBox10,
                            TextBox textBox11, TextBox textBox12, TextBox textBox13, TextBox textBox14, TextBox textBox15,
                            TextBox textBox16, TextBox textBox17, TextBox textBox18, TextBox textBox19, TextBox textBox20, TextBox textBox21, TextBox textBox22)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Karta SET Nazwa_urzadzenia = N'" + textBox2.Text +
                    "', Marka_urzadzenia = N'" + textBox3.Text +
                    "', Model_urzadzenia = N'" + textBox4.Text +
                    "', Numer_seryjny = N'" + textBox5.Text +
                    "', Data_zakupu = N'" + textBox6.Text +
                    "', Data_oddania_do_eksploatacji = N'" + textBox7.Text +
                    "', Dodatkowe_akcesoria = N'" + textBox8.Text +
                    "', Uzytkownik = N'" + textBox9.Text +
                    "', Od_kiedy = N'" + textBox10.Text +
                    "', Gdzie = N'" + textBox11.Text +
                    "', Uzytkownik2 = N'" + textBox12.Text +
                    "', Od_kiedy2 = N'" + textBox13.Text +
                    "', Gdzie2 = N'" + textBox14.Text +
                    "', Uzytkownik3 = N'" + textBox15.Text +
                    "', Od_kiedy3 = N'" + textBox16.Text +
                    "', Gdzie3 = N'" + textBox17.Text +
                    "', Uzytkownik4 = N'" + textBox18.Text +
                    "', Od_kiedy4 = N'" + textBox19.Text +
                    "', Gdzie4 = N'" + textBox20.Text +
                    "', Data_zalozenia = N'" + textBox21.Text +
                    "', Zalozyciel = N'" + textBox22.Text +
                   "'WHERE Nr_karty = N'" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Zapisano!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        //odswieżenie widoku bazy danych
        public void RefreshBase(DataSet dataSet, int iNumberTable)
        {
            string sNazwaTabeli = "";
            sNazwaTabeli = dataSet.Tables[iNumberTable].TableName.ToString();
            try
            {
                connection.Open();
                string query = "SELECT * FROM " + sNazwaTabeli;
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[0]);
                dataSet.Tables[0].Clear();
                SDA.Fill(dataSet.Tables[0]);
                connection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
