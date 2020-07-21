using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Security.AccessControl;
using LiczbyNaSlowaNET;

namespace EwiInf
{
    public partial class Faktura : UserControl
    {
        string stringConnection;
        public string setStringConnection { set { stringConnection = value; } }
        LookDataGridView LookTable = new LookDataGridView();
        FakturaClass faktura = new FakturaClass();
        //zmienna nowa pozycja czy modyfikacja
        bool NewOrEdit = false;
        //index wybranego wiersza
        int iRowsIndex = 0;

        public Faktura()
        {
            InitializeComponent();
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Faktura_Load(object sender, EventArgs e)
        {
            this.fakturyTableAdapter.Fill(this.ewidencjaDataSet.Faktury);
            LookTable.FormatDataGrid(dataGridView1);
            faktura.ConnectionString(stringConnection);

            data_fakturyTextBox.Text= "DD.MM.RRRR";
            termin_platnosciTextBox.Text = "DD.MM.RRRR";
            przekazano_do_DFTextBox.Text= "DD.MM.RRRR";

            //zaznaczenie ostatniego wiersza
            if (dataGridView1.Rows.Count > 0)
            {
                bEdit.Visible = true;
                dataGridView1.ClearSelection();

                int nRowIndex = dataGridView1.Rows.Count - 1;
                int nColumnIndex = 3;

                dataGridView1.Rows[nRowIndex].Selected = true;
                dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void GenerateReport()
        {
                //string z nazwą pomieszczenia
                string fileName = "";
                fileName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //ścieżka z nazwą pliku do tworzenia
                string path = Application.StartupPath + "/Faktury/" + fileName + ".pdf";
                //ścieżka do utworzenia katalogu na wydruki
                string path2 = Application.StartupPath + "/Faktury/";
                //ustawienie zabezpieczenia do zapisu i tworzenie katalogu
                DirectorySecurity securityRules = new DirectorySecurity();
                string dirPath = Path.GetDirectoryName(path2);
                securityRules.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.Modify, AccessControlType.Allow));
                if (dirPath == null) throw new InvalidOperationException("Nie udało się zapisać ze względu na lokalne ustawienia bezpieczeństwa!");
                if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath, securityRules);

                //rozmiar dokumentu i marginesów
                Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                //ustawienia czcionek
                var bigFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 18);
                var normalFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 12);
                var normalBoldFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 12);
                var smallFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
                var smallBoldFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
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
                string sLPandFacturNR = "";
                if(dataGridView1.Rows.Count>0) sLPandFacturNR = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " - " + dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //tutuł
                Paragraph p = new Paragraph("REJESTR OPERACJI - INFORMATYKA        /          " + sLPandFacturNR+ Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);

                //linie rysowanie tabeli na uwagi zmieniajacej położenie jeśli tabela urośnie
                PdfContentByte cb = writer.DirectContent;
                cb.SetLineWidth(0.25);
                cb.MoveTo(50, document.PageSize.GetBottom(770));
                cb.LineTo(550, document.PageSize.GetBottom(770));
                cb.Stroke();
                //data
                p = new Paragraph(DateTime.Now.ToShortDateString() + Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);

                p = new Paragraph(Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);

                p = new Paragraph("Wybrano:          " + dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);

                p = new Paragraph("(podpis)" + Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_RIGHT;
                document.Add(p);

                cb.SetLineWidth(3);
                cb.MoveTo(50, 625);
                cb.LineTo(550, 625);
                cb.Stroke();

                p = new Paragraph("Dnia:                             ZATWIERDZONO DO WYPŁATY ZE ŚRODKÓW BUDŻETOWYCH" + Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("WN", smallBoldFont), 95, 595, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Lp", smallBoldFont), 165, 595, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Produkt", smallBoldFont), 240, 595, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Paragraf", smallBoldFont), 340, 595, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Kwota", smallBoldFont), 400, 595, 0);

                int iSelectedIndex = 0;
                decimal dSuma = 0.00M;
                CultureInfo culture = new CultureInfo("en-US");
                if (dataGridView1.Rows.Count > 0)
                {
                    iSelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    int iNewX = 17;
                    int iLP = 1;
                    
                    //uzupełnianie faktury
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[iSelectedIndex].Cells[4].Value.ToString() == dataGridView1.Rows[i].Cells[4].Value.ToString()
                            && dataGridView1.Rows[iSelectedIndex].Cells[1].Value.ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString()
                            && dataGridView1.Rows[iSelectedIndex].Cells[5].Value.ToString() == dataGridView1.Rows[i].Cells[5].Value.ToString())
                        {
                            p = new Paragraph(Environment.NewLine, normalBoldFont);
                            p.Alignment = Element.ALIGN_RIGHT;
                            document.Add(p);

                            ColumnText.ShowTextAligned(writer.DirectContent,
                            Element.ALIGN_LEFT, new Phrase(iLP.ToString()+")", smallFont), 155, 595-iNewX, 0);

                            ColumnText.ShowTextAligned(writer.DirectContent,
                            Element.ALIGN_LEFT, new Phrase(dataGridView1.Rows[i].Cells[7].Value.ToString(), smallFont), 185, 595-iNewX, 0);

                            ColumnText.ShowTextAligned(writer.DirectContent,
                            Element.ALIGN_LEFT, new Phrase(dataGridView1.Rows[i].Cells[2].Value.ToString(), smallFont), 305, 595-iNewX, 0);

                            ColumnText.ShowTextAligned(writer.DirectContent,
                            Element.ALIGN_LEFT, new Phrase(dataGridView1.Rows[i].Cells[3].Value.ToString(), smallFont), 355, 595 - iNewX, 0);

                            ColumnText.ShowTextAligned(writer.DirectContent,
                            Element.ALIGN_LEFT, new Phrase(dataGridView1.Rows[i].Cells[12].Value.ToString()+" zł", smallFont), 380, 595-iNewX, 0);

                            dSuma = dSuma + Convert.ToDecimal(dataGridView1.Rows[i].Cells[12].Value, culture);

                            //jeśli to sprzęt
                            if(dataGridView1.Rows[i].Cells[10].Value.ToString()!="0" &&
                                !string.IsNullOrEmpty(dataGridView1.Rows[i].Cells[11].Value.ToString()))
                            {
                                if (iLP == 1)
                                {
                                    ColumnText.ShowTextAligned(writer.DirectContent,
                                    Element.ALIGN_LEFT, new Phrase("SPRZĘT WCIĄGNIĘTY NA EWIDENCJĘ INFORMATYCZNO-ŁĄCZNOŚCIOWĄ:", smallBoldFont), 50, 250 - iNewX + 17, 0);
                                }
                                ColumnText.ShowTextAligned(writer.DirectContent,
                                Element.ALIGN_LEFT, new Phrase(dataGridView1.Rows[i].Cells[7].Value.ToString() + " - " +
                                dataGridView1.Rows[i].Cells[8].Value.ToString() + " - " +
                                dataGridView1.Rows[i].Cells[9].Value.ToString().Trim() + " - " +
                                dataGridView1.Rows[i].Cells[10].Value.ToString() + " - " +
                                dataGridView1.Rows[i].Cells[11].Value.ToString() + " - " +
                                dataGridView1.Rows[i].Cells[12].Value.ToString() +" zł", smallFont), 50, 250 - iNewX, 0);

                            }

                            iLP++;
                            iNewX = iNewX + 17;
                        }
                    }
                }

                //linie poziome
                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 608);
                cb.LineTo(550, 608);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 591);
                cb.LineTo(550, 591);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 574);
                cb.LineTo(550, 574);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 557);
                cb.LineTo(550, 557);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 540);
                cb.LineTo(550, 540);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 523);
                cb.LineTo(550, 523);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 506);
                cb.LineTo(550, 506);
                cb.Stroke();

                cb.SetLineWidth(3);
                cb.MoveTo(50, 489);
                cb.LineTo(550, 489);
                cb.Stroke();

                //linie pionowe
                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 608);
                cb.LineTo(50, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(150, 608);
                cb.LineTo(150, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(180, 608);
                cb.LineTo(180, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(300, 608);
                cb.LineTo(300, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(350, 591);
                cb.LineTo(350, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(375, 608);
                cb.LineTo(375, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(425, 608);
                cb.LineTo(425, 489);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(550, 608);
                cb.LineTo(550, 489);
                cb.Stroke();

                //pod tabelką
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Słownie do wypłaty:", smallBoldFont), 50, 475, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("RAZEM:", smallBoldFont), 340, 475, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(dSuma.ToString("F")+" zł", smallBoldFont), 380, 475, 0);

                p = new Paragraph(Environment.NewLine, normalBoldFont);
                p.Alignment = Element.ALIGN_RIGHT;
                document.Add(p);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(NumberToText.Convert(dSuma, Currency.PLN, true), smallBoldFont), 50, 458, 0);

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 455);
                cb.LineTo(550, 455);
                cb.Stroke();

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("DYREKTOR", smallBoldFont), 470, 441, 0);


                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("SPRAWDZONO POD WZGLĘDEM", smallBoldFont), 50, 411, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("MERYTORYCZNYM, ZAANGAŻOWANO", smallBoldFont), 50, 396, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("POWYŻSZĄ KWOTĘ", smallBoldFont), 50, 382, 0);

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 351);
                cb.LineTo(425, 351);
                cb.Stroke();

                cb.SetLineWidth(0.25);
                cb.MoveTo(425, 455);
                cb.LineTo(425, 290);
                cb.Stroke();

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("GŁÓWNY KSIĘGOWY", smallBoldFont), 50, 319, 0);

                cb.SetLineWidth(0.25);
                cb.MoveTo(50, 290);
                cb.LineTo(550, 290);
                cb.Stroke();

                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
            
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = true;
            bEnterSearch.Visible = true;
            bFind.Visible = false;
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }

        private void bEnterSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = false;
            bEnterSearch.Visible = false;
            bFind.Visible = true;
            faktura.FindInBase(ewidencjaDataSet, textBoxSearch.Text);
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                textBoxSearch.Visible = false;
                bEnterSearch.Visible = false;
                bFind.Visible = true;
                faktura.FindInBase(ewidencjaDataSet, textBoxSearch.Text);
            }
        }

        private void bAddPositionAtFaktura_Click(object sender, EventArgs e)
        {
            string sID = "0";
            panelAddFaktura.Visible = true;
            dataGridView1.ReadOnly = true;
            LookTable.enableDisableControls(false, panelControlButton);

            sID = dataGridView1.Rows.Count.ToString();
            NormalColorAllField(panelAddFaktura);

            ewidencjaDataSet.Clear();
            lpTextBox.Text = sID;
            NewOrEdit = false;
            btNextPosition.Visible = true;
            data_fakturyTextBox.Text = "DD.MM.RRRR";
            termin_platnosciTextBox.Text = "DD.MM.RRRR";
            przekazano_do_DFTextBox.Text = "DD.MM.RRRR";

            chbITorNOT.Checked = false;
        }

        //sprawdzenie czy sa nie wypełnione pola
        public bool CheckAllField(Panel panel)
        {
            int iIleRazy = 0;

            foreach (var item in panel.Controls)
            {
                if(item is TextBox)
                {
                    TextBox textBox = item as TextBox;
                    if(textBox.Text=="" && textBox.Name!= "indeks_finansowyTextBox")
                    {
                        if (iIleRazy == 0) MessageBox.Show("Nie wszystkie pola są uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox.Text = "";
                        textBox.BackColor = Color.Red;
                        iIleRazy++;
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox ComboBox = item as ComboBox;
                    if (ComboBox.Text == "" && ComboBox.Name!= "rodzaj_ewidencjiComboBox")
                    {
                        if (iIleRazy == 0) MessageBox.Show("Nie wszystkie pola są uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ComboBox.Text = "";
                        ComboBox.BackColor = Color.Red;
                        iIleRazy++;
                    }
                }

            }

            if (iIleRazy == 0) return true;
            else return false;
        }

        //sprawdzenie czy pole daty jest w formacie daty
        bool CheckDate(Panel panel)
        {
            //warunek na to by była data wpisana
            DateTime Test;
            int iIleRazy = 0;
            foreach (var item in panelAddFaktura.Controls)
            {

                if (item is TextBox)
                {
                    TextBox dataTextBox = item as TextBox;
                    if (dataTextBox.Name == "termin_platnosciTextBox" || dataTextBox.Name == "przekazano_do_DFTextBox" || dataTextBox.Name == "data_fakturyTextBox")
                    {
                        if (DateTime.TryParseExact(dataTextBox.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out Test) == false)
                        {
                            if (iIleRazy == 0) MessageBox.Show("Prawidłowy format daty to DD.MM.RRRR!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataTextBox.Text = "DD.MM.RRRR";
                            dataTextBox.BackColor = Color.Red;
                            iIleRazy++;
                        }
                    }
                }
            }
            if (iIleRazy == 0) return true;
            else return false;
        }

        //podac dane do zapisu wszystkich pol
        string[] ToSaveAllField(Panel panel)
        {
            string[] stringAllFields=new string[18];
            int i = 0;

            foreach (var item in panel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = item as TextBox;
                    stringAllFields[i] = textBox.Text;
                    if (string.IsNullOrEmpty(stringAllFields[i])) stringAllFields[i] = null;
                    i++;
                }
                else if (item is ComboBox)
                {
                    ComboBox ComboBox = item as ComboBox;
                    stringAllFields[i] = ComboBox.Text;
                    if (string.IsNullOrEmpty(stringAllFields[i])) stringAllFields[i] = null;
                    i++;
                }
            }
            string s="";
            for (int a = 0; a < 18; a++)
            {
                s = s + " " + stringAllFields[a];
            }

            return stringAllFields;
        }

        //wszystkie pola normalnie kolorem
        void NormalColorAllField(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = item as TextBox;
                    textBox.BackColor = Color.White;
                }
                else if (item is ComboBox)
                {
                    ComboBox ComboBox = item as ComboBox;
                    ComboBox.BackColor = Color.White;
                }

            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //odblokowanie zmiany reszty pól
            miesiacComboBox.Enabled = true;
            nr_fakturyTextBox.ReadOnly = false;
            data_fakturyTextBox.Enabled = true;
            dostawcaTextBox.ReadOnly = false;
            termin_platnosciTextBox.Enabled = true;
            sposob_zaplatyComboBox.Enabled = true;
            przekazano_do_DFTextBox.Enabled = true;
            nazwisko_ImieTextBox.ReadOnly = false;
            opis_fakturyTextBox.ReadOnly = false;
            NormalColorAllField(panelAddFaktura);

            //nowa pozycja
            if (NewOrEdit == false)
            {
                if (CheckAllField(panelAddFaktura) && CheckDate(panelAddFaktura))
                {
                    bEdit.Visible = true;
                    faktura.SaveData(ToSaveAllField(panelAddFaktura));
                    faktura.RefreshBase(ewidencjaDataSet);
                    panelAddFaktura.Visible = false;
                    dataGridView1.ReadOnly = false;
                    LookTable.enableDisableControls(true, panelControlButton);
                    fakturyTableAdapter.Fill(ewidencjaDataSet.Faktury);

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.ClearSelection();

                        int nRowIndex = dataGridView1.Rows.Count - 1;
                        int nColumnIndex = 3;

                        dataGridView1.Rows[nRowIndex].Selected = true;
                        dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                        dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
                    }
                }
            }
            //edycja pozycji
            else
            {
                bEdit.Visible = true;
                faktura.ModifyData(ToSaveAllField(panelAddFaktura));
                faktura.RefreshBase(ewidencjaDataSet);
                panelAddFaktura.Visible = false;
                dataGridView1.ReadOnly = false;
                LookTable.enableDisableControls(true, panelControlButton);

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();

                    int nRowIndex = iRowsIndex;
                    int nColumnIndex = 3;

                    dataGridView1.Rows[nRowIndex].Selected = true;
                    dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                    dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
                }
            }
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            //odblokowanie zmiany reszty pól
            miesiacComboBox.Enabled = true;
            nr_fakturyTextBox.ReadOnly = false;
            data_fakturyTextBox.Enabled = true;
            dostawcaTextBox.ReadOnly = false;
            termin_platnosciTextBox.Enabled = true;
            sposob_zaplatyComboBox.Enabled = true;
            przekazano_do_DFTextBox.Enabled = true;
            nazwisko_ImieTextBox.ReadOnly = false;
            opis_fakturyTextBox.ReadOnly = false;
            NormalColorAllField(panelAddFaktura);

            panelAddFaktura.Visible = false;
            dataGridView1.ReadOnly = false;
            LookTable.enableDisableControls(true, panelControlButton);
            fakturyTableAdapter.Fill(ewidencjaDataSet.Faktury);

            if (NewOrEdit == false)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();

                    int nRowIndex = dataGridView1.Rows.Count - 1;
                    int nColumnIndex = 3;

                    dataGridView1.Rows[nRowIndex].Selected = true;
                    dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                    dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
                }
            }
            else
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();

                    int nRowIndex = iRowsIndex;
                    int nColumnIndex = 3;

                    dataGridView1.Rows[nRowIndex].Selected = true;
                    dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                    dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
                }
            }
        }

        private void panelControlButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            panelAddFaktura.Visible = true;
            dataGridView1.ReadOnly = true;
            LookTable.enableDisableControls(false, panelControlButton);

            lpTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            NormalColorAllField(panelAddFaktura);

            NewOrEdit = true;
            btNextPosition.Visible = false;

            if (dataGridView1.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[1].Value.ToString())) miesiacComboBox.SelectedIndex = -1;
                else miesiacComboBox.SelectedItem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[9].Value.ToString())) jednostka_miaryComboBox.SelectedIndex = -1;
                else jednostka_miaryComboBox.SelectedItem = dataGridView1.SelectedRows[0].Cells[9].Value.ToString().Trim();
                if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[11].Value.ToString())) rodzaj_ewidencjiComboBox.SelectedIndex = -1;
                else rodzaj_ewidencjiComboBox.SelectedItem = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[14].Value.ToString())) sposob_zaplatyComboBox.SelectedIndex = -1;
                else sposob_zaplatyComboBox.SelectedItem = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            }
            if (dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "0" && string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[11].Value.ToString())) chbITorNOT.Checked = false;
            else chbITorNOT.Checked = true;

            iRowsIndex = dataGridView1.SelectedRows[0].Index;
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            //tylko cyfry i backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nazwisko_ImieTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tylko litery i backspace
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void EnterDate(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }

        private void DateKeyPres(object sender, KeyPressEventArgs e)
        {
            //tylko cyfry kropka i backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void wartoscTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tylko cyfry kropka i backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void chbITorNOT_CheckedChanged(object sender, EventArgs e)
        {
            if (chbITorNOT.Checked == true)
            {
                chbITorNOT.Text = "Zakup sprzętu";
                indeks_finansowyTextBox.Enabled = true;
                rodzaj_ewidencjiComboBox.Enabled = true;
            }
            else
            {
                chbITorNOT.Text = "Zwykłe zakupy";
                indeks_finansowyTextBox.Enabled = false;
                rodzaj_ewidencjiComboBox.Enabled = false;
            }
        }

        private void btNextPosition_Click(object sender, EventArgs e)
        {

            NormalColorAllField(panelAddFaktura);
            if (CheckAllField(panelAddFaktura) && CheckDate(panelAddFaktura))
            {
                bEdit.Visible = true;
                faktura.SaveData(ToSaveAllField(panelAddFaktura));
                faktura.RefreshBase(ewidencjaDataSet);
            }
            string sID = "0";

            sID = dataGridView1.Rows.Count.ToString();
            
            fakturyBindingSource.Position = dataGridView1.Rows.Count - 1;
            lpTextBox.Text = sID;
            //dane do wyczyszczenia by wprowadzić nowe dane ciagu dalszego faktury
            paragrafTextBox.Text = "";
            pozycja_paragrafTextBox.Text = "";
            specyfikacjaTextBox.Text = "";
            iloscTextBox.Text = "";
            jednostka_miaryComboBox.SelectedIndex = -1;
            indeks_finansowyTextBox.Text = "";
            rodzaj_ewidencjiComboBox.SelectedIndex = -1;
            wartoscTextBox.Text = "";
            //blokada zmiany reszty pól
            miesiacComboBox.Enabled = false;
            nr_fakturyTextBox.ReadOnly = true;
            data_fakturyTextBox.Enabled = false;
            dostawcaTextBox.ReadOnly = true;
            termin_platnosciTextBox.Enabled = false;
            sposob_zaplatyComboBox.Enabled = false;
            przekazano_do_DFTextBox.Enabled = false;
            nazwisko_ImieTextBox.ReadOnly = true;
            opis_fakturyTextBox.ReadOnly = true;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();

                int nRowIndex = dataGridView1.Rows.Count - 1;
                int nColumnIndex = 3;

                dataGridView1.Rows[nRowIndex].Selected = true;
                dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
        }

        private void LeaveDateWithoutDate_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "") textBox.Text = "DD:MM:RRRR";
        }

        private void panelAddFaktura_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
