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
                    "VALUES (N'" + args[2] + "', N'" + Convert.ToInt32(args[3]) + "', N'" + Convert.ToInt32(args[4]) + "', N'" + args[5] + "', N'" + args[6] + "', N'" + args[7] + "', N'" + args[8] + "', N'" + Convert.ToInt32(args[9]) + "', N'" + args[10] + "', N'" + Convert.ToInt32(args[11]) + "', N'" + args[12] + "', N'" + args[13] + "', N'" + args[14] + "', N'" + args[0] + "', N'" + args[15] + "', N'" + args[16] + "', N'" + args[17] + "')";
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
        public void ModifyData(params string[] args)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Faktury SET Miesiac = N'" + args[2] +
                    "', Paragraf = N'" + args[3] +
                    "', Pozycja_paragraf = N'" + args[4] +
                    "', Nr_faktury = N'" + args[5] +
                    "', Data_faktury = N'" + args[6] +
                    "', Dostawca = N'" + args[7] +
                    "', Specyfikacja = N'" + args[8] +
                    "', Ilosc = N'" + args[9] +
                    "', Jednostka_miary = N'" + args[10] +
                    "', Indeks_finansowy = N'" + args[11] +
                    "', Rodzaj_ewidencji = N'" + args[12] +
                    "', Wartosc = N'" + args[13] +
                    "', Termin_platnosci = N'" + args[14] +
                    "', Sposob_zaplaty = N'" + args[0] +
                    "', Przekazano_do_DF = N'" + args[15] +
                    "', Nazwisko_Imie = N'" + args[16] +
                    "', Opis_faktury = N'" + args[17] +
                    
                    "'WHERE Lp = N'" + args[1] + "'";
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