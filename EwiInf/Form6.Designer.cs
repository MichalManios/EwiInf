namespace EwiInf
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonStart = new FontAwesome.Sharp.IconButton();
            this.iconButtonPolaczenie = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogowanie = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.iconPictureBoxCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelWindow = new System.Windows.Forms.Panel();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ustawieniaPolaczenia1 = new EwiInf.UstawieniaPolaczenia();
            this.logowanie1 = new EwiInf.Logowanie();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrent)).BeginInit();
            this.panelWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(52)))), ((int)(((byte)(121)))));
            this.panelMenu.Controls.Add(this.iconButtonStart);
            this.panelMenu.Controls.Add(this.iconButtonPolaczenie);
            this.panelMenu.Controls.Add(this.iconButtonLogowanie);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 285);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonStart
            // 
            this.iconButtonStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonStart.FlatAppearance.BorderSize = 0;
            this.iconButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonStart.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonStart.ForeColor = System.Drawing.Color.White;
            this.iconButtonStart.IconChar = FontAwesome.Sharp.IconChar.ChessBoard;
            this.iconButtonStart.IconColor = System.Drawing.Color.White;
            this.iconButtonStart.IconSize = 50;
            this.iconButtonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStart.Location = new System.Drawing.Point(0, 220);
            this.iconButtonStart.Name = "iconButtonStart";
            this.iconButtonStart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonStart.Rotation = 0D;
            this.iconButtonStart.Size = new System.Drawing.Size(220, 60);
            this.iconButtonStart.TabIndex = 2;
            this.iconButtonStart.Text = "OKNO POWITALNE";
            this.iconButtonStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonStart.UseVisualStyleBackColor = true;
            this.iconButtonStart.Click += new System.EventHandler(this.iconButtonStart_Click);
            // 
            // iconButtonPolaczenie
            // 
            this.iconButtonPolaczenie.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonPolaczenie.FlatAppearance.BorderSize = 0;
            this.iconButtonPolaczenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPolaczenie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonPolaczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonPolaczenie.ForeColor = System.Drawing.Color.White;
            this.iconButtonPolaczenie.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButtonPolaczenie.IconColor = System.Drawing.Color.White;
            this.iconButtonPolaczenie.IconSize = 50;
            this.iconButtonPolaczenie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPolaczenie.Location = new System.Drawing.Point(0, 160);
            this.iconButtonPolaczenie.Name = "iconButtonPolaczenie";
            this.iconButtonPolaczenie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPolaczenie.Rotation = 0D;
            this.iconButtonPolaczenie.Size = new System.Drawing.Size(220, 60);
            this.iconButtonPolaczenie.TabIndex = 1;
            this.iconButtonPolaczenie.Text = "USTAWIENIA POŁĄCZENIA";
            this.iconButtonPolaczenie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPolaczenie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPolaczenie.UseVisualStyleBackColor = true;
            this.iconButtonPolaczenie.Click += new System.EventHandler(this.iconButtonPolaczenie_Click);
            // 
            // iconButtonLogowanie
            // 
            this.iconButtonLogowanie.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonLogowanie.FlatAppearance.BorderSize = 0;
            this.iconButtonLogowanie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogowanie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonLogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonLogowanie.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogowanie.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButtonLogowanie.IconColor = System.Drawing.Color.White;
            this.iconButtonLogowanie.IconSize = 50;
            this.iconButtonLogowanie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogowanie.Location = new System.Drawing.Point(0, 100);
            this.iconButtonLogowanie.Name = "iconButtonLogowanie";
            this.iconButtonLogowanie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonLogowanie.Rotation = 0D;
            this.iconButtonLogowanie.Size = new System.Drawing.Size(220, 60);
            this.iconButtonLogowanie.TabIndex = 0;
            this.iconButtonLogowanie.Text = "LOGOWANIE";
            this.iconButtonLogowanie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogowanie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogowanie.UseVisualStyleBackColor = true;
            this.iconButtonLogowanie.Click += new System.EventHandler(this.iconButtonLogowanie_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::EwiInf.Properties.Resources.godlo2;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 200;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(121)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Controls.Add(this.iconPictureBoxCurrent);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(564, 50);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(55, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 43);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "EwiInf";
            // 
            // iconPictureBoxCurrent
            // 
            this.iconPictureBoxCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(30)))), ((int)(((byte)(121)))));
            this.iconPictureBoxCurrent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBoxCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxCurrent.IconChar = FontAwesome.Sharp.IconChar.ChessBoard;
            this.iconPictureBoxCurrent.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxCurrent.IconSize = 49;
            this.iconPictureBoxCurrent.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxCurrent.Name = "iconPictureBoxCurrent";
            this.iconPictureBoxCurrent.Size = new System.Drawing.Size(49, 50);
            this.iconPictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBoxCurrent.TabIndex = 0;
            this.iconPictureBoxCurrent.TabStop = false;
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder.Location = new System.Drawing.Point(220, 50);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(564, 7);
            this.panelBorder.TabIndex = 2;
            // 
            // panelWindow
            // 
            this.panelWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.panelWindow.Controls.Add(this.ustawieniaPolaczenia1);
            this.panelWindow.Controls.Add(this.logowanie1);
            this.panelWindow.Controls.Add(this.iconButtonExit);
            this.panelWindow.Controls.Add(this.labelDate);
            this.panelWindow.Controls.Add(this.labelTime);
            this.panelWindow.Controls.Add(this.pictureBox1);
            this.panelWindow.Controls.Add(this.label4);
            this.panelWindow.Controls.Add(this.label3);
            this.panelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWindow.Location = new System.Drawing.Point(220, 57);
            this.panelWindow.Name = "panelWindow";
            this.panelWindow.Size = new System.Drawing.Size(564, 228);
            this.panelWindow.TabIndex = 3;
            this.panelWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWindow_Paint);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.White;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonExit.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonExit.IconSize = 60;
            this.iconButtonExit.Location = new System.Drawing.Point(0, 169);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(64, 59);
            this.iconButtonExit.TabIndex = 62;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.iconButtonExit, "Zakończ program");
            this.iconButtonExit.UseVisualStyleBackColor = true;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(122)))), ((int)(((byte)(130)))));
            this.labelDate.Location = new System.Drawing.Point(152, 163);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 21);
            this.labelDate.TabIndex = 61;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(239)))), ((int)(((byte)(236)))));
            this.labelTime.Location = new System.Drawing.Point(216, 121);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 33);
            this.labelTime.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EwiInf.Properties.Resources.godlosw;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(233, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(484, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Michał Manios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(500, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Wersja: 1.0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ustawieniaPolaczenia1
            // 
            this.ustawieniaPolaczenia1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.ustawieniaPolaczenia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ustawieniaPolaczenia1.Location = new System.Drawing.Point(0, 0);
            this.ustawieniaPolaczenia1.Name = "ustawieniaPolaczenia1";
            this.ustawieniaPolaczenia1.Size = new System.Drawing.Size(564, 228);
            this.ustawieniaPolaczenia1.TabIndex = 4;
            this.ustawieniaPolaczenia1.Visible = false;
            this.ustawieniaPolaczenia1.Load += new System.EventHandler(this.ustawieniaPolaczenia1_Load);
            // 
            // logowanie1
            // 
            this.logowanie1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.logowanie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logowanie1.Location = new System.Drawing.Point(0, 0);
            this.logowanie1.Name = "logowanie1";
            this.logowanie1.Size = new System.Drawing.Size(564, 228);
            this.logowanie1.TabIndex = 63;
            this.logowanie1.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 285);
            this.Controls.Add(this.panelWindow);
            this.Controls.Add(this.panelBorder);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwiInf";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCurrent)).EndInit();
            this.panelWindow.ResumeLayout(false);
            this.panelWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonStart;
        private FontAwesome.Sharp.IconButton iconButtonPolaczenie;
        private FontAwesome.Sharp.IconButton iconButtonLogowanie;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCurrent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelWindow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private Logowanie logowanie1;
        private UstawieniaPolaczenia ustawieniaPolaczenia1;
    }
}