namespace EwiInf
{
    partial class Logowanie
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUser = new System.Windows.Forms.Panel();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHaslo = new System.Windows.Forms.Panel();
            this.iconPictureBoxHaslo = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonChangePassword = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zmianaHasla1 = new global::EwiInf.ZmianaHasla();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.panelHaslo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxHaslo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.iconPictureBoxUser);
            this.panelUser.Controls.Add(this.textBoxUser);
            this.panelUser.Location = new System.Drawing.Point(165, 73);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(265, 35);
            this.panelUser.TabIndex = 100;
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.iconPictureBoxUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBoxUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxUser.IconSize = 35;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Size = new System.Drawing.Size(42, 35);
            this.iconPictureBoxUser.TabIndex = 2;
            this.iconPictureBoxUser.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUser.Location = new System.Drawing.Point(38, 0);
            this.textBoxUser.MaxLength = 100;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(227, 33);
            this.textBoxUser.TabIndex = 100;
            this.textBoxUser.Text = "Użytkownik";
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUser.Enter += new System.EventHandler(this.textBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.textBoxUser_Leave);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.labelTitle.Location = new System.Drawing.Point(212, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ZALOGUJ SIĘ";
            // 
            // panelHaslo
            // 
            this.panelHaslo.Controls.Add(this.iconPictureBoxHaslo);
            this.panelHaslo.Controls.Add(this.textBoxHaslo);
            this.panelHaslo.Location = new System.Drawing.Point(165, 126);
            this.panelHaslo.Name = "panelHaslo";
            this.panelHaslo.Size = new System.Drawing.Size(265, 35);
            this.panelHaslo.TabIndex = 101;
            // 
            // iconPictureBoxHaslo
            // 
            this.iconPictureBoxHaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.iconPictureBoxHaslo.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxHaslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxHaslo.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt;
            this.iconPictureBoxHaslo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxHaslo.IconSize = 35;
            this.iconPictureBoxHaslo.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxHaslo.Name = "iconPictureBoxHaslo";
            this.iconPictureBoxHaslo.Size = new System.Drawing.Size(42, 35);
            this.iconPictureBoxHaslo.TabIndex = 2;
            this.iconPictureBoxHaslo.TabStop = false;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.textBoxHaslo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHaslo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxHaslo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxHaslo.Location = new System.Drawing.Point(38, 2);
            this.textBoxHaslo.MaxLength = 100;
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(227, 33);
            this.textBoxHaslo.TabIndex = 101;
            this.textBoxHaslo.Text = "Hasło";
            this.textBoxHaslo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHaslo.Enter += new System.EventHandler(this.textBoxHaslo_Enter);
            this.textBoxHaslo.Leave += new System.EventHandler(this.textBoxHaslo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(487, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Michał Manios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(500, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Wersja: 1.0";
            // 
            // iconButtonChangePassword
            // 
            this.iconButtonChangePassword.FlatAppearance.BorderSize = 0;
            this.iconButtonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChangePassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChangePassword.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconButtonChangePassword.IconChar = FontAwesome.Sharp.IconChar.Ad;
            this.iconButtonChangePassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconButtonChangePassword.IconSize = 40;
            this.iconButtonChangePassword.Location = new System.Drawing.Point(16, 174);
            this.iconButtonChangePassword.Name = "iconButtonChangePassword";
            this.iconButtonChangePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonChangePassword.Rotation = 0D;
            this.iconButtonChangePassword.Size = new System.Drawing.Size(180, 38);
            this.iconButtonChangePassword.TabIndex = 103;
            this.iconButtonChangePassword.Text = "Zmień hasło";
            this.iconButtonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonChangePassword.UseVisualStyleBackColor = true;
            this.iconButtonChangePassword.Click += new System.EventHandler(this.iconButtonChangePassword_Click);
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.FlatAppearance.BorderSize = 0;
            this.iconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonLogin.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButtonLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconButtonLogin.IconSize = 40;
            this.iconButtonLogin.Location = new System.Drawing.Point(311, 174);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonLogin.Rotation = 0D;
            this.iconButtonLogin.Size = new System.Drawing.Size(170, 38);
            this.iconButtonLogin.TabIndex = 102;
            this.iconButtonLogin.Text = "Loguj";
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogin.UseVisualStyleBackColor = true;
            this.iconButtonLogin.Click += new System.EventHandler(this.iconButtonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.panel1.Location = new System.Drawing.Point(165, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 5);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.panel2.Location = new System.Drawing.Point(165, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 5);
            this.panel2.TabIndex = 106;
            // 
            // zmianaHasla1
            // 
            this.zmianaHasla1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.zmianaHasla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zmianaHasla1.Location = new System.Drawing.Point(0, 0);
            this.zmianaHasla1.Name = "zmianaHasla1";
            this.zmianaHasla1.Size = new System.Drawing.Size(564, 228);
            this.zmianaHasla1.TabIndex = 109;
            this.zmianaHasla1.Visible = false;
            this.zmianaHasla1.Load += new System.EventHandler(this.zmianaHasla1_Load_1);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.zmianaHasla1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButtonChangePassword);
            this.Controls.Add(this.iconButtonLogin);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelHaslo);
            this.Controls.Add(this.panelUser);
            this.Name = "Logowanie";
            this.Size = new System.Drawing.Size(564, 228);
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.VisibleChanged += new System.EventHandler(this.Logowanie_VisibleChanged);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).EndInit();
            this.panelHaslo.ResumeLayout(false);
            this.panelHaslo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxHaslo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panelHaslo;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private FontAwesome.Sharp.IconButton iconButtonLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxHaslo;
        private FontAwesome.Sharp.IconButton iconButtonChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ZmianaHasla zmianaHasla1;
    }
}
