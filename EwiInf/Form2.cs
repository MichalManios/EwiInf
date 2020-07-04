using iTextSharp.text;
using iTextSharp.text.pdf;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Form2 : Form
    {
        ConectAndModifyData connectData = new ConectAndModifyData();
        CardConservation card = new CardConservation();
        string connectionString = "";
        //okno głowne
        Form1 _owner;
        //zmienna pokazujaca okno 2 jako zapis false lub modyfikacja true
        bool bModify = false;
        //zmienna wyswietlanie tylko danych
        bool bOnlyLook = false;
        //numer wskazanego wiersza z tabeli
        int iIDnumber = 0;
        ConectAndModifyData conectCard = new ConectAndModifyData();

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

        public Form2(Form1 owner, string ConnectionString)
        {
            InitializeComponent();
            _owner = owner;
            connectData.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            connectionString = ConnectionString;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
        }

        public Form2(bool bmodify, int iIdNumber, Form1 owner, string ConnectionString)
        {
            InitializeComponent();
            this._owner = owner;
            this.bModify = bmodify;
            this.iIDnumber = iIdNumber;
            connectData.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            connectionString = ConnectionString;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
        }

        public Form2(bool bNewView, Form1 owner, string ConnectionString)
        {
            InitializeComponent();
            this._owner = owner;
            this.bOnlyLook = bNewView;
            connectData.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            connectionString = ConnectionString;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void ewiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ewiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewidencjaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //dodanie nowej karty
            if (bModify == false && bOnlyLook == false)
            {
                // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
                this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);

                //update danych w tabeli
                connectData.RefreshBase(ewidencjaDataSet);
                //kolejne numery przy tworzeniu nowej pozycji
                //pobranie nowego id i zapis do zmiennej
                string sId = "";
                if (ewidencjaDataSet.Ewi.Rows.Count > 0) sId = (Convert.ToInt32(ewidencjaDataSet.Ewi.Rows[ewidencjaDataSet.Ewi.Rows.Count - 1][0]) + 1).ToString();
                else sId = "1";
                if (ewidencjaDataSet.Ewi.Rows.Count > 0)
                {
                    //uzupełnianie comboboxow z bazy danych by można było wybrać z tych grup co już są zapisane
                    connectData.CompleteCombo(ewidencjaDataSet, comboBoxRodzajSprzetu, 2);
                    //connectData.CompleteCombo(ewidencjaDataSet, comboBoxRodzajEwidencji, 9);
                    connectData.CompleteComboII(ewidencjaDataSet, comboBoxBudynek, 20);
                    //blokowanie wyboru przed wybraniem wyboru nadrzednego
                    comboBoxPietro.Enabled = false;
                    comboBoxPomieszczenie.Enabled = false;
                    //niewidoczne przyciski do dodawania itemow do podrzednych combosow
                    btAddPietro.Visible = false;
                    btAddPomieszczenie.Visible = false;
                }
                //reset pól
                ewidencjaDataSet.Clear();
                //uzupełnienie id
                idTextBox.Text = sId;
            }
            if (bModify == true && bOnlyLook == false)
            {
                // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
                this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);
                //update danych w tabeli
                connectData.RefreshBase(ewidencjaDataSet);
                if (ewidencjaDataSet.Ewi.Rows.Count > 0)
                {
                    //uzupełnianie comboboxow z bazy danych by można było wybrać z tych grup co już są zapisane
                    connectData.CompleteCombo(ewidencjaDataSet, comboBoxRodzajSprzetu, 2);
                    //connectData.CompleteCombo(ewidencjaDataSet, comboBoxRodzajEwidencji, 9);
                    connectData.CompleteComboII(ewidencjaDataSet, comboBoxBudynek, 20);
                    //blokowanie wyboru w podrzednych przed wybraniem nadrzednego wyboru
                    comboBoxPietro.Enabled = false;
                    comboBoxPomieszczenie.Enabled = false;
                    //niewidoczne przyciski do dodawania itemow do podrzednych combosow
                    btAddPietro.Visible = false;
                    btAddPomieszczenie.Visible = false;
                    
                }

                ewiBindingSource.Position = ewiBindingSource.Find("Id", iIDnumber);
                comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
                comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
                comboBoxBudynek.SelectedItem = budynekTextBox.Text;
                comboBoxPietro.SelectedItem = pietroTextBox.Text;
                comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
                comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;

                if (numer_kartyTextBox1.Text != "")
                {
                    checkBoxCreateCard.Visible = false;
                    label1.Visible = false;
                    bSettings.Visible = true;
                }
                else
                {
                    checkBoxCreateCard.Visible = true;
                    label1.Visible = true;
                    bSettings.Visible = false;
                }
                connectData.Where(comboBoxBudynek.SelectedItem.ToString(), comboBoxPomieszczenie.SelectedItem.ToString(), comboBoxPietro.SelectedItem.ToString());
                GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
            }
            //tylko przegladanie kart
            if (bOnlyLook == true)
            {
                // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
                this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);
                //update danych w tabeli
                connectData.RefreshBase(ewidencjaDataSet);
                if (ewidencjaDataSet.Ewi.Rows.Count > 0)
                {
                    //uzupełnianie comboboxow z bazy danych by można było wybrać z tych grup co już są zapisane
                    connectData.CompleteCombo(ewidencjaDataSet, comboBoxRodzajSprzetu, 2);
                    //connectData.CompleteCombo(ewidencjaDataSet, comboBoxRodzajEwidencji, 9);
                    connectData.CompleteCombo(ewidencjaDataSet, comboBoxBudynek, 20);
                    connectData.CompleteCombo(ewidencjaDataSet, comboBoxPietro, 21);
                    connectData.CompleteCombo(ewidencjaDataSet, comboBoxPomieszczenie, 22);
                }

                comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
                comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
                comboBoxBudynek.SelectedItem = budynekTextBox.Text;
                comboBoxPietro.SelectedItem = pietroTextBox.Text;
                comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
                comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;

                foreach (Control c in Controls)
                {
                    c.Enabled = false;
                    if (c is TextBox) c.BackColor = Color.LightBlue;
                    if(c is ComboBox) c.BackColor = Color.LightBlue;
                }
                bSave.Visible = false;
                bCancel.Enabled = true;
                bSettings.Enabled = true;
                panelSteer.Visible = true;
                panelSteer.Enabled = true;
                PrintQRCode.Enabled = true;
                label1.Visible = false;
                checkBoxCreateCard.Visible = false;
                if (ewidencjaDataSet.Tables[0].Rows[0][25].ToString() == "") bSettings.Visible = false;
                else bSettings.Visible = true;

                if (ewidencjaDataSet.Ewi.Rows.Count > 0)
                {
                    lbHowMuchOf.Text = "1 z " + ewidencjaDataSet.Ewi.Rows.Count;
                    //uzupełnianie comboboxow z bazy danych by można było wybrać z tych grup co już są zapisane
                    for (int i = 0; i < ewidencjaDataSet.Ewi.Rows.Count; i++)
                    {
                        comboBoxWhatItem.Items.Add(i + 1);
                    }
                    comboBoxWhatItem.SelectedIndex = 0;
                }
                GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
                btPrint.Visible = true;
                btPrint.Enabled = true;
            }

        }

        private void karta_grafiki2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void procesorLabel_Click(object sender, EventArgs e)
        {

        }

        private void procesorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ramLabel_Click(object sender, EventArgs e)
        {

        }

        private void ramTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dysk1Label_Click(object sender, EventArgs e)
        {

        }

        private void dysk1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dysk2Label_Click(object sender, EventArgs e)
        {

        }

        private void dysk2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dysk3Label_Click(object sender, EventArgs e)
        {

        }

        private void dysk3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void budynekLabel_Click(object sender, EventArgs e)
        {

        }

        private void budynekTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pietroLabel_Click(object sender, EventArgs e)
        {

        }

        private void pietroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pomieszczenieLabel_Click(object sender, EventArgs e)
        {

        }

        private void pomieszczenieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void informatyka_LacznoscLabel_Click(object sender, EventArgs e)
        {

        }

        private void informatyka_LacznoscTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uwagiLabel_Click(object sender, EventArgs e)
        {

        }

        private void uwagiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nr_seryjnyLabel_Click(object sender, EventArgs e)
        {

        }

        private void nr_seryjnyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wartosc_zakupuLabel_Click(object sender, EventArgs e)
        {

        }

        private void wartosc_zakupuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nr_fakturyLabel_Click(object sender, EventArgs e)
        {

        }

        private void nr_fakturyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rodzaj_ewidencjiLabel_Click(object sender, EventArgs e)
        {

        }

        private void rodzaj_ewidencjiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mac_adresLabel_Click(object sender, EventArgs e)
        {

        }

        private void mac_adresTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iP_adres1Label_Click(object sender, EventArgs e)
        {

        }

        private void iP_adres1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iP_adres2Label_Click(object sender, EventArgs e)
        {

        }

        private void iP_adres2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iP_adres3Label_Click(object sender, EventArgs e)
        {

        }

        private void iP_adres3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void karta_grafiki1Label_Click(object sender, EventArgs e)
        {

        }

        private void karta_grafiki1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iP_adres4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iP_adres4Label_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void karta_grafiki2Label_Click(object sender, EventArgs e)
        {

        }

        private void nr_ewidencyjnyLabel_Click(object sender, EventArgs e)
        {

        }

        private void nr_ewidencyjnyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rodzaj_sprzętuLabel_Click(object sender, EventArgs e)
        {

        }

        private void rodzaj_sprzętuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nazwa_ProducentLabel_Click(object sender, EventArgs e)
        {

        }

        private void nazwa_ProducentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rok_produkcjiLabel_Click(object sender, EventArgs e)
        {

        }

        private void rok_produkcjiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void termin_gwarancjiLabel_Click(object sender, EventArgs e)
        {

        }

        private void termin_gwarancjiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            panelSteer.Visible = false;
            bSettings.Visible = false;
            bSave.Visible = true;
            label1.Visible = true;
            checkBoxCreateCard.Visible = true;
            connectData.ClearCombosAndButtons();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(bModify==false) 
            _owner.Show();
            //_owner.RefreshTable();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 Form4 = new Form4(this, true, numer_kartyTextBox1.Text, connectionString);
            Form4.ShowDialog();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Color color = idTextBox.BackColor;
            //zapis do combosów i ustawienie jako selected wpisanego tekstu edytowanych combosow
            connectData.AddItemToComboBox();
            //sprawdz pola musowe czy uzupelnione dopiero dalej
            if (idTextBox.Text == "" || nr_ewidencyjnyTextBox.Text == "" || comboBoxRodzajSprzetu.Text == "" || nazwa_ProducentTextBox.Text == "" || nr_seryjnyTextBox.Text=="" ||
                rok_produkcjiTextBox.Text == "" || termin_gwarancjiTextBox.Text == "" || wartosc_zakupuTextBox.Text == "" || nr_fakturyTextBox.Text == "" ||
                comboBoxRodzajEwidencji.Text == "" || comboBoxBudynek.Text == "" || comboBoxPietro.Text == "" || comboBoxPomieszczenie.Text == "" || comboBoxInformatykaLacznosc.Text == "")
            {
                MessageBox.Show("Nie wszystkie wymagane pola do zapisu są wypełnione. Uzupełnij zaznaczone pole/pola aby zapisać dane!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //kolorowanie border textboxow
                //kolorowanie normalne
                foreach (Control tb in this.Controls)
                {
                    if (tb is TextBox) tb.BackColor = color;
                    if (tb is ComboBox) tb.BackColor = color;
                }
                //na czerwono nie wypełnionych
                foreach (Control tb in this.Controls)
                {
                    if(tb is TextBox)
                    {
                        if (tb.Text == "") tb.BackColor = Color.Red;
                    }
                    if(tb is ComboBox)
                    {
                        if (tb.Text == "") tb.BackColor = Color.Red;
                    }
                    //zaznaczenie normalnym kolorem pustego pola niewymaganego
                    if(tb.Name=="nr_seryjnyTextBox") tb.BackColor = color;
                    if (tb.Name == "mac_adresTextBox") tb.BackColor = color;
                    if (tb.Name == "iP_adres1TextBox") tb.BackColor = color;
                    if (tb.Name == "iP_adres2TextBox") tb.BackColor = color;
                    if (tb.Name == "iP_adres3TextBox") tb.BackColor = color;
                    if (tb.Name == "system_operacyjnyTextBox1") tb.BackColor = color;
                    if (tb.Name == "karta_grafiki1TextBox") tb.BackColor = color;
                    if (tb.Name == "karta_grafiki2TextBox") tb.BackColor = color;
                    if (tb.Name == "procesorTextBox") tb.BackColor = color;
                    if (tb.Name == "ramTextBox") tb.BackColor = color;
                    if (tb.Name == "dysk1TextBox") tb.BackColor = color;
                    if (tb.Name == "dysk2TextBox") tb.BackColor = color;
                    if (tb.Name == "numer_kartyTextBox1") tb.BackColor = color;
                    if (tb.Name == "uwagiTextBox") tb.BackColor = color;
                    if (tb.Name == "nr_seryjnyTextBoc") tb.BackColor = color;
                }
            }
            else
            {
                //zapis buttonem gdy jest dodanie nowego rekordu
                if (bModify == false)
                {
                    if (checkBoxCreateCard.Checked == true)
                    {
                        DataSet dataSet = new DataSet();
                        dataSet = ewidencjaDataSet;
                        card.RefreshBase(dataSet, "Karta");


                        if (dataSet.Tables["Karta"].Rows.Count > 0)
                        {
                            int iNumerKarty = dataSet.Tables["Karta"].Rows.Count + 1;
                            numer_kartyTextBox1.Text = iNumerKarty.ToString() + "\\" + DateTime.Today.Year.ToString();
                        }
                        else numer_kartyTextBox1.Text = "1" + "\\" + DateTime.Today.Year.ToString();
                        connectData.SaveData(idTextBox, nr_ewidencyjnyTextBox, comboBoxRodzajSprzetu, nazwa_ProducentTextBox, rok_produkcjiTextBox, termin_gwarancjiTextBox, nr_seryjnyTextBox, wartosc_zakupuTextBox, nr_fakturyTextBox, comboBoxRodzajEwidencji, mac_adresTextBox, iP_adres1TextBox, iP_adres2TextBox, iP_adres3TextBox, karta_grafiki1TextBox, karta_grafiki2TextBox, procesorTextBox, ramTextBox, dysk1TextBox, dysk2TextBox, comboBoxBudynek, comboBoxPietro, comboBoxPomieszczenie, comboBoxInformatykaLacznosc, system_operacyjnyTextBox1, numer_kartyTextBox1, uwagiTextBox, index_finansowyTextBox);
                        string sGdzie = comboBoxBudynek.Text + " \\ " + comboBoxPietro.Text + " \\ " + comboBoxPomieszczenie.Text;
                        this.Hide();
                        Form4 Form4 = new Form4(this, true, numer_kartyTextBox1.Text, nazwa_ProducentTextBox.Text, nr_seryjnyTextBox.Text, sGdzie, connectionString);
                        Form4.ShowDialog();
                    }
                    else
                    {
                        connectData.SaveData(idTextBox, nr_ewidencyjnyTextBox, comboBoxRodzajSprzetu, nazwa_ProducentTextBox, rok_produkcjiTextBox, termin_gwarancjiTextBox, nr_seryjnyTextBox, wartosc_zakupuTextBox, nr_fakturyTextBox, comboBoxRodzajEwidencji, mac_adresTextBox, iP_adres1TextBox, iP_adres2TextBox, iP_adres3TextBox, karta_grafiki1TextBox, karta_grafiki2TextBox, procesorTextBox, ramTextBox, dysk1TextBox, dysk2TextBox, comboBoxBudynek, comboBoxPietro, comboBoxPomieszczenie, comboBoxInformatykaLacznosc, system_operacyjnyTextBox1, numer_kartyTextBox1, uwagiTextBox, index_finansowyTextBox);
                        GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
                    }

                }
                //zapis buttonem gdy jest modyfikowany rekord
                if (bModify==true)
                {
                    if (checkBoxCreateCard.Checked == true)
                    {
                        DataSet dataSet = new DataSet();
                        dataSet = ewidencjaDataSet;
                        card.RefreshBase(dataSet, "Karta");


                        if (dataSet.Tables["Karta"].Rows.Count > 0)
                        {
                            int iNumerKarty = dataSet.Tables["Karta"].Rows.Count + 1;
                            numer_kartyTextBox1.Text = iNumerKarty.ToString() + "\\" + DateTime.Today.Year.ToString();
                        }
                        else numer_kartyTextBox1.Text = "1" + "\\" + DateTime.Today.Year.ToString();
                        connectData.ModifyData(idTextBox, nr_ewidencyjnyTextBox, comboBoxRodzajSprzetu, nazwa_ProducentTextBox, rok_produkcjiTextBox, termin_gwarancjiTextBox, nr_seryjnyTextBox, wartosc_zakupuTextBox, nr_fakturyTextBox, comboBoxRodzajEwidencji, mac_adresTextBox, iP_adres1TextBox, iP_adres2TextBox, iP_adres3TextBox, karta_grafiki1TextBox, karta_grafiki2TextBox, procesorTextBox, ramTextBox, dysk1TextBox, dysk2TextBox, comboBoxBudynek, comboBoxPietro, comboBoxPomieszczenie, comboBoxInformatykaLacznosc, system_operacyjnyTextBox1, numer_kartyTextBox1, uwagiTextBox, index_finansowyTextBox);
                        string sGdzie = comboBoxBudynek.Text + " \\ " + comboBoxPietro.Text + " \\ " + comboBoxPomieszczenie.Text;
                        this.Hide();
                        Form4 Form4 = new Form4(this, true, numer_kartyTextBox1.Text, nazwa_ProducentTextBox.Text, nr_seryjnyTextBox.Text, sGdzie, connectionString);
                        Form4.ShowDialog();
                    }
                    else
                    {
                        //zapis zmodyfikowanych pól
                        if (connectData.LocalizationChange(comboBoxBudynek.Text, comboBoxPomieszczenie.Text, comboBoxPietro.Text) == true)
                        {
                            connectData.ModifyData(idTextBox, nr_ewidencyjnyTextBox, comboBoxRodzajSprzetu, nazwa_ProducentTextBox, rok_produkcjiTextBox, termin_gwarancjiTextBox, nr_seryjnyTextBox, wartosc_zakupuTextBox, nr_fakturyTextBox, comboBoxRodzajEwidencji, mac_adresTextBox, iP_adres1TextBox, iP_adres2TextBox, iP_adres3TextBox, karta_grafiki1TextBox, karta_grafiki2TextBox, procesorTextBox, ramTextBox, dysk1TextBox, dysk2TextBox, comboBoxBudynek, comboBoxPietro, comboBoxPomieszczenie, comboBoxInformatykaLacznosc, system_operacyjnyTextBox1, numer_kartyTextBox1, uwagiTextBox, index_finansowyTextBox);
                            //otwarcie okna karty gdy jest numer karty i istnieje karta by zmodyfikowac
                            if (numer_kartyTextBox1.Text != "")
                            {
                                this.Hide();
                                Form4 Form4 = new Form4(this, true, true, numer_kartyTextBox1.Text, connectData.LocalizationString(comboBoxBudynek.Text, comboBoxPietro.Text, comboBoxPomieszczenie.Text), connectionString);
                                Form4.ShowDialog();

                            }
                        }
                        else
                        {
                            connectData.ModifyData(idTextBox, nr_ewidencyjnyTextBox, comboBoxRodzajSprzetu, nazwa_ProducentTextBox, rok_produkcjiTextBox, termin_gwarancjiTextBox, nr_seryjnyTextBox, wartosc_zakupuTextBox, nr_fakturyTextBox, comboBoxRodzajEwidencji, mac_adresTextBox, iP_adres1TextBox, iP_adres2TextBox, iP_adres3TextBox, karta_grafiki1TextBox, karta_grafiki2TextBox, procesorTextBox, ramTextBox, dysk1TextBox, dysk2TextBox, comboBoxBudynek, comboBoxPietro, comboBoxPomieszczenie, comboBoxInformatykaLacznosc, system_operacyjnyTextBox1, numer_kartyTextBox1, uwagiTextBox, index_finansowyTextBox);
                            GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
                        }
                    }
                }
                
                else this.Close();
                //kolorowanie normalne wszystkich 
                foreach (Control tb in this.Controls)
                {
                    if(tb is TextBox) tb.BackColor = color;
                    if (tb is ComboBox) tb.BackColor = color;
                }
                connectData.ButtonAndComboNormal();
                connectData.ClearCombosAndButtons();

            }
        }


        private void comboBoxRodzajSprzetu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void comboBoxRodzajSprzetu_Leave(object sender, EventArgs e)
        {
            
        }

        private void btAddRodzajSprzetu_Click(object sender, EventArgs e)
        {
            connectData.AddComboBox(comboBoxRodzajSprzetu, btAddRodzajSprzetu);
        }

        private void btAddBudynek_Click(object sender, EventArgs e)
        {
            connectData.AddComboBox(comboBoxBudynek, btAddBudynek);
            btAddPietro.Visible = true;
            comboBoxPietro.Enabled = true;
            if (bOnlyLook == false)
            {
                //po zmianie enabled podrzednych na false
                comboBoxPietro.Enabled = false;
                comboBoxPomieszczenie.Enabled = false;
                //niewidoczne buttony do podrzednych combosow do dodawania itemow po zmianie wartosci
                btAddPietro.Visible = false;
                btAddPomieszczenie.Visible = false;
                //czyszczenie po zmianie combosow podrzednych
                comboBoxPietro.Items.Clear();
                comboBoxPomieszczenie.Items.Clear();
                //podrzedny o jeden stopien nizej enabled true
                comboBoxPietro.Enabled = true;
                //widoczny button do dodawania nowych pieter
                btAddPietro.Visible = true;
                //uzupełnienie combosów o wybor itemów
                //connectData.CompleteFloorII(comboBoxBudynek, comboBoxPietro);
            }
        }

        private void btAddPietro_Click(object sender, EventArgs e)
        {
            connectData.AddComboBox(comboBoxPietro, btAddPietro);
            btAddPomieszczenie.Visible = true;
            comboBoxPomieszczenie.Enabled = true;
            if (bOnlyLook == false)
            {
                //czyszczenie combosa
                comboBoxPomieszczenie.Items.Clear();
                //właczenie enabled
                comboBoxPomieszczenie.Enabled = true;
                //widoczny button do dodawania itemow do pomieszczenia
                btAddPomieszczenie.Visible = true;
                //uzupełnianie combosa
                //connectData.CompleteRoomII(comboBoxPietro, comboBoxPomieszczenie);
            }
        }

        private void btAddPomieszczenie_Click(object sender, EventArgs e)
        {
            connectData.AddComboBox(comboBoxPomieszczenie, btAddPomieszczenie);
        }

        private void comboBoxRodzajEwidencji_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void comboBoxBudynek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void comboBoxPietro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void comboBoxPomieszczenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void btForwardOne_Click(object sender, EventArgs e)
        {
            if (ewiBindingSource.Position + 1 < ewiBindingSource.Count)
            {
                //przesuniecie o jeden do przodu strony
                ewiBindingSource.MoveNext();
                //ustawienie biezacej strony w combo wyboru strony
                comboBoxWhatItem.SelectedIndex = ewiBindingSource.Position;
                //wypis ktora to strona z ilu
                lbHowMuchOf.Text = (ewiBindingSource.Position+1).ToString() + " z " + ewiBindingSource.Count.ToString();
                //jesli jest karta urzadzenia pokazanie przycisku jesli nie schowanie
                if (ewidencjaDataSet.Tables[0].Rows[ewiBindingSource.Position][25].ToString() == "") bSettings.Visible = false;
                else bSettings.Visible = true;
                //uzupełnianie comboboxow
                comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
                comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
                comboBoxBudynek.SelectedItem = budynekTextBox.Text;
                comboBoxPietro.SelectedItem = pietroTextBox.Text;
                comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
                comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;
                GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
            }
        }

        private void btBackwardOne_Click(object sender, EventArgs e)
        {
            if (ewiBindingSource.Position - 1 >= 0)
            {
                //przesuniecie o jeden do tyłu strony
                ewiBindingSource.MovePrevious();
                //ustawienie biezacej strony w combo wyboru strony
                comboBoxWhatItem.SelectedIndex = ewiBindingSource.Position;
                //wypis ktora to strona z ilu
                lbHowMuchOf.Text = (ewiBindingSource.Position + 1).ToString() + " z " + ewiBindingSource.Count.ToString();
                //jesli jest karta urzadzenia pokazanie przycisku jesli nie schowanie
                if (ewidencjaDataSet.Tables[0].Rows[ewiBindingSource.Position][25].ToString() == "") bSettings.Visible = false;
                else bSettings.Visible = true;
                //uzupełnianie comboboxow
                comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
                comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
                comboBoxBudynek.SelectedItem = budynekTextBox.Text;
                comboBoxPietro.SelectedItem = pietroTextBox.Text;
                comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
                comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;
                GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
            }
        }

        private void btMoveLas_Click(object sender, EventArgs e)
        {
            //przesuniecie do ostatniej strony
            ewiBindingSource.MoveLast();
            //ustawienie biezacej strony w combo wyboru strony
            comboBoxWhatItem.SelectedIndex = ewiBindingSource.Position;
            //wypis ktora to strona z ilu
            lbHowMuchOf.Text = (ewiBindingSource.Position + 1).ToString() + " z " + ewiBindingSource.Count.ToString();
            //jesli jest karta urzadzenia pokazanie przycisku jesli nie schowanie
            if (ewidencjaDataSet.Tables[0].Rows[ewiBindingSource.Position][25].ToString() == "") bSettings.Visible = false;
            else bSettings.Visible = true;
            //uzupełnianie comboboxow
            comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
            comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
            comboBoxBudynek.SelectedItem = budynekTextBox.Text;
            comboBoxPietro.SelectedItem = pietroTextBox.Text;
            comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
            comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;
            GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
        }

        private void btMoveFirst_Click(object sender, EventArgs e)
        {
            //przesuniecie do pierwszej strony
            ewiBindingSource.MoveFirst();
            //ustawienie biezacej strony w combo wyboru strony
            comboBoxWhatItem.SelectedIndex = ewiBindingSource.Position;
            //wypis ktora to strona z ilu
            lbHowMuchOf.Text = (ewiBindingSource.Position + 1).ToString() + " z " + ewiBindingSource.Count.ToString();
            //jesli jest karta urzadzenia pokazanie przycisku jesli nie schowanie
            if (ewidencjaDataSet.Tables[0].Rows[ewiBindingSource.Position][25].ToString() == "") bSettings.Visible = false;
            else bSettings.Visible = true;
            //uzupełnianie comboboxow
            comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
            comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
            comboBoxBudynek.SelectedItem = budynekTextBox.Text;
            comboBoxPietro.SelectedItem = pietroTextBox.Text;
            comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
            comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;
            GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
        }

        private void comboBoxWhatItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //przesuniecie karty na wskazana pozycje w comboboxie wyboru strony
            ewiBindingSource.Position = comboBoxWhatItem.SelectedIndex;//ewiBindingSource.Find("Id", iIDnumber);
            //wypis ktora to strona z ilu
            lbHowMuchOf.Text = (ewiBindingSource.Position + 1).ToString() + " z " + ewiBindingSource.Count.ToString();
            //jesli jest karta urzadzenia pokazanie przycisku jesli nie schowanie
            if (ewidencjaDataSet.Tables[0].Rows[ewiBindingSource.Position][25].ToString() == "") bSettings.Visible = false;
            else bSettings.Visible = true;
            //uzupełnianie comboboxow
            comboBoxRodzajSprzetu.SelectedItem = rodzaj_sprzętuTextBox.Text;
            comboBoxRodzajEwidencji.SelectedItem = rodzaj_ewidencjiTextBox.Text;
            comboBoxBudynek.SelectedItem = budynekTextBox.Text;
            comboBoxPietro.SelectedItem = pietroTextBox.Text;
            comboBoxPomieszczenie.SelectedItem = pomieszczenieTextBox.Text;
            comboBoxInformatykaLacznosc.SelectedItem = informatyka_LacznoscTextBox.Text;
            GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text, comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
        }

        private void comboBoxPietro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bOnlyLook == false)
            {
                //czyszczenie combosa
                comboBoxPomieszczenie.Items.Clear();
                //właczenie enabled
                comboBoxPomieszczenie.Enabled = true;
                //widoczny button do dodawania itemow do pomieszczenia
                btAddPomieszczenie.Visible = true;
                //uzupełnianie combosa
                connectData.CompleteRoomII(comboBoxPietro, comboBoxPomieszczenie);
            }
        }

        private void comboBoxPomieszczenie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBudynek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bOnlyLook == false)
            {
                //po zmianie enabled podrzednych na false
                comboBoxPietro.Enabled = false;
                comboBoxPomieszczenie.Enabled = false;
                //niewidoczne buttony do podrzednych combosow do dodawania itemow po zmianie wartosci
                btAddPietro.Visible = false;
                btAddPomieszczenie.Visible = false;
                //czyszczenie po zmianie combosow podrzednych
                comboBoxPietro.Items.Clear();
                comboBoxPomieszczenie.Items.Clear();
                //podrzedny o jeden stopien nizej enabled true
                comboBoxPietro.Enabled = true;
                //widoczny button do dodawania nowych pieter
                btAddPietro.Visible = true;
                //uzupełnienie combosów o wybor itemów
                connectData.CompleteFloorII(comboBoxBudynek, comboBoxPietro);
            }
        }

        private void checkBoxCreateCard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            GenerateReportOfDevice();
        }
        
        //drukowanie raportu zwykłego urzadzenia
        public void GenerateReportOfDevice()
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = idTextBox.Text;
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
            Document document = new Document(PageSize.A4.Rotate(), 50, 50, 50, 50);
            //ustawienia czcionek
            var bigFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 18);
            var normalBigFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 14);
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
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Id: ", normalBigFont), 400, 525, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(idTextBox.Text, normalBigFont), 420, 525, 0);

                //lewa strona
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Nr ewidencyjny: ", normalBigFont), 75, 500, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(nr_ewidencyjnyTextBox.Text, normalBigFont), 225, 500, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Rodzaj sprzętu: ", normalBigFont), 75, 475, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(rodzaj_sprzętuTextBox.Text, normalBigFont), 225, 475, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Producent i model: ", normalBigFont), 75, 450, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(nazwa_ProducentTextBox.Text, normalBigFont), 225, 450, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Rok produkcji: ", normalBigFont), 75, 425, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(rok_produkcjiTextBox.Text, normalBigFont), 225, 425, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Termin gwaracnji: ", normalBigFont), 75, 400, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(termin_gwarancjiTextBox.Text, normalBigFont), 225, 400, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Nr seryjny: ", normalBigFont), 75, 375, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(nr_seryjnyTextBox.Text, normalBigFont), 225, 375, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Wartość zakupu: ", normalBigFont), 75, 350, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(wartosc_zakupuTextBox.Text, normalBigFont), 225, 350, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Nr faktury: ", normalBigFont), 75, 325, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(nr_fakturyTextBox.Text, normalBigFont), 225, 325, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Rodzaj ewidencji: ", normalBigFont), 75, 300, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(rodzaj_ewidencjiTextBox.Text, normalBigFont), 225, 300, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Mac adres: ", normalBigFont), 75, 275, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(mac_adresTextBox.Text, normalBigFont), 225, 275, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("IP adres1: ", normalBigFont), 75, 250, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(iP_adres1TextBox.Text, normalBigFont), 225, 250, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("IP adres2: ", normalBigFont), 75, 225, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(iP_adres2TextBox.Text, normalBigFont), 225, 225, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("IP adres3: ", normalBigFont), 75, 200, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(iP_adres3TextBox.Text, normalBigFont), 225, 200, 0);

                //prawa strona
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("System operacyjny: ", normalBigFont), 425, 500, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(system_operacyjnyTextBox1.Text, normalBigFont), 575, 500, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Karta grafiki1: ", normalBigFont), 425, 475, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(karta_grafiki1TextBox.Text, normalBigFont), 575, 475, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Karta grafiki2: ", normalBigFont), 425, 450, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(karta_grafiki2TextBox.Text, normalBigFont), 575, 450, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Procesor: ", normalBigFont), 425, 425, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(procesorTextBox.Text, normalBigFont), 575, 425, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Ram: ", normalBigFont), 425, 400, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(ramTextBox.Text, normalBigFont), 575, 400, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Dysk1: ", normalBigFont), 425, 375, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(dysk1TextBox.Text, normalBigFont), 575, 375, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Dysk2: ", normalBigFont), 425, 350, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(dysk2TextBox.Text, normalBigFont), 575, 350, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Nr karty: ", normalBigFont), 425, 325, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(numer_kartyTextBox1.Text, normalBigFont), 575, 325, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Budynek: ", normalBigFont), 425, 300, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(budynekTextBox.Text, normalBigFont), 575, 300, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Piętro: ", normalBigFont), 425, 275, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(pietroTextBox.Text, normalBigFont), 575, 275, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Pomieszczenie: ", normalBigFont), 425, 250, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(pomieszczenieTextBox.Text, normalBigFont), 575, 250, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Informatyka\\Łączność: ", normalBigFont), 425, 225, 0);
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase(informatyka_LacznoscTextBox.Text, normalBigFont), 575, 225, 0);

                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("Uwagi: ", normalBigFont), 425, 200, 0);
                //ColumnText.ShowTextAligned(writer.DirectContent,
                //Element.ALIGN_LEFT, new Phrase(uwagiTextBox.Text, normalBigFont), 575, 200, 0);
                ColumnText ct = new ColumnText(writer.DirectContent);
                ct.SetSimpleColumn(new iTextSharp.text.Rectangle(575, 220, 800, 75));
                ct.AddElement(new Paragraph(uwagiTextBox.Text, normalBigFont));
                ct.Go();

                //qrcode
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_LEFT, new Phrase("QRCode:", bigFont), 110, 120, 0);
                iTextSharp.text.Image qr = iTextSharp.text.Image.GetInstance(pbQRCode.BackgroundImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                qr.ScaleAbsolute(100, 100);
                qr.SetAbsolutePosition(200, 75);
                document.Add(qr);

                //dolne wpisy
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Wydruk wygenerowany z EwiInf dla Aresztu Śledczego w Łodzi " + DateTime.Now.ToString(), normalFont), 250, 60, 0);
                //koniec wydruku

                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
        }

        private void pbQRCode_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (pbQRCode.BackgroundImage != null) PrintQRCode.Visible = true;
            else PrintQRCode.Visible = false;
        }

        private void PrintQRCode_Click(object sender, EventArgs e)
        {
            
            foreach (Control c in Controls)
            {
                //if(c.Name!= "btPrintThisQR")//&& c.Name != "btBackPrintThisQr")
                c.Enabled = false;
            }
            panelChoiceWherePrint.Visible = true;
            panelChoiceWherePrint.BringToFront();
            panelChoiceWherePrint.Enabled = true;
            //btPrintThisQR.Enabled = true;
            //btBackPrintThisQr.Enabled = true;
            rb1.Checked = true;
        }

        private void btBackPrintThisQr_Click(object sender, EventArgs e)
        {
            panelChoiceWherePrint.Visible = false;
            if(bOnlyLook==true)
            {
                bSave.Visible = false;
                bCancel.Enabled = true;
                bSettings.Enabled = true;
                panelSteer.Visible = true;
                panelSteer.Enabled = true;
                PrintQRCode.Enabled = true;
                label1.Visible = false;
                checkBoxCreateCard.Visible = false;
                if (ewidencjaDataSet.Tables[0].Rows[0][25].ToString() == "") bSettings.Visible = false;
                else bSettings.Visible = true;
                btPrint.Visible = true;
                btPrint.Enabled = true;
            }
            else
            {
                foreach (Control c in Controls)
                {
                    c.Enabled = true;
                }
            }
        }

        private void btPrintThisQR_Click(object sender, EventArgs e)
        {
            panelChoiceWherePrint.Visible = false;
            if (bOnlyLook == true)
            {
                bSave.Visible = false;
                bCancel.Enabled = true;
                bSettings.Enabled = true;
                panelSteer.Visible = true;
                panelSteer.Enabled = true;
                PrintQRCode.Enabled = true;
                label1.Visible = false;
                checkBoxCreateCard.Visible = false;
                if (ewidencjaDataSet.Tables[0].Rows[0][25].ToString() == "") bSettings.Visible = false;
                else bSettings.Visible = true;
                btPrint.Visible = true;
                btPrint.Enabled = true;
            }
            else
            {
                foreach (Control c in Controls)
                {
                    c.Enabled = true;
                }
            }
            foreach (Control r in panelChoiceWherePrint.Controls)
            {
                if (r is RadioButton)
                {
                    if((r as RadioButton).Checked==true) PrintThisQrThere(r as RadioButton);
                }
            }
            
        }

        //drukowanie qr i ewidencyjny numer we wskazanym miejscy
        private void PrintThisQrThere(RadioButton r)
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = "Naklejka";
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
                //wyciecie z radiobuttonów tylko liczb z nazy
                string rb = r.Name.Substring(2);
                //int trzymający liczbę który radiobutton został wybrany
                int irb = Convert.ToInt32(rb);
                //druga linia radiobutonów
                if (irb > 3 && irb < 7)
                {
                    yPoz = 800 - 150;
                    yPio = 800 - 150;
                    xPoz = 45;
                    xPio = 45;
                    irb = irb - 3;
                }
                //trzecia linia radiobutonow
                if (irb > 6 && irb < 10)
                {
                    yPoz = 800 - 150*2;
                    yPio = 800 - 150*2;
                    xPoz = 45;
                    xPio = 45;
                    irb = irb - 6;
                }
                //czwarta linia radiobutonow
                if (irb > 9 && irb < 13)
                {
                    yPoz = 800 - 150 * 3;
                    yPio = 800 - 150 * 3;
                    xPoz = 45;
                    xPio = 45;
                    irb = irb - 9;
                }
                //piąta linia radiobuttonow
                if (irb > 12 && irb < 16)
                {
                    yPoz = 800 - 150 * 4;
                    yPio = 800 - 150 * 4;
                    xPoz = 45;
                    xPio = 45;
                    irb = irb - 12;
                }

                //linia pozioma
                cb.SetLineWidth(1);
                cb.MoveTo(xPoz + 170 * (irb - 1), yPoz);
                cb.LineTo(xPoz + 170 * irb, yPoz);
                cb.Stroke();

                cb.SetLineWidth(1);
                cb.MoveTo(xPoz + 170 * (irb - 1), yPoz - 150);
                cb.LineTo(xPoz + 170 * irb, yPoz - 150);
                cb.Stroke();

                //linia pionowa
                cb.SetLineWidth(1);
                cb.MoveTo(xPio + 170 * (irb - 1), yPio);
                cb.LineTo(xPio + 170 * (irb - 1), yPio - 150);
                cb.Stroke();

                cb.SetLineWidth(1);
                cb.MoveTo(xPio + 170 + 170 * (irb - 1), yPio);
                cb.LineTo(xPio + 170 + 170 * (irb - 1), yPio - 150);
                cb.Stroke();

                //numer ewidencyjny
                s = nr_ewidencyjnyTextBox.Text.Trim();
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase(s, normalBoldFont), (xPoz + 170 * (irb - 1)) + (170 / 2), yPoz - 20, 0);

                //qrcode
                GenerateQR(nr_ewidencyjnyTextBox.Text, nazwa_ProducentTextBox.Text,
                           comboBoxRodzajEwidencji.Text, comboBoxInformatykaLacznosc.Text, index_finansowyTextBox.Text);
                iTextSharp.text.Image qr = iTextSharp.text.Image.GetInstance(pbQRCode.BackgroundImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                qr.ScaleAbsolute(100, 100);
                qr.SetAbsolutePosition(xPoz + 35 + 170 * (irb - 1), yPoz - 140);
                document.Add(qr);

                //cienka pozioma linia
                cb.SetLineWidth(0.25);
                cb.MoveTo(xPoz + 170 * (irb - 1), yPoz - 30);
                cb.LineTo(xPoz + 170 * irb, yPoz - 30);
                cb.Stroke();
            }

                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
    }
}
