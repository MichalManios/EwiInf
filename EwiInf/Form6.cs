using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace EwiInf
{
    public partial class Form6 : Form
    {
        ConnectionAndUser con = new ConnectionAndUser();
        //Pola
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public Form6()
        {
            //panel zaznaczenia wybranego przycisku
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

        }

        //kolory do wyboru zdefiniowane 6 wykorzystane 3
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Aktywny przycisk
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Przycisk
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(19, 52, 121);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //lewy panel do oznaczenia aktywnego przycisku
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //wyświetlenie ikony wybranego przycisku w niby tytule
                iconPictureBoxCurrent.IconChar = currentBtn.IconChar;
                iconPictureBoxCurrent.IconColor = color;
                labelTitle.ForeColor = color;
            }
        }
        //powrot przycisku do normalnego stanu nie wybranego
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(19, 52, 121);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            ActivateButton(iconButtonStart, RGBColors.color3);
            timer1.Start();
        }

        private void iconButtonLogowanie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            logowanie1.Visible = true;
            logowanie1.BringToFront();
            labelTitle.ForeColor = iconButtonLogowanie.ForeColor;
            labelTitle.Text = iconButtonLogowanie.Text;
            ustawieniaPolaczenia1.Visible = false;
        }

        private void iconButtonPolaczenie_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ustawieniaPolaczenia1.Visible = true;
            ustawieniaPolaczenia1.BringToFront();
            labelTitle.ForeColor = iconButtonPolaczenie.ForeColor;
            labelTitle.Text = iconButtonPolaczenie.Text;
            logowanie1.Visible = false;
        }

        private void iconButtonStart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            logowanie1.Visible = false;
            ustawieniaPolaczenia1.Visible = false;
            labelTitle.ForeColor = iconButtonStart.ForeColor;
            labelTitle.Text = "EwiInf";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void panelWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ustawieniaPolaczenia1_Load(object sender, EventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
