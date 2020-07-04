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
    class CardConservation
    {
        //zmienne 
        SqlConnection connection;// = new SqlConnection(@"Data Source = DESKTOP-DOSSHB6\SQLEXPRESS; Initial Catalog = C:\USERS\1133183\SOURCE\REPOS\EWIINF\EWIINF\EWIDENCJA.MDF;User ID = Administrator; Password=789kaoz");//(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1133183\source\repos\EwiInf\EwiInf\Ewidencja.mdf;Integrated Security=True");
        public void ConnectionString(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
        }
        //ile rekordów w bazie karta naprawy
        int iHowMuchRecordsInRepair = 0;
        //ile rekordów w bazie karta konserwacji
        int iHowMuchRecordsInConservation = 0;

        public int IHowMuchRecordsInRepair { get { return iHowMuchRecordsInRepair; } set { iHowMuchRecordsInRepair = value; } }
        public int IHowMuchRecordsInConservation { get { return iHowMuchRecordsInConservation; } set { iHowMuchRecordsInConservation = value; } }

        //zapis do bazy danych
        public void SaveData(TextBox textBox1, TextBox Lp, TextBox textBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8, string nazwaTabeli)
        {
            try
            {
                connection.Open();
                string query="";
                if(nazwaTabeli=="Karta_konserwacja") query = "INSERT INTO "+ nazwaTabeli + " (Nr_karty, Lp, Data, Opis_wykonywanej_czynnosci, Czas_konserwacji, Wykonawca, Podpis_uzytkownika_urzadzenia, Uwagi_dotyczace_pracy_urzadzenia)" +
                    "VALUES(N'" + textBox1.Text + "', N'" + Lp.Text + "', N'" + textBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + textBox6.Text + "', N'" + textBox7.Text + "', N'" + textBox8.Text + "')";
                if(nazwaTabeli == "Karta_naprawy") query = "INSERT INTO " + nazwaTabeli + " (Nr_karty, Lp, Data, Rodzaj_naprawy, Data_oddania_do_naprawy, Data_odbioru_z_naprawy, Koszt_naprawy, Podpis_nadzorujacego_naprawe)" +
                     "VALUES(N'" + textBox1.Text + "', N'" + Lp.Text + "', N'" + textBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + textBox6.Text + "', N'" + textBox7.Text + "', N'" + textBox8.Text + "')";

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
                if (nazwaTabeli == "Karta_naprawy") iHowMuchRecordsInRepair++;
                if (nazwaTabeli == "Karta_konserwacja") iHowMuchRecordsInConservation++;
                connection.Close();
            }
        }

        //odswieżenie widoku bazy danych
        public void RefreshBase(DataSet dataSet, string sNazwaTabeli)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM "+sNazwaTabeli;
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[sNazwaTabeli]);
                dataSet.Tables[sNazwaTabeli].Clear();
                SDA.Fill(dataSet.Tables[sNazwaTabeli]);
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

        //wyszukiwanie w bazie
        public void FindInBase(DataSet dataSet, TextBox textBoxNumerKarty, string nazwaTabeli)
        {
            string query = "";
            try
            {
                connection.Open();
                
                query = "SELECT * FROM "+ nazwaTabeli+" WHERE Nr_karty LIKE '" + textBoxNumerKarty.Text + "'";
                
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[nazwaTabeli]);
                dataSet.Tables[nazwaTabeli].Clear();
                SDA.Fill(dataSet.Tables[nazwaTabeli]);
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

        //modyfikacja rekordu i zapis modyfikacji
        public void ModifyDataRepair(TextBox textBox1,TextBox Lp, TextBox textBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Karta_naprawy SET Nr_karty = N'" + textBox1.Text +
                    
                    "', Data = N'" + textBox3.Text +
                    "', Rodzaj_naprawy = N'" + textBox4.Text +
                    "', Data_oddania_do_naprawy = N'" + textBox5.Text +
                    "', Data_odbioru_z_naprawy = N'" + textBox6.Text +
                    "', Koszt_naprawy = N'" + textBox7.Text +
                    "', Podpis_nadzorujacego_naprawe = N'" + textBox8.Text +
                    "'WHERE Lp = N'" + Lp.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Dokonano zmian!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void ModifyDataConservation(TextBox textBox1, TextBox Lp, TextBox textBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Karta_Konserwacja SET Nr_karty = N'" + textBox1.Text +
                    
                    "', Data = N'" + textBox3.Text +
                    "', Opis_wykonywanej_czynnosci = N'" + textBox4.Text +
                    "', Czas_konserwacji = N'" + textBox5.Text +
                    "', Wykonawca = N'" + textBox6.Text +
                    "', Podpis_uzytkownika_urzadzenia = N'" + textBox7.Text +
                    "', Uwagi_dotyczace_pracy_urzadzenia = N'" + textBox8.Text +
                    "'WHERE Lp = N'" + Lp.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Dokonano zmian!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //modyfikacja rekordu i zapis modyfikacji karty
        public void ModifyDataCard(string Uzytkownik, string Gdzie, string OdKiedy,
            string Uzytkownik2, string Gdzie2, string OdKiedy2,
            string Uzytkownik3, string Gdzie3, string OdKiedy3,
            string Uzytkownik4, string Gdzie4, string OdKiedy4,
            string NrKarty)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Karta SET Uzytkownik = N'" + Uzytkownik +
                    "', Od_kiedy = N'" + OdKiedy +
                    "', Gdzie = N'" + Gdzie +
                    "', Uzytkownik2 = N'" + Uzytkownik2 +
                    "', Od_kiedy2 = N'" + OdKiedy2 +
                    "', Gdzie2 = N'" + Gdzie2 +
                    "', Uzytkownik3 = N'" + Uzytkownik3 +
                    "', Od_kiedy3 = N'" + OdKiedy3 +
                    "', Gdzie3 = N'" + Gdzie3 +
                    "', Uzytkownik4 = N'" + Uzytkownik4 +
                    "', Od_kiedy4 = N'" + OdKiedy4 +
                    "', Gdzie4 = N'" + Gdzie4 +
                    "'WHERE Nr_karty = N'" + NrKarty + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Dokonano zmian!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
