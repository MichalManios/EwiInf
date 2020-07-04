namespace EwiInf
{
    partial class History
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControlButton = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index_finansowy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_usuniecia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bEnterSearch = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrewidencyjnyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajsprzetuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaproducentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajewidencjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informatykaLacznoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrseryjnyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrfakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartosczakupuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budynekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pietroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pomieszczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktomodyfikowalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uwagiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ewidencjaDataSet = new EwiInf.EwidencjaDataSet();
            this.historyTableAdapter = new EwiInf.EwidencjaDataSetTableAdapters.HistoryTableAdapter();
            this.panelTitle.SuspendLayout();
            this.panelControlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1384, 50);
            this.panelTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usunięty sprzęt:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControlButton
            // 
            this.panelControlButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelControlButton.Controls.Add(this.bEnterSearch);
            this.panelControlButton.Controls.Add(this.textBoxSearch);
            this.panelControlButton.Controls.Add(this.btPrint);
            this.panelControlButton.Controls.Add(this.bFind);
            this.panelControlButton.Controls.Add(this.label4);
            this.panelControlButton.Controls.Add(this.label3);
            this.panelControlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButton.Location = new System.Drawing.Point(0, 641);
            this.panelControlButton.Name = "panelControlButton";
            this.panelControlButton.Size = new System.Drawing.Size(1384, 100);
            this.panelControlButton.TabIndex = 2;
            this.panelControlButton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlButton_Paint);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(182, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(389, 20);
            this.textBoxSearch.TabIndex = 60;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.Visible = false;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1295, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Michał Manios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1311, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Wersja: 1.0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nrewidencyjnyDataGridViewTextBoxColumn,
            this.Index_finansowy,
            this.rodzajsprzetuDataGridViewTextBoxColumn,
            this.nazwaproducentaDataGridViewTextBoxColumn,
            this.rodzajewidencjiDataGridViewTextBoxColumn,
            this.informatykaLacznoscDataGridViewTextBoxColumn,
            this.nrseryjnyDataGridViewTextBoxColumn,
            this.nrfakturyDataGridViewTextBoxColumn,
            this.wartosczakupuDataGridViewTextBoxColumn,
            this.budynekDataGridViewTextBoxColumn,
            this.pietroDataGridViewTextBoxColumn,
            this.pomieszczenieDataGridViewTextBoxColumn,
            this.ktomodyfikowalDataGridViewTextBoxColumn,
            this.Data_usuniecia,
            this.uwagiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historyBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1384, 591);
            this.dataGridView1.TabIndex = 3;
            // 
            // Index_finansowy
            // 
            this.Index_finansowy.DataPropertyName = "Index_finansowy";
            this.Index_finansowy.HeaderText = "Indeks finansowy";
            this.Index_finansowy.Name = "Index_finansowy";
            this.Index_finansowy.ReadOnly = true;
            this.Index_finansowy.Width = 150;
            // 
            // Data_usuniecia
            // 
            this.Data_usuniecia.DataPropertyName = "Data_usuniecia";
            this.Data_usuniecia.HeaderText = "Data usunięcia";
            this.Data_usuniecia.Name = "Data_usuniecia";
            this.Data_usuniecia.ReadOnly = true;
            this.Data_usuniecia.Width = 132;
            // 
            // bEnterSearch
            // 
            this.bEnterSearch.BackgroundImage = global::EwiInf.Properties.Resources._16755934531579697357_641;
            this.bEnterSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnterSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bEnterSearch.Location = new System.Drawing.Point(591, 15);
            this.bEnterSearch.Name = "bEnterSearch";
            this.bEnterSearch.Size = new System.Drawing.Size(60, 60);
            this.bEnterSearch.TabIndex = 61;
            this.toolTip1.SetToolTip(this.bEnterSearch, "Znajdź");
            this.bEnterSearch.UseVisualStyleBackColor = false;
            this.bEnterSearch.Visible = false;
            this.bEnterSearch.Click += new System.EventHandler(this.bEnterSearch_Click);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.BackgroundImage = global::EwiInf.Properties.Resources._1820249201578889576_64;
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.Location = new System.Drawing.Point(24, 15);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(60, 60);
            this.btPrint.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btPrint, "Zapisz historię do pdf");
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // bFind
            // 
            this.bFind.BackgroundImage = global::EwiInf.Properties.Resources._19543538161579680322_64;
            this.bFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bFind.Location = new System.Drawing.Point(103, 15);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(60, 60);
            this.bFind.TabIndex = 6;
            this.toolTip1.SetToolTip(this.bFind, "Szukaj");
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nrewidencyjnyDataGridViewTextBoxColumn
            // 
            this.nrewidencyjnyDataGridViewTextBoxColumn.DataPropertyName = "Nr_ewidencyjny";
            this.nrewidencyjnyDataGridViewTextBoxColumn.HeaderText = "Nr ewidencyjny";
            this.nrewidencyjnyDataGridViewTextBoxColumn.Name = "nrewidencyjnyDataGridViewTextBoxColumn";
            this.nrewidencyjnyDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrewidencyjnyDataGridViewTextBoxColumn.Width = 135;
            // 
            // rodzajsprzetuDataGridViewTextBoxColumn
            // 
            this.rodzajsprzetuDataGridViewTextBoxColumn.DataPropertyName = "Rodzaj_sprzetu";
            this.rodzajsprzetuDataGridViewTextBoxColumn.HeaderText = "Rodzaj sprzętu";
            this.rodzajsprzetuDataGridViewTextBoxColumn.Name = "rodzajsprzetuDataGridViewTextBoxColumn";
            this.rodzajsprzetuDataGridViewTextBoxColumn.ReadOnly = true;
            this.rodzajsprzetuDataGridViewTextBoxColumn.Width = 133;
            // 
            // nazwaproducentaDataGridViewTextBoxColumn
            // 
            this.nazwaproducentaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa_producenta";
            this.nazwaproducentaDataGridViewTextBoxColumn.HeaderText = "Nazwa/producent";
            this.nazwaproducentaDataGridViewTextBoxColumn.Name = "nazwaproducentaDataGridViewTextBoxColumn";
            this.nazwaproducentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaproducentaDataGridViewTextBoxColumn.Width = 170;
            // 
            // rodzajewidencjiDataGridViewTextBoxColumn
            // 
            this.rodzajewidencjiDataGridViewTextBoxColumn.DataPropertyName = "Rodzaj_ewidencji";
            this.rodzajewidencjiDataGridViewTextBoxColumn.HeaderText = "Rodzaj ewidencji";
            this.rodzajewidencjiDataGridViewTextBoxColumn.Name = "rodzajewidencjiDataGridViewTextBoxColumn";
            this.rodzajewidencjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.rodzajewidencjiDataGridViewTextBoxColumn.Width = 148;
            // 
            // informatykaLacznoscDataGridViewTextBoxColumn
            // 
            this.informatykaLacznoscDataGridViewTextBoxColumn.DataPropertyName = "Informatyka_Lacznosc";
            this.informatykaLacznoscDataGridViewTextBoxColumn.HeaderText = "Informatyka/Łączność";
            this.informatykaLacznoscDataGridViewTextBoxColumn.Name = "informatykaLacznoscDataGridViewTextBoxColumn";
            this.informatykaLacznoscDataGridViewTextBoxColumn.ReadOnly = true;
            this.informatykaLacznoscDataGridViewTextBoxColumn.Width = 202;
            // 
            // nrseryjnyDataGridViewTextBoxColumn
            // 
            this.nrseryjnyDataGridViewTextBoxColumn.DataPropertyName = "Nr_seryjny";
            this.nrseryjnyDataGridViewTextBoxColumn.HeaderText = "Nr seryjny";
            this.nrseryjnyDataGridViewTextBoxColumn.Name = "nrseryjnyDataGridViewTextBoxColumn";
            this.nrseryjnyDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrseryjnyDataGridViewTextBoxColumn.Width = 99;
            // 
            // nrfakturyDataGridViewTextBoxColumn
            // 
            this.nrfakturyDataGridViewTextBoxColumn.DataPropertyName = "Nr_faktury";
            this.nrfakturyDataGridViewTextBoxColumn.HeaderText = "Nr faktury";
            this.nrfakturyDataGridViewTextBoxColumn.Name = "nrfakturyDataGridViewTextBoxColumn";
            this.nrfakturyDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrfakturyDataGridViewTextBoxColumn.Width = 101;
            // 
            // wartosczakupuDataGridViewTextBoxColumn
            // 
            this.wartosczakupuDataGridViewTextBoxColumn.DataPropertyName = "Wartosc_zakupu";
            this.wartosczakupuDataGridViewTextBoxColumn.HeaderText = "Wartość zakupu";
            this.wartosczakupuDataGridViewTextBoxColumn.Name = "wartosczakupuDataGridViewTextBoxColumn";
            this.wartosczakupuDataGridViewTextBoxColumn.ReadOnly = true;
            this.wartosczakupuDataGridViewTextBoxColumn.Width = 141;
            // 
            // budynekDataGridViewTextBoxColumn
            // 
            this.budynekDataGridViewTextBoxColumn.DataPropertyName = "Budynek";
            this.budynekDataGridViewTextBoxColumn.HeaderText = "Budynek";
            this.budynekDataGridViewTextBoxColumn.Name = "budynekDataGridViewTextBoxColumn";
            this.budynekDataGridViewTextBoxColumn.ReadOnly = true;
            this.budynekDataGridViewTextBoxColumn.Width = 99;
            // 
            // pietroDataGridViewTextBoxColumn
            // 
            this.pietroDataGridViewTextBoxColumn.DataPropertyName = "Pietro";
            this.pietroDataGridViewTextBoxColumn.HeaderText = "Piętro";
            this.pietroDataGridViewTextBoxColumn.Name = "pietroDataGridViewTextBoxColumn";
            this.pietroDataGridViewTextBoxColumn.ReadOnly = true;
            this.pietroDataGridViewTextBoxColumn.Width = 79;
            // 
            // pomieszczenieDataGridViewTextBoxColumn
            // 
            this.pomieszczenieDataGridViewTextBoxColumn.DataPropertyName = "Pomieszczenie";
            this.pomieszczenieDataGridViewTextBoxColumn.HeaderText = "Pomieszczenie";
            this.pomieszczenieDataGridViewTextBoxColumn.Name = "pomieszczenieDataGridViewTextBoxColumn";
            this.pomieszczenieDataGridViewTextBoxColumn.ReadOnly = true;
            this.pomieszczenieDataGridViewTextBoxColumn.Width = 142;
            // 
            // ktomodyfikowalDataGridViewTextBoxColumn
            // 
            this.ktomodyfikowalDataGridViewTextBoxColumn.DataPropertyName = "Kto_modyfikowal";
            this.ktomodyfikowalDataGridViewTextBoxColumn.HeaderText = "Kto dokonał modyfikacji";
            this.ktomodyfikowalDataGridViewTextBoxColumn.Name = "ktomodyfikowalDataGridViewTextBoxColumn";
            this.ktomodyfikowalDataGridViewTextBoxColumn.ReadOnly = true;
            this.ktomodyfikowalDataGridViewTextBoxColumn.Width = 196;
            // 
            // uwagiDataGridViewTextBoxColumn
            // 
            this.uwagiDataGridViewTextBoxColumn.DataPropertyName = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.uwagiDataGridViewTextBoxColumn.Name = "uwagiDataGridViewTextBoxColumn";
            this.uwagiDataGridViewTextBoxColumn.ReadOnly = true;
            this.uwagiDataGridViewTextBoxColumn.Width = 80;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.ewidencjaDataSet;
            // 
            // ewidencjaDataSet
            // 
            this.ewidencjaDataSet.DataSetName = "EwidencjaDataSet";
            this.ewidencjaDataSet.EnforceConstraints = false;
            this.ewidencjaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControlButton);
            this.Controls.Add(this.panelTitle);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1384, 741);
            this.Load += new System.EventHandler(this.History_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelControlButton.ResumeLayout(false);
            this.panelControlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource historyBindingSource;
        private EwidencjaDataSet ewidencjaDataSet;
        private EwidencjaDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelControlButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeksfinansowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrewidencyjnyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index_finansowy;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajsprzetuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaproducentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajewidencjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informatykaLacznoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrseryjnyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrfakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartosczakupuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budynekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pietroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pomieszczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktomodyfikowalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_usuniecia;
        private System.Windows.Forms.DataGridViewTextBoxColumn uwagiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button bEnterSearch;
    }
}
