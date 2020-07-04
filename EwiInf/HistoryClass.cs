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
    class HistoryClass
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
                query = "SELECT * FROM History WHERE Nr_ewidencyjny LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Rodzaj_sprzetu LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Nazwa_producenta LIKE '%" + sWhatWeLooking + "%' OR " +

                                                                                                            "Nr_seryjny LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Wartosc_zakupu LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Nr_faktury LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Rodzaj_ewidencji LIKE '%" + sWhatWeLooking + "%' OR " +

                                                                                                            "Budynek LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Pietro LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Pomieszczenie LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Informatyka_Lacznosc LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Kto_modyfikowal LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Data_usuniecia LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Uwagi LIKE '%" + sWhatWeLooking + "%' OR " +
                                                                                                            "Index_finansowy LIKE '%" + sWhatWeLooking + "%'";
                if (sWhatWeLooking == "") query = "SELECT * FROM History";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables["History"]);
                dataSet.Tables["History"].Clear();
                SDA.Fill(dataSet.Tables["History"]);
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
