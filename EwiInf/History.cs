using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace EwiInf
{
    public partial class History : UserControl
    {
        string stringConnection;
        public string setStringConnection { set { stringConnection=value; } }
        LookDataGridView LookTable = new LookDataGridView();
        HistoryClass history = new HistoryClass();

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.historyTableAdapter.Fill(this.ewidencjaDataSet.History);
            LookTable.FormatDataGrid(dataGridView1);
            history.ConnectionString(stringConnection);
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
            history.FindInBase(ewidencjaDataSet, textBoxSearch.Text);
        }

        private void panelControlButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                textBoxSearch.Visible = false;
                bEnterSearch.Visible = false;
                bFind.Visible = true;
                history.FindInBase(ewidencjaDataSet, textBoxSearch.Text);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = "Historia";
            //ścieżka z nazwą pliku do tworzenia
            string path = Application.StartupPath + "/Historia/" + fileName + ".pdf";
            //ścieżka do utworzenia katalogu na wydruki
            string path2 = Application.StartupPath + "/Historia/";
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
                Paragraph p = new Paragraph("Usunięty sprzęt Informatyki i Łączności:" + Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);

                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                //rozmiar szerokosc kolumn
                float[] widths = new float[] { 50f, 125f, 125f, 150f, 150f, 125f, 125f, 125f, 125f, 125f, 125f,
                125f, 125f, 125f, 125f, 400f };
                //zmienna do zapisu szerokosci kolumn wybranych kolumn
                

                pdfTable.SetWidths(widths);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;

                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                //tworzenie header column
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, smallFont));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);
                }
                //wypełnianie komorek danymi
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell cell2 = new PdfPCell(new Phrase(cell.Value.ToString(), smallFont));
                        cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell2);
                    }
                }
                document.Add(pdfTable);

                //dolne wpisy
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Wykaz usuniętego sprzętu wygenerowany z EwiInf dla Aresztu Śledczego w Łodzi " + DateTime.Now.ToString(), normalFont), 250, 60, 0);
                //koniec wydruku

                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
        }
    }
}
