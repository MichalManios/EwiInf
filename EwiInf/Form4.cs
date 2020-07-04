using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Form4 : Form
    {
        Form2 _owner2;
        Form1 _owner1;
        bool bNew = false;
        bool bEdit = false;
        string sNumerKarty = "";
        string sNazwaUrzadzenia = "";
        string sNumerSeryjny = "";
        string sGdzie = "";
        CardConectAndModify cardConection = new CardConectAndModify();
        CardConservation cardConservation = new CardConservation();
        CardConservation cardRepair = new CardConservation();
        CardConservation card = new CardConservation();

        //zmienna edycja czy zapis btSaveServices
        bool bEditOrSave = false;
        //zmienna edycja czy zapis bSaveRepair
        bool bEditOrSave2 = false;
        //zmienna naprawa zapis czy edycja
        bool bSaveRepairs = false;
        //zmienna konserwacja zapis czy edycja
        bool bSaveConservation = false;
        //zmienna tylko przegladanie kart
        bool bLook = false;
        //zmienna do obsługi karty gdy zmieniła się na urzadzeniu lokalizacja
        bool bChangeLocalization = false;
        //edycja karty urzadzenia pierwsza zakładka
        bool bEditCard = false;

        //tylko przegladanie
        public Form4(Form1 owner, bool bLook, string ConnectionString)
        {
            InitializeComponent();
            _owner1 = owner;
            cardConection.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            cardConservation.ConnectionString(ConnectionString);
            cardRepair.ConnectionString(ConnectionString);
            this.bLook = bLook;

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);

        }
        //zmiana lokalizacji w danych
        public Form4(Form2 owner, bool bEdit, bool bChangeLocalization, string sNumerKarty, string sGdzie, string ConnectionString)
        {
            InitializeComponent();
            _owner2 = owner;
            this.bEdit=bEdit;
            this.bChangeLocalization = bChangeLocalization;
            this.sNumerKarty = sNumerKarty;
            this.sGdzie = sGdzie;
            cardConection.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            cardConservation.ConnectionString(ConnectionString);
            cardRepair.ConnectionString(ConnectionString);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);

        }
        //edycja karty
        public Form4(Form2 owner, bool bEdit, string sNumerKarty, string ConnectionString)
        {
            InitializeComponent();
            _owner2 = owner;
            this.bEdit = bEdit;
            this.sNumerKarty = sNumerKarty;
            cardConection.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            cardConservation.ConnectionString(ConnectionString);
            cardRepair.ConnectionString(ConnectionString);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);

        }
        //nowa karta
        public Form4(Form2 owner, bool bNew, string sNumerKarty, string sNazwaUrzadzenia, string sNumerSeryjny, string sGdzie, string ConnectionString)
        {
            InitializeComponent();
            _owner2 = owner;
            this.sNumerKarty = sNumerKarty;
            this.sNazwaUrzadzenia = sNazwaUrzadzenia;
            this.sGdzie = sGdzie;
            this.bNew = bNew;
            this.sNumerSeryjny = sNumerSeryjny;
            cardConection.ConnectionString(ConnectionString);
            card.ConnectionString(ConnectionString);
            cardConservation.ConnectionString(ConnectionString);
            cardRepair.ConnectionString(ConnectionString);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
        }
        //standardowy konstruktor
        public Form4()
        {
            InitializeComponent();
        }
        //funkcja readonly
        private void CardReadOnly(bool bBool, bool bEditCard)
        {
            //zakładka karta
            marka_urzadzeniaTextBox.ReadOnly = bBool;
            model_urzadzeniaTextBox.ReadOnly = bBool;
            data_zakupuTextBox.ReadOnly = bBool;
            data_oddania_do_eksploatacjiTextBox.ReadOnly = bBool;
            dodatkowe_akcesoriaTextBox.ReadOnly = bBool;
            uzytkownikTextBox.ReadOnly = bBool;
            uzytkownik2TextBox.ReadOnly = bBool;
            uzytkownik3TextBox.ReadOnly = bBool;
            uzytkownik4TextBox.ReadOnly = bBool;
            od_kiedyTextBox.ReadOnly = bBool;
            od_kiedy2TextBox.ReadOnly = bBool;
            od_kiedy3TextBox.ReadOnly = bBool;
            od_kiedy4TextBox.ReadOnly = bBool;
            if (bEditCard == false)
            {
                //karta naprawy
                dataTextBox.ReadOnly = bBool;
                rodzaj_naprawyTextBox.ReadOnly = bBool;
                data_oddania_do_naprawyTextBox.ReadOnly = bBool;
                data_odbioru_z_naprawyTextBox.ReadOnly = bBool;
                koszt_naprawyTextBox.ReadOnly = bBool;
                podpis_nadzorujacego_napraweTextBox.ReadOnly = bBool;
                //karta konserwacji
                dataTextBox1.ReadOnly = bBool;
                opis_wykonywanej_czynnosciTextBox.ReadOnly = bBool;
                czas_konserwacjiTextBox.ReadOnly = bBool;
                wykonawcaTextBox.ReadOnly = bBool;
                podpis_uzytkownika_urzadzeniaTextBox.ReadOnly = bBool;
                uwagi_dotyczace_pracy_urzadzeniaTextBox.ReadOnly = bBool;
            }
        }

        //funkcja dajaca miejsce do wpisu nowego uzytkownika gdy chcemy dodac nowego a wszystkie 4 pola juz sa uzyte
        private void NewUserWhenAllFieldsFull(bool bChangeLocalization)
        {
            string[] sUzytkownik = new string[3];
            string[] sGdzie = new string[3];
            string[] sOdKiedy = new string[3];

            sUzytkownik[0] = uzytkownik2TextBox.Text;
            sUzytkownik[1] = uzytkownik3TextBox.Text;
            sUzytkownik[2] = uzytkownik4TextBox.Text;

            sGdzie[0] = gdzie2TextBox.Text;
            sGdzie[1] = gdzie3TextBox.Text;
            sGdzie[2] = gdzie4TextBox.Text;

            sOdKiedy[0] = od_kiedy2TextBox.Text;
            sOdKiedy[1] = od_kiedy3TextBox.Text;
            sOdKiedy[2] = od_kiedy4TextBox.Text;

            uzytkownikTextBox.Text = sUzytkownik[0];
            uzytkownik2TextBox.Text = sUzytkownik[1];
            uzytkownik3TextBox.Text = sUzytkownik[2];
            uzytkownik4TextBox.Text = "";
            uzytkownik4TextBox.ReadOnly = false;
            uzytkownik4TextBox.Focus();

            gdzieTextBox.Text = sGdzie[0];
            gdzie2TextBox.Text = sGdzie[1];
            gdzie3TextBox.Text = sGdzie[2];
            gdzie4TextBox.Text = "";
            gdzie4TextBox.Text = this.sGdzie;

            od_kiedyTextBox.Text = sOdKiedy[0];
            od_kiedy2TextBox.Text = sOdKiedy[1];
            od_kiedy3TextBox.Text = sOdKiedy[2];
            od_kiedy4TextBox.Text = "";
            od_kiedy4TextBox.ReadOnly = false;

            if (bChangeLocalization == true)
            {
                uzytkownik4TextBox.BackColor = Color.Red;
                od_kiedy4TextBox.BackColor = Color.Red;
            }

        }
        //funkcja sprawdzajaca czy wszystkie pola uzytkownika sa zapełnione
        private void AddUserInCardVisible()
        {
            if (uzytkownikTextBox.Text != "" && uzytkownik2TextBox.Text != "" && uzytkownik3TextBox.Text != "" && uzytkownik4TextBox.Text != "") btAddUserInCard.Visible = true;
        }

        //funkcja zmieniajaca readonly
        private void RepairReadOnly(bool bBool)
        {
            dataTextBox.ReadOnly = bBool;
            rodzaj_naprawyTextBox.ReadOnly = bBool;
            data_oddania_do_naprawyTextBox.ReadOnly = bBool;
            data_odbioru_z_naprawyTextBox.ReadOnly = bBool;
            koszt_naprawyTextBox.ReadOnly = bBool;
            podpis_nadzorujacego_napraweTextBox.ReadOnly = bBool;
        }
        //funkcja zmieniajaca readonly
        private void ConservationReadOnly(bool bBool)
        {
            dataTextBox1.ReadOnly = bBool;
            opis_wykonywanej_czynnosciTextBox.ReadOnly = bBool;
            czas_konserwacjiTextBox.ReadOnly = bBool;
            wykonawcaTextBox.ReadOnly = bBool;
            //podpis_uzytkownika_urzadzeniaTextBox.ReadOnly = bBool;
            uwagi_dotyczace_pracy_urzadzeniaTextBox.ReadOnly = bBool;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //klasa odpowiadajaca za wyglad tabel
            LookDataGridView LookTable = new LookDataGridView();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet1.Karta_konserwacja' . Możesz go przenieść lub usunąć.
            this.karta_konserwacjaTableAdapter.Fill(this.ewidencjaDataSet.Karta_konserwacja);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Karta_naprawy' . Możesz go przenieść lub usunąć.
            this.karta_naprawyTableAdapter.Fill(this.ewidencjaDataSet.Karta_naprawy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Karta' . Możesz go przenieść lub usunąć.
            this.kartaTableAdapter.Fill(this.ewidencjaDataSet.Karta);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
            this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);
            //formatowanie wygladu tabel
            LookTable.FormatDataGrid(dataGridView1);
            LookTable.FormatDataGrid(dataGridView2);

            //sczytanie ilości rekorów w karcie naprawy
            cardRepair.IHowMuchRecordsInRepair = ewidencjaDataSet.Karta_naprawy.Rows.Count;
            //sczytanie ilości rekordów w karcie konserwacja
            cardConservation.IHowMuchRecordsInConservation = ewidencjaDataSet.Karta_konserwacja.Rows.Count;

            //wypełnienie karty danymi pierwszej karty i nie mozna edytowac tylko przegladanie kart
            if(bLook==true)
            {
                //refresh danych w bazie karta
                card.RefreshBase(ewidencjaDataSet, "Karta");
                card.RefreshBase(ewidencjaDataSet, "Karta_konserwacja");
                card.RefreshBase(ewidencjaDataSet, "Karta_naprawy");
                //wyswietlenie danych zwiazanych z szukana karta numerem
                kartaBindingSource.MoveFirst();
                //tylko odczyt danych w komorkach
                CardReadOnly(true, false);
                ConservationReadOnly(true);
                RepairReadOnly(true);
                //przyciski widoczne i niewidoczne
                panelSteer.Visible = true;
                btBack.Visible = true;
                bSave.Visible = false;
                btEdit.Visible = false;
                bAddRepair.Visible = false;
                bSaveRepair.Visible = false;
                btAddServices.Visible = false;
                btSaveServices.Visible = false;

                tbFindCard.ReadOnly = false;

                if (ewidencjaDataSet.Karta.Rows.Count > 0)
                {
                    lbHowMuchOf.Text = "1 z " + ewidencjaDataSet.Karta.Rows.Count;
                    //uzupełnianie comboboxow z bazy danych by można było wybrać z tych grup co już są zapisane
                    for (int i = 0; i < ewidencjaDataSet.Karta.Rows.Count; i++)
                    {
                        comboBoxWhatItem.Items.Add(i + 1);
                    }
                    comboBoxWhatItem.SelectedIndex = 0;
                }
            }

            //wypełnienie karty danymi przy wyborze edytuj
            if (bEdit==true)
            {
                
                //refresh danych w bazie karta
                card.RefreshBase(ewidencjaDataSet, "Karta");
                card.RefreshBase(ewidencjaDataSet, "Karta_konserwacja");
                card.RefreshBase(ewidencjaDataSet, "Karta_naprawy");
                //wyswietlenie danych zwiazanych z szukana karta numerem
                kartaBindingSource.Position = kartaBindingSource.Find("Nr_karty", sNumerKarty);
                //tylko odczyt danych w komorkach
                CardReadOnly(true, false);
            }
            //obsługa włączenia karty gdy zmieniła się lokalizacja
            if(bChangeLocalization==true)
            {
                MessageBox.Show("Zmieniono lokalizację sprzętu. Musisz wprowadzić aktualizację w karcie urządzenia!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //tylko odczyt danych w komorkach
                CardReadOnly(true, false);
                ConservationReadOnly(true);
                RepairReadOnly(true);
                //przyciski widoczne i niewidoczne
                bSave.Visible = true;
                btBack.Visible = false;
                btEdit.Visible = false;
                bAddRepair.Visible = false;
                bSaveRepair.Visible = false;
                btAddServices.Visible = false;
                btSaveServices.Visible = false;
                //podswietlenie na czerwono i mozliwosc edycji tylko pol dotyczacych zmiany lokalizacji
                if(gdzieTextBox.Text=="")
                {
                    gdzieTextBox.Text = sGdzie;
                    uzytkownikTextBox.ReadOnly = false;
                    uzytkownikTextBox.BackColor = Color.Red;
                    od_kiedyTextBox.ReadOnly = false;
                    od_kiedyTextBox.BackColor = Color.Red;
                    uzytkownikTextBox.Focus();
                }
                else if (gdzie2TextBox.Text == "")
                {
                    gdzie2TextBox.Text = sGdzie;
                    uzytkownik2TextBox.ReadOnly = false;
                    uzytkownik2TextBox.BackColor = Color.Red;
                    od_kiedy2TextBox.ReadOnly = false;
                    od_kiedy2TextBox.BackColor = Color.Red;
                    uzytkownik2TextBox.Focus();
                }
                else if (gdzie3TextBox.Text == "")
                {
                    gdzie3TextBox.Text = sGdzie;
                    uzytkownik3TextBox.ReadOnly = false;
                    uzytkownik3TextBox.BackColor = Color.Red;
                    od_kiedy3TextBox.ReadOnly = false;
                    od_kiedy3TextBox.BackColor = Color.Red;
                    uzytkownik3TextBox.Focus();
                }
                else if (gdzie4TextBox.Text == "")
                {
                    gdzie4TextBox.Text = sGdzie;
                    uzytkownik4TextBox.ReadOnly = false;
                    uzytkownik4TextBox.BackColor = Color.Red;
                    od_kiedy4TextBox.ReadOnly = false;
                    
                    uzytkownik4TextBox.Focus();
                }
                //przypadek gdy wszystkie pola zajęte i potrzeba nowego
                else
                {
                    NewUserWhenAllFieldsFull(bChangeLocalization);
                    
                }
            }

            //wypełnienie uwag w konserwacyjnej zakładce
            if (bNew == false)
            {
                tbCardNumber.Text = nr_kartyTextBox.Text;
                if (dataGridView2.Rows.Count > 0)
                {

                    //uzupełnienie tabeli danymi tylko zwiazanymi z dana karta urzadzenia jesli sa
                    cardConservation.FindInBase(ewidencjaDataSet, nr_kartyTextBox, "Karta_konserwacja");

                    //numerowanie lp w tabeli
                    if (dataGridView2.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {  
                            dataGridView2.Rows[i].Cells["Column1"].Value = i + 1;
                        }
                    }
                    
                    //jeśli sa rekordy
                    if (dataGridView2.Rows.Count > 0)
                    {
                        btSaveServices.Visible = true;
                        toolTip1.SetToolTip(btSaveServices, "Modyfikuj wybrany rekord");
                        btSaveServices.BackgroundImage = Properties.Resources._5891647491535351484_64;
                        tbWarning.Text = "";
                        for (int i = 0; i < ewidencjaDataSet.Karta_konserwacja.Rows.Count; i++)
                        {
                            if(tbWarning.Text=="") tbWarning.Text = ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                            else tbWarning.Text = tbWarning.Text + Environment.NewLine + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                        }
                    }
                    else
                    {
                        btSaveServices.Visible = false;
                        tbWarning.Text = "";
                    }
                }
            }
            //wypełnienie uwag w naprawy zakładce
            if (bNew == false)
            {
                tbNumberCard.Text = nr_kartyTextBox.Text;
                if (dataGridView1.Rows.Count>0)
                {
                    
                    //uzupełnienie tabeli danymi tylko zwiazanymi z dana karta urzadzenia jesli sa
                    cardRepair.FindInBase(ewidencjaDataSet, nr_kartyTextBox, "Karta_naprawy");
                    //numerowanie lp w tabeli
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells["Lp"].Value = i + 1;
                        }
                    }
                    //jesli sa rekordy
                    if (dataGridView1.Rows.Count > 0)
                    {
                        bSaveRepair.Visible = true;
                        toolTip1.SetToolTip(bSaveRepair, "Modyfikuj wybrany rekord");
                        bSaveRepair.BackgroundImage = Properties.Resources._5891647491535351484_64;
                    }
                    else
                    {
                        bSaveRepair.Visible = false;
                    }
                }
            }
            if (bNew==true)
            {
                //reset pól by były puste i uzupełnienie potrzebnych reszta dla uzytkownika
                ewidencjaDataSet.Clear();
                //uzupełnienie danych z bazy
                nr_kartyTextBox.Text = sNumerKarty;
                tbNumberCard.Text = sNumerKarty;
                tbCardNumber.Text = sNumerKarty;
                nazwa_urzadzeniaTextBox.Text = sNazwaUrzadzenia;
                numer_seryjnyTextBox.Text = sNumerSeryjny;
                gdzieTextBox.Text = sGdzie;
                data_zalozeniaTextBox.Text = DateTime.Today.ToShortDateString();
                zalozycielTextBox.Text = Environment.UserName;
                //piersza zakładka
                bSave.Visible = true;
                bSave.Enabled = true;
                btBack.Visible = false;
                btEdit.Visible = false;
                nr_kartyTextBox.ReadOnly = true;
                nazwa_urzadzeniaTextBox.ReadOnly = true;
                data_zalozeniaTextBox.ReadOnly = true;
                zalozycielTextBox.ReadOnly = true;
                tbNumberCard.ReadOnly = true;
                tbCardNumber.ReadOnly = true;
                tbWarning.ReadOnly = true;
                //naprawy
                RepairReadOnly(true);
                //konserwacja
                ConservationReadOnly(true);
                //uzupełnienie tabeli karta naprawy
                cardRepair.FindInBase(ewidencjaDataSet, nr_kartyTextBox, "Karta_naprawy");
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells["Lp"].Value = i + 1;
                    }
                }
                //uzupełnienie tabeli karta konserwacji
                cardConservation.FindInBase(ewidencjaDataSet, nr_kartyTextBox, "Karta_konserwacja");
                if (dataGridView2.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        dataGridView2.Rows[i].Cells["Column1"].Value = i + 1;
                    }
                }
                tbWarning.Text = "";
                for (int i = 0; i < ewidencjaDataSet.Karta_konserwacja.Rows.Count; i++)
                {
                    if (tbWarning.Text == "") tbWarning.Text = ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                    else tbWarning.Text = tbWarning.Text + Environment.NewLine + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                }
            }
            
        }

        

        private void kartaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kartaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ewidencjaDataSet);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bLook==false) _owner2.Close();
            if (bLook == true) _owner1.Show();
        }

        private void bAddRepair_Click(object sender, EventArgs e)
        {
            
                toolTip1.SetToolTip(bSaveRepair, "Zapisz wpis o konserwacji");
                bSaveRepair.BackgroundImage = Properties.Resources._16755934531579697357_64;

                dataTextBox.Text = "";
                rodzaj_naprawyTextBox.Text = "";
                data_oddania_do_naprawyTextBox.Text = "";
                data_odbioru_z_naprawyTextBox.Text = "";
                koszt_naprawyTextBox.Text = "";
                podpis_nadzorujacego_napraweTextBox.Text = "";
                RepairReadOnly(false);
                bAddRepair.Visible = false;
                bSaveRepair.Visible = true;
                bEditOrSave2 = false;
                bSaveRepairs = true;
            
        }

        private void btAddServices_Click(object sender, EventArgs e)
        {

                if (uzytkownik4TextBox.Text != "") podpis_uzytkownika_urzadzeniaTextBox.Text = uzytkownik4TextBox.Text;
                if (uzytkownik3TextBox.Text != "") podpis_uzytkownika_urzadzeniaTextBox.Text = uzytkownik3TextBox.Text;
                if (uzytkownik2TextBox.Text != "") podpis_uzytkownika_urzadzeniaTextBox.Text = uzytkownik2TextBox.Text;
                if (uzytkownikTextBox.Text != "") podpis_uzytkownika_urzadzeniaTextBox.Text = uzytkownikTextBox.Text;

                toolTip1.SetToolTip(btSaveServices, "Zapisz wpis o konserwacji");
                btSaveServices.BackgroundImage = Properties.Resources._16755934531579697357_64;

                dataTextBox1.Text = "";
                opis_wykonywanej_czynnosciTextBox.Text = "";
                czas_konserwacjiTextBox.Text = "";
                wykonawcaTextBox.Text = "";

                uwagi_dotyczace_pracy_urzadzeniaTextBox.Text = "";
                ConservationReadOnly(false);
                btAddServices.Visible = false;
                btSaveServices.Visible = true;
                bEditOrSave = false;
                bSaveConservation = true;
            
        }

        private void btSaveServices_Click(object sender, EventArgs e)
        {

            if (bSaveConservation == true)
            {
                //zapis do bazy
                if (dataTextBox1.Text == "" || opis_wykonywanej_czynnosciTextBox.Text == "" || podpis_uzytkownika_urzadzeniaTextBox.Text == "")
                {
                    MessageBox.Show("Nie wszystkie wymagane pola do zapisu są wypełnione. Uzupełnij zaznaczone pole/pola aby zapisać dane!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dataTextBox1.Text == "") dataTextBox1.BackColor = Color.Red;
                    if (opis_wykonywanej_czynnosciTextBox.Text == "") opis_wykonywanej_czynnosciTextBox.BackColor = Color.Red;
                    if (podpis_uzytkownika_urzadzeniaTextBox.Text == "") podpis_uzytkownika_urzadzeniaTextBox.BackColor = Color.Red;
                }
                else
                {
                    
                    if (bEditOrSave == false)
                    {
                        lp_TextBox1.Text = cardConservation.IHowMuchRecordsInConservation.ToString();//iLp.ToString();
                                                                                                     //zapis nowego rekordu
                                                                                                     //zapis nowego rekordu
                        cardConservation.SaveData(nr_kartyTextBox, lp_TextBox1, dataTextBox1, opis_wykonywanej_czynnosciTextBox,
                            czas_konserwacjiTextBox, wykonawcaTextBox, podpis_uzytkownika_urzadzeniaTextBox, uwagi_dotyczace_pracy_urzadzeniaTextBox, "Karta_konserwacja");
                        cardConservation.FindInBase(ewidencjaDataSet, tbCardNumber, "Karta_konserwacja");

                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            dataGridView2.Rows[i].Cells["Column1"].Value = i + 1;
                        }
                        tbWarning.Text = "";
                        for (int i = 0; i < ewidencjaDataSet.Karta_konserwacja.Rows.Count; i++)
                        {
                            if (tbWarning.Text == "") tbWarning.Text = ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                            else tbWarning.Text = tbWarning.Text + Environment.NewLine + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                        }
                        bEditOrSave = true;
                    }
                    else if (bEditOrSave == true)
                    {

                       
                        //edycja rekordu
                        
                        cardConservation.ModifyDataConservation(nr_kartyTextBox, lp_TextBox1, dataTextBox1, opis_wykonywanej_czynnosciTextBox,
                                czas_konserwacjiTextBox, wykonawcaTextBox, podpis_uzytkownika_urzadzeniaTextBox, uwagi_dotyczace_pracy_urzadzeniaTextBox);
                        
                        cardConservation.FindInBase(ewidencjaDataSet, tbCardNumber, "Karta_konserwacja");
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            dataGridView2.Rows[i].Cells["Column1"].Value = i + 1;
                        }
                        tbWarning.Text = "";
                        for (int i = 0; i < ewidencjaDataSet.Karta_konserwacja.Rows.Count; i++)
                        {
                            if (tbWarning.Text == "") tbWarning.Text = ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                            else tbWarning.Text = tbWarning.Text + Environment.NewLine + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                        }
                        bEditOrSave = false;
                    }
                    ConservationReadOnly(true);
                    btAddServices.Visible = true;
                    btSaveServices.Visible = true;
                    //czyszczenie wypełnienia i koloru na normalny
                    foreach (Control item in tabControl1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.BackColor = tbCardNumber.BackColor;
                            item.Text = "";
                        }
                    }
                }
                toolTip1.SetToolTip(btSaveServices, "Modyfikuj wybrany rekord");
                btSaveServices.BackgroundImage = Properties.Resources._5891647491535351484_64;
                bSaveConservation = false;
            }
            else if (bSaveConservation == false)
            {
                toolTip1.SetToolTip(btSaveServices, "Zapisz wpis o konserwacji");
                btSaveServices.BackgroundImage = Properties.Resources._16755934531579697357_64;

                ConservationReadOnly(false);
                btAddServices.Visible = false;
                btSaveServices.Visible = true;
                //zmienna edycja czy zapis btSaveServices
                bEditOrSave = true;
                bSaveConservation = true;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //zapis danych w nowej karcie
            if (bNew == true)
            {
                bool bEmptyTextBox = false;
                //warunek sprawdzajacy czy uzupełnione sa pola wymagane
                foreach (Control item in this.panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item.Text.Trim() == "")
                        {
                            if (item.Name != "dodatkowe_akcesoriaTextBox")
                            {
                                bEmptyTextBox = true;
                                break;
                            }
                        }
                    }
                }
                if (gdzie4TextBox.Text != "" && (uzytkownik4TextBox.Text == "" || od_kiedy4TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzie3TextBox.Text != "" && (uzytkownik3TextBox.Text == "" || od_kiedy3TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzie2TextBox.Text != "" && (uzytkownik2TextBox.Text == "" || od_kiedy2TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzieTextBox.Text != "" && (uzytkownikTextBox.Text == "" || od_kiedyTextBox.Text == "")) bEmptyTextBox = true;

                if (bEmptyTextBox == true)
                {
                    MessageBox.Show("Nie wszystkie wymagane pola do zapisu są wypełnione. Uzupełnij zaznaczone pole/pola aby zapisać dane!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //zaznaczenie na czerwono pustych pol wymaganych do zapisu
                    //zmienna do dania focusa pierwszemu pustemu polu
                    int i = 0;
                    foreach (Control item in this.panel1.Controls)
                    {
                        if (item is TextBox)
                        {
                            if (item.Text.Trim() == "")
                            {
                                if (item.Name != "dodatkowe_akcesoriaTextBox")
                                {
                                    if (i == 0) item.Focus();
                                    item.BackColor = Color.Red;
                                    i++;
                                }
                            }
                        }
                    }
                    if (gdzie4TextBox.Text != "" && (uzytkownik4TextBox.Text == "" || od_kiedy4TextBox.Text == ""))
                    {
                        if (uzytkownik4TextBox.Text == "") uzytkownik4TextBox.BackColor = Color.Red;
                        if (od_kiedy4TextBox.Text == "") od_kiedy4TextBox.BackColor = Color.Red;
                    }
                    else if (gdzie3TextBox.Text != "" && (uzytkownik3TextBox.Text == "" || od_kiedy3TextBox.Text == ""))
                    {
                        if (uzytkownik3TextBox.Text == "") uzytkownik3TextBox.BackColor = Color.Red;
                        if (od_kiedy3TextBox.Text == "") od_kiedy3TextBox.BackColor = Color.Red;
                    }
                    else if (gdzie2TextBox.Text != "" && (uzytkownik2TextBox.Text == "" || od_kiedy2TextBox.Text == ""))
                    {
                        if (uzytkownik2TextBox.Text == "") uzytkownik2TextBox.BackColor = Color.Red;
                        if (od_kiedy2TextBox.Text == "") od_kiedy2TextBox.BackColor = Color.Red;
                    }
                    else if (gdzieTextBox.Text != "" && (uzytkownikTextBox.Text == "" || od_kiedyTextBox.Text == ""))
                    {
                        if (uzytkownikTextBox.Text == "") uzytkownikTextBox.BackColor = Color.Red;
                        if (od_kiedyTextBox.Text == "") od_kiedyTextBox.BackColor = Color.Red;
                    }
                }
                else
                {
                    //sprawdzenie pozostałych kart i zapis lub nie
                    //zapis do bazy danych karta
                    cardConection.SaveData(nr_kartyTextBox, nazwa_urzadzeniaTextBox, marka_urzadzeniaTextBox, model_urzadzeniaTextBox,
                        numer_seryjnyTextBox, data_zakupuTextBox, data_oddania_do_eksploatacjiTextBox, dodatkowe_akcesoriaTextBox,
                        uzytkownikTextBox,  od_kiedyTextBox, gdzieTextBox,
                        uzytkownik2TextBox, od_kiedy2TextBox, gdzie2TextBox,
                        uzytkownik3TextBox, od_kiedy3TextBox, gdzie3TextBox,
                        uzytkownik4TextBox, od_kiedy4TextBox, gdzie4TextBox,
                        data_zalozeniaTextBox, zalozycielTextBox);
                    
                    this.Close();
                }
            }


            //edycja danych w karcie
            //zapis danych w nowej karcie
            if (bEditCard == true)
            {
                bool bEmptyTextBox = false;
                //warunek sprawdzajacy czy uzupełnione sa pola wymagane
                foreach (Control item in this.panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item.Text.Trim() == "")
                        {
                            if (item.Name != "dodatkowe_akcesoriaTextBox")
                            {
                                bEmptyTextBox = true;
                                break;
                            }
                        }
                    }
                }
                if (gdzie4TextBox.Text != "" && (uzytkownik4TextBox.Text == "" || od_kiedy4TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzie3TextBox.Text != "" && (uzytkownik3TextBox.Text == "" || od_kiedy3TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzie2TextBox.Text != "" && (uzytkownik2TextBox.Text == "" || od_kiedy2TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzieTextBox.Text != "" && (uzytkownikTextBox.Text == "" || od_kiedyTextBox.Text == "")) bEmptyTextBox = true;

                if (bEmptyTextBox == true)
                {
                    MessageBox.Show("Nie wszystkie wymagane pola do zapisu są wypełnione. Uzupełnij zaznaczone pole/pola aby zapisać dane!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //zaznaczenie na czerwono pustych pol wymaganych do zapisu
                    //zmienna do dania focusa pierwszemu pustemu polu
                    int i = 0;
                    foreach (Control item in this.panel1.Controls)
                    {
                        if (item is TextBox)
                        {
                            if (item.Text.Trim() == "")
                            {
                                if (item.Name != "dodatkowe_akcesoriaTextBox")
                                {
                                    if (i == 0) item.Focus();
                                    item.BackColor = Color.Red;
                                    i++;
                                }
                            }
                        }
                    }
                    if (gdzie4TextBox.Text != "" && (uzytkownik4TextBox.Text == "" || od_kiedy4TextBox.Text == ""))
                    {
                        if (uzytkownik4TextBox.Text == "") uzytkownik4TextBox.BackColor = Color.Red;
                        if (od_kiedy4TextBox.Text == "") od_kiedy4TextBox.BackColor = Color.Red;
                    }
                    else if (gdzie3TextBox.Text != "" && (uzytkownik3TextBox.Text == "" || od_kiedy3TextBox.Text == ""))
                    {
                        if (uzytkownik3TextBox.Text == "") uzytkownik3TextBox.BackColor = Color.Red;
                        if (od_kiedy3TextBox.Text == "") od_kiedy3TextBox.BackColor = Color.Red;
                    }
                    else if (gdzie2TextBox.Text != "" && (uzytkownik2TextBox.Text == "" || od_kiedy2TextBox.Text == ""))
                    {
                        if (uzytkownik2TextBox.Text == "") uzytkownik2TextBox.BackColor = Color.Red;
                        if (od_kiedy2TextBox.Text == "") od_kiedy2TextBox.BackColor = Color.Red;
                    }
                    else if (gdzieTextBox.Text != "" && (uzytkownikTextBox.Text == "" || od_kiedyTextBox.Text == ""))
                    {
                        if (uzytkownikTextBox.Text == "") uzytkownikTextBox.BackColor = Color.Red;
                        if (od_kiedyTextBox.Text == "") od_kiedyTextBox.BackColor = Color.Red;
                    }
                }
                else
                {
                    //sprawdzenie pozostałych kart i zapis lub nie
                    //zapis do bazy danych karta
                    cardConection.ModifyData(nr_kartyTextBox, nazwa_urzadzeniaTextBox, marka_urzadzeniaTextBox, model_urzadzeniaTextBox,
                        numer_seryjnyTextBox, data_zakupuTextBox, data_oddania_do_eksploatacjiTextBox, dodatkowe_akcesoriaTextBox,
                        uzytkownikTextBox, od_kiedyTextBox, gdzieTextBox,
                        uzytkownik2TextBox, od_kiedy2TextBox, gdzie2TextBox,
                        uzytkownik3TextBox, od_kiedy3TextBox, gdzie3TextBox,
                        uzytkownik4TextBox, od_kiedy4TextBox, gdzie4TextBox,
                        data_zalozeniaTextBox, zalozycielTextBox);
                    
                    this.Close();
                }
            }

            //zapis gdy zmieniła się lokalizacja
            if (bChangeLocalization == true)
            {


                bool bEmptyTextBox = false;
                if (gdzie4TextBox.Text != "" && (uzytkownik4TextBox.Text == "" || od_kiedy4TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzie3TextBox.Text != "" && (uzytkownik3TextBox.Text == "" || od_kiedy3TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzie2TextBox.Text != "" && (uzytkownik2TextBox.Text == "" || od_kiedy2TextBox.Text == "")) bEmptyTextBox = true;
                else if (gdzieTextBox.Text != "" && (uzytkownikTextBox.Text == "" || od_kiedyTextBox.Text == "")) bEmptyTextBox = true;

                
                if (bEmptyTextBox == true)
                {
                    
                    MessageBox.Show("Nie wszystkie wymagane pola do zapisu są wypełnione. Uzupełnij zaznaczone pole/pola aby zapisać dane!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //zmiana koloru tła na normalny
                    uzytkownikTextBox.BackColor = nr_kartyTextBox.BackColor;
                    od_kiedyTextBox.BackColor = nr_kartyTextBox.BackColor;
                    uzytkownik2TextBox.BackColor = nr_kartyTextBox.BackColor;
                    od_kiedy2TextBox.BackColor = nr_kartyTextBox.BackColor;
                    uzytkownik3TextBox.BackColor = nr_kartyTextBox.BackColor;
                    od_kiedy3TextBox.BackColor = nr_kartyTextBox.BackColor;
                    uzytkownik4TextBox.BackColor = nr_kartyTextBox.BackColor;
                    od_kiedy4TextBox.BackColor = nr_kartyTextBox.BackColor;

                    //pokolorowanie na czerwono pustych pól
                    if (gdzie4TextBox.Text != "" && (uzytkownik4TextBox.Text == "" || od_kiedy4TextBox.Text == ""))
                    {
                        if (uzytkownik4TextBox.Text == "") uzytkownik4TextBox.BackColor = Color.Red;
                        if (od_kiedy4TextBox.Text == "") od_kiedy4TextBox.BackColor = Color.Red;
                    }
                    else if (gdzie3TextBox.Text != "" && (uzytkownik3TextBox.Text == "" || od_kiedy3TextBox.Text == ""))
                    {
                        if (uzytkownik3TextBox.Text == "") uzytkownik3TextBox.BackColor = Color.Red;
                        if (od_kiedy3TextBox.Text == "") od_kiedy3TextBox.BackColor = Color.Red;
                    }
                    else if (gdzie2TextBox.Text != "" && (uzytkownik2TextBox.Text == "" || od_kiedy2TextBox.Text == ""))
                    {
                        if (uzytkownik2TextBox.Text == "") uzytkownik2TextBox.BackColor = Color.Red;
                        if (od_kiedy2TextBox.Text == "") od_kiedy2TextBox.BackColor = Color.Red;
                    }
                    else if (gdzieTextBox.Text != "" && (uzytkownikTextBox.Text == "" || od_kiedyTextBox.Text == ""))
                    {
                        if (uzytkownikTextBox.Text == "") uzytkownikTextBox.BackColor = Color.Red;
                        if (od_kiedyTextBox.Text == "") od_kiedyTextBox.BackColor = Color.Red;
                    }
                }
                //modyfikacja pól w karcie uzytkonika zwiazane z lokalizacja od kiedy i uzytkownik
                else
                {
                    card.ModifyDataCard(uzytkownikTextBox.Text, gdzieTextBox.Text, od_kiedyTextBox.Text,
                       uzytkownik2TextBox.Text, gdzie2TextBox.Text, od_kiedy2TextBox.Text,
                       uzytkownik3TextBox.Text, gdzie3TextBox.Text, od_kiedy3TextBox.Text,
                       uzytkownik4TextBox.Text, gdzie4TextBox.Text, od_kiedy4TextBox.Text, nr_kartyTextBox.Text);
                    this.Close();
                }
            }
        }

        private void bSaveRepair_Click(object sender, EventArgs e)
        {

            if (bSaveRepairs == true)
            {
                //zapis do bazy
                if (dataTextBox.Text == "" || rodzaj_naprawyTextBox.Text == "" || data_oddania_do_naprawyTextBox.Text == "")
                {
                    MessageBox.Show("Nie wszystkie wymagane pola do zapisu są wypełnione. Uzupełnij zaznaczone pole/pola aby zapisać dane!!!", "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dataTextBox.Text == "") dataTextBox.BackColor = Color.Red;
                    if (rodzaj_naprawyTextBox.Text == "") rodzaj_naprawyTextBox.BackColor = Color.Red;
                    if (data_oddania_do_naprawyTextBox.Text == "") data_oddania_do_naprawyTextBox.BackColor = Color.Red;
                }
                else
                {

                    if (bEditOrSave2 == false)
                    {
                        lp_TextBox.Text = cardRepair.IHowMuchRecordsInRepair.ToString();//iLp.ToString();
                        //zapis nowego rekordu
                        cardRepair.SaveData(tbNumberCard, lp_TextBox, dataTextBox, rodzaj_naprawyTextBox, data_oddania_do_naprawyTextBox, data_odbioru_z_naprawyTextBox, koszt_naprawyTextBox, podpis_nadzorujacego_napraweTextBox, "Karta_naprawy");

                        cardRepair.FindInBase(ewidencjaDataSet, tbNumberCard, "Karta_naprawy");
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[8].Value = i + 1;
                        }
                        bEditOrSave2 = true;
                    }
                    else if (bEditOrSave2 == true)
                    {


                        cardRepair.ModifyDataRepair(tbNumberCard, lp_TextBox, dataTextBox, rodzaj_naprawyTextBox, data_oddania_do_naprawyTextBox, data_odbioru_z_naprawyTextBox, koszt_naprawyTextBox, podpis_nadzorujacego_napraweTextBox);

                        cardRepair.FindInBase(ewidencjaDataSet, tbNumberCard, "Karta_naprawy");
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells["Lp"].Value = i + 1;
                        }

                        bEditOrSave2 = false;
                    }
                    RepairReadOnly(true);
                    bAddRepair.Visible = true;
                    bSaveRepair.Visible = true;
                    //czyszczenie wypełnienia i koloru na normalny
                    foreach (Control item in tabControl1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.BackColor = tbNumberCard.BackColor;
                            item.Text = "";
                        }
                    }
                }
                toolTip1.SetToolTip(bSaveRepair, "Modyfikuj wybrany rekord");
                bSaveRepair.BackgroundImage = Properties.Resources._5891647491535351484_64;
                bSaveRepairs = false;
            }
            else if (bSaveRepairs == false)
            {
                toolTip1.SetToolTip(bSaveRepair, "Zapisz wpis o naprawie");
                bSaveRepair.BackgroundImage = Properties.Resources._16755934531579697357_64;

                RepairReadOnly(false);
                bAddRepair.Visible = false;
                bSaveRepair.Visible = true;
                //zmienna edycja czy zapis btSaveServices
                bEditOrSave2 = true;
                bSaveRepairs = true;
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            bEditCard = true;
            bSave.Visible = true;
            btEdit.Visible = false;
            //zmiana pol do edycji w karcie urzadzenia pierwsza zakładka
            CardReadOnly(false, true);
            //blokowanie pól uzytkownik gdzie i od kiedy jesli sa dane w nich
            foreach (Control item in this.panel2.Controls)
            {
                if (item is TextBox) (item as TextBox).ReadOnly = true;
            }
            //odblokowanie pustych pól do edycji
            if(gdzieTextBox.Text=="")
            {
                uzytkownikTextBox.ReadOnly = false;
                od_kiedyTextBox.ReadOnly = false;
            }
            else if (gdzie2TextBox.Text == "")
            {
                uzytkownik2TextBox.ReadOnly = false;
                od_kiedy2TextBox.ReadOnly = false;
            } 
            else if (gdzie3TextBox.Text == "")
            {
                uzytkownik3TextBox.ReadOnly = false;
                od_kiedy3TextBox.ReadOnly = false;
            }
            else if (gdzie4TextBox.Text == "")
            {
                uzytkownik4TextBox.ReadOnly = false;
                od_kiedy4TextBox.ReadOnly = false;
            }
            AddUserInCardVisible();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            lp_TextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
                lp_TextBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btMoveFirst_Click(object sender, EventArgs e)
        {
            //przesuniecie do pierwszej strony
            kartaBindingSource.MoveFirst();
            //ustawienie biezacej strony w combo wyboru strony
            comboBoxWhatItem.SelectedIndex = kartaBindingSource.Position;
            //wypis ktora to strona z ilu
            lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();

        }

        private void btMoveLas_Click(object sender, EventArgs e)
        {
            //przesuniecie do ostatniej strony
            kartaBindingSource.MoveLast();
            //ustawienie biezacej strony w combo wyboru strony
            comboBoxWhatItem.SelectedIndex = kartaBindingSource.Position;
            //wypis ktora to strona z ilu
            lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();

        }

        private void btBackwardOne_Click(object sender, EventArgs e)
        {
            if (kartaBindingSource.Position - 1 >= 0)
            {
                //przesuniecie o jeden do tyłu strony
                kartaBindingSource.MovePrevious();
                //ustawienie biezacej strony w combo wyboru strony
                comboBoxWhatItem.SelectedIndex = kartaBindingSource.Position;
                //wypis ktora to strona z ilu
                lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();
            }
        }

        private void btForwardOne_Click(object sender, EventArgs e)
        {
            if (kartaBindingSource.Position + 1 < kartaBindingSource.Count)
            {
                //przesuniecie o jeden do przodu strony
                kartaBindingSource.MoveNext();
                //ustawienie biezacej strony w combo wyboru strony
                comboBoxWhatItem.SelectedIndex = kartaBindingSource.Position;
                //wypis ktora to strona z ilu
                lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();
            }
        }

        private void comboBoxWhatItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //przesuniecie karty na wskazana pozycje w comboboxie wyboru strony
            kartaBindingSource.Position = comboBoxWhatItem.SelectedIndex;//ewiBindingSource.Find("Id", iIDnumber);
            //wypis ktora to strona z ilu
            lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();

        }

        private void bFind_Click(object sender, EventArgs e)
        {
            //zmienna do sprawdzenia czy jest szukany wynik czy takiego nie ma
            bool bIsThatCard = false;
            for (int i = 0; i < ewidencjaDataSet.Karta.Rows.Count; i++)
            {
                if(ewidencjaDataSet.Karta.Rows[i]["Nr_karty"].ToString()==tbFindCard.Text.Trim())
                {
                    //przesuniecie karty na wskazana pozycje w comboboxie wyboru strony
                    kartaBindingSource.Position = i;
                    //ustawienie biezacej strony w combo wyboru strony
                    comboBoxWhatItem.SelectedIndex = kartaBindingSource.Position;
                    //wypis ktora to strona z ilu
                    lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();
                    bIsThatCard = true;
                    break;
                }
            }
            //card.FindInBase(ewidencjaDataSet, tbFindCard, "Karta");
            tbFindCard.Text = "";
            if (bIsThatCard == false)
            {
                MessageBox.Show("Niestety nie istnieje szukany numer karty.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //przesuniecie do pierwszej strony
                kartaBindingSource.MoveFirst();
                //ustawienie biezacej strony w combo wyboru strony
                comboBoxWhatItem.SelectedIndex = kartaBindingSource.Position;
                //wypis ktora to strona z ilu
                lbHowMuchOf.Text = (kartaBindingSource.Position + 1).ToString() + " z " + kartaBindingSource.Count.ToString();
            }

        }

        private void kartaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (bLook == true)
            {
                //wypełnienie uwag w konserwacyjnej zakładce
                if (bNew == false)
                {
                    tbCardNumber.Text = nr_kartyTextBox.Text;
                    //uzupełnienie tabeli danymi tylko zwiazanymi z dana karta urzadzenia jesli sa
                    cardConservation.FindInBase(ewidencjaDataSet, nr_kartyTextBox, "Karta_konserwacja");
                    //numerowanie lp w tabeli
                    if (dataGridView2.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            dataGridView2.Rows[i].Cells[7].Value = i + 1;
                        }
                    }
                    //jeśli sa rekordy
                    if (dataGridView2.Rows.Count > 0)
                    {
                        tbWarning.Text = "";
                        for (int i = 0; i < ewidencjaDataSet.Karta_konserwacja.Rows.Count; i++)
                        {
                            if (tbWarning.Text == "") tbWarning.Text = ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                            else tbWarning.Text = tbWarning.Text + Environment.NewLine + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Data"].ToString() + ": " + ewidencjaDataSet.Karta_konserwacja.Rows[i]["Uwagi_dotyczace_pracy_urzadzenia"].ToString();
                        }
                    }
                    else
                    {
                        btSaveServices.Visible = false;
                        tbWarning.Text = "";
                    }

                }
                //wypełnienie uwag w naprawy zakładce
                if (bNew == false)
                {

                    tbNumberCard.Text = nr_kartyTextBox.Text;
                    //uzupełnienie tabeli danymi tylko zwiazanymi z dana karta urzadzenia jesli sa
                    cardRepair.FindInBase(ewidencjaDataSet, nr_kartyTextBox, "Karta_naprawy");
                    //numerowanie lp w tabeli
                    if (dataGridView1.Rows.Count > 0)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Cells[8].Value = i + 1;
                        }
                    }

                }
            }
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //numerowanie lp w tabeli
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    dataGridView2.Rows[i].Cells["Column1"].Value = i + 1;
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //numerowanie lp w tabeli
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Lp"].Value = i + 1;
                }
            }
        }

        private void uzytkownik2TextBox_TextChanged(object sender, EventArgs e)
        {
            if(bEditCard==true)
            {
                gdzie2TextBox.Text = gdzieTextBox.Text;
            }
        }

        private void uzytkownik3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (bEditCard == true)
            {
                gdzie3TextBox.Text = gdzie2TextBox.Text;
            }
        }

        private void uzytkownik4TextBox_TextChanged(object sender, EventArgs e)
        {
            if (bEditCard == true)
            {
                gdzie4TextBox.Text = gdzie3TextBox.Text;
            }
        }

        private void od_kiedy2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (bEditCard == true)
            {
                gdzie2TextBox.Text = gdzieTextBox.Text;
            }
        }

        private void od_kiedy3TextBox_TextChanged(object sender, EventArgs e)
        {
            if (bEditCard == true)
            {
                gdzie3TextBox.Text = gdzie2TextBox.Text;
            }
        }

        private void od_kiedy4TextBox_TextChanged(object sender, EventArgs e)
        {
            if (bEditCard == true)
            {
                gdzie4TextBox.Text = gdzie3TextBox.Text;
            }
        }

        private void btAddUserInCard_Click(object sender, EventArgs e)
        {
            NewUserWhenAllFieldsFull(bChangeLocalization);
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            GenerateCard();
        }

        //generuje kartę urządzenia do pdf
        private void GenerateCard()
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = nr_kartyTextBox.Text;
            if (fileName == "")
            {
                MessageBox.Show("Nie utworzyłeś karty i próbujesz zapisać pustą kartę!", "Brak karty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                fileName = fileName.Replace('\\', ' ');
                //ścieżka z nazwą pliku do tworzenia
                string path = Application.StartupPath + "/Wydruki kart urządzeń/" + fileName + ".pdf";
                //ścieżka do utworzenia katalogu na wydruki
                string path2 = Application.StartupPath + "/Wydruki kart urządzeń/";
                //ustawienie zabezpieczenia do zapisu i tworzenie katalogu
                DirectorySecurity securityRules = new DirectorySecurity();
                string dirPath = Path.GetDirectoryName(path2);
                securityRules.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.Modify, AccessControlType.Allow));
                if (dirPath == null) throw new InvalidOperationException("Nie udało się zapisać ze względu na lokalne ustawienia bezpieczeństwa!");
                if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath, securityRules);

                //rozmiar dokumentu i marginesów
                Document document = new Document(PageSize.A4, 50, 50, 50, 50);
                //ustawienia czcionek
                var bigFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 18);
                var normalFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 10);
                var normalBigFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 14);
                var normalBigBoldFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 14);
                var normalBoldFont = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1250, BaseFont.EMBEDDED, 10);
                var smallFont = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED, 8);
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
                    PdfContentByte pcb = writer.DirectContent;
                    PdfContentByte pcb2 = writer.DirectContent;
                    PdfContentByte cb = writer.DirectContent;
                    //treść wydruku
                    Paragraph p = new Paragraph("KARTA URZĄDZENIA:", bigFont);
                    p.Alignment = Element.ALIGN_CENTER;
                    document.Add(p);
                    p = new Paragraph(Environment.NewLine, normalFont);
                    p.Alignment = Element.ALIGN_CENTER;
                    document.Add(p);
                    fileName = fileName.Replace(' ', '\\');
                    p = new Paragraph("Nr karty: " + fileName, bigFont);
                    p.Alignment = Element.ALIGN_CENTER;
                    document.Add(p);
                    p = new Paragraph(Environment.NewLine, normalFont);
                    p.Alignment = Element.ALIGN_LEFT;
                    document.Add(p);
                    //wypełnienie 
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Nazwa urządzenia: ", normalBigBoldFont), 50, 700, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(nazwa_urzadzeniaTextBox.Text, normalBigFont), 200, 700, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Marka urządzenia: ", normalBigBoldFont), 50, 675, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(marka_urzadzeniaTextBox.Text, normalBigFont), 200, 675, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Model urządzenia: ", normalBigBoldFont), 50, 650, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(model_urzadzeniaTextBox.Text, normalBigFont), 200, 650, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Numer seryjny: ", normalBigBoldFont), 50, 625, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(numer_seryjnyTextBox.Text, normalBigFont), 200, 625, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Data zakupu: ", normalBigBoldFont), 50, 600, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(data_zakupuTextBox.Text, normalBigFont), 200, 600, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Data oddania do eksploatacji: ", normalBigBoldFont), 50, 575, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(data_oddania_do_eksploatacjiTextBox.Text, normalBigFont), 250, 575, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Dodatkowe akcesoria: ", normalBigBoldFont), 50, 550, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(dodatkowe_akcesoriaTextBox.Text, normalBigFont), 200, 550, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Pracę urządzenia nadzoruje: ", bigFont), document.PageSize.GetRight(1) / 2 - (28 * 4), 525, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("1 Użytkownik: ", normalBoldFont), 50, 500, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(uzytkownikTextBox.Text, smallFont), 120, 500, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Gdzie: ", normalBoldFont), 265, 500, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(gdzieTextBox.Text, smallFont), 300, 500, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Od kiedy: ", normalBoldFont), 470, 500, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(od_kiedyTextBox.Text, smallFont), 520, 500, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("2 Użytkownik: ", normalBoldFont), 50, 485, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(uzytkownik2TextBox.Text, smallFont), 120, 485, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Gdzie: ", normalBoldFont), 265, 485, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(gdzie2TextBox.Text, smallFont), 300, 485, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Od kiedy: ", normalBoldFont), 470, 485, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(od_kiedy2TextBox.Text, smallFont), 520, 485, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("3 Użytkownik: ", normalBoldFont), 50, 470, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(uzytkownik3TextBox.Text, smallFont), 120, 470, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Gdzie: ", normalBoldFont), 265, 470, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(gdzie3TextBox.Text, smallFont), 300, 470, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Od kiedy: ", normalBoldFont), 470, 470, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(od_kiedy3TextBox.Text, smallFont), 520, 470, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("4 Użytkownik: ", normalBoldFont), 50, 455, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(uzytkownik4TextBox.Text, smallFont), 120, 455, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Gdzie: ", normalBoldFont), 265, 455, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(gdzie4TextBox.Text, smallFont), 300, 455, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Od kiedy: ", normalBoldFont), 470, 455, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(od_kiedy4TextBox.Text, smallFont), 520, 455, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Data założenia karty: ", normalBoldFont), 50, 435, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(data_zalozeniaTextBox.Text, normalBoldFont), 155, 435, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Założyciel karty: ", normalBoldFont), 350, 435, 0);
                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase(zalozycielTextBox.Text, normalBoldFont), 430, 435, 0);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Rejestracja napraw głównych: ", normalBigBoldFont), document.PageSize.GetRight(1) / 2 - (28 * 4), 400, 0);

                    //tabelka naprawy


                    //tabela z datagridview
                    PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                    //rozmiar szerokosc kolumn
                    float[] widths = new float[] { 75f, 110f, 135f, 600f, 135f, 135f, 105f, 250f, 75f };
                    pdfTable.TotalWidth = 530f;
                    pdfTable.SetWidths(widths);
                    pdfTable.DefaultCell.Padding = 5;
                    pdfTable.WidthPercentage = 100;

                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    //tworzenie header column na pierwszej stronie
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
                            //pdfTable.AddCell(new PdfPCell(new Phrase(cell.Value.ToString(), smallFont)));
                        }
                    }
                    //jak jest mniej niż 15 rysowanie pustych komorek
                    if (dataGridView1.Rows.Count < 15)
                    {
                        int iRow = 15 - dataGridView1.Rows.Count;
                        for (int i = 0; i < iRow; i++)
                        {
                            for (int a = 0; a < 9; a++)
                                pdfTable.AddCell(new PdfPCell(new Phrase(" ", smallFont)));
                        }
                    }
                    //wyświetlenie w pdf
                    pdfTable.WriteSelectedRows(0, -1, 30, 385, pcb);
                    //document.Add(pdfTable);

                    //druga strona
                    document.NewPage();

                    //druga strona karty
                    p = new Paragraph("Przebieg konserwacji:" + Environment.NewLine, bigFont);
                    p.Alignment = Element.ALIGN_CENTER;
                    document.Add(p);
                    p = new Paragraph(Environment.NewLine, bigFont);
                    p.Alignment = Element.ALIGN_CENTER;
                    document.Add(p);

                    //tabela z datagridview
                    PdfPTable pdfTable2 = new PdfPTable(dataGridView2.Columns.Count);
                    //rozmiar szerokosc kolumn
                    float[] widths2 = new float[] { 75f, 110f, 135f, 450f, 270f, 250f, 250f, 75f, 0f };
                    pdfTable2.TotalWidth = 530f;

                    pdfTable2.SetWidths(widths2);
                    pdfTable2.DefaultCell.Padding = 5;
                    pdfTable2.WidthPercentage = 100;

                    pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
                    //tworzenie header column na pierwszej stronie
                    foreach (DataGridViewColumn column in dataGridView2.Columns)
                    {
                        //if (column.Visible == true)
                        //{
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, smallFont));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable2.AddCell(cell);
                        //}
                    }
                    //wypełnianie komorek danymi
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            //if (cell.Visible == true)
                            //{
                            PdfPCell cell2 = new PdfPCell(new Phrase(cell.Value.ToString(), smallFont));
                            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable2.AddCell(cell2);
                            //}
                        }
                    }
                    //jak jest mniej niż 30 rysowanie pustych komorek
                    if (dataGridView2.Rows.Count < 30)
                    {
                        int iRow = 30 - dataGridView2.Rows.Count;
                        for (int i = 0; i < iRow; i++)
                        {
                            for (int a = 0; a < 8; a++)
                            {
                                pdfTable2.AddCell(new PdfPCell(new Phrase(" ", smallFont)));
                            }
                        }
                    }
                    //wyświetlenie w pdf
                    pdfTable2.WriteSelectedRows(0, -1, 30, 725, pcb2);
                    //document.Add(pdfTable2);

                    ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_LEFT, new Phrase("Uwagi dotyczące pracy urządzenia:", normalBigBoldFont), 50, 710 - pdfTable2.CalculateHeights(), 0);

                    int iLiczEntery = 0;
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[8].Value.ToString() != "")
                        {
                            string s = dataGridView2.Rows[i].Cells[2].Value.ToString() + ": " + dataGridView2.Rows[i].Cells[8].Value.ToString();

                            //tutaj ractangle spróbuj
                            ColumnText.ShowTextAligned(writer.DirectContent,
                            Element.ALIGN_LEFT, new Phrase(s, smallFont), 35, 690 - (iLiczEntery * 10) - pdfTable2.CalculateHeights(), 0);
                            iLiczEntery++;
                        }
                    }




                    //linie rysowanie tabeli na uwagi zmieniajacej położenie jeśli tabela urośnie
                    cb.SetLineWidth(0.25);
                    cb.MoveTo(30, document.PageSize.GetBottom(710 - pdfTable2.CalculateHeights() - 200));
                    cb.LineTo(560, document.PageSize.GetBottom(710 - pdfTable2.CalculateHeights() - 200));
                    cb.Stroke();

                    cb.SetLineWidth(0.25);
                    cb.MoveTo(30, document.PageSize.GetBottom(730 - pdfTable2.CalculateHeights()));
                    cb.LineTo(30, document.PageSize.GetBottom(710 - pdfTable2.CalculateHeights() - 200));
                    cb.Stroke();

                    cb.SetLineWidth(0.25);
                    cb.MoveTo(560, document.PageSize.GetBottom(730 - pdfTable2.CalculateHeights()));
                    cb.LineTo(560, document.PageSize.GetBottom(710 - pdfTable2.CalculateHeights() - 200));
                    cb.Stroke();

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
}
