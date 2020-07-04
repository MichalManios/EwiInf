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
    class FakturaClass
    {
        SqlConnection connection;
        public void ConnectionString(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
        }

        //wyszukiwanie w bazie
        public void FindInBase(DataSet dataSet, string sWhatWeLooking)
        {
            string query = "";
            try
            {
                connection.Open();
                query = "SELECT * FROM Faktury WHERE Miesiac LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Paragraf LIKE '%" + sWhatWeLooking + "%' OR " +

                                                                                                            "Pozycja_paragraf LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Nr_faktury LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Data_faktury LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Dostawca LIKE '%" + sWhatWeLooking + "%' OR " +

                                                                                                            "Specyfikacja LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Ilosc LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Jednostka_miary LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Indeks_finansowy LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Rodzaj_ewidencji LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Wartosc LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Termin_platnosci LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Sposob_zaplaty LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Przekazano_do_DF LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Nazwisko_Imie LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Opis_faktury LIKE '%" + sWhatWeLooking + "%'";
                if (sWhatWeLooking == "") query = "SELECT * FROM Faktury";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables["Faktury"]);
                dataSet.Tables["Faktury"].Clear();
                SDA.Fill(dataSet.Tables["Faktury"]);
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

        //odswieżenie widoku bazy danych
        public void RefreshBase(DataSet dataSet)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Faktury";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables["Faktury"]);
                dataSet.Tables["Faktury"].Clear();
                SDA.Fill(dataSet.Tables["Faktury"]);
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


        
        //zapis do bazy danych
        public void SaveData(params string[] args)//18 bez 0 które jest automatycznie nadawane
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Faktury (Miesiac, Paragraf, Pozycja_paragraf, Nr_faktury, Data_faktury, Dostawca, Specyfikacja, Ilosc, Jednostka_miary, Indeks_finansowy, Rodzaj_ewidencji, Wartosc, Termin_platnosci, Sposob_zaplaty, Przekazano_do_DF, Nazwisko_Imie, Opis_faktury)" +
                    "VALUES (N'" + args[1] + "', N'" + Convert.ToInt32(args[2]) + "', N'" + Convert.ToInt32(args[3]) + "', N'" + args[4] + "', N'" + args[5] + "', N'" + args[6] + "', N'" + args[7] + "', N'" + Convert.ToInt32(args[8]) + "', N'" + args[9] + "', N'" + Convert.ToInt32(args[10]) + "', N'" + args[11] + "', N'" + args[12] + "', N'" + args[13] + "', N'" + args[14] + "', N'" + args[15] + "', N'" + args[16] + "', N'" + args[17] + "')";
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
        //modyfikacja rekordu i zapis modyfikacji
        public void ModifyData(TextBox textBox1, TextBox textBox2, ComboBox comboBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, ComboBox comboBox10,
                            TextBox textBox11, TextBox textBox12, TextBox textBox13, TextBox textBox14, TextBox textBox15,
                            TextBox textBox16, TextBox textBox17, TextBox textBox18, TextBox textBox19, TextBox textBox20,
                            ComboBox comboBox23, ComboBox comboBox24, ComboBox comboBox25,
                            ComboBox comboBox26, TextBox textBox21, TextBox textBox22, TextBox textBox27, TextBox textBox28)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Ewi SET Nr_ewidencyjny = N'" + textBox2.Text +
                    "', Rodzaj_sprzętu = N'" + comboBox3.Text +
                    "', Nazwa_Producent = N'" + textBox4.Text +
                    "', Rok_produkcji = N'" + textBox5.Text +
                    "', Termin_gwarancji = N'" + textBox6.Text +
                    "', Nr_seryjny = N'" + textBox7.Text +
                    "', Wartosc_zakupu = N'" + textBox8.Text +
                    "', Nr_faktury = N'" + textBox9.Text +
                    "', Rodzaj_ewidencji = N'" + comboBox10.Text +
                    "', Mac_adres = N'" + textBox11.Text +
                    "', IP_adres1 = N'" + textBox12.Text +
                    "', IP_adres2 = N'" + textBox13.Text +
                    "', IP_adres3 = N'" + textBox14.Text +
                    "', Karta_grafiki1 = N'" + textBox15.Text +
                    "', Karta_grafiki2 = N'" + textBox16.Text +
                    "', Procesor = N'" + textBox17.Text +
                    "', Ram = N'" + textBox18.Text +
                    "', Dysk1 = N'" + textBox19.Text +
                    "', Dysk2 = N'" + textBox20.Text +
                    "', Budynek = N'" + comboBox23.Text +
                    "', Pietro = N'" + comboBox24.Text +
                    "', Pomieszczenie = N'" + comboBox25.Text +
                    "', Informatyka_Lacznosc = N'" + comboBox26.Text +
                   "', System_operacyjny = N'" + textBox21.Text +
                    "', Numer_karty = N'" + textBox22.Text +
                    "', Uwagi = N'" + textBox27.Text +
                    "', Index_finansowy = N'" + textBox28.Text +
                    "'WHERE Id = N'" + textBox1.Text + "'";
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