using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwiInf
{
    public partial class Form7 : Form
    {
        Form1 _owner;
        string ConnectionString = "";
        string GetConnectionString { get { return ConnectionString; } }
        //if true History false Faktura
        bool WhatUserControl;

        public Form7(Form1 form1, string ConnectionString, bool History)
        {
            InitializeComponent();
            this._owner = form1;
            this.ConnectionString = ConnectionString;
            this.WhatUserControl = History;
            if (WhatUserControl)
            {
                faktura1.Visible = false;
                history1.Visible = true;
                history1.setStringConnection = ConnectionString;
            }
            else
            {
                faktura1.Visible = true;
                history1.Visible = false;
                faktura1.setStringConnection = ConnectionString;
            }
        }

        public Form7()
        {
            InitializeComponent();
        }
        //obsługa panelu do przyciągania formy jak by był tytułem
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //koniec obsługi i w designer formy7 ostatnia linijka panel1

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            _owner.Show();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelWorkWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void history1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
