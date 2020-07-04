using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    class LookDataGridView
    {
        private DataGridView dataGridView;
        private CheckBox[] checkBoxes = new CheckBox[28];


        //formatowanie wygladu tabelek
        public void FormatDataGrid(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        //blokada formatki przy wyborze menu
        public void enableDisableControls(bool val, Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is Panel || c is GroupBox)
                {
                    enableDisableControls(true, c);
                }
                else
                {
                    c.Enabled = val;
                }
            }
        }
        //ładowanie checkboxów z systemu
        public void AddCheckbox(CheckBox[] checkBox)
        {
            this.checkBoxes = checkBox;
        }
        //odznaczanie checkboxow po wybraniu pokaz wszystkie
        public void UnchekCheckBoxes()
        {
            for (int i = 0; i < this.checkBoxes.Length - 1; i++)
            {
                this.checkBoxes[i].Checked = false;
            }
        }
        //ukrywanie i pokazywanie kolumn tabeli
        public void HideShowColumn(CheckBox[] checkBox)
        {
            this.checkBoxes = checkBox;
            //sprawdza czy opcja checkbox pokaz wszystko jest zaznaczona jesli tak pokazuje wszystkie kolumny
            if (this.checkBoxes[27].Checked == true)
            {
                for (int i = 0; i < this.checkBoxes.Length - 1; i++)
                {
                    dataGridView.Columns[i].Visible = true;
                    this.checkBoxes[i].Checked = false;
                }
                this.checkBoxes[27].Checked = false;
            }
            //jesli nie ukrywa zaznaczone kolumny
            else
            {
                for (int i = 0; i < this.checkBoxes.Length-1; i++)
                {
                    if (this.checkBoxes[i].Checked == true) dataGridView.Columns[i].Visible = false;
                    if (this.checkBoxes[i].Checked == false) dataGridView.Columns[i].Visible = true;
                }
            }
        }


    }
}
