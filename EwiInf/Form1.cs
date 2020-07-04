using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using QRCoder;
using System.Runtime.Serialization.Formatters.Binary;

namespace EwiInf
{
    public partial class Form1 : Form
    {
        ConnectionAndUser con = new ConnectionAndUser();
        SqlConnection connection; //= new SqlConnection(@"Data Source = DESKTOP-DOSSHB6\SQLEXPRESS; Initial Catalog = C:\USERS\1133183\SOURCE\REPOS\EWIINF\EWIINF\EWIDENCJA.MDF;User ID = Administrator; Password=789kaoz");//(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1133183\source\repos\EwiInf\EwiInf\Ewidencja.mdf;Integrated Security=True");
        //klasa odpowiadajaca za wyglad tabel
        LookDataGridView LookTable = new LookDataGridView();
        CheckBox[] checkBoxes = new CheckBox[28];
        ConectAndModifyData connectData = new ConectAndModifyData();


        //funkcja wrzuca wszystkie checkboxy z panelu opcji do tablicy z checkboxami
        private void TableCheckboxes()
        {
            int a = 27;
            foreach (Control c in panelOptionTable.Controls)
            {
                if (c is CheckBox)
                {
                    checkBoxes[a] = c as CheckBox;
                    a = a - 1;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            //tego użyj do budowy stringa
            //EwiInf.Properties.Settings.Default["EwidencjaConnectionString"] = "Data Source=DESKTOP-DOSSHB6\\SQLEXPRESS;Initial Catalog=C:\\USERS\\1133183\\SOURCE\\REPOS\\EWIINF\\EWIINF\\EWIDENCJA.MDF;User ID=Administrator;Password=789kaoz";
        }

        //sterowanie widocznością przycisków
        private void SteerVisibleButtons()
        {
            if (dataGridView1.RowCount > 0)
            {
                bRemoveReg.Visible = true;
                bEdit.Visible = true;
                bFind.Enabled = true;
                btDeviceCard.Visible = true;
                btNewView.Visible = true;
                btPrint.Visible = true;
                btFindAllInThisDoc.Visible = true;
            }
            else
            {
                bRemoveReg.Visible = false;
                bEdit.Visible = false;
                bFind.Enabled = false;
                btDeviceCard.Visible = false;
                btNewView.Visible = false;
                btPrint.Visible = false;
                btFindAllInThisDoc.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            connection = new SqlConnection(con.ConnectionString);
            connectData.ConnectionString(con.ConnectionString);

            EwiInf.Properties.Settings.Default["EwidencjaConnectionString"] = con.ConnectionString;
            //label1.Text = ewidencjaDataSet.Tables[2].TableName.ToString();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
            this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);
            //formatowanie tabeli
            LookTable.FormatDataGrid(dataGridView1);
            //uzupełnienie wszystkich chekboxow do tabeli
            TableCheckboxes();
            //dodanie checkboxów do klasy
            LookTable.AddCheckbox(checkBoxes);
            //enabled odpowiednie przyciski i odpowiednie disabled

            comboBoxColumn.Visible = false;
            textBoxSearch.Visible = false;
            bEnterSearch.Visible = false;
            //wpisanie wszystkich wpisów ile jest
            label2.Text = "Wszystkich wpisów:" + " " + dataGridView1.Rows.Count.ToString();

            SteerVisibleButtons();
            //wypełnienie szukajki z comboboxa hedaders z datagridview
            connectData.GetHeaderDGV(dataGridView1, comboBoxColumn);
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void RefreshTable()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Ewi";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
                this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);
                //formatowanie tabeli
                LookTable.FormatDataGrid(dataGridView1);
                label2.Text = "Wszystkich wpisów:" + " " + dataGridView1.Rows.Count.ToString();
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

        private void bAddReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2(this, con.ConnectionString);
            Form2.ShowDialog();
            
            //zdarzenie
           
        }

        private void btEwidence_Click(object sender, EventArgs e)
        {
            //otwarcie okna z ewidencja
            this.Hide();
            Form5 Form5 = new Form5(this, con.ConnectionString);
            Form5.ShowDialog();
        }

        private void btRoom_Click(object sender, EventArgs e)
        {
            //otwarcie okna z ewidencja sprzetu w danym pomieszczeniu
            this.Hide();
            Form3 Form3 = new Form3(this, con.ConnectionString);
            Form3.ShowDialog();
        }
        

        private void bSettings_Click(object sender, EventArgs e)
        {
            //pokazanie panelu z checboxami do zaznaczenia widocznych kolumn w tabeli
            panelOptionTable.Visible = true;
            //zablokowanie nie potrzebnych kontrolek w oknie
            LookTable.enableDisableControls(false, this);
        }

        private void btOkey_Click(object sender, EventArgs e)
        {
            //ukrycie panelu z opcjami
            panelOptionTable.Visible = false;
            //odblokowanie kontrolek w oknie
            LookTable.enableDisableControls(true, this);
            //uzycie funkcji by ukryc pokazac wybrane kolumny
            LookTable.HideShowColumn(checkBoxes);
            //enabled odpowiednie przyciski i odpowiednie disabled
            if (dataGridView1.RowCount > 0) bFind.Enabled = true;
            else bFind.Enabled = false;
            //wypełnienie szukajki z comboboxa hedaders z datagridview
            connectData.GetHeaderDGV(dataGridView1, comboBoxColumn);
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            comboBoxColumn.Visible = true;
            textBoxSearch.Visible = true;
            bEnterSearch.Visible = true;
            comboBoxColumn.SelectedIndex = 0;
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }

        private void bEnterSearch_Click(object sender, EventArgs e)
        {
            comboBoxColumn.Visible = false;
            textBoxSearch.Visible = false;
            bEnterSearch.Visible = false;
            //szukanie danych w bazie danych i ich wyświetlanie
            string sColumnToFind = "";
            if (comboBoxColumn.SelectedIndex > dataGridView1.ColumnCount) sColumnToFind = comboBoxColumn.SelectedItem.ToString();
            else if (comboBoxColumn.SelectedIndex == 0) sColumnToFind = "SZUKAJ W CAŁEJ TABELI";
            else sColumnToFind = dataGridView1.Columns[comboBoxColumn.SelectedIndex].DataPropertyName.ToString();
            connectData.FindInBase(ewidencjaDataSet, textBoxSearch, sColumnToFind);

            SteerVisibleButtons();
            bFind.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bEdit.Visible = true;
            bRemoveReg.Visible = true;
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                bEdit.Visible = true;
                bRemoveReg.Visible = true;
            }
            else
            {
                bEdit.Visible = false;
                bRemoveReg.Visible = false;
            }
            int iIdNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            this.Hide();
            Form2 Form2 = new Form2(true, iIdNumber, this, con.ConnectionString);
            Form2.ShowDialog();
            
        }


        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            //funkcja odpowiada za odznaczenie pozostałych checkboxow jak ten zaznaczony jest
            LookTable.UnchekCheckBoxes();
        }

        private void bRemoveReg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony rekord???", "ZAPYTANIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //usuniecie rekordu
                connectData.DeleteData(dataGridView1);
                //odswiezenie widoku tabeli
                RefreshTable();
            }
            //widoczne usun i edytuj zalezne czy jest co wybrac
            if (dataGridView1.Rows.Count > 0)
            {
                bEdit.Visible = true;
                bRemoveReg.Visible = true;
            }
            else
            {
                bEdit.Visible = false;
                bRemoveReg.Visible = false;
            }
            SteerVisibleButtons();
        }

        private void btNewView_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                this.Hide();
                Form2 Form2 = new Form2(true, this, con.ConnectionString);
                Form2.ShowDialog();
            }
            else MessageBox.Show("Brak rekordów w bazie danych do wyświetlenia!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch.Focus();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                comboBoxColumn.Visible = false;
                textBoxSearch.Visible = false;
                bEnterSearch.Visible = false;
                //szukanie danych w bazie danych i ich wyświetlanie
                string sColumnToFind = "";
                if (comboBoxColumn.SelectedIndex > dataGridView1.ColumnCount) sColumnToFind = comboBoxColumn.SelectedItem.ToString();
                else if (comboBoxColumn.SelectedIndex == 0) sColumnToFind = "SZUKAJ W CAŁEJ TABELI";
                else sColumnToFind = dataGridView1.Columns[comboBoxColumn.SelectedIndex].DataPropertyName.ToString();
                connectData.FindInBase(ewidencjaDataSet, textBoxSearch, sColumnToFind);

                SteerVisibleButtons();
                bFind.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDeviceCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Form4 = new Form4(this, true, con.ConnectionString);
            Form4.ShowDialog();
        }

        private void comboBoxColumn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = "Wykaz sprzętu";
            //ścieżka z nazwą pliku do tworzenia
            string path = Application.StartupPath + "/Wydruki sprzętu/" + fileName + ".pdf";
            //ścieżka do utworzenia katalogu na wydruki
            string path2 = Application.StartupPath + "/Wydruki sprzętu/";
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
            var smallFont= FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 4);
            //utworzenie dokumentu
            PdfWriter writer=null;
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
                Paragraph p = new Paragraph("Spis sprzętu Informatyki i Łączności:" + Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);

                //tabela z datagridview
                int iloscKolumn = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible == true) iloscKolumn++;
                }
                PdfPTable pdfTable = new PdfPTable(iloscKolumn);//dataGridView1.Columns.Count);
                                                                //rozmiar szerokosc kolumn
                float[] widths = new float[] { 50f, 100f, 105f, 150f, 80f, 80f, 100f, 100f, 100f, 100f, 85f,
            100f, 100f,100f, 100f,110f, 110f,150f, 100f, 100f,100f, 100f,100f, 150f, 165f, 110f, 100f, 150f };
                //zmienna do zapisu szerokosci kolumn wybranych kolumn
                float[] widths2 = new float[iloscKolumn];
                int iWidths2 = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible)
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
                foreach (DataGridViewColumn column in dataGridView1.Columns)
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
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

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            SteerVisibleButtons();
            if (Visible == true) connectData.RefreshBase(ewidencjaDataSet);
        }

        private void btQrCodePrint_Click(object sender, EventArgs e)
        {
            GenerateQRAndEwi();
        }
        
        //generuje naklejki z qr code i nr ewidencyjnym do obklejenia
        private void GenerateQRAndEwi()
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = "Naklejki";
            //ścieżka z nazwą pliku do tworzenia
            string path = Application.StartupPath + "/Naklejki/" + fileName + ".pdf";
            //ścieżka do utworzenia katalogu na wydruki
            string path2 = Application.StartupPath + "/Naklejki/";
            //ustawienie zabezpieczenia do zapisu i tworzenie katalogu
            DirectorySecurity securityRules = new DirectorySecurity();
            string dirPath = Path.GetDirectoryName(path2);
            securityRules.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.Modify, AccessControlType.Allow));
            if (dirPath == null) throw new InvalidOperationException("Nie udało się zapisać ze względu na lokalne ustawienia bezpieczeństwa!");
            if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath, securityRules);

            //rozmiar dokumentu i marginesów
            Document document = new Document(PageSize.A4, 30, 30, 50, 50);
            //ustawienia czcionek
            var bigFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 18);
            var bigBoldFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 18);
            var normalBoldFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 14);
            var normalsmallFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 10);
            var smallFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 4);
            //utworzenie dokumentu
            PdfWriter writer = null;
            bool bOpen = false;
            try
            {
                writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                //ewent do numeracji stron 
                //writer.PageEvent = new ITextEvent();
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

          

                //generujemy naklejki
                PdfContentByte cb = writer.DirectContent;

                int xPoz = 45;
                int yPoz = 800;
                int xPio = 45;
                int yPio = 800;
                string s = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        if (i%3==0)
                        {
                            yPoz = yPoz - 150;
                            yPio = yPio - 150;
                            xPoz = 45;
                            xPio = 45;
                        }
                    }
                    if(i<30)
                    {
                        //linia pozioma
                        cb.SetLineWidth(1);
                        cb.MoveTo(xPoz, yPoz);
                        cb.LineTo(xPoz+170, yPoz);
                        cb.Stroke();

                        cb.SetLineWidth(1);
                        cb.MoveTo(xPoz, yPoz-150);
                        cb.LineTo(xPoz + 170, yPoz-150);
                        cb.Stroke();
                        //linia pionowa
                        cb.SetLineWidth(1);
                        cb.MoveTo(xPio, yPio);
                        cb.LineTo(xPio, yPio-150);
                        cb.Stroke();

                        cb.SetLineWidth(1);
                        cb.MoveTo(xPio+170, yPio);
                        cb.LineTo(xPio + 170, yPio-150);
                        cb.Stroke();

                        //numer ewidencyjny
                        s = dataGridView1.Rows[i].Cells[1].Value.ToString().Trim();
                        ColumnText.ShowTextAligned(writer.DirectContent,
                        Element.ALIGN_CENTER, new Phrase(s, normalBoldFont), (xPoz) + (170/2), yPoz-20, 0);

                        //qrcode
                        GenerateQR(dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[3].Value.ToString(),
                                   dataGridView1.Rows[i].Cells[9].Value.ToString(), dataGridView1.Rows[i].Cells[24].Value.ToString(),
                                   dataGridView1.Rows[i].Cells[10].Value.ToString());
                        iTextSharp.text.Image qr = iTextSharp.text.Image.GetInstance(pbQRCode.BackgroundImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                        qr.ScaleAbsolute(100, 100);
                        qr.SetAbsolutePosition(xPoz+35, yPoz-140);
                        document.Add(qr);

                        //cienka pozioma linia
                        cb.SetLineWidth(0.25);
                        cb.MoveTo(xPoz, yPoz-30);
                        cb.LineTo(xPoz + 170, yPoz-30);
                        cb.Stroke();

                        xPoz = xPoz + 170;
                        xPio = xPio + 170;
                    }
                    
                }
 
                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
        }

        //generuje kod qr
        private void GenerateQR(string numerEwidencyjny, string nazwaSprzetu, string rodzajEwidenji, string InfLacz, string IndexFinansowy)
        {
            string dane = "";
            dane = numerEwidencyjny + ". " +
                nazwaSprzetu + ". " +
                rodzajEwidenji + ". " +
                InfLacz + ". " +
                IndexFinansowy + ". ";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(dane, QRCodeGenerator.ECCLevel.H);
            QRCode qrCode = new QRCode(qrCodeData);
            //Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pbQRCode.BackgroundImage = qrCode.GetGraphic(20);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btVat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Form7 = new Form7(this, con.ConnectionString, false);
            Form7.ShowDialog();
        }

        private void btFindAllInThisDoc_Click(object sender, EventArgs e)
        {
            textBoxSearchByDoc.Visible = true;
            btEnterByDoc.Visible = true;
            btFindAllInThisDoc.Visible = false;
            textBoxSearchByDoc.Focus();
            textBoxSearchByDoc.Text = "";
        }

        private void btEnterByDoc_Click(object sender, EventArgs e)
        {
            textBoxSearchByDoc.Visible = false;
            btEnterByDoc.Visible = false;
            btFindAllInThisDoc.Visible = true;
            connectData.FindInBaseByNumberDoc(ewidencjaDataSet, textBoxSearchByDoc.Text);

        }

        private void textBoxSearchByDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxSearchByDoc.Visible = false;
                btEnterByDoc.Visible = false;
                btFindAllInThisDoc.Visible = true;
                connectData.FindInBaseByNumberDoc(ewidencjaDataSet, textBoxSearchByDoc.Text);
            }
        }

        private void btHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 Form7 = new Form7(this, con.ConnectionString, true);
            Form7.ShowDialog();
        }
    }
}
