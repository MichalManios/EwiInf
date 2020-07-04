namespace EwiInf
{
    partial class ZmianaHasla
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
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.panelHaslo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBoxHaslo = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButtonChangePassword = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.panelHaslo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxHaslo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNewPassword.Location = new System.Drawing.Point(38, 0);
            this.textBoxNewPassword.MaxLength = 100;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(254, 33);
            this.textBoxNewPassword.TabIndex = 4;
            this.textBoxNewPassword.Text = "Nowe hasło";
            this.textBoxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNewPassword.Enter += new System.EventHandler(this.textBoxNewPassword_Enter);
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.iconPictureBoxUser);
            this.panelUser.Controls.Add(this.textBoxNewPassword);
            this.panelUser.Location = new System.Drawing.Point(144, 71);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(294, 35);
            this.panelUser.TabIndex = 106;
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.iconPictureBoxUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconPictureBoxUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxUser.IconSize = 35;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Size = new System.Drawing.Size(42, 35);
            this.iconPictureBoxUser.TabIndex = 2;
            this.iconPictureBoxUser.TabStop = false;
            // 
            // textBoxConfirmNewPassword
            // 
            this.textBoxConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.textBoxConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmNewPassword.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxConfirmNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxConfirmNewPassword.Location = new System.Drawing.Point(38, 2);
            this.textBoxConfirmNewPassword.MaxLength = 100;
            this.textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            this.textBoxConfirmNewPassword.Size = new System.Drawing.Size(254, 33);
            this.textBoxConfirmNewPassword.TabIndex = 101;
            this.textBoxConfirmNewPassword.Text = "Potwierdź nowe hasło";
            this.textBoxConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConfirmNewPassword.Enter += new System.EventHandler(this.textBoxConfirmNewPassword_Enter);
            this.textBoxConfirmNewPassword.Leave += new System.EventHandler(this.textBoxConfirmNewPassword_Leave);
            // 
            // panelHaslo
            // 
            this.panelHaslo.Controls.Add(this.panel2);
            this.panelHaslo.Controls.Add(this.iconPictureBoxHaslo);
            this.panelHaslo.Controls.Add(this.textBoxConfirmNewPassword);
            this.panelHaslo.Location = new System.Drawing.Point(144, 124);
            this.panelHaslo.Name = "panelHaslo";
            this.panelHaslo.Size = new System.Drawing.Size(294, 35);
            this.panelHaslo.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 5);
            this.panel2.TabIndex = 111;
            // 
            // iconPictureBoxHaslo
            // 
            this.iconPictureBoxHaslo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.iconPictureBoxHaslo.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxHaslo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxHaslo.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.iconPictureBoxHaslo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconPictureBoxHaslo.IconSize = 35;
            this.iconPictureBoxHaslo.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxHaslo.Name = "iconPictureBoxHaslo";
            this.iconPictureBoxHaslo.Size = new System.Drawing.Size(42, 35);
            this.iconPictureBoxHaslo.TabIndex = 2;
            this.iconPictureBoxHaslo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.labelTitle.Location = new System.Drawing.Point(196, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ZMIANA HASŁA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(500, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Wersja: 1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(487, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Michał Manios";
            // 
            // iconButtonChangePassword
            // 
            this.iconButtonChangePassword.FlatAppearance.BorderSize = 0;
            this.iconButtonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonChangePassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonChangePassword.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconButtonChangePassword.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButtonChangePassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconButtonChangePassword.IconSize = 40;
            this.iconButtonChangePassword.Location = new System.Drawing.Point(153, 175);
            this.iconButtonChangePassword.Name = "iconButtonChangePassword";
            this.iconButtonChangePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButtonChangePassword.Rotation = 0D;
            this.iconButtonChangePassword.Size = new System.Drawing.Size(272, 38);
            this.iconButtonChangePassword.TabIndex = 102;
            this.iconButtonChangePassword.Text = "Zatwierdź nowe hasło";
            this.iconButtonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonChangePassword.UseVisualStyleBackColor = true;
            this.iconButtonChangePassword.Click += new System.EventHandler(this.iconButtonChangePassword_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.panel1.Location = new System.Drawing.Point(144, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 5);
            this.panel1.TabIndex = 111;
            // 
            // ZmianaHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(15)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButtonChangePassword);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelHaslo);
            this.Controls.Add(this.panelUser);
            this.Name = "ZmianaHasla";
            this.Size = new System.Drawing.Size(564, 228);
            this.Load += new System.EventHandler(this.ZmianaHasla_Load);
            this.VisibleChanged += new System.EventHandler(this.ZmianaHasla_VisibleChanged);
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

        private System.Windows.Forms.TextBox textBoxNewPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxHaslo;
        private System.Windows.Forms.Panel panelHaslo;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton iconButtonChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
