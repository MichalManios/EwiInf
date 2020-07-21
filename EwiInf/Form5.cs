using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    public partial class Form5 : Form
    {
        EwidenceConfig ewidenceConfig = new EwidenceConfig();
        string sConnectionString = "";
        Form1 _owner;
        bool bAddNew = false;
        bool bEdit = false;
        bool bAddNew2 = false;
        bool bEdit2 = false;
        bool bAddNew3 = false;
        bool bEdit3 = false;

        public Form5(Form1 form1, string ConnectionString)
        {
            InitializeComponent();
            _owner = form1;
            ewidenceConfig.ConnectionString(ConnectionString);
            sConnectionString = ConnectionString;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);

        }

        public Form5()
        {
            InitializeComponent();
        }

        private void InitializeButtonsAndText()
        {
            if (dataGridView1.Rows.Count > 0) btEdit.Visible = true;
            if (dataGridView2.Rows.Count > 0) btEdit2.Visible = true;
            if (dataGridView3.Rows.Count > 0) btEdit3.Visible = true;
        }

        private void AddingNewPosition(int iWhatTabControl)
        {
            //pierwsza zakładka
            if (iWhatTabControl == 1)
            {
                labelPokazTylko1.Visible = false;
                comboBoxPokazTylko1.Visible = false;
                btFindInThisDoc.Visible = false;
                btAdd.Visible = false;
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                btBackward.Visible = false;
                btEdit.Visible = false;
                btCancel.Visible = true;
                btSave.Visible = true;
                comboBoxNazwa.Enabled = true;
                numericPrzychod.Enabled = true;
                numericRozchod.Enabled = true;
                jMTextBox.ReadOnly = false;
                dataTextBox.ReadOnly = false;
                opisTextBox.ReadOnly = false;
                dokument_ksiegowyTextBox.ReadOnly = false;
                uwagiTextBox.ReadOnly = false;
                //comboboxnazwa uzupełnienie tutaj

                jMTextBox.Text = "";
                dataTextBox.Text = "";
                opisTextBox.Text = "";
                dokument_ksiegowyTextBox.Text = "";
                numericPrzychod.Value = 0;
                numericRozchod.Value = 0;
                //stan ustawić na zero po uzupełnieniu nazwy odswiezenie i odswiezenie po zmianach przychod rozchod

                stanTextBox.Text = "0";

                uwagiTextBox.Text = "";
            }
            //druga zakładka
            if (iWhatTabControl == 2)
            {
                labelPokazTylko2.Visible = false;
                comboBoxPokazTylko2.Visible = false;
                btFindInThisDoc2.Visible = false;
                btAdd2.Visible = false;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                btBackward2.Visible = false;
                btEdit2.Visible = false;
                btCancel2.Visible = true;
                btSave2.Visible = true;
                comboBoxNazwa2.Enabled = true;
                numericPrzychod2.Enabled = true;
                numericRozchod2.Enabled = true;
                jMTextBox1.ReadOnly = false;
                dataTextBox1.ReadOnly = false;
                opisTextBox1.ReadOnly = false;
                dokument_ksiegowyTextBox1.ReadOnly = false;
                uwagiTextBox1.ReadOnly = false;
                //comboboxnazwa uzupełnienie tutaj

                jMTextBox1.Text = "";
                dataTextBox1.Text = "";
                opisTextBox1.Text = "";
                dokument_ksiegowyTextBox1.Text = "";
                numericPrzychod2.Value = 0;
                numericRozchod2.Value = 0;
                //stan ustawić na zero po uzupełnieniu nazwy odswiezenie i odswiezenie po zmianach przychod rozchod

                stanTextBox1.Text = "0";

                uwagiTextBox2.Text = "";
            }
            //trzecia zakładka
            if (iWhatTabControl == 3)
            {
                labelPokazTylko3.Visible = false;
                comboBoxPokazTylko3.Visible = false;
                btFindInThisDoc3.Visible = false;
                btAdd3.Visible = false;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                btBackward3.Visible = false;
                btEdit3.Visible = false;
                btCancel3.Visible = true;
                btSave3.Visible = true;
                comboBoxNazwa3.Enabled = true;
                numericPrzychod3.Enabled = true;
                numericRozchod3.Enabled = true;
                jMTextBox2.ReadOnly = false;
                dataTextBox2.ReadOnly = false;
                opisTextBox2.ReadOnly = false;
                dokument_ksiegowyTextBox2.ReadOnly = false;
                uwagiTextBox2.ReadOnly = false;
                //comboboxnazwa uzupełnienie tutaj

                jMTextBox2.Text = "";
                dataTextBox2.Text = "";
                opisTextBox2.Text = "";
                dokument_ksiegowyTextBox2.Text = "";
                numericPrzychod3.Value = 0;
                numericRozchod3.Value = 0;
                //stan ustawić na zero po uzupełnieniu nazwy odswiezenie i odswiezenie po zmianach przychod rozchod

                stanTextBox2.Text = "0";

                uwagiTextBox2.Text = "";
            }
        }

        //edytowanie przyciski
        private void EditingPosition(int iWhatTabControl)
        {
            //pierwsza zakładka
            if (iWhatTabControl == 1)
            {
                labelPokazTylko1.Visible = false;
                comboBoxPokazTylko1.Visible = false;
                btFindInThisDoc.Visible = false;
                btEdit.Visible = false;
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                btBackward.Visible = false;
                btAdd.Visible = false;
                btCancel.Visible = true;
                btSave.Visible = true;
                comboBoxNazwa.Enabled = true;
                numericPrzychod.Enabled = true;
                numericRozchod.Enabled = true;
                jMTextBox.ReadOnly = false;
                dataTextBox.ReadOnly = false;
                opisTextBox.ReadOnly = false;
                dokument_ksiegowyTextBox.ReadOnly = false;
                uwagiTextBox.ReadOnly = false;
                comboBoxNazwa.Enabled = false;


                //stan ustawić odswiezenie po zmianach przychod rozchod


                uwagiTextBox.Text = "";
            }
            //druga zakładka
            if (iWhatTabControl == 2)
            {
                labelPokazTylko2.Visible = false;
                comboBoxPokazTylko2.Visible = false;
                btFindInThisDoc2.Visible = false;
                btEdit2.Visible = false;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage3);
                btBackward2.Visible = false;
                btAdd2.Visible = false;
                btCancel2.Visible = true;
                btSave2.Visible = true;
                comboBoxNazwa2.Enabled = true;
                numericPrzychod2.Enabled = true;
                numericRozchod2.Enabled = true;
                jMTextBox1.ReadOnly = false;
                dataTextBox1.ReadOnly = false;
                opisTextBox1.ReadOnly = false;
                dokument_ksiegowyTextBox1.ReadOnly = false;
                uwagiTextBox1.ReadOnly = false;
                comboBoxNazwa2.Enabled = false;


                //stan ustawić odswiezenie po zmianach przychod rozchod


                uwagiTextBox2.Text = "";
            }
            //trzecia zakładka
            if (iWhatTabControl == 3)
            {
                labelPokazTylko3.Visible = false;
                comboBoxPokazTylko3.Visible = false;
                btFindInThisDoc3.Visible = false;
                btEdit3.Visible = false;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                btBackward3.Visible = false;
                btAdd3.Visible = false;
                btCancel3.Visible = true;
                btSave3.Visible = true;
                comboBoxNazwa3.Enabled = true;
                numericPrzychod3.Enabled = true;
                numericRozchod3.Enabled = true;
                jMTextBox2.ReadOnly = false;
                dataTextBox2.ReadOnly = false;
                opisTextBox2.ReadOnly = false;
                dokument_ksiegowyTextBox2.ReadOnly = false;
                uwagiTextBox2.ReadOnly = false;
                comboBoxNazwa3.Enabled = false;


                //stan ustawić odswiezenie po zmianach przychod rozchod


                uwagiTextBox2.Text = "";
            }
        }

        //canceling operation
        private void CancelOperation(int iWhatTabControl)
        {
            //pierwsza zakładka
            if (iWhatTabControl == 1)
            {
                labelPokazTylko1.Visible = true;
                comboBoxPokazTylko1.Visible = true;
                btFindInThisDoc.Visible = true;
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.TabPages.Add(tabPage3);
                btBackward.Visible = true;
                btAdd.Visible = true;
                btCancel.Visible = false;
                btSave.Visible = false;
                comboBoxNazwa.Enabled = false;
                numericPrzychod.Enabled = false;
                numericRozchod.Enabled = false;
                jMTextBox.ReadOnly = true;
                dataTextBox.ReadOnly = true;
                opisTextBox.ReadOnly = true;
                dokument_ksiegowyTextBox.ReadOnly = true;
                uwagiTextBox.ReadOnly = true;


                //ustawić wszystkie pola na wartosci z datagrida lub puste jak pierwsza pozycja
                //gdy edytujemy lud dodajemy a sa jakies juz wpisy
                if (dataGridView1.Rows.Count > 0)
                {
                    ewidencjaSTBindingSource.MoveFirst();
                    btEdit.Visible = true;
                }
                //gdy edytujemy lub dodajemy a nie ma wpisów
                else
                {
                    comboBoxNazwa.Text = "";
                    jMTextBox.Text = "";
                    dataTextBox.Text = "";
                    opisTextBox.Text = "";
                    dokument_ksiegowyTextBox.Text = "";
                    numericPrzychod.Value = 0;
                    numericRozchod.Value = 0;
                    stanTextBox.Text = "0";
                    uwagiTextBox.Text = "";
                }
            }
            //druga zakładka
            if (iWhatTabControl == 2)
            {
                labelPokazTylko2.Visible = true;
                comboBoxPokazTylko2.Visible = true;
                btFindInThisDoc2.Visible = true;
                tabControl1.TabPages.Add(tabPage1);
                tabControl1.TabPages.Add(tabPage3);
                btBackward2.Visible = true;
                btAdd2.Visible = true;
                btCancel2.Visible = false;
                btSave2.Visible = false;
                comboBoxNazwa2.Enabled = false;
                numericPrzychod2.Enabled = false;
                numericRozchod2.Enabled = false;
                jMTextBox1.ReadOnly = true;
                dataTextBox1.ReadOnly = true;
                opisTextBox1.ReadOnly = true;
                dokument_ksiegowyTextBox1.ReadOnly = true;
                uwagiTextBox1.ReadOnly = true;


                //ustawić wszystkie pola na wartosci z datagrida lub puste jak pierwsza pozycja
                //gdy edytujemy lud dodajemy a sa jakies juz wpisy
                if (dataGridView2.Rows.Count > 0)
                {
                    ewidencjaSTBindingSource.MoveFirst();
                    btEdit2.Visible = true;
                }
                //gdy edytujemy lub dodajemy a nie ma wpisów
                else
                {
                    comboBoxNazwa2.Text = "";
                    jMTextBox1.Text = "";
                    dataTextBox1.Text = "";
                    opisTextBox1.Text = "";
                    dokument_ksiegowyTextBox1.Text = "";
                    numericPrzychod2.Value = 0;
                    numericRozchod2.Value = 0;
                    stanTextBox1.Text = "0";
                    uwagiTextBox1.Text = "";
                }
            }
            //trzecia zakładka
            if (iWhatTabControl == 3)
            {
                labelPokazTylko3.Visible = true;
                comboBoxPokazTylko3.Visible = true;
                btFindInThisDoc3.Visible = true;
                tabControl1.TabPages.Add(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                btBackward3.Visible = true;
                btAdd3.Visible = true;
                btCancel3.Visible = false;
                btSave3.Visible = false;
                comboBoxNazwa3.Enabled = false;
                numericPrzychod3.Enabled = false;
                numericRozchod3.Enabled = false;
                jMTextBox2.ReadOnly = true;
                dataTextBox2.ReadOnly = true;
                opisTextBox2.ReadOnly = true;
                dokument_ksiegowyTextBox2.ReadOnly = true;
                uwagiTextBox2.ReadOnly = true;


                //ustawić wszystkie pola na wartosci z datagrida lub puste jak pierwsza pozycja
                //gdy edytujemy lud dodajemy a sa jakies juz wpisy
                if (dataGridView3.Rows.Count > 0)
                {
                    ewidencjaSTBindingSource.MoveFirst();
                    btEdit3.Visible = true;
                }
                //gdy edytujemy lub dodajemy a nie ma wpisów
                else
                {
                    comboBoxNazwa3.Text = "";
                    jMTextBox2.Text = "";
                    dataTextBox2.Text = "";
                    opisTextBox2.Text = "";
                    dokument_ksiegowyTextBox2.Text = "";
                    numericPrzychod3.Value = 0;
                    numericRozchod3.Value = 0;
                    stanTextBox2.Text = "0";
                    uwagiTextBox2.Text = "";
                }
            }
        }

        //SAVE operation
        private void SaveOperation(int iWhatTabControl)
        {
            //pierwsza zakładka
            if (iWhatTabControl == 1)
            {
                labelPokazTylko1.Visible = true;
                comboBoxPokazTylko1.Visible = true;
                btFindInThisDoc.Visible = true;
                tabControl1.TabPages.Add(tabPage2);
                tabControl1.TabPages.Add(tabPage3);
                btBackward.Visible = true;
                btAdd.Visible = true;
                btCancel.Visible = false;
                btSave.Visible = false;
                comboBoxNazwa.Enabled = false;
                numericPrzychod.Enabled = false;
                numericRozchod.Enabled = false;
                jMTextBox.ReadOnly = true;
                dataTextBox.ReadOnly = true;
                opisTextBox.ReadOnly = true;
                dokument_ksiegowyTextBox.ReadOnly = true;
                uwagiTextBox.ReadOnly = true;


                //ustawić wszystkie pola na wartosci z datagrida lub puste jak pierwsza pozycja
                //gdy edytujemy lud dodajemy a sa jakies juz wpisy
                if (dataGridView1.Rows.Count > 0) ewidencjaSTBindingSource.MoveFirst();
                //gdy edytujemy lub dodajemy a nie ma wpisów
                else
                {
                    comboBoxNazwa.Text = "";
                    jMTextBox.Text = "";
                    dataTextBox.Text = "";
                    opisTextBox.Text = "";
                    dokument_ksiegowyTextBox.Text = "";
                    numericPrzychod.Value = 0;
                    numericRozchod.Value = 0;
                    stanTextBox.Text = "0";
                    uwagiTextBox.Text = "";
                }
                //zapis

            }
            //druga zakładka
            if (iWhatTabControl == 2)
            {
                labelPokazTylko2.Visible = true;
                comboBoxPokazTylko2.Visible = true;
                btFindInThisDoc2.Visible = true;
                tabControl1.TabPages.Add(tabPage1);
                tabControl1.TabPages.Add(tabPage3);
                btBackward2.Visible = true;
                btAdd2.Visible = true;
                btCancel2.Visible = false;
                btSave2.Visible = false;
                comboBoxNazwa2.Enabled = false;
                numericPrzychod2.Enabled = false;
                numericRozchod2.Enabled = false;
                jMTextBox1.ReadOnly = true;
                dataTextBox1.ReadOnly = true;
                opisTextBox1.ReadOnly = true;
                dokument_ksiegowyTextBox1.ReadOnly = true;
                uwagiTextBox1.ReadOnly = true;


                //ustawić wszystkie pola na wartosci z datagrida lub puste jak pierwsza pozycja
                //gdy edytujemy lud dodajemy a sa jakies juz wpisy
                if (dataGridView2.Rows.Count > 0) ewidencjapowyzejBindingSource.MoveFirst();
                //gdy edytujemy lub dodajemy a nie ma wpisów
                else
                {
                    comboBoxNazwa2.Text = "";
                    jMTextBox1.Text = "";
                    dataTextBox1.Text = "";
                    opisTextBox1.Text = "";
                    dokument_ksiegowyTextBox1.Text = "";
                    numericPrzychod2.Value = 0;
                    numericRozchod2.Value = 0;
                    stanTextBox1.Text = "0";
                    uwagiTextBox1.Text = "";
                }
                //zapis

            }
            //trzecia zakładka
            if (iWhatTabControl == 3)
            {
                labelPokazTylko3.Visible = true;
                comboBoxPokazTylko3.Visible = true;
                btFindInThisDoc3.Visible = true;
                tabControl1.TabPages.Add(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                btBackward3.Visible = true;
                btAdd3.Visible = true;
                btCancel3.Visible = false;
                btSave3.Visible = false;
                comboBoxNazwa3.Enabled = false;
                numericPrzychod3.Enabled = false;
                numericRozchod3.Enabled = false;
                jMTextBox2.ReadOnly = true;
                dataTextBox2.ReadOnly = true;
                opisTextBox2.ReadOnly = true;
                dokument_ksiegowyTextBox2.ReadOnly = true;
                uwagiTextBox2.ReadOnly = true;


                //ustawić wszystkie pola na wartosci z datagrida lub puste jak pierwsza pozycja
                //gdy edytujemy lud dodajemy a sa jakies juz wpisy
                if (dataGridView3.Rows.Count > 0) ewidencjaponizejBindingSource.MoveFirst();
                //gdy edytujemy lub dodajemy a nie ma wpisów
                else
                {
                    comboBoxNazwa3.Text = "";
                    jMTextBox2.Text = "";
                    dataTextBox2.Text = "";
                    opisTextBox2.Text = "";
                    dokument_ksiegowyTextBox2.Text = "";
                    numericPrzychod3.Value = 0;
                    numericRozchod3.Value = 0;
                    stanTextBox2.Text = "0";
                    uwagiTextBox2.Text = "";
                }
                //zapis

            }
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.History' . Możesz go przenieść lub usunąć.
            this.historyTableAdapter.Fill(this.ewidencjaDataSet.History);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet1.PonizejStanOtwarcia' . Możesz go przenieść lub usunąć.
            this.ponizejStanOtwarciaTableAdapter.Fill(this.ewidencjaDataSet.PonizejStanOtwarcia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_ST' . Możesz go przenieść lub usunąć.
            this.ewidencja_STTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_ST);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.StanOtwarciaST' . Możesz go przenieść lub usunąć.
            this.stanOtwarciaSTTableAdapter.Fill(this.ewidencjaDataSet.StanOtwarciaST);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet1.StanOtwarciaST' . Możesz go przenieść lub usunąć.
            this.stanOtwarciaSTTableAdapter.Fill(this.ewidencjaDataSet.StanOtwarciaST);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet1.PowyzejStanOtwarcia' . Możesz go przenieść lub usunąć.
            this.powyzejStanOtwarciaTableAdapter.Fill(this.ewidencjaDataSet.PowyzejStanOtwarcia);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.StanOtwarciaST' . Możesz go przenieść lub usunąć.
            this.stanOtwarciaSTTableAdapter.Fill(this.ewidencjaDataSet.StanOtwarciaST);

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.StanOtwarciaST' . Możesz go przenieść lub usunąć.
            //this.stanOtwarciaSTTableAdapter.Connection.Close();
            //this.stanOtwarciaSTTableAdapter.Connection.ConnectionString = sConnectionString;
            //this.stanOtwarciaSTTableAdapter.Connection.Open();
            //this.stanOtwarciaSTTableAdapter.Fill(this.ewidencjaDataSet.StanOtwarciaST);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewi' . Możesz go przenieść lub usunąć.
            this.ewiTableAdapter.Fill(this.ewidencjaDataSet.Ewi);
            //klasa odpowiadajaca za wyglad tabel
            LookDataGridView LookTable = new LookDataGridView();
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_ponizej' . Możesz go przenieść lub usunąć.
            this.ewidencja_ponizejTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_ponizej);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_powyzej' . Możesz go przenieść lub usunąć.
            this.ewidencja_powyzejTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_powyzej);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_ST' . Możesz go przenieść lub usunąć.
            this.ewidencja_STTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_ST);
            //formatowanie wygladu tabel
            LookTable.FormatDataGrid(dataGridView1);
            LookTable.FormatDataGrid(dataGridView2);
            LookTable.FormatDataGrid(dataGridView3);
            LookTable.FormatDataGrid(dataGridView4);
            LookTable.FormatDataGrid(dataGridView5);
            LookTable.FormatDataGrid(dataGridView6);
            LookTable.FormatDataGrid(dataGridView10);
            LookTable.FormatDataGrid(dataGridView11);
            LookTable.FormatDataGrid(dataGridView12);
            //visible przycisków edit na wszystkich 3 formatkach jesli jest jakis rekord
            InitializeButtonsAndText();
            //połączenie i sczytanie danych z tabeli ewi
            ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewi");

            //pierwsza zakładka
            //uzupełnienie combosa rodzajami sprzetu z tabeli ewi
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa, 2);
            //uzupełnienie kombosa do pozostawienia tylko wybranej dziedziny
            ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko1, "Ewidencja_ST", 1);
            comboBoxPokazTylko1.SelectedIndex = 0;
            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.TypeOfEquipment(ewidencjaDataSet, 1, "Ewidencja_ST");
            //uzupełnienie tabeli według sprzętów
            ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ST");
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView1);

            //druga zakładka
            //uzupełnienie combosa rodzajami sprzetu z tabeli ewi
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa2, 2);
            //uzupełnienie kombosa do pozostawienia tylko wybranej dziedziny
            ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko2, "Ewidencja_powyzej", 1);
            comboBoxPokazTylko2.SelectedIndex = 0;
            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.TypeOfEquipment(ewidencjaDataSet, 1, "Ewidencja_powyzej");
            //uzupełnienie tabeli według sprzętów
            ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_powyzej");
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView2);

            //zakładka trzecia
            //uzupełnienie combosa rodzajami sprzetu z tabeli ewi
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa3, 2);
            //uzupełnienie kombosa do pozostawienia tylko wybranej dziedziny
            ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko3, "Ewidencja_ponizej", 1);
            comboBoxPokazTylko3.SelectedIndex = 0;
            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.TypeOfEquipment(ewidencjaDataSet, 1, "Ewidencja_ponizej");
            //uzupełnienie tabeli według sprzętów
            ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ponizej");
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView3);

            //widoczność przycisku szukaj po dokumencie księgowym w zależności czy są rekordy
            if (dataGridView1.Rows.Count > 0) btFindInThisDoc.Visible = true;
            if (dataGridView2.Rows.Count > 0) btFindInThisDoc2.Visible = true;
            if (dataGridView3.Rows.Count > 0) btFindInThisDoc3.Visible = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBackward_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBackward2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBackward3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.Show();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            bAddNew = true;
            AddingNewPosition(1);

            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa, 2);

            //uzupełnienie stanu z ostatniej kolumny sprzetu
            ewidenceConfig.RefreshScore(dataGridView1, comboBoxNazwa, stanTextBox, dataGridView7);
            //aktualny stan
            ewidenceConfig.IStan = Convert.ToInt32(stanTextBox.Text);
            ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod.Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod.Value);
        }

        private void btAdd2_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = false;
            bAddNew2 = true;
            AddingNewPosition(2);

            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa2, 2);

            //uzupełnienie stanu z ostatniej kolumny sprzetu
            ewidenceConfig.RefreshScore(dataGridView2, comboBoxNazwa2, stanTextBox1, dataGridView7);
            //aktualny stan
            ewidenceConfig.IStan = Convert.ToInt32(stanTextBox1.Text);
            ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod2.Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod2.Value);
        }

        private void btAdd3_Click(object sender, EventArgs e)
        {
            dataGridView3.Enabled = false;
            bAddNew3 = true;
            AddingNewPosition(3);

            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa3, 2);

            //uzupełnienie stanu z ostatniej kolumny sprzetu
            ewidenceConfig.RefreshScore(dataGridView3, comboBoxNazwa3, stanTextBox2, dataGridView7);
            //aktualny stan
            ewidenceConfig.IStan = Convert.ToInt32(stanTextBox2.Text);
            ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod3.Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod3.Value);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            bEdit = true;
            EditingPosition(1);

            //aktualny stan
            stanTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            ewidenceConfig.IStan = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[8].Value);
            ewidenceConfig.NumPlus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
        }

        private void btEdit2_Click(object sender, EventArgs e)
        {
            dataGridView2.Enabled = false;
            bEdit2 = true;
            EditingPosition(2);

            //aktualny stan
            stanTextBox1.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
            ewidenceConfig.IStan = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[8].Value);
            ewidenceConfig.NumPlus = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[6].Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[7].Value);
        }

        private void btEdit3_Click(object sender, EventArgs e)
        {
            dataGridView3.Enabled = false;
            bEdit3 = true;
            EditingPosition(3);

            //aktualny stan
            stanTextBox2.Text = dataGridView3.SelectedRows[0].Cells[8].Value.ToString();
            ewidenceConfig.IStan = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[8].Value);
            ewidenceConfig.NumPlus = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[6].Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[7].Value);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.tabPage1.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Name != uwagiTextBox.Name)
                    {
                        (item as TextBox).BackColor = stanTextBox.BackColor;
                    }
                }
            }
            panelSTState.Visible = false;
            CancelOperation(1);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_ST' . Możesz go przenieść lub usunąć.
            this.ewidencja_STTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_ST);
            dataGridView1.Enabled = true;
            bAddNew = false;
            bEdit = false;

            //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
            ewidenceConfig.CompleteCombo(ewidencjaDataSet, comboBoxNazwa, 2);
            //uzupełnienie tabeli według sprzętów
            ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ST");
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView1);
        }

        private void btCancel2_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.tabPage2.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Name != uwagiTextBox2.Name)
                    {
                        (item as TextBox).BackColor = stanTextBox2.BackColor;
                    }
                }
            }
            panelPowyzejState.Visible = false;
            CancelOperation(2);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_ST' . Możesz go przenieść lub usunąć.
            this.ewidencja_powyzejTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_powyzej);
            dataGridView2.Enabled = true;
            bAddNew2 = false;
            bEdit2 = false;

            //uzupełnienie tabeli według sprzętów
            ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_powyzej");
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView2);
        }

        private void btCancel3_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.tabPage3.Controls)
            {
                if (item is TextBox)
                {
                    if ((item as TextBox).Name != uwagiTextBox2.Name)
                    {
                        (item as TextBox).BackColor = stanTextBox2.BackColor;
                    }
                }
            }
            panelPonizejState.Visible = false;
            CancelOperation(3);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'ewidencjaDataSet.Ewidencja_ST' . Możesz go przenieść lub usunąć.
            this.ewidencja_ponizejTableAdapter.Fill(this.ewidencjaDataSet.Ewidencja_ponizej);
            dataGridView3.Enabled = true;
            bAddNew3 = false;
            bEdit3 = false;

            //uzupełnienie tabeli według sprzętów
            ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ponizej");
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView3);
        }

        //sprawdzenie czy data nie jest niższa zczytując ostatnią
        public int Date(ComboBox comboBoxNazwa, DataGridView dataGridView1)
        {
            string sRodzajSprzetu = comboBoxNazwa.Text;
            int iData = 0;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(sRodzajSprzetu==dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    iData = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString().Substring(6));
                }
            }
            return iData;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
           

            //zmiana koloru tła na normalny tych co zrobiły się czerwone
            foreach (Control item in this.tabPage1.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).BackColor = stanTextBox.BackColor;
                }
            }
            DateTime Test;
            //zapis stanu by móc zapisać wpis w ewidencji
            if (panelSTState.Visible == true)
            {
                MessageBox.Show("Nie wszystkie pola stanu początkowego zostały uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxNazwa.Text == "") comboBoxNazwa.BackColor = Color.Red;
                if (textBoxJM.Text == "") textBoxJM.BackColor = Color.Red;
                if (textBoxRok.Text == "") textBoxRok.BackColor = Color.Red;
                if (textBoxStan.Text == "") textBoxStan.BackColor = Color.Red;
            }
            else
            {
                if (comboBoxNazwa.Text == "" || jMTextBox.Text == "" || dataTextBox.Text == "" || opisTextBox.Text == "" ||
                    dokument_ksiegowyTextBox.Text == "")
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostały uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control item in this.tabPage1.Controls)
                    {
                        if (item is TextBox)
                        {
                            if ((item as TextBox).Name != uwagiTextBox.Name)
                            {
                                if ((item as TextBox).Text == "") (item as TextBox).BackColor = Color.Red;
                                else (item as TextBox).BackColor = stanTextBox.BackColor;
                            }
                        }
                    }

                }
                string rok = dataTextBox.Text;
                //dodany w warunku length
                if (rok != "" && rok.Length==10) rok = dataTextBox.Text.Substring(6);
                if (DateTime.TryParseExact(dataTextBox.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out Test) == false)
                {
                    MessageBox.Show("Prawidłowy format daty to DD.MM.RRRR!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox.Text = "";
                    dataTextBox.BackColor = Color.Red;
                }
                else if (textBoxRok.Visible==true && Convert.ToInt32(rok) < Convert.ToInt32(textBoxRok.Text))
                {
                    MessageBox.Show("Data jest niższa od daty wprowadzonego stanu początkowego!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox.BackColor = Color.Red;
                    dataTextBox.Focus();
                }
                //opcja sprawdzenia czy data poprzednia z tego rodzaju urzadzeń nie jest niższa od wprowadzanej
                else if(Convert.ToInt32(dataTextBox.Text.Substring(6))<Date(comboBoxNazwa, dataGridView1))
                {
                    MessageBox.Show("Data nie może być niższa od daty w ostatniej pozycji!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox.BackColor = Color.Red;
                    dataTextBox.Focus();
                }
                else
                {
                    if (bAddNew == true)
                    {
                        ewidenceConfig.SaveData("Ewidencja_ST", dataGridView1.Rows.Count, comboBoxNazwa.Text, jMTextBox.Text, dataTextBox.Text, opisTextBox.Text, dokument_ksiegowyTextBox.Text, numericPrzychod.Value.ToString(), numericRozchod.Value.ToString(), stanTextBox.Text, uwagiTextBox.Text, index_finansowyTextBox2.Text);
                        ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewidencja_ST");
                        SaveOperation(1);
                        bAddNew = false;
                        panelSTState.Visible = false;
                        ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko1, "Ewidencja_ST", 1);
                        comboBoxPokazTylko1.SelectedIndex = 0;
                    }
                    if (bEdit == true)
                    {
                        ewidenceConfig.ModifyData("Ewidencja_ST", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[10].Value), comboBoxNazwa.Text, jMTextBox.Text, dataTextBox.Text, opisTextBox.Text, dokument_ksiegowyTextBox.Text, numericPrzychod.Value.ToString(), numericRozchod.Value.ToString(), stanTextBox.Text, uwagiTextBox.Text, index_finansowyTextBox2.Text);
                        ewidenceConfig.RefreshScorePastEdit(dataGridView1, comboBoxNazwa, stanTextBox);
                        ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewidencja_ST");
                        SaveOperation(1);
                        bEdit = false;
                        ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko1, "Ewidencja_ST", 1);
                        comboBoxPokazTylko1.SelectedIndex = 0;
                    }
                    dataGridView1.Enabled = true;
                    //uzupełnienie tabeli według sprzętów
                    ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ST");
                    //oddzielanie rodzajów szarym wierszem
                    ewidenceConfig.GreyRows(dataGridView1);
                    //button edit widoczny lub nie
                    if (dataGridView1.Rows.Count > 0) btEdit.Visible = true;

                }
            }
        }

        private void btSave2_Click(object sender, EventArgs e)
        {
            //zmiana koloru tła na normalny tych co zrobiły się czerwone
            foreach (Control item in this.tabPage2.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).BackColor = stanTextBox1.BackColor;
                }
            }
            DateTime Test;
            //zapis stanu by móc zapisać wpis w ewidencji
            if (panelPowyzejState.Visible == true)
            {
                MessageBox.Show("Nie wszystkie pola stanu początkowego zostały uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxNazwa2.Text == "") comboBoxNazwa2.BackColor = Color.Red;
                if (textBoxJM2.Text == "") textBoxJM2.BackColor = Color.Red;
                if (textBoxRok2.Text == "") textBoxRok2.BackColor = Color.Red;
                if (textBoxStan2.Text == "") textBoxStan2.BackColor = Color.Red;
            }
            else
            {
                if (comboBoxNazwa2.Text == "" || jMTextBox1.Text == "" || dataTextBox1.Text == "" || opisTextBox1.Text == "" ||
                    dokument_ksiegowyTextBox1.Text == "")
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostały uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control item in this.tabPage2.Controls)
                    {
                        if (item is TextBox)
                        {
                            if ((item as TextBox).Name != uwagiTextBox1.Name)
                            {
                                if ((item as TextBox).Text == "") (item as TextBox).BackColor = Color.Red;
                                else (item as TextBox).BackColor = stanTextBox1.BackColor;
                            }
                        }
                    }
                }
                string rok = dataTextBox1.Text;
                if (rok != "") rok = dataTextBox1.Text.Substring(6);
                if (DateTime.TryParseExact(dataTextBox1.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out Test) == false)
                {
                    MessageBox.Show("Prawidłowy format daty to DD.MM.RRRR!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox1.Text = "";
                    dataTextBox1.BackColor = Color.Red;
                }
                else if (textBoxRok2.Visible == true && Convert.ToInt32(rok) < Convert.ToInt32(textBoxRok2.Text))
                {
                    MessageBox.Show("Data jest niższa od daty wprowadzonego stanu początkowego!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox1.BackColor = Color.Red;
                    dataTextBox1.Focus();
                }
                //opcja sprawdzenia czy data poprzednia z tego rodzaju urzadzeń nie jest niższa od wprowadzanej
                else if (Convert.ToInt32(dataTextBox1.Text.Substring(6)) < Date(comboBoxNazwa2, dataGridView2))
                {
                    MessageBox.Show("Data nie może być niższa od daty w ostatniej pozycji!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox1.BackColor = Color.Red;
                    dataTextBox1.Focus();
                }
                else
                {
                    if (bAddNew2 == true)
                    {
                        ewidenceConfig.SaveData("Ewidencja_powyzej", dataGridView2.Rows.Count, comboBoxNazwa2.Text, jMTextBox1.Text, dataTextBox1.Text, opisTextBox1.Text, dokument_ksiegowyTextBox1.Text, numericPrzychod2.Value.ToString(), numericRozchod2.Value.ToString(), stanTextBox1.Text, uwagiTextBox1.Text, index_finansowyTextBox1.Text);
                        ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewidencja_powyzej");
                        SaveOperation(2);
                        bAddNew2 = false;
                        panelPowyzejState.Visible = false;
                        ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko2, "Ewidencja_powyzej", 1);
                        comboBoxPokazTylko2.SelectedIndex = 0;
                    }
                    if (bEdit2 == true)
                    {
                        ewidenceConfig.ModifyData("Ewidencja_powyzej", Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[10].Value), comboBoxNazwa.Text, jMTextBox.Text, dataTextBox.Text, opisTextBox.Text, dokument_ksiegowyTextBox.Text, numericPrzychod.Value.ToString(), numericRozchod.Value.ToString(), stanTextBox.Text, uwagiTextBox.Text, index_finansowyTextBox1.Text);
                        ewidenceConfig.RefreshScorePastEdit(dataGridView2, comboBoxNazwa2, stanTextBox1);
                        ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewidencja_powyzej");
                        SaveOperation(2);
                        bEdit2 = false;
                        ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko2, "Ewidencja_powyzej", 1);
                        comboBoxPokazTylko2.SelectedIndex = 0;
                    }
                    dataGridView2.Enabled = true;
                    //uzupełnienie tabeli według sprzętów
                    ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_powyzej");
                    //oddzielanie rodzajów szarym wierszem
                    ewidenceConfig.GreyRows(dataGridView2);
                    //button edit widoczny lub nie
                    if (dataGridView2.Rows.Count > 0) btEdit2.Visible = true;
                }
            }
        }

        private void btSave3_Click(object sender, EventArgs e)
        {
            //zmiana koloru tła na normalny tych co zrobiły się czerwone
            foreach (Control item in this.tabPage3.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).BackColor = stanTextBox2.BackColor;
                }
            }
            DateTime Test;
            if (panelPonizejState.Visible == true)
            {
                MessageBox.Show("Nie wszystkie pola stanu początkowego zostały uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxNazwa3.Text == "") comboBoxNazwa3.BackColor = Color.Red;
                if (textBoxJM3.Text == "") textBoxJM3.BackColor = Color.Red;
                if (textBoxRok3.Text == "") textBoxRok3.BackColor = Color.Red;
                if (textBoxStan3.Text == "") textBoxStan3.BackColor = Color.Red;
            }
            else
            {
                if (comboBoxNazwa3.Text == "" || jMTextBox2.Text == "" || dataTextBox2.Text == "" || opisTextBox2.Text == "" ||
                    dokument_ksiegowyTextBox2.Text == "")
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostały uzupełnione!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Control item in this.tabPage3.Controls)
                    {
                        if (item is TextBox)
                        {
                            if ((item as TextBox).Name != uwagiTextBox2.Name)
                            {
                                if ((item as TextBox).Text == "") (item as TextBox).BackColor = Color.Red;
                                else (item as TextBox).BackColor = stanTextBox2.BackColor;
                            }
                        }
                    }
                }
                string rok = dataTextBox2.Text;
                if (rok != "") rok = dataTextBox2.Text.Substring(6);
                if (DateTime.TryParseExact(dataTextBox2.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out Test) == false)
                {
                    MessageBox.Show("Prawidłowy format daty to DD.MM.RRRR!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox2.Text = "";
                    dataTextBox2.BackColor = Color.Red;
                }
                else if (textBoxRok3.Visible == true && Convert.ToInt32(rok) < Convert.ToInt32(textBoxRok3.Text))
                {
                    MessageBox.Show("Data jest niższa od daty wprowadzonego stanu początkowego!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox2.BackColor = Color.Red;
                    dataTextBox2.Focus();
                }
                //opcja sprawdzenia czy data poprzednia z tego rodzaju urzadzeń nie jest niższa od wprowadzanej
                else if (Convert.ToInt32(dataTextBox2.Text.Substring(6)) < Date(comboBoxNazwa3, dataGridView3))
                {
                    MessageBox.Show("Data nie może być niższa od daty w ostatniej pozycji!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataTextBox2.BackColor = Color.Red;
                    dataTextBox2.Focus();
                }
                else
                {
                    if (bAddNew3 == true)
                    {
                        ewidenceConfig.SaveData("Ewidencja_ponizej", dataGridView3.Rows.Count, comboBoxNazwa3.Text, jMTextBox2.Text, dataTextBox2.Text, opisTextBox2.Text, dokument_ksiegowyTextBox2.Text, numericPrzychod3.Value.ToString(), numericRozchod3.Value.ToString(), stanTextBox2.Text, uwagiTextBox2.Text, index_finansowyTextBox.Text);
                        ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewidencja_ponizej");
                        SaveOperation(3);
                        bAddNew3 = false;
                        panelPonizejState.Visible = false;
                        ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko3, "Ewidencja_ponizej", 1);
                        comboBoxPokazTylko3.SelectedIndex = 0;
                    }
                    if (bEdit3 == true)
                    {
                        ewidenceConfig.ModifyData("Ewidencja_ponizej", Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[10].Value), comboBoxNazwa3.Text, jMTextBox2.Text, dataTextBox2.Text, opisTextBox2.Text, dokument_ksiegowyTextBox2.Text, numericPrzychod3.Value.ToString(), numericRozchod3.Value.ToString(), stanTextBox2.Text, uwagiTextBox2.Text, index_finansowyTextBox.Text);
                        ewidenceConfig.RefreshScorePastEdit(dataGridView3, comboBoxNazwa3, stanTextBox2);
                        ewidenceConfig.RefreshBase(ewidencjaDataSet, "Ewidencja_ponizej");
                        SaveOperation(3);
                        bEdit3 = false;
                        ewidenceConfig.CompleteComboSearch(ewidencjaDataSet, comboBoxPokazTylko3, "Ewidencja_ponizej", 1);
                        comboBoxPokazTylko3.SelectedIndex = 0;
                    }
                    dataGridView3.Enabled = true;
                    //uzupełnienie tabeli według sprzętów
                    ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ponizej");
                    //oddzielanie rodzajów szarym wierszem
                    ewidenceConfig.GreyRows(dataGridView3);
                    //button edit widoczny lub nie
                    if (dataGridView3.Rows.Count > 0) btEdit3.Visible = true;
                }
            }
        }

        private void comboBoxNazwa3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void comboBoxNazwa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void comboBoxNazwa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'ż')
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                comboBoxNazwa.Items.Clear();
                comboBoxNazwa.Items.Add(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                comboBoxNazwa.SelectedIndex = 0;
                numericPrzychod.Value= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value);
                numericRozchod.Value= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
                stanTextBox.Text= dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                comboBoxNazwa2.Items.Clear();
                comboBoxNazwa2.Items.Add(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                comboBoxNazwa2.SelectedIndex = 0;
                numericPrzychod2.Value = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[6].Value);
                numericRozchod2.Value = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[7].Value);
                stanTextBox1.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                comboBoxNazwa3.Items.Clear();
                comboBoxNazwa3.Items.Add(dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
                comboBoxNazwa3.SelectedIndex = 0;
                numericPrzychod3.Value = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[6].Value);
                numericRozchod3.Value = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[7].Value);
                stanTextBox2.Text = dataGridView3.SelectedRows[0].Cells[8].Value.ToString();
            }
        }
        private void numericPrzychod_ValueChanged(object sender, EventArgs e)
        {
            ewidenceConfig.RefreshPlusMinus(numericPrzychod, numericRozchod, stanTextBox);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void numericRozchod_ValueChanged(object sender, EventArgs e)
        {
            ewidenceConfig.RefreshPlusMinus(numericPrzychod, numericRozchod, stanTextBox);
        }

        private void comboBoxNazwa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ewidenceConfig.SetStateOpening(comboBoxNazwa.Text, dataGridView1))
            {
                panelSTState.Visible = true;
                textBoxJM.Text = "";
                textBoxRok.Text = "";
                textBoxStan.Text = "0";
                comboBoxNazwa.BackColor = uwagiTextBox.BackColor;
                textBoxJM.BackColor = uwagiTextBox.BackColor;
                textBoxRok.BackColor = uwagiTextBox.BackColor;
                textBoxStan.BackColor = uwagiTextBox.BackColor;
            }
            //uzupełnienie stanu z ostatniej kolumny sprzetu
            ewidenceConfig.RefreshScore(dataGridView1, comboBoxNazwa, stanTextBox, dataGridView7);
            //aktualny stan
            ewidenceConfig.IStan = Convert.ToInt32(stanTextBox.Text);
            ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod.Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod.Value);
        }

        private void numericPrzychod2_ValueChanged(object sender, EventArgs e)
        {
            ewidenceConfig.RefreshPlusMinus(numericPrzychod2, numericRozchod2, stanTextBox1);
        }

        private void numericRozchod2_ValueChanged(object sender, EventArgs e)
        {
            ewidenceConfig.RefreshPlusMinus(numericPrzychod2, numericRozchod2, stanTextBox1);
        }

        private void numericPrzychod3_ValueChanged(object sender, EventArgs e)
        {
            ewidenceConfig.RefreshPlusMinus(numericPrzychod3, numericRozchod3, stanTextBox2);
        }

        private void numericRozchod3_ValueChanged(object sender, EventArgs e)
        {
            ewidenceConfig.RefreshPlusMinus(numericPrzychod3, numericRozchod3, stanTextBox2);
        }

        private void comboBoxNazwa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ewidenceConfig.SetStateOpening(comboBoxNazwa2.Text, dataGridView2))
            {
                panelPowyzejState.Visible = true;
                textBoxJM2.Text = "";
                textBoxRok2.Text = "";
                textBoxStan2.Text = "0";
                comboBoxNazwa2.BackColor = uwagiTextBox1.BackColor;
                textBoxJM2.BackColor = uwagiTextBox1.BackColor;
                textBoxRok2.BackColor = uwagiTextBox1.BackColor;
                textBoxStan2.BackColor = uwagiTextBox1.BackColor;
            }
            //uzupełnienie stanu z ostatniej kolumny sprzetu
            ewidenceConfig.RefreshScore(dataGridView2, comboBoxNazwa2, stanTextBox1, dataGridView7);
            //aktualny stan
            ewidenceConfig.IStan = Convert.ToInt32(stanTextBox1.Text);
            ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod2.Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod2.Value);
        }

        private void comboBoxNazwa3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ewidenceConfig.SetStateOpening(comboBoxNazwa3.Text, dataGridView3))
            {
                panelPonizejState.Visible = true;
                textBoxJM3.Text = "";
                textBoxRok3.Text = "";
                textBoxStan3.Text = "0";
                comboBoxNazwa3.BackColor = uwagiTextBox2.BackColor;
                textBoxJM3.BackColor = uwagiTextBox2.BackColor;
                textBoxRok3.BackColor = uwagiTextBox2.BackColor;
                textBoxStan3.BackColor = uwagiTextBox2.BackColor;
            }
            //uzupełnienie stanu z ostatniej kolumny sprzetu
            ewidenceConfig.RefreshScore(dataGridView3, comboBoxNazwa3, stanTextBox2, dataGridView7);
            //aktualny stan
            ewidenceConfig.IStan = Convert.ToInt32(stanTextBox2.Text);
            ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod3.Value);
            ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod3.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btPrintSrodki_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateReportSrodki(dataGridView1, "Środki trwałe", dataGridView7);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //raport środki trwałe, powyzej i ponizej
                                            //tabela                    nazwa folderu i wykazu
        private void GenerateReportSrodki(DataGridView dataGridView, string FileName, DataGridView dataGridView7)
        {
            //string z nazwą pomieszczenia
            string fileName = "";
            fileName = FileName;
            //ścieżka z nazwą pliku do tworzenia
            string path = Application.StartupPath + "/"+fileName+"/" + fileName + ".pdf";
            //ścieżka do utworzenia katalogu na wydruki
            string path2 = Application.StartupPath + "/" + fileName + "/";
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
                Paragraph p = new Paragraph(fileName + " Informatyki i Łączności:" + Environment.NewLine, bigBoldFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);
                p = new Paragraph(Environment.NewLine, bigFont);
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);


                PdfPTable pdfTable = new PdfPTable(11);
                //rozmiar szerokosc kolumn
                float[] widths = new float[] { 300f, 100f, 50f, 80f, 300f, 100f, 70f, 70f, 70f, 300f, 50f };

                pdfTable.SetWidths(widths);
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
                //do sprawdzenia czy nowy rodzaj sprzętu i zrobić podział
                string sNazwaSprzetu = "";
                //zmienna do okreslenia i drukowania bilansu otwarcia na wydruku
                string date = "";
                //do wyliczenia stanu otwracia w bilansie otwarcia
                int stan = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    
                    if (sNazwaSprzetu != dataGridView.Rows[i].Cells[0].Value.ToString())
                    {
                        date = "";
                        //szary wiersz dzielacy rodzaje sprzetów
                        for (int a = 0; a < 11; a++)
                        {

                            PdfPCell cell2 = new PdfPCell(new Phrase(" ", smallFont));
                            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
                            cell2.BackgroundColor = new iTextSharp.text.BaseColor(119, 136, 153);
                            pdfTable.AddCell(cell2);

                            sNazwaSprzetu = dataGridView.Rows[i].Cells[0].Value.ToString();
                        }
                        //pierwszy bilans otwarcia
                        for (int a = 0; a < dataGridView7.Rows.Count; a++)
                        {
                            if(sNazwaSprzetu == dataGridView7.Rows[a].Cells[1].Value.ToString())
                            {
                                date = dataGridView7.Rows[a].Cells[3].Value.ToString().Trim();
                                break;
                                //stan= Convert.ToInt32(dataGridView7.Rows[a].Cells[4].Value.ToString());
                            }
                        }
                        if(date=="") date = dataGridView.Rows[i].Cells[3].Value.ToString().Substring(6);
                        PdfPCell cell4 = new PdfPCell(new Phrase("Bilans otwarcia " + date, smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase("0", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase("0", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        stan = Convert.ToInt32(dataGridView.Rows[i].Cells[8].Value) - Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value) + Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value);
                        cell4 = new PdfPCell(new Phrase(stan.ToString(), smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        cell4 = new PdfPCell(new Phrase(" ", smallFont));
                        cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                        pdfTable.AddCell(cell4);
                        //drukowanie komórek z tabeli
                        for (int a = 0; a < 11; a++)
                        {
                            PdfPCell cell3 = new PdfPCell(new Phrase(dataGridView.Rows[i].Cells[a].Value.ToString(), smallFont));
                            cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable.AddCell(cell3);
                        }
                    }
                    //tutaj gdy jest ta sama nazwa poprostu zwykłe drukowanie
                    else
                    {
                        //bilansy otwarcia w danym typie po dacie
                        if (date != dataGridView.Rows[i].Cells[3].Value.ToString().Substring(6))
                        {
                            int idate2 = Convert.ToInt32(date);
                            date = dataGridView.Rows[i].Cells[3].Value.ToString().Substring(6);
                            //drukowanie gdy luka większa niż rok
                            if (Convert.ToInt32(date) > idate2 + 1)
                            {
                                for (int z = 0; z < Convert.ToInt32(date)-idate2; z++)
                                {
                                    PdfPCell cell4 = new PdfPCell(new Phrase("Bilans otwarcia " + (idate2+z+1), smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase("0", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase("0", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    stan = Convert.ToInt32(dataGridView.Rows[i].Cells[8].Value) - Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value) + Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value);
                                    cell4 = new PdfPCell(new Phrase(stan.ToString(), smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                    cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                    cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                    pdfTable.AddCell(cell4);
                                }
                            }
                            //drukowanie bez luk w datach
                            else
                            {
                                PdfPCell cell4 = new PdfPCell(new Phrase("Bilans otwarcia " + date, smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase("0", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase("0", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                stan = Convert.ToInt32(dataGridView.Rows[i].Cells[8].Value) - Convert.ToInt32(dataGridView.Rows[i].Cells[6].Value) + Convert.ToInt32(dataGridView.Rows[i].Cells[7].Value);
                                cell4 = new PdfPCell(new Phrase(stan.ToString(), smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                                cell4 = new PdfPCell(new Phrase(" ", smallFont));
                                cell4.VerticalAlignment = Element.ALIGN_MIDDLE;
                                pdfTable.AddCell(cell4);
                            }
                        }
                        //normalne drukowanie
                        for (int a = 0; a < 11; a++)
                        {
                            PdfPCell cell3 = new PdfPCell(new Phrase(dataGridView.Rows[i].Cells[a].Value.ToString(), smallFont));
                            cell3.VerticalAlignment = Element.ALIGN_MIDDLE;
                            pdfTable.AddCell(cell3);
                        }
                        
                    }
                }

                document.Add(pdfTable);

                //dolne wpisy
                ColumnText.ShowTextAligned(writer.DirectContent,
                Element.ALIGN_CENTER, new Phrase("Wykaz " + fileName.ToLower() + " wygenerowany z EwiInf dla Aresztu Śledczego w Łodzi " + DateTime.Now.ToString(), normalFont), 250, 60, 0);
                //koniec wydruku

                document.Close();

                //otwarcie pliku w pdf readerze
                Process.Start(path);
            }
        }

        private void btPrintPowyzej_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateReportSrodki(dataGridView2, "Ewidencja powyżej", dataGridView8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btPrintPonizej_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateReportSrodki(dataGridView3, "Ewidencja poniżej", dataGridView9);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btFindInThisDoc_Click(object sender, EventArgs e)
        {
            panelFindInThisDoc.BringToFront();
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            ewidenceConfig.FindEquipmentByDoc(ewidencjaDataSet, "Ewi", dokument_ksiegowyTextBox.Text.Trim(), "ŚRODEK TRWAŁY", index_finansowyTextBox2.Text.Trim());
            panelFindInThisDoc.Visible = true;
        }

        private void btFindInThisDoc2_Click(object sender, EventArgs e)
        {
            panelFindInThisDoc2.BringToFront();
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage3);
            ewidenceConfig.FindEquipmentByDoc(ewidencjaDataSet, "Ewi", dokument_ksiegowyTextBox1.Text.Trim(), "POWYŻEJ", index_finansowyTextBox1.Text);
            panelFindInThisDoc2.Visible = true;
        }

        private void btFindInThisDoc3_Click(object sender, EventArgs e)
        {
            panelFindInThisDoc3.BringToFront();
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            ewidenceConfig.FindEquipmentByDoc(ewidencjaDataSet, "Ewi", dokument_ksiegowyTextBox2.Text.Trim(), "PONIŻEJ", index_finansowyTextBox.Text);
            panelFindInThisDoc3.Visible = true;
        }

        private void btBackInDock_Click(object sender, EventArgs e)
        {
            panelFindInThisDoc.Visible = false;
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);
            dataGridView10.Visible = false;
        }

        private void btPrintByDoc_Click(object sender, EventArgs e)
        {
            if (dataGridView10.Visible)
            {
                try
                {
                    ewidenceConfig.GenerateReportByNumberDoc(dokument_ksiegowyTextBox.Text.Trim(), "Środki trwałe", dataGridView10, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    ewidenceConfig.GenerateReportByNumberDoc(dokument_ksiegowyTextBox.Text.Trim(), "Środki trwałe", dataGridView4, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btPrintByDoc2_Click(object sender, EventArgs e)
        {
            if (dataGridView11.Visible)
            {
                try
                {
                    ewidenceConfig.GenerateReportByNumberDoc(dokument_ksiegowyTextBox1.Text.Trim(), "Ewidencja powyżej", dataGridView11, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    ewidenceConfig.GenerateReportByNumberDoc(dokument_ksiegowyTextBox1.Text.Trim(), "Ewidencja powyżej", dataGridView5, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btBackInDock2_Click(object sender, EventArgs e)
        {
            panelFindInThisDoc2.Visible = false;
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage3);
            dataGridView11.Visible = false;
        }

        private void btPrintByDoc3_Click(object sender, EventArgs e)
        {
            if (dataGridView12.Visible)
            {
                try
                {
                    ewidenceConfig.GenerateReportByNumberDoc(dokument_ksiegowyTextBox2.Text.Trim(), "Ewidencja poniżej", dataGridView12, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    ewidenceConfig.GenerateReportByNumberDoc(dokument_ksiegowyTextBox2.Text.Trim(), "Ewidencja poniżej", dataGridView6, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OSTRZEŻENIE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btBackInDock3_Click(object sender, EventArgs e)
        {
            panelFindInThisDoc3.Visible = false;
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            dataGridView12.Visible = false;
        }

        private void comboBoxPokazTylko1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPokazTylko1.SelectedIndex==0)
            {
                //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
                ewidenceConfig.TypeOfEquipment(ewidencjaDataSet, 1, "Ewidencja_ST");
                //uzupełnienie tabeli według sprzętów
                ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ST");
                //oddzielanie rodzajów szarym wierszem
                ewidenceConfig.GreyRows(dataGridView1);
            }
            else ewidenceConfig.FindByEquipment(ewidencjaDataSet, "Ewidencja_ST", comboBoxPokazTylko1.Text);

        }

        private void comboBoxPokazTylko2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPokazTylko2.SelectedIndex == 0)
            {
                //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
                ewidenceConfig.TypeOfEquipment(ewidencjaDataSet, 1, "Ewidencja_powyzej");
                //uzupełnienie tabeli według sprzętów
                ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_powyzej");
                //oddzielanie rodzajów szarym wierszem
                ewidenceConfig.GreyRows(dataGridView2);
            }
            else ewidenceConfig.FindByEquipment(ewidencjaDataSet, "Ewidencja_powyzej", comboBoxPokazTylko2.Text);

        }

        private void comboBoxPokazTylko3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPokazTylko3.SelectedIndex == 0)
            {
                //tworzy liste z nazwami rodzajów sprzetu według którego ma byc posortowane
                ewidenceConfig.TypeOfEquipment(ewidencjaDataSet, 1, "Ewidencja_ponizej");
                //uzupełnienie tabeli według sprzętów
                ewidenceConfig.FindInBase(ewidencjaDataSet, "Ewidencja_ponizej");
                //oddzielanie rodzajów szarym wierszem
                ewidenceConfig.GreyRows(dataGridView3);
            }
            else ewidenceConfig.FindByEquipment(ewidencjaDataSet, "Ewidencja_ponizej", comboBoxPokazTylko3.Text);

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelFindInThisDoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFindInThisDoc3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFindInThisDoc_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btSaveState_Click(object sender, EventArgs e)
        {
            if (comboBoxNazwa.Text == "" || textBoxJM.Text == "" || textBoxRok.Text == "" || textBoxStan.Text == "")
            {
                MessageBox.Show("Nie wszystkie wymagane pola są wypełnione!!!", "Informacja!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxNazwa.Text == "") comboBoxNazwa.BackColor = Color.Red;
                if (textBoxJM.Text == "") textBoxJM.BackColor = Color.Red;
                if (textBoxRok.Text == "") textBoxRok.BackColor = Color.Red;
                if (textBoxStan.Text == "") textBoxStan.BackColor = Color.Red;
            }
            else
            {
                ewidenceConfig.SaveOpenStateST("StanOtwarciaST", dataGridView7.Rows.Count, comboBoxNazwa.Text, textBoxJM.Text, textBoxRok.Text, textBoxStan.Text);
                ewidenceConfig.RefreshBase(ewidencjaDataSet, "StanOtwarciaST");
                comboBoxNazwa.BackColor = uwagiTextBox.BackColor;
                textBoxJM.BackColor = uwagiTextBox.BackColor;
                textBoxRok.BackColor = uwagiTextBox.BackColor;
                textBoxStan.BackColor = uwagiTextBox.BackColor;
                panelSTState.Visible = false;
                int iStan = Convert.ToInt16(stanTextBox.Text) + Convert.ToInt32(textBoxStan.Text);
                stanTextBox.Text = iStan.ToString();
                ewidenceConfig.IStan = Convert.ToInt32(stanTextBox.Text);
                ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod.Value);
                ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod.Value);
            }
        }

        private void textBoxStan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else e.Handled = true;

        }

        private void textBoxRok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else e.Handled = true;
        }

        private void textBoxStan_Enter(object sender, EventArgs e)
        {
            textBoxStan.Text = "";
        }

        private void textBoxJM2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxRok2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else e.Handled = true;
        }

        private void textBoxStan2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else e.Handled = true;
        }

        private void btSavePowyzejState_Click(object sender, EventArgs e)
        {
            if (comboBoxNazwa2.Text == "" || textBoxJM2.Text == "" || textBoxRok2.Text == "" || textBoxStan2.Text == "")
            {
                MessageBox.Show("Nie wszystkie wymagane pola są wypełnione!!!", "Informacja!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxNazwa2.Text == "") comboBoxNazwa2.BackColor = Color.Red;
                if (textBoxJM2.Text == "") textBoxJM2.BackColor = Color.Red;
                if (textBoxRok2.Text == "") textBoxRok2.BackColor = Color.Red;
                if (textBoxStan2.Text == "") textBoxStan2.BackColor = Color.Red;
            }
            else
            {
                ewidenceConfig.SaveOpenStateST("PowyzejStanOtwarcia", dataGridView8.Rows.Count, comboBoxNazwa2.Text, textBoxJM2.Text, textBoxRok2.Text, textBoxStan2.Text);
                ewidenceConfig.RefreshBase(ewidencjaDataSet, "PowyzejStanOtwarcia");
                comboBoxNazwa2.BackColor = uwagiTextBox1.BackColor;
                textBoxJM2.BackColor = uwagiTextBox1.BackColor;
                textBoxRok2.BackColor = uwagiTextBox1.BackColor;
                textBoxStan2.BackColor = uwagiTextBox1.BackColor;
                panelPowyzejState.Visible = false;
                int iStan = Convert.ToInt16(stanTextBox1.Text) + Convert.ToInt32(textBoxStan2.Text);
                stanTextBox1.Text = iStan.ToString();
                ewidenceConfig.IStan = Convert.ToInt32(stanTextBox1.Text);
                ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod2.Value);
                ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod2.Value);
            }
        }

        private void textBoxStan2_Enter(object sender, EventArgs e)
        {
            textBoxStan2.Text = "";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //oddzielanie rodzajów szarym wierszem
            ewidenceConfig.GreyRows(dataGridView1);
            ewidenceConfig.GreyRows(dataGridView2);
            ewidenceConfig.GreyRows(dataGridView3);
        }

        private void textBoxJM_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxJM3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxRok3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else e.Handled = true;
        }

        private void textBoxStan3_Enter(object sender, EventArgs e)
        {
            textBoxStan3.Text = "";
        }

        private void textBoxStan3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else e.Handled = true;
        }

        private void btSaveStatePonizej_Click(object sender, EventArgs e)
        {
            if (comboBoxNazwa3.Text == "" || textBoxJM3.Text == "" || textBoxRok3.Text == "" || textBoxStan3.Text == "")
            {
                MessageBox.Show("Nie wszystkie wymagane pola są wypełnione!!!", "Informacja!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (comboBoxNazwa3.Text == "") comboBoxNazwa3.BackColor = Color.Red;
                if (textBoxJM3.Text == "") textBoxJM3.BackColor = Color.Red;
                if (textBoxRok3.Text == "") textBoxRok3.BackColor = Color.Red;
                if (textBoxStan3.Text == "") textBoxStan3.BackColor = Color.Red;
            }
            else
            {
                ewidenceConfig.SaveOpenStateST("PonizejStanOtwarcia", dataGridView9.Rows.Count, comboBoxNazwa3.Text, textBoxJM3.Text, textBoxRok3.Text, textBoxStan3.Text);
                ewidenceConfig.RefreshBase(ewidencjaDataSet, "PonizejStanOtwarcia");
                comboBoxNazwa3.BackColor = uwagiTextBox2.BackColor;
                textBoxJM3.BackColor = uwagiTextBox2.BackColor;
                textBoxRok3.BackColor = uwagiTextBox2.BackColor;
                textBoxStan3.BackColor = uwagiTextBox2.BackColor;
                panelPonizejState.Visible = false;
                int iStan = Convert.ToInt16(stanTextBox2.Text) + Convert.ToInt32(textBoxStan3.Text);
                stanTextBox1.Text = iStan.ToString();
                ewidenceConfig.IStan = Convert.ToInt32(stanTextBox2.Text);
                ewidenceConfig.NumMinus = Convert.ToInt32(numericRozchod3.Value);
                ewidenceConfig.NumPlus = Convert.ToInt32(numericPrzychod3.Value);
            }
        }

        private void panelFindInThisDoc_VisibleChanged(object sender, EventArgs e)
        {
            
            if (panelFindInThisDoc.Visible)
            {
                
                if (dataGridView4.Rows.Count==0)
                {
                    
                    ewidenceConfig.FindEquipmentByDoc(ewidencjaDataSet, "History", dokument_ksiegowyTextBox.Text.Trim(), "ŚRODEK TRWAŁY", index_finansowyTextBox2.Text.Trim());
                    if(dataGridView10.Rows.Count>0) dataGridView10.Visible = true;
                    
                }
            }
        }

        private void panelFindInThisDoc2_VisibleChanged(object sender, EventArgs e)
        {
            if(panelFindInThisDoc2.Visible)
            {
                if(dataGridView5.Rows.Count==0)
                {
                    ewidenceConfig.FindEquipmentByDoc(ewidencjaDataSet, "History", dokument_ksiegowyTextBox1.Text.Trim(), "POWYŻEJ", index_finansowyTextBox1.Text.Trim());
                    if (dataGridView11.Rows.Count > 0) dataGridView11.Visible = true;
                }
            }
        }

        private void panelFindInThisDoc3_VisibleChanged(object sender, EventArgs e)
        {
            if(panelFindInThisDoc3.Visible)
            {
                if(dataGridView6.Rows.Count==0)
                {
                    ewidenceConfig.FindEquipmentByDoc(ewidencjaDataSet, "History", dokument_ksiegowyTextBox2.Text.Trim(), "PONIŻEJ", index_finansowyTextBox.Text);
                    if (dataGridView12.Rows.Count > 0) dataGridView12.Visible = true;
                }
            }
        }
    }
}
