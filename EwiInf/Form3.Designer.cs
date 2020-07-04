namespace EwiInf
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.listBoxMonitor = new System.Windows.Forms.ListBox();
            this.listBoxPrinter = new System.Windows.Forms.ListBox();
            this.listBoxTelephone = new System.Windows.Forms.ListBox();
            this.listBoxComputer = new System.Windows.Forms.ListBox();
            this.listBoxOther = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btPrint = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ewidencjaDataSet1 = new EwiInf.EwidencjaDataSet();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(531, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomieszczenie:";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRoom.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbRoom.Location = new System.Drawing.Point(581, 64);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(102, 19);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.Text = "Nie wybrano";
            // 
            // listBoxMonitor
            // 
            this.listBoxMonitor.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMonitor.ForeColor = System.Drawing.Color.GhostWhite;
            this.listBoxMonitor.FormattingEnabled = true;
            this.listBoxMonitor.ItemHeight = 19;
            this.listBoxMonitor.Location = new System.Drawing.Point(111, 108);
            this.listBoxMonitor.Name = "listBoxMonitor";
            this.listBoxMonitor.Size = new System.Drawing.Size(236, 190);
            this.listBoxMonitor.TabIndex = 3;
            // 
            // listBoxPrinter
            // 
            this.listBoxPrinter.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxPrinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPrinter.ForeColor = System.Drawing.Color.GhostWhite;
            this.listBoxPrinter.FormattingEnabled = true;
            this.listBoxPrinter.ItemHeight = 19;
            this.listBoxPrinter.Location = new System.Drawing.Point(111, 331);
            this.listBoxPrinter.Name = "listBoxPrinter";
            this.listBoxPrinter.Size = new System.Drawing.Size(236, 190);
            this.listBoxPrinter.TabIndex = 3;
            // 
            // listBoxTelephone
            // 
            this.listBoxTelephone.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTelephone.ForeColor = System.Drawing.Color.GhostWhite;
            this.listBoxTelephone.FormattingEnabled = true;
            this.listBoxTelephone.ItemHeight = 19;
            this.listBoxTelephone.Location = new System.Drawing.Point(518, 331);
            this.listBoxTelephone.Name = "listBoxTelephone";
            this.listBoxTelephone.Size = new System.Drawing.Size(236, 190);
            this.listBoxTelephone.TabIndex = 3;
            // 
            // listBoxComputer
            // 
            this.listBoxComputer.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxComputer.ForeColor = System.Drawing.Color.GhostWhite;
            this.listBoxComputer.FormattingEnabled = true;
            this.listBoxComputer.ItemHeight = 19;
            this.listBoxComputer.Location = new System.Drawing.Point(518, 108);
            this.listBoxComputer.Name = "listBoxComputer";
            this.listBoxComputer.Size = new System.Drawing.Size(236, 190);
            this.listBoxComputer.TabIndex = 3;
            // 
            // listBoxOther
            // 
            this.listBoxOther.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOther.ForeColor = System.Drawing.Color.GhostWhite;
            this.listBoxOther.FormattingEnabled = true;
            this.listBoxOther.ItemHeight = 19;
            this.listBoxOther.Location = new System.Drawing.Point(946, 108);
            this.listBoxOther.Name = "listBoxOther";
            this.listBoxOther.Size = new System.Drawing.Size(356, 437);
            this.listBoxOther.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1184, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Michał Manios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1213, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Wersja: 1.0";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.Color.GhostWhite;
            this.treeView1.LineColor = System.Drawing.Color.GhostWhite;
            this.treeView1.Location = new System.Drawing.Point(1308, 1);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(219, 557);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.BackgroundImage = global::EwiInf.Properties.Resources._1820249201578889576_64;
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.Location = new System.Drawing.Point(12, 12);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(60, 60);
            this.btPrint.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btPrint, "Generuj raport wykazu pomieszczenia");
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Visible = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::EwiInf.Properties.Resources._15965365301579761135_128;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(422, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 75);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Lista telefonów w pomieszczeniu");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::EwiInf.Properties.Resources._14388637931537348221_128;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(12, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Lista drukarek w pomieszczeniu");
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::EwiInf.Properties.Resources._9411509341557740371_128;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(850, 108);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Pozostałe urządzenia");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EwiInf.Properties.Resources._1102208761536063356_128;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(422, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Lista komputerów w pomieszczeniu");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EwiInf.Properties.Resources._19702157991557740339_128;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Lista monitorów w pomieszczeniu");
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(308, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 150);
            this.dataGridView1.TabIndex = 153;
            this.dataGridView1.Visible = false;
            // 
            // ewidencjaDataSet1
            // 
            this.ewidencjaDataSet1.DataSetName = "EwidencjaDataSet";
            this.ewidencjaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "L.P.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Nazwa/Producent";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 500;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Numer ewidencyjny";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Index Finansowy";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Ewidencja";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "szt.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1530, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxOther);
            this.Controls.Add(this.listBoxComputer);
            this.Controls.Add(this.listBoxTelephone);
            this.Controls.Add(this.listBoxPrinter);
            this.Controls.Add(this.listBoxMonitor);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRoom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwiInf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox listBoxMonitor;
        private System.Windows.Forms.ListBox listBoxPrinter;
        private System.Windows.Forms.ListBox listBoxTelephone;
        private System.Windows.Forms.ListBox listBoxComputer;
        private System.Windows.Forms.ListBox listBoxOther;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private EwidencjaDataSet ewidencjaDataSet1;
        private System.Windows.Forms.Button btPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}