using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    class EwidenceConfig
    {
        //zmienne 
        SqlConnection connection;// = new SqlConnection(@"Data Source = DESKTOP-DOSSHB6\SQLEXPRESS; Initial Catalog = C:\USERS\1133183\SOURCE\REPOS\EWIINF\EWIINF\EWIDENCJA.MDF;User ID = Administrator; Password=789kaoz");//(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1133183\source\repos\EwiInf\EwiInf\Ewidencja.mdf;Integrated Security=True");
        public void ConnectionString(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
        }
        public List<string> listaCombo = new List<string>();
        IEnumerable<string> sortCombo;
        public List<string> listaCombo2 = new List<string>();
        IEnumerable<string> sortCombo2;
        int iStan = 0;
        int numPlus = 0;
        int numMinus = 0;
        string sStan = "";

        public int IStan { set { iStan = value; } }
        public int NumPlus { set { numPlus = value; } }
        public int NumMinus { set { numMinus = value; } }

        //zapis do bazy danych
        public void SaveData(string NazwaTabeli, int ID, string Nazwa, string JM, string Data, string Opis, string DokumentKsiegowy, string Przychod, string Rozchod, string Stan, string Uwagi, string Index_finansowy)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO " + NazwaTabeli + " (Id, Nazwa_przedmiotu, JM, Data, Opis, Dokument_ksiegowy, Przychod, Rozchod, Stan, Uwagi, Index_finansowy)" +
                    "VALUES (N'" + ID + "', N'" + Nazwa + "', N'" + JM + "', N'" + Data + "', N'" + Opis + "', N'" + DokumentKsiegowy + "', N'" + Przychod + "', N'" + Rozchod + "', N'" + Stan + "', N'" + Uwagi + "', N'" + Index_finansowy + "')";
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
        public void ModifyData(string NazwaTabeli, int ID, string Nazwa, string JM, string Data, string Opis, string DokumentKsiegowy, string Przychod, string Rozchod, string Stan, string Uwagi, string Index_finansowy)
        {
            try
            {
                connection.Open();
                string query = "UPDATE " + NazwaTabeli + " SET Nazwa_Przedmiotu = N'" + Nazwa +
                    "', JM = N'" + JM +
                    "', Data = N'" + Data +
                    "', Opis = N'" + Opis +
                    "', Dokument_ksiegowy = N'" + DokumentKsiegowy +
                    "', Przychod = N'" + Przychod +
                    "', Rozchod = N'" + Rozchod +
                    "', Stan = N'" + Stan +
                    "', Uwagi = N'" + Uwagi +
                    "', Index_finansowy = N'" + Index_finansowy +
                    "'WHERE Id = N'" + ID + "'";
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

        //usunięcie z bazy danych
        public void DeleteData(DataGridView dataGridView1, string NazwaTabeli)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM " + NazwaTabeli + " Where Id='" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
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
        public void RefreshBase(DataSet dataSet, string NazwaTabeli)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM " + NazwaTabeli + "";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[NazwaTabeli]);
                dataSet.Tables[NazwaTabeli].Clear();
                SDA.Fill(dataSet.Tables[NazwaTabeli]);
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

        //uzupełnienie comba rodzaj sprzetu danymi do wyboru z bazy danych
        public void CompleteCombo(DataSet dataSet, ComboBox comboBox, int iID)
        {
            comboBox.Items.Clear();
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                listaCombo.Add(dataSet.Tables[0].Rows[i][iID].ToString().ToUpper());
            }
            sortCombo = listaCombo.Distinct<string>() as IEnumerable<string>;
            foreach (var item in sortCombo)
            {
                comboBox.Items.Add(item);
            }
        }

        //uzupełnienie comba rodzaj sprzetu danymi do wyboru z bazy danych
        public void CompleteComboSearch(DataSet dataSet, ComboBox comboBox, string sNazwaTabeli, int iID)
        {
            //tutaj nowe dane combo i list
            comboBox.Items.Clear();
            comboBox.Items.Add("WSZYSTKO");
            listaCombo2.Clear();
            for (int i = 0; i < dataSet.Tables[sNazwaTabeli].Rows.Count; i++)
            {
                listaCombo2.Add(dataSet.Tables[sNazwaTabeli].Rows[i][iID].ToString().ToUpper());
            }
            sortCombo2 = null;
            sortCombo2 = listaCombo2.Distinct<string>() as IEnumerable<string>;
            foreach (var item in sortCombo2)
            {
                comboBox.Items.Add(item);
            }
        }

        //uzupełnienie rodzajów sprzetu w ewidencji
        int ileRodzaj = 0;
        public void TypeOfEquipment(DataSet dataSet, int iID, string NazwaTabeli)
        {
            for (int i = 0; i < dataSet.Tables[NazwaTabeli].Rows.Count; i++)
            {
                listaCombo.Add(dataSet.Tables[NazwaTabeli].Rows[i][iID].ToString().ToUpper());
            }
            sortCombo = listaCombo.Distinct<string>() as IEnumerable<string>;
            foreach (var item in sortCombo)
            {
                ileRodzaj++;
            }
        }

        //wyszukiwanie w bazie
        public void FindInBase(DataSet dataSet, string NazwaTabeli)
        {
            int ile = ileRodzaj;
            int i = 0;
            SqlDataAdapter[] SDA = new SqlDataAdapter[ile];
            string query = "";
            dataSet.Tables[NazwaTabeli].Clear();
            try
            {
                connection.Open();
                foreach (var item in sortCombo)
                {  
                    query = "SELECT * FROM "+NazwaTabeli+" WHERE Nazwa_przedmiotu LIKE '" + item + "'";
                    SDA[i]= new SqlDataAdapter(query, connection);
                    SDA[i].Update(dataSet.Tables[NazwaTabeli]);
                    //dataSet.Tables[NazwaTabeli].Clear();
                    SDA[i].Fill(dataSet.Tables[NazwaTabeli]);
                    i++;
                }
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

        //kolorowanie i oddzielanie liniami szarymi w datagridzie
        public void GreyRows(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                string Rodzaj = dataGridView.Rows[0].Cells[0].Value.ToString();
                //dataGridView.Rows.Insert(0, 1);
                dataGridView.Rows[0].DefaultCellStyle.BackColor = Color.Gray;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView.Rows[i].Cells[0].Value.ToString() != Rodzaj)
                    {
                        Rodzaj = dataGridView.Rows[i].Cells[0].Value.ToString();
                        //dataGridView.Rows.Insert(i, 1);
                        dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                    }
                }
            }
        }

        //liczenie sum po dodaniu sprzetu
        public void RefreshScore(DataGridView dataGridView, ComboBox comboBox, TextBox stanTextBox, DataGridView dataGridViewStan)
        {
            //int iStanPoczatkowy = 0;
            int ileJest = 0;
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (comboBox.Text == dataGridView.Rows[i].Cells[0].Value.ToString()) ileJest++;
                }
            }
            /*if (dataGridViewStan.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewStan.Rows.Count; i++)
                {
                    if (comboBox.Text == dataGridViewStan.Rows[i].Cells[1].Value.ToString())
                    {
                        iStanPoczatkowy = Convert.ToInt32(dataGridViewStan.Rows[i].Cells[4].Value);
                        break;
                    }
                }
            }*/
            //iStanPoczatkowy = iStanPoczatkowy + 0;
            if (ileJest == 0) stanTextBox.Text = "0";//iStanPoczatkowy.ToString();

            if (dataGridView.Rows.Count > 0)
            {
                for (int i = dataGridView.SelectedRows[0].Index; i < dataGridView.Rows.Count; i++)
                {
                    if (comboBox.Text == dataGridView.Rows[i].Cells[0].Value.ToString())
                    {
                        //iStanPoczatkowy=iStanPoczatkowy + Convert.ToInt32(dataGridView.Rows[i].Cells[8].Value);
                        stanTextBox.Text = dataGridView.Rows[i].Cells[8].Value.ToString();//iStanPoczatkowy.ToString();
                    }
                }
            }
        }
        //refresz plus i minus button
        public void RefreshPlusMinus(NumericUpDown numericUpDownPlus, NumericUpDown numericUpDownMinus, TextBox textBoxStan)
        {
            /*if (numericUpDownMinus.Value == numMinus && numericUpDownPlus.Value != numPlus)
            {
                textBoxStan.Text = iStan.ToString();
                textBoxStan.Text = (Convert.ToInt32(textBoxStan.Text) + numericUpDownPlus.Value).ToString();
            }
            if (numericUpDownPlus.Value == numPlus && numericUpDownMinus.Value != numMinus)
            {
                textBoxStan.Text = iStan.ToString();
                textBoxStan.Text = (Convert.ToInt32(textBoxStan.Text) - numericUpDownMinus.Value).ToString();
            }*/
            //if (numericUpDownMinus.Value != numMinus && numericUpDownPlus.Value != numPlus)
            //{
                textBoxStan.Text = iStan.ToString();
                textBoxStan.Text = (Convert.ToInt32(textBoxStan.Text) + numericUpDownPlus.Value-numericUpDownMinus.Value-numPlus+numMinus).ToString();
            //}
            
        }

        //uzupełnienie po edycji stanu
        public void RefreshScorePastEdit(DataGridView dataGridView, ComboBox comboBox, TextBox stanTextBox)
        {
            //int iStanPoczatkowy = 0;
            int iIleJesWierszy = 0;
            /*if (dataGridViewStan.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewStan.Rows.Count; i++)
                {
                    if (comboBox.Text == dataGridViewStan.Rows[i].Cells[1].Value.ToString())
                    {
                        iStanPoczatkowy = Convert.ToInt32(dataGridViewStan.Rows[i].Cells[4].Value);
                        break;
                    }
                }
            }*/
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = dataGridView.SelectedRows[0].Index+1; i < dataGridView.Rows.Count; i++)
                {
                    if (comboBox.Text == dataGridView.Rows[i].Cells[0].Value.ToString())
                    {
                        //if(iIleJesWierszy==0) stanTextBox.Text = (Convert.ToInt32(stanTextBox.Text) + Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value) - Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value)).ToString()+iStanPoczatkowy.ToString();
                        stanTextBox.Text = (Convert.ToInt32(stanTextBox.Text)+ Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value)- Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value)).ToString();
                        sStan = stanTextBox.Text;
                        //zapis zmodyfikowanych danych
                        ModifyDataScore("Ewidencja_ST", Convert.ToInt32(dataGridView.Rows[i].Cells[10].Value), sStan);
                        //MessageBox.Show(stanTextBox.Text+"=" + stanTextBox.Text + "+"+dataGridView.Rows[i].Cells[6].Value.ToString()+ "-"+ dataGridView.Rows[i].Cells[7].Value.ToString(), "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        iIleJesWierszy++;
                    }
                }
            }
        }

        //modyfikacja rekordu i zapis modyfikacji
        public void ModifyDataScore(string NazwaTabeli, int ID, string Stan)
        {
            try
            {
                connection.Open();
                string query = "UPDATE " + NazwaTabeli + " SET Stan = N'" + Stan +
                    "'WHERE Id = N'" + ID + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Dokonano zmian tutaj!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //wyszukiwanie w bazie przedmiotu po dokumencie księgowym
        public void FindEquipmentByDoc(DataSet dataSet, string NazwaTabeli, string NumerDokumentu, string RodzajEwidencji, string IndexFinansowy)
        {
            SqlDataAdapter SDA = new SqlDataAdapter();
            string query = "";
            dataSet.Tables[NazwaTabeli].Clear();
            try
            {

                query = "SELECT * FROM " + NazwaTabeli + " WHERE Nr_faktury LIKE N'" + NumerDokumentu + "' AND " + "Rodzaj_ewidencji LIKE N'" + RodzajEwidencji + "' AND " + "Index_finansowy LIKE N'" + IndexFinansowy + "'";
                SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[NazwaTabeli]);
                //dataSet.Tables[NazwaTabeli].Clear();
                SDA.Fill(dataSet.Tables[NazwaTabeli]);

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

        //ustawienie by wyświetlać tylko dany typ danych
        public void FindByEquipment(DataSet dataSet, string NazwaTabeli, string sRodzajPrzedmiotu)
        {
            if (sRodzajPrzedmiotu == null) sRodzajPrzedmiotu = "WSZYSTKO";
            SqlDataAdapter SDA = new SqlDataAdapter();
            string query = "";
            dataSet.Tables[NazwaTabeli].Clear();
            try
            {
                query = "SELECT * FROM " + NazwaTabeli + " WHERE Nazwa_przedmiotu LIKE '" + sRodzajPrzedmiotu + "'"; 
                SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[NazwaTabeli]);
                //dataSet.Tables[NazwaTabeli].Clear();
                SDA.Fill(dataSet.Tables[NazwaTabeli]);

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

        public void GenerateReportByNumberDoc(string NumerDokumentu, string KtoraEwidencja, DataGridView dataGridView, bool bHistory)
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = NumerDokumentu.Replace('\\','-');
            //ścieżka z nazwą pliku do tworzenia
            string path = Application.StartupPath + "\\"+KtoraEwidencja+"\\" + fileName + ".pdf";
            //ścieżka do utworzenia katalogu na wydruki
            string path2 = Application.StartupPath + "\\"+KtoraEwidencja;
            //ustawienie zabezpieczenia do zapisu i tworzenie katalogu
            DirectorySecurity securityRules = new DirectorySecurity();
            string dirPath = Path.GetDirectoryName(path2);
            securityRules.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.Modify, AccessControlType.Allow));
            if (dirPath == null) throw new InvalidOperationException("Nie udało się zapisać ze względu na lokalne ustawienia bezpieczeństwa!");
            if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath, securityRules);

            //rozmiar dokumentu i marginesów
            Document document = new Document(PageSize.A4.Rotate(), 25, 25, 50, 50);
            //ustawienia czcionek
            var bigFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 18);
            var normalFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 10);
            var smallFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 4);
            //utworzenie dokumentu
            PdfWriter writer = null;
            bool bOpen = false;
            try
            {
                writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                //ewent do numeracji stron 
                writer.PageEvent = new ITextEvent();
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bOpen = true;
            }


            if (bOpen == false)
            {
                document.Open();

                //treść wydruku

                //tutuł
                Paragraph p;
                if (bHistory==true) p = new Paragraph("Sprzęt usunięty wchodzący w skład " + KtoraEwidencja + " zaksięgowany na podstawie dokumentu numer: ", bigFont);
                else p = new Paragraph("Sprzęt wchodzący w skład "+KtoraEwidencja+ " zaksięgowany na podstawie dokumentu numer: ", bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(NumerDokumentu, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);

                //tabela z datagridview
                int iloscKolumn = 0;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Columns[i].Visible == true) iloscKolumn++;
                }
                PdfPTable pdfTable = new PdfPTable(iloscKolumn);//dataGridView1.Columns.Count);
                                                                //rozmiar szerokosc kolumn
                float[] widths = new float[] { 50f, 100f, 105f, 150f, 80f, 80f, 100f, 100f, 100f, 100f, 85f,
            100f, 100f,100f, 100f,110f, 110f,150f, 100f, 100f,100f, 100f,100f, 150f, 165f, 110f, 100f, 150f };
                //zmienna do zapisu szerokosci kolumn wybranych kolumn
                float[] widths2 = new float[iloscKolumn];
                int iWidths2 = 0;
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    if (dataGridView.Columns[i].Visible)
                    {
                        widths2[iWidths2] = widths[i];
                        iWidths2++;
                    }
                }

                pdfTable.SetWidths(widths2);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;

                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                //tworzenie header column
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    if (column.Visible == true)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, smallFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell);
                    }
                }
                //wypełnianie komorek danymi
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.Visible == true)
                        {
                            PdfPCell cell2 = new PdfPCell(new Phrase(cell.Value.ToString(), smallFont));
                            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable.AddCell(cell2);
                        }
                    }
                }
                document.Add(pdfTable);

                //dolne wpisy
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Wykaz sprzętu wygenerowany z EwiInf dla Aresztu Śledczego w Łodzi " + DateTime.Now.ToString(), normalFont), 250, 60, 0);
                //koniec wydruku

                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
        }

        //ustawianie stanów otwarcia
        public bool SetStateOpening(string sNazwa, DataGridView dataGridView)
        {
            int iIleRazyJest = 0;
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (sNazwa == dataGridView.Rows[i].Cells[0].Value.ToString()) iIleRazyJest++;
                }
            }
            else
            {
                iIleRazyJest = 0;
            }
            if (iIleRazyJest == 0) return true;
            else return false;
        }

        //zapis stanu otwarcia
        public void SaveOpenStateST(string NazwaTabeli, int ID, string Rodzaj, string JM, string Rok, string Stan)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO " + NazwaTabeli + " (Id, Rodzaj, JM, Rok, Stan)" +
                    "VALUES (N'" + ID + "', N'" + Rodzaj + "', N'" + JM + "', N'" + Rok + "', N'" + Stan + "')";
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
    }
}
