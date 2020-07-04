namespace EwiInf
{
    partial class Faktura
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
            System.Windows.Forms.Label lpLabel;
            System.Windows.Forms.Label miesiacLabel;
            System.Windows.Forms.Label paragrafLabel;
            System.Windows.Forms.Label pozycja_paragrafLabel;
            System.Windows.Forms.Label nr_fakturyLabel;
            System.Windows.Forms.Label data_fakturyLabel;
            System.Windows.Forms.Label dostawcaLabel;
            System.Windows.Forms.Label specyfikacjaLabel;
            System.Windows.Forms.Label iloscLabel;
            System.Windows.Forms.Label jednostka_miaryLabel;
            System.Windows.Forms.Label indeks_finansowyLabel;
            System.Windows.Forms.Label rodzaj_ewidencjiLabel;
            System.Windows.Forms.Label wartoscLabel;
            System.Windows.Forms.Label termin_platnosciLabel;
            System.Windows.Forms.Label przekazano_do_DFLabel;
            System.Windows.Forms.Label nazwisko_ImieLabel;
            System.Windows.Forms.Label opis_fakturyLabel;
            System.Windows.Forms.Label sposob_zaplatyLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faktura));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelControlButton = new System.Windows.Forms.Panel();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAddPositionAtFaktura = new System.Windows.Forms.Button();
            this.bEnterSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.panelAddFaktura = new System.Windows.Forms.Panel();
            
            this.lpTextBox = new System.Windows.Forms.TextBox();
            this.miesiacComboBox = new System.Windows.Forms.ComboBox();
            this.paragrafTextBox = new System.Windows.Forms.TextBox();
            this.pozycja_paragrafTextBox = new System.Windows.Forms.TextBox();
            this.nr_fakturyTextBox = new System.Windows.Forms.TextBox();
            this.data_fakturyTextBox = new System.Windows.Forms.TextBox();
            this.dostawcaTextBox = new System.Windows.Forms.TextBox();
            this.specyfikacjaTextBox = new System.Windows.Forms.TextBox();
            this.iloscTextBox = new System.Windows.Forms.TextBox();
            this.jednostka_miaryComboBox = new System.Windows.Forms.ComboBox();
            this.indeks_finansowyTextBox = new System.Windows.Forms.TextBox();
            this.rodzaj_ewidencjiComboBox = new System.Windows.Forms.ComboBox();
            this.wartoscTextBox = new System.Windows.Forms.TextBox();
            this.termin_platnosciTextBox = new System.Windows.Forms.TextBox();
            this.sposob_zaplatyComboBox = new System.Windows.Forms.ComboBox();
            this.przekazano_do_DFTextBox = new System.Windows.Forms.TextBox();
            this.nazwisko_ImieTextBox = new System.Windows.Forms.TextBox();
            this.opis_fakturyTextBox = new System.Windows.Forms.TextBox();
            this.fakturyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ewidencjaDataSet = new EwiInf.EwidencjaDataSet();
            this.lpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miesiacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paragrafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozycjaparagrafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrfakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specyfikacjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jednostkamiaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indeksfinansowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajewidencjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminplatnosciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sposobzaplatyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przekazanodoDFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoImieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisfakturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakturyTableAdapter = new EwiInf.EwidencjaDataSetTableAdapters.FakturyTableAdapter();
            this.tableAdapterManager = new EwiInf.EwidencjaDataSetTableAdapters.TableAdapterManager();
            lpLabel = new System.Windows.Forms.Label();
            miesiacLabel = new System.Windows.Forms.Label();
            paragrafLabel = new System.Windows.Forms.Label();
            pozycja_paragrafLabel = new System.Windows.Forms.Label();
            nr_fakturyLabel = new System.Windows.Forms.Label();
            data_fakturyLabel = new System.Windows.Forms.Label();
            dostawcaLabel = new System.Windows.Forms.Label();
            specyfikacjaLabel = new System.Windows.Forms.Label();
            iloscLabel = new System.Windows.Forms.Label();
            jednostka_miaryLabel = new System.Windows.Forms.Label();
            indeks_finansowyLabel = new System.Windows.Forms.Label();
            rodzaj_ewidencjiLabel = new System.Windows.Forms.Label();
            wartoscLabel = new System.Windows.Forms.Label();
            termin_platnosciLabel = new System.Windows.Forms.Label();
            przekazano_do_DFLabel = new System.Windows.Forms.Label();
            nazwisko_ImieLabel = new System.Windows.Forms.Label();
            opis_fakturyLabel = new System.Windows.Forms.Label();
            sposob_zaplatyLabel = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelControlButton.SuspendLayout();
            this.panelAddFaktura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lpLabel
            // 
            lpLabel.AutoSize = true;
            lpLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            lpLabel.Location = new System.Drawing.Point(38, 12);
            lpLabel.Name = "lpLabel";
            lpLabel.Size = new System.Drawing.Size(32, 19);
            lpLabel.TabIndex = 0;
            lpLabel.Text = "Lp:";
            // 
            // miesiacLabel
            // 
            miesiacLabel.AutoSize = true;
            miesiacLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            miesiacLabel.Location = new System.Drawing.Point(38, 44);
            miesiacLabel.Name = "miesiacLabel";
            miesiacLabel.Size = new System.Drawing.Size(69, 19);
            miesiacLabel.TabIndex = 2;
            miesiacLabel.Text = "Miesiac:";
            // 
            // paragrafLabel
            // 
            paragrafLabel.AutoSize = true;
            paragrafLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            paragrafLabel.Location = new System.Drawing.Point(38, 80);
            paragrafLabel.Name = "paragrafLabel";
            paragrafLabel.Size = new System.Drawing.Size(77, 19);
            paragrafLabel.TabIndex = 4;
            paragrafLabel.Text = "Paragraf:";
            // 
            // pozycja_paragrafLabel
            // 
            pozycja_paragrafLabel.AutoSize = true;
            pozycja_paragrafLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            pozycja_paragrafLabel.Location = new System.Drawing.Point(38, 112);
            pozycja_paragrafLabel.Name = "pozycja_paragrafLabel";
            pozycja_paragrafLabel.Size = new System.Drawing.Size(138, 19);
            pozycja_paragrafLabel.TabIndex = 6;
            pozycja_paragrafLabel.Text = "Pozycja paragraf:";
            // 
            // nr_fakturyLabel
            // 
            nr_fakturyLabel.AutoSize = true;
            nr_fakturyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nr_fakturyLabel.Location = new System.Drawing.Point(38, 145);
            nr_fakturyLabel.Name = "nr_fakturyLabel";
            nr_fakturyLabel.Size = new System.Drawing.Size(89, 19);
            nr_fakturyLabel.TabIndex = 8;
            nr_fakturyLabel.Text = "Nr faktury:";
            // 
            // data_fakturyLabel
            // 
            data_fakturyLabel.AutoSize = true;
            data_fakturyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            data_fakturyLabel.Location = new System.Drawing.Point(38, 177);
            data_fakturyLabel.Name = "data_fakturyLabel";
            data_fakturyLabel.Size = new System.Drawing.Size(106, 19);
            data_fakturyLabel.TabIndex = 10;
            data_fakturyLabel.Text = "Data faktury:";
            // 
            // dostawcaLabel
            // 
            dostawcaLabel.AutoSize = true;
            dostawcaLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dostawcaLabel.Location = new System.Drawing.Point(38, 210);
            dostawcaLabel.Name = "dostawcaLabel";
            dostawcaLabel.Size = new System.Drawing.Size(85, 19);
            dostawcaLabel.TabIndex = 12;
            dostawcaLabel.Text = "Dostawca:";
            // 
            // specyfikacjaLabel
            // 
            specyfikacjaLabel.AutoSize = true;
            specyfikacjaLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            specyfikacjaLabel.Location = new System.Drawing.Point(38, 242);
            specyfikacjaLabel.Name = "specyfikacjaLabel";
            specyfikacjaLabel.Size = new System.Drawing.Size(105, 19);
            specyfikacjaLabel.TabIndex = 14;
            specyfikacjaLabel.Text = "Specyfikacja:";
            // 
            // iloscLabel
            // 
            iloscLabel.AutoSize = true;
            iloscLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            iloscLabel.Location = new System.Drawing.Point(38, 274);
            iloscLabel.Name = "iloscLabel";
            iloscLabel.Size = new System.Drawing.Size(48, 19);
            iloscLabel.TabIndex = 16;
            iloscLabel.Text = "Ilosc:";
            // 
            // jednostka_miaryLabel
            // 
            jednostka_miaryLabel.AutoSize = true;
            jednostka_miaryLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            jednostka_miaryLabel.Location = new System.Drawing.Point(38, 306);
            jednostka_miaryLabel.Name = "jednostka_miaryLabel";
            jednostka_miaryLabel.Size = new System.Drawing.Size(133, 19);
            jednostka_miaryLabel.TabIndex = 18;
            jednostka_miaryLabel.Text = "Jednostka miary:";
            // 
            // indeks_finansowyLabel
            // 
            indeks_finansowyLabel.AutoSize = true;
            indeks_finansowyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            indeks_finansowyLabel.Location = new System.Drawing.Point(37, 339);
            indeks_finansowyLabel.Name = "indeks_finansowyLabel";
            indeks_finansowyLabel.Size = new System.Drawing.Size(143, 19);
            indeks_finansowyLabel.TabIndex = 20;
            indeks_finansowyLabel.Text = "Indeks finansowy:";
            // 
            // rodzaj_ewidencjiLabel
            // 
            rodzaj_ewidencjiLabel.AutoSize = true;
            rodzaj_ewidencjiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rodzaj_ewidencjiLabel.Location = new System.Drawing.Point(38, 374);
            rodzaj_ewidencjiLabel.Name = "rodzaj_ewidencjiLabel";
            rodzaj_ewidencjiLabel.Size = new System.Drawing.Size(141, 19);
            rodzaj_ewidencjiLabel.TabIndex = 22;
            rodzaj_ewidencjiLabel.Text = "Rodzaj ewidencji:";
            // 
            // wartoscLabel
            // 
            wartoscLabel.AutoSize = true;
            wartoscLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wartoscLabel.Location = new System.Drawing.Point(38, 408);
            wartoscLabel.Name = "wartoscLabel";
            wartoscLabel.Size = new System.Drawing.Size(73, 19);
            wartoscLabel.TabIndex = 24;
            wartoscLabel.Text = "Wartosc:";
            // 
            // termin_platnosciLabel
            // 
            termin_platnosciLabel.AutoSize = true;
            termin_platnosciLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            termin_platnosciLabel.Location = new System.Drawing.Point(38, 440);
            termin_platnosciLabel.Name = "termin_platnosciLabel";
            termin_platnosciLabel.Size = new System.Drawing.Size(139, 19);
            termin_platnosciLabel.TabIndex = 26;
            termin_platnosciLabel.Text = "Termin platnosci:";
            // 
            // przekazano_do_DFLabel
            // 
            przekazano_do_DFLabel.AutoSize = true;
            przekazano_do_DFLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            przekazano_do_DFLabel.Location = new System.Drawing.Point(37, 506);
            przekazano_do_DFLabel.Name = "przekazano_do_DFLabel";
            przekazano_do_DFLabel.Size = new System.Drawing.Size(147, 19);
            przekazano_do_DFLabel.TabIndex = 30;
            przekazano_do_DFLabel.Text = "Przekazano do DF:";
            // 
            // nazwisko_ImieLabel
            // 
            nazwisko_ImieLabel.AutoSize = true;
            nazwisko_ImieLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazwisko_ImieLabel.Location = new System.Drawing.Point(37, 543);
            nazwisko_ImieLabel.Name = "nazwisko_ImieLabel";
            nazwisko_ImieLabel.Size = new System.Drawing.Size(121, 19);
            nazwisko_ImieLabel.TabIndex = 32;
            nazwisko_ImieLabel.Text = "Nazwisko Imie:";
            // 
            // opis_fakturyLabel
            // 
            opis_fakturyLabel.AutoSize = true;
            opis_fakturyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            opis_fakturyLabel.Location = new System.Drawing.Point(37, 578);
            opis_fakturyLabel.Name = "opis_fakturyLabel";
            opis_fakturyLabel.Size = new System.Drawing.Size(104, 19);
            opis_fakturyLabel.TabIndex = 34;
            opis_fakturyLabel.Text = "Opis faktury:";
            // 
            // sposob_zaplatyLabel
            // 
            sposob_zaplatyLabel.AutoSize = true;
            sposob_zaplatyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sposob_zaplatyLabel.Location = new System.Drawing.Point(38, 472);
            sposob_zaplatyLabel.Name = "sposob_zaplatyLabel";
            sposob_zaplatyLabel.Size = new System.Drawing.Size(124, 19);
            sposob_zaplatyLabel.TabIndex = 28;
            sposob_zaplatyLabel.Text = "Sposob zaplaty:";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1384, 50);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(638, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Faktury:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1294, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Michał Manios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1310, 62);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpDataGridViewTextBoxColumn,
            this.miesiacDataGridViewTextBoxColumn,
            this.paragrafDataGridViewTextBoxColumn,
            this.pozycjaparagrafDataGridViewTextBoxColumn,
            this.nrfakturyDataGridViewTextBoxColumn,
            this.datafakturyDataGridViewTextBoxColumn,
            this.dostawcaDataGridViewTextBoxColumn,
            this.specyfikacjaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.jednostkamiaryDataGridViewTextBoxColumn,
            this.indeksfinansowyDataGridViewTextBoxColumn,
            this.rodzajewidencjiDataGridViewTextBoxColumn,
            this.wartoscDataGridViewTextBoxColumn,
            this.terminplatnosciDataGridViewTextBoxColumn,
            this.sposobzaplatyDataGridViewTextBoxColumn,
            this.przekazanodoDFDataGridViewTextBoxColumn,
            this.nazwiskoImieDataGridViewTextBoxColumn,
            this.opisfakturyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fakturyBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.dataGridView1.Size = new System.Drawing.Size(1384, 595);
            this.dataGridView1.TabIndex = 6;
            // 
            // panelControlButton
            // 
            this.panelControlButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelControlButton.Controls.Add(this.bEdit);
            this.panelControlButton.Controls.Add(this.bAddPositionAtFaktura);
            this.panelControlButton.Controls.Add(this.bEnterSearch);
            this.panelControlButton.Controls.Add(this.textBoxSearch);
            this.panelControlButton.Controls.Add(this.btPrint);
            this.panelControlButton.Controls.Add(this.bFind);
            this.panelControlButton.Controls.Add(this.label4);
            this.panelControlButton.Controls.Add(this.label3);
            this.panelControlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlButton.Location = new System.Drawing.Point(0, 645);
            this.panelControlButton.Name = "panelControlButton";
            this.panelControlButton.Size = new System.Drawing.Size(1384, 100);
            this.panelControlButton.TabIndex = 5;
            this.panelControlButton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlButton_Paint);
            // 
            // bEdit
            // 
            this.bEdit.BackgroundImage = global::EwiInf.Properties.Resources._5891647491535351484_64;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bEdit.Location = new System.Drawing.Point(100, 15);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(60, 60);
            this.bEdit.TabIndex = 63;
            this.toolTip1.SetToolTip(this.bEdit, "Edytuj wybrany rekord");
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Visible = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAddPositionAtFaktura
            // 
            this.bAddPositionAtFaktura.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bAddPositionAtFaktura.BackgroundImage = global::EwiInf.Properties.Resources._19265206991579511413_64;
            this.bAddPositionAtFaktura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddPositionAtFaktura.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAddPositionAtFaktura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddPositionAtFaktura.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bAddPositionAtFaktura.Location = new System.Drawing.Point(26, 15);
            this.bAddPositionAtFaktura.Name = "bAddPositionAtFaktura";
            this.bAddPositionAtFaktura.Size = new System.Drawing.Size(60, 60);
            this.bAddPositionAtFaktura.TabIndex = 62;
            this.toolTip1.SetToolTip(this.bAddPositionAtFaktura, "Wprowadź fakturę");
            this.bAddPositionAtFaktura.UseVisualStyleBackColor = false;
            this.bAddPositionAtFaktura.Click += new System.EventHandler(this.bAddPositionAtFaktura_Click);
            // 
            // bEnterSearch
            // 
            this.bEnterSearch.BackgroundImage = global::EwiInf.Properties.Resources._16755934531579697357_641;
            this.bEnterSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnterSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bEnterSearch.Location = new System.Drawing.Point(740, 15);
            this.bEnterSearch.Name = "bEnterSearch";
            this.bEnterSearch.Size = new System.Drawing.Size(60, 60);
            this.bEnterSearch.TabIndex = 61;
            this.toolTip1.SetToolTip(this.bEnterSearch, "Znajdź");
            this.bEnterSearch.UseVisualStyleBackColor = false;
            this.bEnterSearch.Visible = false;
            this.bEnterSearch.Click += new System.EventHandler(this.bEnterSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearch.Location = new System.Drawing.Point(331, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(389, 20);
            this.textBoxSearch.TabIndex = 60;
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearch.Visible = false;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.BackgroundImage = global::EwiInf.Properties.Resources._1820249201578889576_64;
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.Location = new System.Drawing.Point(173, 15);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(60, 60);
            this.btPrint.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btPrint, "Zapisz do pdf wskazaną fakturę");
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // bFind
            // 
            this.bFind.BackgroundImage = global::EwiInf.Properties.Resources._19543538161579680322_64;
            this.bFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFind.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bFind.Location = new System.Drawing.Point(252, 15);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(60, 60);
            this.bFind.TabIndex = 6;
            this.toolTip1.SetToolTip(this.bFind, "Szukaj");
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancel.BackgroundImage")));
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bCancel.Location = new System.Drawing.Point(398, 643);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(40, 40);
            this.bCancel.TabIndex = 38;
            this.toolTip1.SetToolTip(this.bCancel, "Cofnij do okna głównego");
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = global::EwiInf.Properties.Resources._13898481211537356036_64;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.bSave.Location = new System.Drawing.Point(240, 643);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(40, 40);
            this.bSave.TabIndex = 37;
            this.toolTip1.SetToolTip(this.bSave, "Zapisz");
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // panelAddFaktura
            // 
            this.panelAddFaktura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddFaktura.Controls.Add(this.bCancel);
            this.panelAddFaktura.Controls.Add(this.bSave);
            this.panelAddFaktura.Controls.Add(sposob_zaplatyLabel);
            this.panelAddFaktura.Controls.Add(this.sposob_zaplatyComboBox);
            this.panelAddFaktura.Controls.Add(lpLabel);
            this.panelAddFaktura.Controls.Add(this.lpTextBox);
            this.panelAddFaktura.Controls.Add(miesiacLabel);
            this.panelAddFaktura.Controls.Add(this.miesiacComboBox);
            this.panelAddFaktura.Controls.Add(paragrafLabel);
            this.panelAddFaktura.Controls.Add(this.paragrafTextBox);
            this.panelAddFaktura.Controls.Add(pozycja_paragrafLabel);
            this.panelAddFaktura.Controls.Add(this.pozycja_paragrafTextBox);
            this.panelAddFaktura.Controls.Add(nr_fakturyLabel);
            this.panelAddFaktura.Controls.Add(this.nr_fakturyTextBox);
            this.panelAddFaktura.Controls.Add(data_fakturyLabel);
            this.panelAddFaktura.Controls.Add(this.data_fakturyTextBox);
            this.panelAddFaktura.Controls.Add(dostawcaLabel);
            this.panelAddFaktura.Controls.Add(this.dostawcaTextBox);
            this.panelAddFaktura.Controls.Add(specyfikacjaLabel);
            this.panelAddFaktura.Controls.Add(this.specyfikacjaTextBox);
            this.panelAddFaktura.Controls.Add(iloscLabel);
            this.panelAddFaktura.Controls.Add(this.iloscTextBox);
            this.panelAddFaktura.Controls.Add(jednostka_miaryLabel);
            this.panelAddFaktura.Controls.Add(this.jednostka_miaryComboBox);
            this.panelAddFaktura.Controls.Add(indeks_finansowyLabel);
            this.panelAddFaktura.Controls.Add(this.indeks_finansowyTextBox);
            this.panelAddFaktura.Controls.Add(rodzaj_ewidencjiLabel);
            this.panelAddFaktura.Controls.Add(this.rodzaj_ewidencjiComboBox);
            this.panelAddFaktura.Controls.Add(wartoscLabel);
            this.panelAddFaktura.Controls.Add(this.wartoscTextBox);
            this.panelAddFaktura.Controls.Add(termin_platnosciLabel);
            this.panelAddFaktura.Controls.Add(this.termin_platnosciTextBox);
            this.panelAddFaktura.Controls.Add(przekazano_do_DFLabel);
            this.panelAddFaktura.Controls.Add(this.przekazano_do_DFTextBox);
            this.panelAddFaktura.Controls.Add(nazwisko_ImieLabel);
            this.panelAddFaktura.Controls.Add(this.nazwisko_ImieTextBox);
            this.panelAddFaktura.Controls.Add(opis_fakturyLabel);
            this.panelAddFaktura.Controls.Add(this.opis_fakturyTextBox);
            this.panelAddFaktura.Location = new System.Drawing.Point(415, 53);
            this.panelAddFaktura.Name = "panelAddFaktura";
            this.panelAddFaktura.Size = new System.Drawing.Size(650, 692);
            this.panelAddFaktura.TabIndex = 0;
            this.panelAddFaktura.Visible = false;
            
            // 
            // lpTextBox
            // 
            this.lpTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Lp", true));
            this.lpTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lpTextBox.Location = new System.Drawing.Point(186, 9);
            this.lpTextBox.Name = "lpTextBox";
            this.lpTextBox.ReadOnly = true;
            this.lpTextBox.Size = new System.Drawing.Size(416, 26);
            this.lpTextBox.TabIndex = 1;
            this.lpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // miesiacComboBox
            // 
            this.miesiacComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Miesiac", true));
            this.miesiacComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.miesiacComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.miesiacComboBox.FormattingEnabled = true;
            this.miesiacComboBox.Items.AddRange(new object[] {
            "STYCZEŃ",
            "LUTY",
            "MARZEC",
            "KWIECIEŃ",
            "MAJ",
            "CZERWIEC",
            "LIPIEC",
            "SIERPIEŃ",
            "WRZESIEŃ",
            "PAŹDZIERNIK",
            "LISTOPAD",
            "GRUDZIEŃ"});
            this.miesiacComboBox.Location = new System.Drawing.Point(186, 41);
            this.miesiacComboBox.Name = "miesiacComboBox";
            this.miesiacComboBox.Size = new System.Drawing.Size(416, 27);
            this.miesiacComboBox.TabIndex = 3;
            // 
            // paragrafTextBox
            // 
            this.paragrafTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.paragrafTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Paragraf", true));
            this.paragrafTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paragrafTextBox.Location = new System.Drawing.Point(186, 77);
            this.paragrafTextBox.MaxLength = 4;
            this.paragrafTextBox.Name = "paragrafTextBox";
            this.paragrafTextBox.Size = new System.Drawing.Size(416, 26);
            this.paragrafTextBox.TabIndex = 5;
            this.paragrafTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paragrafTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // pozycja_paragrafTextBox
            // 
            this.pozycja_paragrafTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pozycja_paragrafTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Pozycja_paragraf", true));
            this.pozycja_paragrafTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pozycja_paragrafTextBox.Location = new System.Drawing.Point(186, 109);
            this.pozycja_paragrafTextBox.MaxLength = 2;
            this.pozycja_paragrafTextBox.Name = "pozycja_paragrafTextBox";
            this.pozycja_paragrafTextBox.Size = new System.Drawing.Size(416, 26);
            this.pozycja_paragrafTextBox.TabIndex = 7;
            this.pozycja_paragrafTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pozycja_paragrafTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // nr_fakturyTextBox
            // 
            this.nr_fakturyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nr_fakturyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Nr_faktury", true));
            this.nr_fakturyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_fakturyTextBox.Location = new System.Drawing.Point(186, 142);
            this.nr_fakturyTextBox.Name = "nr_fakturyTextBox";
            this.nr_fakturyTextBox.Size = new System.Drawing.Size(416, 26);
            this.nr_fakturyTextBox.TabIndex = 9;
            this.nr_fakturyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data_fakturyTextBox
            // 
            this.data_fakturyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.data_fakturyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Data_faktury", true));
            this.data_fakturyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data_fakturyTextBox.Location = new System.Drawing.Point(186, 174);
            this.data_fakturyTextBox.MaxLength = 10;
            this.data_fakturyTextBox.Name = "data_fakturyTextBox";
            this.data_fakturyTextBox.Size = new System.Drawing.Size(416, 26);
            this.data_fakturyTextBox.TabIndex = 11;
            this.data_fakturyTextBox.Text = "DD.MM.RRRR";
            this.data_fakturyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.data_fakturyTextBox.Enter += new System.EventHandler(this.EnterDate);
            this.data_fakturyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateKeyPres);
            // 
            // dostawcaTextBox
            // 
            this.dostawcaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dostawcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Dostawca", true));
            this.dostawcaTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dostawcaTextBox.Location = new System.Drawing.Point(186, 207);
            this.dostawcaTextBox.Name = "dostawcaTextBox";
            this.dostawcaTextBox.Size = new System.Drawing.Size(416, 26);
            this.dostawcaTextBox.TabIndex = 13;
            this.dostawcaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // specyfikacjaTextBox
            // 
            this.specyfikacjaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.specyfikacjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Specyfikacja", true));
            this.specyfikacjaTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.specyfikacjaTextBox.Location = new System.Drawing.Point(186, 239);
            this.specyfikacjaTextBox.Name = "specyfikacjaTextBox";
            this.specyfikacjaTextBox.Size = new System.Drawing.Size(416, 26);
            this.specyfikacjaTextBox.TabIndex = 15;
            this.specyfikacjaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iloscTextBox
            // 
            this.iloscTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.iloscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Ilosc", true));
            this.iloscTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscTextBox.Location = new System.Drawing.Point(186, 271);
            this.iloscTextBox.Name = "iloscTextBox";
            this.iloscTextBox.Size = new System.Drawing.Size(416, 26);
            this.iloscTextBox.TabIndex = 17;
            this.iloscTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iloscTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // jednostka_miaryComboBox
            // 
            this.jednostka_miaryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Jednostka_miary", true));
            this.jednostka_miaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jednostka_miaryComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jednostka_miaryComboBox.FormattingEnabled = true;
            this.jednostka_miaryComboBox.Items.AddRange(new object[] {
            "SZT.",
            "KPL.",
            "ZESTAW"});
            this.jednostka_miaryComboBox.Location = new System.Drawing.Point(186, 303);
            this.jednostka_miaryComboBox.Name = "jednostka_miaryComboBox";
            this.jednostka_miaryComboBox.Size = new System.Drawing.Size(416, 27);
            this.jednostka_miaryComboBox.TabIndex = 19;
            // 
            // indeks_finansowyTextBox
            // 
            this.indeks_finansowyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.indeks_finansowyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Indeks_finansowy", true));
            this.indeks_finansowyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.indeks_finansowyTextBox.Location = new System.Drawing.Point(186, 336);
            this.indeks_finansowyTextBox.Name = "indeks_finansowyTextBox";
            this.indeks_finansowyTextBox.Size = new System.Drawing.Size(416, 26);
            this.indeks_finansowyTextBox.TabIndex = 21;
            this.indeks_finansowyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indeks_finansowyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // rodzaj_ewidencjiComboBox
            // 
            this.rodzaj_ewidencjiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Rodzaj_ewidencji", true));
            this.rodzaj_ewidencjiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rodzaj_ewidencjiComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rodzaj_ewidencjiComboBox.FormattingEnabled = true;
            this.rodzaj_ewidencjiComboBox.Items.AddRange(new object[] {
            "POWYŻEJ",
            "PONIŻEJ",
            "RODEK TRWAŁY"});
            this.rodzaj_ewidencjiComboBox.Location = new System.Drawing.Point(185, 371);
            this.rodzaj_ewidencjiComboBox.Name = "rodzaj_ewidencjiComboBox";
            this.rodzaj_ewidencjiComboBox.Size = new System.Drawing.Size(417, 27);
            this.rodzaj_ewidencjiComboBox.TabIndex = 23;
            // 
            // wartoscTextBox
            // 
            this.wartoscTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wartoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Wartosc", true));
            this.wartoscTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wartoscTextBox.Location = new System.Drawing.Point(185, 405);
            this.wartoscTextBox.Name = "wartoscTextBox";
            this.wartoscTextBox.Size = new System.Drawing.Size(417, 26);
            this.wartoscTextBox.TabIndex = 25;
            this.wartoscTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wartoscTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wartoscTextBox_KeyPress);
            // 
            // termin_platnosciTextBox
            // 
            this.termin_platnosciTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.termin_platnosciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Termin_platnosci", true));
            this.termin_platnosciTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termin_platnosciTextBox.Location = new System.Drawing.Point(186, 437);
            this.termin_platnosciTextBox.MaxLength = 10;
            this.termin_platnosciTextBox.Name = "termin_platnosciTextBox";
            this.termin_platnosciTextBox.Size = new System.Drawing.Size(416, 26);
            this.termin_platnosciTextBox.TabIndex = 27;
            this.termin_platnosciTextBox.Text = "DD.MM.RRRR";
            this.termin_platnosciTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.termin_platnosciTextBox.Enter += new System.EventHandler(this.EnterDate);
            this.termin_platnosciTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateKeyPres);
            // 
            // sposob_zaplatyComboBox
            // 
            this.sposob_zaplatyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Sposob_zaplaty", true));
            this.sposob_zaplatyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sposob_zaplatyComboBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sposob_zaplatyComboBox.FormattingEnabled = true;
            this.sposob_zaplatyComboBox.Items.AddRange(new object[] {
            "PRZELEW",
            "GOTÓWKA"});
            this.sposob_zaplatyComboBox.Location = new System.Drawing.Point(185, 469);
            this.sposob_zaplatyComboBox.Name = "sposob_zaplatyComboBox";
            this.sposob_zaplatyComboBox.Size = new System.Drawing.Size(417, 27);
            this.sposob_zaplatyComboBox.TabIndex = 29;
            // 
            // przekazano_do_DFTextBox
            // 
            this.przekazano_do_DFTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.przekazano_do_DFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Przekazano_do_DF", true));
            this.przekazano_do_DFTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przekazano_do_DFTextBox.Location = new System.Drawing.Point(186, 506);
            this.przekazano_do_DFTextBox.MaxLength = 10;
            this.przekazano_do_DFTextBox.Name = "przekazano_do_DFTextBox";
            this.przekazano_do_DFTextBox.Size = new System.Drawing.Size(416, 26);
            this.przekazano_do_DFTextBox.TabIndex = 31;
            this.przekazano_do_DFTextBox.Text = "DD.MM.RRRR";
            this.przekazano_do_DFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.przekazano_do_DFTextBox.Enter += new System.EventHandler(this.EnterDate);
            this.przekazano_do_DFTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateKeyPres);
            // 
            // nazwisko_ImieTextBox
            // 
            this.nazwisko_ImieTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nazwisko_ImieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Nazwisko_Imie", true));
            this.nazwisko_ImieTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko_ImieTextBox.Location = new System.Drawing.Point(185, 540);
            this.nazwisko_ImieTextBox.Name = "nazwisko_ImieTextBox";
            this.nazwisko_ImieTextBox.Size = new System.Drawing.Size(417, 26);
            this.nazwisko_ImieTextBox.TabIndex = 33;
            this.nazwisko_ImieTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nazwisko_ImieTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nazwisko_ImieTextBox_KeyPress);
            // 
            // opis_fakturyTextBox
            // 
            this.opis_fakturyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.opis_fakturyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakturyBindingSource, "Opis_faktury", true));
            this.opis_fakturyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opis_fakturyTextBox.Location = new System.Drawing.Point(186, 575);
            this.opis_fakturyTextBox.Multiline = true;
            this.opis_fakturyTextBox.Name = "opis_fakturyTextBox";
            this.opis_fakturyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opis_fakturyTextBox.Size = new System.Drawing.Size(416, 62);
            this.opis_fakturyTextBox.TabIndex = 35;
            // 
            // fakturyBindingSource
            // 
            this.fakturyBindingSource.DataMember = "Faktury";
            this.fakturyBindingSource.DataSource = this.ewidencjaDataSet;
            // 
            // ewidencjaDataSet
            // 
            this.ewidencjaDataSet.DataSetName = "EwidencjaDataSet";
            this.ewidencjaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lpDataGridViewTextBoxColumn
            // 
            this.lpDataGridViewTextBoxColumn.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn.Name = "lpDataGridViewTextBoxColumn";
            this.lpDataGridViewTextBoxColumn.ReadOnly = true;
            this.lpDataGridViewTextBoxColumn.Width = 53;
            // 
            // miesiacDataGridViewTextBoxColumn
            // 
            this.miesiacDataGridViewTextBoxColumn.DataPropertyName = "Miesiac";
            this.miesiacDataGridViewTextBoxColumn.HeaderText = "Miesiąc";
            this.miesiacDataGridViewTextBoxColumn.Name = "miesiacDataGridViewTextBoxColumn";
            this.miesiacDataGridViewTextBoxColumn.ReadOnly = true;
            this.miesiacDataGridViewTextBoxColumn.Width = 90;
            // 
            // paragrafDataGridViewTextBoxColumn
            // 
            this.paragrafDataGridViewTextBoxColumn.DataPropertyName = "Paragraf";
            this.paragrafDataGridViewTextBoxColumn.HeaderText = "Paragraf";
            this.paragrafDataGridViewTextBoxColumn.Name = "paragrafDataGridViewTextBoxColumn";
            this.paragrafDataGridViewTextBoxColumn.ReadOnly = true;
            this.paragrafDataGridViewTextBoxColumn.Width = 98;
            // 
            // pozycjaparagrafDataGridViewTextBoxColumn
            // 
            this.pozycjaparagrafDataGridViewTextBoxColumn.DataPropertyName = "Pozycja_paragraf";
            this.pozycjaparagrafDataGridViewTextBoxColumn.HeaderText = "Pozycja paragraf";
            this.pozycjaparagrafDataGridViewTextBoxColumn.Name = "pozycjaparagrafDataGridViewTextBoxColumn";
            this.pozycjaparagrafDataGridViewTextBoxColumn.ReadOnly = true;
            this.pozycjaparagrafDataGridViewTextBoxColumn.Width = 145;
            // 
            // nrfakturyDataGridViewTextBoxColumn
            // 
            this.nrfakturyDataGridViewTextBoxColumn.DataPropertyName = "Nr_faktury";
            this.nrfakturyDataGridViewTextBoxColumn.HeaderText = "Nr faktury";
            this.nrfakturyDataGridViewTextBoxColumn.Name = "nrfakturyDataGridViewTextBoxColumn";
            this.nrfakturyDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrfakturyDataGridViewTextBoxColumn.Width = 101;
            // 
            // datafakturyDataGridViewTextBoxColumn
            // 
            this.datafakturyDataGridViewTextBoxColumn.DataPropertyName = "Data_faktury";
            this.datafakturyDataGridViewTextBoxColumn.HeaderText = "Data faktury";
            this.datafakturyDataGridViewTextBoxColumn.Name = "datafakturyDataGridViewTextBoxColumn";
            this.datafakturyDataGridViewTextBoxColumn.ReadOnly = true;
            this.datafakturyDataGridViewTextBoxColumn.Width = 116;
            // 
            // dostawcaDataGridViewTextBoxColumn
            // 
            this.dostawcaDataGridViewTextBoxColumn.DataPropertyName = "Dostawca";
            this.dostawcaDataGridViewTextBoxColumn.HeaderText = "Dostawca";
            this.dostawcaDataGridViewTextBoxColumn.Name = "dostawcaDataGridViewTextBoxColumn";
            this.dostawcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dostawcaDataGridViewTextBoxColumn.Width = 106;
            // 
            // specyfikacjaDataGridViewTextBoxColumn
            // 
            this.specyfikacjaDataGridViewTextBoxColumn.DataPropertyName = "Specyfikacja";
            this.specyfikacjaDataGridViewTextBoxColumn.HeaderText = "Specyfikacja";
            this.specyfikacjaDataGridViewTextBoxColumn.Name = "specyfikacjaDataGridViewTextBoxColumn";
            this.specyfikacjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.specyfikacjaDataGridViewTextBoxColumn.Width = 126;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            this.iloscDataGridViewTextBoxColumn.Width = 69;
            // 
            // jednostkamiaryDataGridViewTextBoxColumn
            // 
            this.jednostkamiaryDataGridViewTextBoxColumn.DataPropertyName = "Jednostka_miary";
            this.jednostkamiaryDataGridViewTextBoxColumn.HeaderText = "Jednostka miary";
            this.jednostkamiaryDataGridViewTextBoxColumn.Name = "jednostkamiaryDataGridViewTextBoxColumn";
            this.jednostkamiaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.jednostkamiaryDataGridViewTextBoxColumn.Width = 141;
            // 
            // indeksfinansowyDataGridViewTextBoxColumn
            // 
            this.indeksfinansowyDataGridViewTextBoxColumn.DataPropertyName = "Indeks_finansowy";
            this.indeksfinansowyDataGridViewTextBoxColumn.HeaderText = "Indeks finansowy";
            this.indeksfinansowyDataGridViewTextBoxColumn.Name = "indeksfinansowyDataGridViewTextBoxColumn";
            this.indeksfinansowyDataGridViewTextBoxColumn.ReadOnly = true;
            this.indeksfinansowyDataGridViewTextBoxColumn.Width = 150;
            // 
            // rodzajewidencjiDataGridViewTextBoxColumn
            // 
            this.rodzajewidencjiDataGridViewTextBoxColumn.DataPropertyName = "Rodzaj_ewidencji";
            this.rodzajewidencjiDataGridViewTextBoxColumn.HeaderText = "Rodzaj ewidencji";
            this.rodzajewidencjiDataGridViewTextBoxColumn.Name = "rodzajewidencjiDataGridViewTextBoxColumn";
            this.rodzajewidencjiDataGridViewTextBoxColumn.ReadOnly = true;
            this.rodzajewidencjiDataGridViewTextBoxColumn.Width = 148;
            // 
            // wartoscDataGridViewTextBoxColumn
            // 
            this.wartoscDataGridViewTextBoxColumn.DataPropertyName = "Wartosc";
            this.wartoscDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.wartoscDataGridViewTextBoxColumn.Name = "wartoscDataGridViewTextBoxColumn";
            this.wartoscDataGridViewTextBoxColumn.ReadOnly = true;
            this.wartoscDataGridViewTextBoxColumn.Width = 94;
            // 
            // terminplatnosciDataGridViewTextBoxColumn
            // 
            this.terminplatnosciDataGridViewTextBoxColumn.DataPropertyName = "Termin_platnosci";
            this.terminplatnosciDataGridViewTextBoxColumn.HeaderText = "Termin płatności";
            this.terminplatnosciDataGridViewTextBoxColumn.Name = "terminplatnosciDataGridViewTextBoxColumn";
            this.terminplatnosciDataGridViewTextBoxColumn.ReadOnly = true;
            this.terminplatnosciDataGridViewTextBoxColumn.Width = 146;
            // 
            // sposobzaplatyDataGridViewTextBoxColumn
            // 
            this.sposobzaplatyDataGridViewTextBoxColumn.DataPropertyName = "Sposob_zaplaty";
            this.sposobzaplatyDataGridViewTextBoxColumn.HeaderText = "Sposób zapłaty";
            this.sposobzaplatyDataGridViewTextBoxColumn.Name = "sposobzaplatyDataGridViewTextBoxColumn";
            this.sposobzaplatyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sposobzaplatyDataGridViewTextBoxColumn.Width = 132;
            // 
            // przekazanodoDFDataGridViewTextBoxColumn
            // 
            this.przekazanodoDFDataGridViewTextBoxColumn.DataPropertyName = "Przekazano_do_DF";
            this.przekazanodoDFDataGridViewTextBoxColumn.HeaderText = "Przekazano do DF";
            this.przekazanodoDFDataGridViewTextBoxColumn.Name = "przekazanodoDFDataGridViewTextBoxColumn";
            this.przekazanodoDFDataGridViewTextBoxColumn.ReadOnly = true;
            this.przekazanodoDFDataGridViewTextBoxColumn.Width = 135;
            // 
            // nazwiskoImieDataGridViewTextBoxColumn
            // 
            this.nazwiskoImieDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko_Imie";
            this.nazwiskoImieDataGridViewTextBoxColumn.HeaderText = "Nazwisko Imię";
            this.nazwiskoImieDataGridViewTextBoxColumn.Name = "nazwiskoImieDataGridViewTextBoxColumn";
            this.nazwiskoImieDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoImieDataGridViewTextBoxColumn.Width = 130;
            // 
            // opisfakturyDataGridViewTextBoxColumn
            // 
            this.opisfakturyDataGridViewTextBoxColumn.DataPropertyName = "Opis_faktury";
            this.opisfakturyDataGridViewTextBoxColumn.HeaderText = "Opis faktury";
            this.opisfakturyDataGridViewTextBoxColumn.Name = "opisfakturyDataGridViewTextBoxColumn";
            this.opisfakturyDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisfakturyDataGridViewTextBoxColumn.Width = 114;
            // 
            // fakturyTableAdapter
            // 
            this.fakturyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ewidencja_ponizejTableAdapter = null;
            this.tableAdapterManager.Ewidencja_powyzejTableAdapter = null;
            this.tableAdapterManager.Ewidencja_STTableAdapter = null;
            this.tableAdapterManager.EwiTableAdapter = null;
            this.tableAdapterManager.FakturyTableAdapter = this.fakturyTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.Karta_konserwacjaTableAdapter = null;
            this.tableAdapterManager.Karta_naprawyTableAdapter = null;
            this.tableAdapterManager.KartaTableAdapter = null;
            this.tableAdapterManager.PonizejStanOtwarciaTableAdapter = null;
            this.tableAdapterManager.PowyzejStanOtwarciaTableAdapter = null;
            this.tableAdapterManager.StanOtwarciaSTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EwiInf.EwidencjaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Faktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelAddFaktura);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelControlButton);
            this.Name = "Faktura";
            this.Size = new System.Drawing.Size(1384, 745);
            this.Load += new System.EventHandler(this.Faktura_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelControlButton.ResumeLayout(false);
            this.panelControlButton.PerformLayout();
            this.panelAddFaktura.ResumeLayout(false);
            this.panelAddFaktura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelControlButton;
        private System.Windows.Forms.Button bEnterSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miesiacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paragrafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozycjaparagrafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrfakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specyfikacjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednostkamiaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeksfinansowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajewidencjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminplatnosciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sposobzaplatyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn przekazanodoDFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoImieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisfakturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fakturyBindingSource;
        private EwidencjaDataSet ewidencjaDataSet;
        private EwidencjaDataSetTableAdapters.FakturyTableAdapter fakturyTableAdapter;
        private System.Windows.Forms.Button bAddPositionAtFaktura;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelAddFaktura;
        
        private System.Windows.Forms.TextBox lpTextBox;
        private System.Windows.Forms.ComboBox miesiacComboBox;
        private System.Windows.Forms.TextBox paragrafTextBox;
        private System.Windows.Forms.TextBox pozycja_paragrafTextBox;
        private System.Windows.Forms.TextBox nr_fakturyTextBox;
        private System.Windows.Forms.TextBox data_fakturyTextBox;
        private System.Windows.Forms.TextBox dostawcaTextBox;
        private System.Windows.Forms.TextBox specyfikacjaTextBox;
        private System.Windows.Forms.TextBox iloscTextBox;
        private System.Windows.Forms.ComboBox jednostka_miaryComboBox;
        private System.Windows.Forms.TextBox indeks_finansowyTextBox;
        private System.Windows.Forms.ComboBox rodzaj_ewidencjiComboBox;
        private System.Windows.Forms.TextBox wartoscTextBox;
        private System.Windows.Forms.TextBox termin_platnosciTextBox;
        private System.Windows.Forms.ComboBox sposob_zaplatyComboBox;
        private System.Windows.Forms.TextBox przekazano_do_DFTextBox;
        private System.Windows.Forms.TextBox nazwisko_ImieTextBox;
        private System.Windows.Forms.TextBox opis_fakturyTextBox;
        private EwidencjaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
    }
}
