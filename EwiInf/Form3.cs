using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace EwiInf
{
    public partial class Form3 : Form
    {
        ConectAndModifyData conect = new ConectAndModifyData();
        Form1 _owner;
        string sBudynek = "";
        string sPietro = "";
        string sPomieszczenie = "";

        public Form3(Form1 owner, string ConnectionString)
        {
            InitializeComponent();
            _owner = owner;
            conect.ConnectionString(ConnectionString);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
        }

        public Form3()
        {
            InitializeComponent();
        }

        //funkcja uzupełnienia sprzętu
        private void CompleteAll()
        {
            listBoxMonitor.Items.Clear();
            listBoxComputer.Items.Clear();
            listBoxPrinter.Items.Clear();
            listBoxTelephone.Items.Clear();
            listBoxOther.Items.Clear();

            for (int i = 0; i < ewidencjaDataSet1.Ewi.Rows.Count; i++)
            {
                //uzupełnienie listboxa komputer
                if(ewidencjaDataSet1.Ewi.Rows[i][20].ToString()==sBudynek &&
                    ewidencjaDataSet1.Ewi.Rows[i][21].ToString() == sPietro &&
                    ewidencjaDataSet1.Ewi.Rows[i][22].ToString() == sPomieszczenie &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString()=="KOMPUTER")
                {
                    listBoxComputer.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][1].ToString());
                    listBoxComputer.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][3].ToString());
                    listBoxComputer.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][23].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][25].ToString() == "") listBoxComputer.Items.Add("BRAK KARTY");
                    else listBoxComputer.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][25].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][27].ToString() == "") listBoxComputer.Items.Add("BRAK INDEKSU FINANSOWEGO");
                    else listBoxComputer.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][27].ToString());
                    listBoxComputer.Items.Add(Environment.NewLine);
                }

                //uzupełnienie listboxa monitor
                if (ewidencjaDataSet1.Ewi.Rows[i][20].ToString() == sBudynek &&
                    ewidencjaDataSet1.Ewi.Rows[i][21].ToString() == sPietro &&
                    ewidencjaDataSet1.Ewi.Rows[i][22].ToString() == sPomieszczenie &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() == "MONITOR")
                {
                    listBoxMonitor.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][1].ToString());
                    listBoxMonitor.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][3].ToString());
                    listBoxMonitor.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][23].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][25].ToString() == "") listBoxMonitor.Items.Add("BRAK KARTY");
                    else listBoxMonitor.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][25].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][27].ToString() == "") listBoxMonitor.Items.Add("BRAK INDEKSU FINANSOWEGO");
                    else listBoxMonitor.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][27].ToString());
                    listBoxMonitor.Items.Add(Environment.NewLine);
                    
                }

                //uzupełnienie listboxa drukarka
                if (ewidencjaDataSet1.Ewi.Rows[i][20].ToString() == sBudynek &&
                    ewidencjaDataSet1.Ewi.Rows[i][21].ToString() == sPietro &&
                    ewidencjaDataSet1.Ewi.Rows[i][22].ToString() == sPomieszczenie &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() == "DRUKARKA")
                {
                    listBoxPrinter.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][1].ToString());
                    listBoxPrinter.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][3].ToString());
                    listBoxPrinter.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][23].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][25].ToString() == "") listBoxPrinter.Items.Add("BRAK KARTY");
                    else listBoxPrinter.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][25].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][27].ToString() == "") listBoxPrinter.Items.Add("BRAK INDEKSU FINANSOWEGO");
                    else listBoxPrinter.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][27].ToString());
                    listBoxPrinter.Items.Add(Environment.NewLine);
                    
                }

                //uzupełnienie listboxa telefon
                if (ewidencjaDataSet1.Ewi.Rows[i][20].ToString() == sBudynek &&
                    ewidencjaDataSet1.Ewi.Rows[i][21].ToString() == sPietro &&
                    ewidencjaDataSet1.Ewi.Rows[i][22].ToString() == sPomieszczenie &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() == "TELEFON")
                {
                    listBoxTelephone.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][1].ToString());
                    listBoxTelephone.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][3].ToString());
                    listBoxTelephone.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][23].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][25].ToString() == "") listBoxTelephone.Items.Add("BRAK KARTY");
                    else listBoxTelephone.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][25].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][27].ToString() == "") listBoxTelephone.Items.Add("BRAK INDEKSU FINANSOWEGO");
                    else listBoxTelephone.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][27].ToString());
                    listBoxTelephone.Items.Add(Environment.NewLine);
                    
                }

                //uzupełnienie listboxa pozostały sprzęt
                if (ewidencjaDataSet1.Ewi.Rows[i][20].ToString() == sBudynek &&
                    ewidencjaDataSet1.Ewi.Rows[i][21].ToString() == sPietro &&
                    ewidencjaDataSet1.Ewi.Rows[i][22].ToString() == sPomieszczenie &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() != "KOMPUTER" &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() != "MONITOR" &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() != "TELEFON" &&
                    ewidencjaDataSet1.Ewi.Rows[i][2].ToString() != "DRUKARKA")
                {
                    listBoxOther.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][1].ToString());
                    listBoxOther.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][3].ToString());
                    listBoxOther.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][23].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][25].ToString() == "") listBoxOther.Items.Add("BRAK KARTY");
                    else listBoxOther.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][25].ToString());
                    if (ewidencjaDataSet1.Ewi.Rows[i][27].ToString() == "") listBoxOther.Items.Add("BRAK INDEKSU FINANSOWEGO");
                    else listBoxOther.Items.Add(ewidencjaDataSet1.Ewi.Rows[i][27].ToString());
                    listBoxOther.Items.Add(Environment.NewLine);
                    
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conect.RefreshBase(ewidencjaDataSet1);
            conect.TreeView(ewidencjaDataSet1, 20);
            conect.CompleteTreeView(treeView1, ewidencjaDataSet1);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.Show();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (e.Node.Parent != null && e.Node.Parent.Parent != null)
            {
                sPomieszczenie = e.Node.Text;
                sPietro = e.Node.Parent.Text;
                sBudynek = e.Node.Parent.Parent.Text;
                lbRoom.Text = sBudynek + " \\ " + sPietro + " \\ " + sPomieszczenie;
                lbRoom.Left = (this.ClientSize.Width - lbRoom.Width - 280) / 2;
                CompleteAll();
                btPrint.Visible = true;
            }
        }

        
        private void btPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintReportRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void PrintReportRoom()
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = sBudynek + " " + sPietro + " " + sPomieszczenie;
            //ścieżka z nazwą pliku do tworzenia
            string path = Application.StartupPath + "/Wydruki pomieszczeń/" + fileName + ".pdf";
            //ścieżka do utworzenia katalogu na wydruki
            string path2 = Application.StartupPath + "/Wydruki pomieszczeń/";
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
            var normalFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 10);
            //BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);
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
                Paragraph p = new Paragraph("POMIESZCZENIE:", bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(fileName, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, normalFont);
                p.Alignment = Element.ALIGN_LEFT;
                document.Add(p);
                //wypełnienie datagridview
                //lista computerów
                dataGridView1.Rows.Clear();
                int c = 0;
                if (listBoxComputer.Items.Count > 0)
                {
                    for (int i = 0; i < listBoxComputer.Items.Count / 6; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = listBoxComputer.Items[c + 1];
                        dataGridView1.Rows[i].Cells[2].Value = listBoxComputer.Items[c];
                        dataGridView1.Rows[i].Cells[3].Value = listBoxComputer.Items[c + 4];
                        dataGridView1.Rows[i].Cells[4].Value = listBoxComputer.Items[c + 2];
                        dataGridView1.Rows[i].Cells[5].Value = 1;
                        c = i + 6;
                    }
                }
                //lista monitorów
                if (listBoxMonitor.Items.Count > 0)
                {
                    int b = 0;
                    b = dataGridView1.Rows.Count;
                    c = b - b;
                    for (int i = b; i < (listBoxMonitor.Items.Count / 6) + b; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = listBoxMonitor.Items[c + 1];
                        dataGridView1.Rows[i].Cells[2].Value = listBoxMonitor.Items[c];
                        dataGridView1.Rows[i].Cells[3].Value = listBoxMonitor.Items[c + 4];
                        dataGridView1.Rows[i].Cells[4].Value = listBoxMonitor.Items[c + 2];
                        dataGridView1.Rows[i].Cells[5].Value = 1;
                        c = i - b + 6;
                    }
                }
                //lista drukarek
                if (listBoxPrinter.Items.Count > 0)
                {
                    int b = 0;
                    b = dataGridView1.Rows.Count;
                    c = b - b;
                    for (int i = b; i < (listBoxPrinter.Items.Count / 6) + b; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = listBoxPrinter.Items[c + 1];
                        dataGridView1.Rows[i].Cells[2].Value = listBoxPrinter.Items[c];
                        dataGridView1.Rows[i].Cells[3].Value = listBoxPrinter.Items[c + 4];
                        dataGridView1.Rows[i].Cells[4].Value = listBoxPrinter.Items[c + 2];
                        dataGridView1.Rows[i].Cells[5].Value = 1;
                        c = i - b + 5;
                    }
                }
                //lista telefonów
                if (listBoxTelephone.Items.Count > 0)
                {
                    int b = 0;
                    b = dataGridView1.Rows.Count;
                    c = b - b;
                    for (int i = b; i < (listBoxTelephone.Items.Count / 6) + b; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = listBoxTelephone.Items[c + 1];
                        dataGridView1.Rows[i].Cells[2].Value = listBoxTelephone.Items[c];
                        dataGridView1.Rows[i].Cells[3].Value = listBoxTelephone.Items[c + 4];
                        dataGridView1.Rows[i].Cells[4].Value = listBoxTelephone.Items[c + 2];
                        dataGridView1.Rows[i].Cells[5].Value = 1;
                        c = i - b + 6;
                    }
                }
                //lista pozostałych sprzętów
                if (listBoxOther.Items.Count > 0)
                {
                    int b = 0;
                    b = dataGridView1.Rows.Count;
                    c = b - b;
                    for (int i = b; i < (listBoxOther.Items.Count / 6) + b; i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = i + 1;
                        dataGridView1.Rows[i].Cells[1].Value = listBoxOther.Items[c + 1];
                        dataGridView1.Rows[i].Cells[2].Value = listBoxOther.Items[c];
                        dataGridView1.Rows[i].Cells[3].Value = listBoxOther.Items[c + 4];
                        dataGridView1.Rows[i].Cells[4].Value = listBoxOther.Items[c + 2];
                        dataGridView1.Rows[i].Cells[5].Value = 1;
                        c = i - b + 6;
                    }
                }

                //tabela z datagridview
                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                //rozmiar szerokosc kolumn
                float[] widths = new float[] { 80f, 500f, 300f, 250f, 250f, 70f };
                pdfTable.SetWidths(widths);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;

                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                //tworzenie header column
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    pdfTable.AddCell(cell);
                }
                //wypełnianie komorek danymi
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell cell2 = new PdfPCell(new Phrase(cell.Value.ToString(), normalFont));
                        cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell2);
                        //pdfTable.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), normalFont)));
                    }
                }
                document.Add(pdfTable);

                //dolne wpisy
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Wykaz sporządził:", normalFont), 150, 150, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Wykaz przyjał:", normalFont), 500, 150, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Zespół Informatyki i Łączności", normalFont), 150, 125, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("...........................", normalFont), 500, 125, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Raport wygenerowany z EwiInf dla Aresztu Śledczego w Łodzi " + DateTime.Now.ToString(), normalFont), 250, 60, 0);
                //ColumnText.ShowTextAligned(writer.DirectContent,
                //Element.ALIGN_CENTER, new Phrase("Strona "+document.PageNumber+1, normalFont), 300, 40, 0);
                //koniec wydruku

                document.Close();



                //45, 52
                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
        }
        
    }

    


}
