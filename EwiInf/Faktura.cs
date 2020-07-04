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

namespace EwiInf
{
    public partial class Faktura : UserControl
    {
        string stringConnection;
        public string setStringConnection { set { stringConnection = value; } }
        LookDataGridView LookTable = new LookDataGridView();
        FakturaClass faktura = new FakturaClass();

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
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
        private void GenerateReport()
        {

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
            panelAddFaktura.Visible = true;
            dataGridView1.ReadOnly = true;
            LookTable.enableDisableControls(false, panelControlButton);

            lpTextBox.Text = dataGridView1.Rows.Count.ToString();
            NormalColorAllField(panelAddFaktura);
            panelAddFaktura.Controls.SetChildIndex(sposob_zaplatyComboBox, 29);
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
                    if(textBox.Text=="")
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
                    if (ComboBox.Text == "")
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
                    i++;
                }
                else if (item is ComboBox)
                {
                    ComboBox ComboBox = item as ComboBox;
                    stringAllFields[i] = ComboBox.Text;
                    i++;
                }
            }
            string s="";
            for (int a = 0; a < 18; a++)
            {
                s = s + " " + stringAllFields[a];
            }
            MessageBox.Show(s);
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
            NormalColorAllField(panelAddFaktura);
            if (CheckAllField(panelAddFaktura) && CheckDate(panelAddFaktura))
            {

                faktura.SaveData(ToSaveAllField(panelAddFaktura));
                faktura.RefreshBase(ewidencjaDataSet);
                panelAddFaktura.Visible = false;
                dataGridView1.ReadOnly = false;
                LookTable.enableDisableControls(true, panelControlButton);
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            panelAddFaktura.Visible = false;
            dataGridView1.ReadOnly = false;
            LookTable.enableDisableControls(true, panelControlButton);
        }

        private void panelControlButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            panelAddFaktura.Visible = true;
            dataGridView1.ReadOnly = true;
            LookTable.enableDisableControls(false, panelControlButton);
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
    }
}
