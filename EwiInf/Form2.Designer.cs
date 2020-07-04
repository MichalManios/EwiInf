namespace EwiInf
{
    partial class Form2
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nr_ewidencyjnyLabel;
            System.Windows.Forms.Label rodzaj_sprzętuLabel;
            System.Windows.Forms.Label nazwa_ProducentLabel;
            System.Windows.Forms.Label rok_produkcjiLabel;
            System.Windows.Forms.Label termin_gwarancjiLabel;
            System.Windows.Forms.Label nr_seryjnyLabel;
            System.Windows.Forms.Label wartosc_zakupuLabel;
            System.Windows.Forms.Label nr_fakturyLabel;
            System.Windows.Forms.Label rodzaj_ewidencjiLabel;
            System.Windows.Forms.Label mac_adresLabel;
            System.Windows.Forms.Label iP_adres1Label;
            System.Windows.Forms.Label iP_adres2Label;
            System.Windows.Forms.Label iP_adres3Label;
            System.Windows.Forms.Label karta_grafiki1Label;
            System.Windows.Forms.Label karta_grafiki2Label;
            System.Windows.Forms.Label ramLabel;
            System.Windows.Forms.Label dysk1Label;
            System.Windows.Forms.Label dysk2Label;
            System.Windows.Forms.Label budynekLabel;
            System.Windows.Forms.Label pietroLabel;
            System.Windows.Forms.Label pomieszczenieLabel;
            System.Windows.Forms.Label informatyka_LacznoscLabel;
            System.Windows.Forms.Label uwagiLabel;
            System.Windows.Forms.Label numer_kartyLabel1;
            System.Windows.Forms.Label system_operacyjnyLabel1;
            System.Windows.Forms.Label procesorLabel;
            System.Windows.Forms.Label index_finansowyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ewiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.ewiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ewidencjaDataSet = new EwiInf.EwidencjaDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ewiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nr_ewidencyjnyTextBox = new System.Windows.Forms.TextBox();
            this.rodzaj_sprzętuTextBox = new System.Windows.Forms.TextBox();
            this.nazwa_ProducentTextBox = new System.Windows.Forms.TextBox();
            this.rok_produkcjiTextBox = new System.Windows.Forms.TextBox();
            this.termin_gwarancjiTextBox = new System.Windows.Forms.TextBox();
            this.nr_seryjnyTextBox = new System.Windows.Forms.TextBox();
            this.wartosc_zakupuTextBox = new System.Windows.Forms.TextBox();
            this.nr_fakturyTextBox = new System.Windows.Forms.TextBox();
            this.rodzaj_ewidencjiTextBox = new System.Windows.Forms.TextBox();
            this.mac_adresTextBox = new System.Windows.Forms.TextBox();
            this.iP_adres1TextBox = new System.Windows.Forms.TextBox();
            this.iP_adres2TextBox = new System.Windows.Forms.TextBox();
            this.iP_adres3TextBox = new System.Windows.Forms.TextBox();
            this.karta_grafiki1TextBox = new System.Windows.Forms.TextBox();
            this.karta_grafiki2TextBox = new System.Windows.Forms.TextBox();
            this.procesorTextBox = new System.Windows.Forms.TextBox();
            this.ramTextBox = new System.Windows.Forms.TextBox();
            this.dysk1TextBox = new System.Windows.Forms.TextBox();
            this.dysk2TextBox = new System.Windows.Forms.TextBox();
            this.budynekTextBox = new System.Windows.Forms.TextBox();
            this.pietroTextBox = new System.Windows.Forms.TextBox();
            this.pomieszczenieTextBox = new System.Windows.Forms.TextBox();
            this.informatyka_LacznoscTextBox = new System.Windows.Forms.TextBox();
            this.uwagiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCreateCard = new System.Windows.Forms.CheckBox();
            this.comboBoxRodzajSprzetu = new System.Windows.Forms.ComboBox();
            this.comboBoxRodzajEwidencji = new System.Windows.Forms.ComboBox();
            this.comboBoxBudynek = new System.Windows.Forms.ComboBox();
            this.comboBoxPietro = new System.Windows.Forms.ComboBox();
            this.comboBoxPomieszczenie = new System.Windows.Forms.ComboBox();
            this.comboBoxInformatykaLacznosc = new System.Windows.Forms.ComboBox();
            this.ewiTableAdapter = new EwiInf.EwidencjaDataSetTableAdapters.EwiTableAdapter();
            this.tableAdapterManager = new EwiInf.EwidencjaDataSetTableAdapters.TableAdapterManager();
            this.numer_kartyTextBox1 = new System.Windows.Forms.TextBox();
            this.system_operacyjnyTextBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btPrintThisQR = new System.Windows.Forms.Button();
            this.btBackPrintThisQr = new System.Windows.Forms.Button();
            this.PrintQRCode = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btForwardOne = new System.Windows.Forms.Button();
            this.btBackwardOne = new System.Windows.Forms.Button();
            this.btMoveLas = new System.Windows.Forms.Button();
            this.btMoveFirst = new System.Windows.Forms.Button();
            this.btAddPomieszczenie = new System.Windows.Forms.Button();
            this.btAddPietro = new System.Windows.Forms.Button();
            this.btAddBudynek = new System.Windows.Forms.Button();
            this.btAddRodzajSprzetu = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.comboBoxWhatItem = new System.Windows.Forms.ComboBox();
            this.panelSteer = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbHowMuchOf = new System.Windows.Forms.Label();
            this.panelChoiceWherePrint = new System.Windows.Forms.Panel();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb14 = new System.Windows.Forms.RadioButton();
            this.rb11 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb13 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.index_finansowyTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nr_ewidencyjnyLabel = new System.Windows.Forms.Label();
            rodzaj_sprzętuLabel = new System.Windows.Forms.Label();
            nazwa_ProducentLabel = new System.Windows.Forms.Label();
            rok_produkcjiLabel = new System.Windows.Forms.Label();
            termin_gwarancjiLabel = new System.Windows.Forms.Label();
            nr_seryjnyLabel = new System.Windows.Forms.Label();
            wartosc_zakupuLabel = new System.Windows.Forms.Label();
            nr_fakturyLabel = new System.Windows.Forms.Label();
            rodzaj_ewidencjiLabel = new System.Windows.Forms.Label();
            mac_adresLabel = new System.Windows.Forms.Label();
            iP_adres1Label = new System.Windows.Forms.Label();
            iP_adres2Label = new System.Windows.Forms.Label();
            iP_adres3Label = new System.Windows.Forms.Label();
            karta_grafiki1Label = new System.Windows.Forms.Label();
            karta_grafiki2Label = new System.Windows.Forms.Label();
            ramLabel = new System.Windows.Forms.Label();
            dysk1Label = new System.Windows.Forms.Label();
            dysk2Label = new System.Windows.Forms.Label();
            budynekLabel = new System.Windows.Forms.Label();
            pietroLabel = new System.Windows.Forms.Label();
            pomieszczenieLabel = new System.Windows.Forms.Label();
            informatyka_LacznoscLabel = new System.Windows.Forms.Label();
            uwagiLabel = new System.Windows.Forms.Label();
            numer_kartyLabel1 = new System.Windows.Forms.Label();
            system_operacyjnyLabel1 = new System.Windows.Forms.Label();
            procesorLabel = new System.Windows.Forms.Label();
            index_finansowyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ewiBindingNavigator)).BeginInit();
            this.ewiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet)).BeginInit();
            this.panelSteer.SuspendLayout();
            this.panelChoiceWherePrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            idLabel.ForeColor = System.Drawing.Color.GhostWhite;
            idLabel.Location = new System.Drawing.Point(371, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(29, 19);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // nr_ewidencyjnyLabel
            // 
            nr_ewidencyjnyLabel.AutoSize = true;
            nr_ewidencyjnyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nr_ewidencyjnyLabel.ForeColor = System.Drawing.Color.GhostWhite;
            nr_ewidencyjnyLabel.Location = new System.Drawing.Point(11, 63);
            nr_ewidencyjnyLabel.Name = "nr_ewidencyjnyLabel";
            nr_ewidencyjnyLabel.Size = new System.Drawing.Size(127, 19);
            nr_ewidencyjnyLabel.TabIndex = 3;
            nr_ewidencyjnyLabel.Text = "Nr ewidencyjny:";
            nr_ewidencyjnyLabel.Click += new System.EventHandler(this.nr_ewidencyjnyLabel_Click);
            // 
            // rodzaj_sprzętuLabel
            // 
            rodzaj_sprzętuLabel.AutoSize = true;
            rodzaj_sprzętuLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rodzaj_sprzętuLabel.ForeColor = System.Drawing.Color.GhostWhite;
            rodzaj_sprzętuLabel.Location = new System.Drawing.Point(11, 92);
            rodzaj_sprzętuLabel.Name = "rodzaj_sprzętuLabel";
            rodzaj_sprzętuLabel.Size = new System.Drawing.Size(125, 19);
            rodzaj_sprzętuLabel.TabIndex = 5;
            rodzaj_sprzętuLabel.Text = "Rodzaj sprzętu:";
            rodzaj_sprzętuLabel.Click += new System.EventHandler(this.rodzaj_sprzętuLabel_Click);
            // 
            // nazwa_ProducentLabel
            // 
            nazwa_ProducentLabel.AutoSize = true;
            nazwa_ProducentLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nazwa_ProducentLabel.ForeColor = System.Drawing.Color.GhostWhite;
            nazwa_ProducentLabel.Location = new System.Drawing.Point(11, 124);
            nazwa_ProducentLabel.Name = "nazwa_ProducentLabel";
            nazwa_ProducentLabel.Size = new System.Drawing.Size(150, 19);
            nazwa_ProducentLabel.TabIndex = 7;
            nazwa_ProducentLabel.Text = "Producent i model:";
            nazwa_ProducentLabel.Click += new System.EventHandler(this.nazwa_ProducentLabel_Click);
            // 
            // rok_produkcjiLabel
            // 
            rok_produkcjiLabel.AutoSize = true;
            rok_produkcjiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rok_produkcjiLabel.ForeColor = System.Drawing.Color.GhostWhite;
            rok_produkcjiLabel.Location = new System.Drawing.Point(11, 156);
            rok_produkcjiLabel.Name = "rok_produkcjiLabel";
            rok_produkcjiLabel.Size = new System.Drawing.Size(119, 19);
            rok_produkcjiLabel.TabIndex = 9;
            rok_produkcjiLabel.Text = "Rok produkcji:";
            rok_produkcjiLabel.Click += new System.EventHandler(this.rok_produkcjiLabel_Click);
            // 
            // termin_gwarancjiLabel
            // 
            termin_gwarancjiLabel.AutoSize = true;
            termin_gwarancjiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            termin_gwarancjiLabel.ForeColor = System.Drawing.Color.GhostWhite;
            termin_gwarancjiLabel.Location = new System.Drawing.Point(11, 188);
            termin_gwarancjiLabel.Name = "termin_gwarancjiLabel";
            termin_gwarancjiLabel.Size = new System.Drawing.Size(144, 19);
            termin_gwarancjiLabel.TabIndex = 11;
            termin_gwarancjiLabel.Text = "Termin gwarancji:";
            termin_gwarancjiLabel.Click += new System.EventHandler(this.termin_gwarancjiLabel_Click);
            // 
            // nr_seryjnyLabel
            // 
            nr_seryjnyLabel.AutoSize = true;
            nr_seryjnyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nr_seryjnyLabel.ForeColor = System.Drawing.Color.GhostWhite;
            nr_seryjnyLabel.Location = new System.Drawing.Point(12, 220);
            nr_seryjnyLabel.Name = "nr_seryjnyLabel";
            nr_seryjnyLabel.Size = new System.Drawing.Size(87, 19);
            nr_seryjnyLabel.TabIndex = 13;
            nr_seryjnyLabel.Text = "Nr seryjny:";
            nr_seryjnyLabel.Click += new System.EventHandler(this.nr_seryjnyLabel_Click);
            // 
            // wartosc_zakupuLabel
            // 
            wartosc_zakupuLabel.AutoSize = true;
            wartosc_zakupuLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wartosc_zakupuLabel.ForeColor = System.Drawing.Color.GhostWhite;
            wartosc_zakupuLabel.Location = new System.Drawing.Point(11, 252);
            wartosc_zakupuLabel.Name = "wartosc_zakupuLabel";
            wartosc_zakupuLabel.Size = new System.Drawing.Size(133, 19);
            wartosc_zakupuLabel.TabIndex = 15;
            wartosc_zakupuLabel.Text = "Wartość zakupu:";
            wartosc_zakupuLabel.Click += new System.EventHandler(this.wartosc_zakupuLabel_Click);
            // 
            // nr_fakturyLabel
            // 
            nr_fakturyLabel.AutoSize = true;
            nr_fakturyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nr_fakturyLabel.ForeColor = System.Drawing.Color.GhostWhite;
            nr_fakturyLabel.Location = new System.Drawing.Point(11, 286);
            nr_fakturyLabel.Name = "nr_fakturyLabel";
            nr_fakturyLabel.Size = new System.Drawing.Size(89, 19);
            nr_fakturyLabel.TabIndex = 17;
            nr_fakturyLabel.Text = "Nr faktury:";
            nr_fakturyLabel.Click += new System.EventHandler(this.nr_fakturyLabel_Click);
            // 
            // rodzaj_ewidencjiLabel
            // 
            rodzaj_ewidencjiLabel.AutoSize = true;
            rodzaj_ewidencjiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rodzaj_ewidencjiLabel.ForeColor = System.Drawing.Color.GhostWhite;
            rodzaj_ewidencjiLabel.Location = new System.Drawing.Point(11, 318);
            rodzaj_ewidencjiLabel.Name = "rodzaj_ewidencjiLabel";
            rodzaj_ewidencjiLabel.Size = new System.Drawing.Size(141, 19);
            rodzaj_ewidencjiLabel.TabIndex = 19;
            rodzaj_ewidencjiLabel.Text = "Rodzaj ewidencji:";
            rodzaj_ewidencjiLabel.Click += new System.EventHandler(this.rodzaj_ewidencjiLabel_Click);
            // 
            // mac_adresLabel
            // 
            mac_adresLabel.AutoSize = true;
            mac_adresLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            mac_adresLabel.ForeColor = System.Drawing.Color.GhostWhite;
            mac_adresLabel.Location = new System.Drawing.Point(11, 350);
            mac_adresLabel.Name = "mac_adresLabel";
            mac_adresLabel.Size = new System.Drawing.Size(89, 19);
            mac_adresLabel.TabIndex = 21;
            mac_adresLabel.Text = "Mac adres:";
            mac_adresLabel.Click += new System.EventHandler(this.mac_adresLabel_Click);
            // 
            // iP_adres1Label
            // 
            iP_adres1Label.AutoSize = true;
            iP_adres1Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            iP_adres1Label.ForeColor = System.Drawing.Color.GhostWhite;
            iP_adres1Label.Location = new System.Drawing.Point(11, 383);
            iP_adres1Label.Name = "iP_adres1Label";
            iP_adres1Label.Size = new System.Drawing.Size(83, 19);
            iP_adres1Label.TabIndex = 23;
            iP_adres1Label.Text = "IP adres1:";
            iP_adres1Label.Click += new System.EventHandler(this.iP_adres1Label_Click);
            // 
            // iP_adres2Label
            // 
            iP_adres2Label.AutoSize = true;
            iP_adres2Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            iP_adres2Label.ForeColor = System.Drawing.Color.GhostWhite;
            iP_adres2Label.Location = new System.Drawing.Point(11, 412);
            iP_adres2Label.Name = "iP_adres2Label";
            iP_adres2Label.Size = new System.Drawing.Size(83, 19);
            iP_adres2Label.TabIndex = 25;
            iP_adres2Label.Text = "IP adres2:";
            iP_adres2Label.Click += new System.EventHandler(this.iP_adres2Label_Click);
            // 
            // iP_adres3Label
            // 
            iP_adres3Label.AutoSize = true;
            iP_adres3Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            iP_adres3Label.ForeColor = System.Drawing.Color.GhostWhite;
            iP_adres3Label.Location = new System.Drawing.Point(11, 444);
            iP_adres3Label.Name = "iP_adres3Label";
            iP_adres3Label.Size = new System.Drawing.Size(83, 19);
            iP_adres3Label.TabIndex = 27;
            iP_adres3Label.Text = "IP adres3:";
            iP_adres3Label.Click += new System.EventHandler(this.iP_adres3Label_Click);
            // 
            // karta_grafiki1Label
            // 
            karta_grafiki1Label.AutoSize = true;
            karta_grafiki1Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            karta_grafiki1Label.ForeColor = System.Drawing.Color.GhostWhite;
            karta_grafiki1Label.Location = new System.Drawing.Point(513, 92);
            karta_grafiki1Label.Name = "karta_grafiki1Label";
            karta_grafiki1Label.Size = new System.Drawing.Size(116, 19);
            karta_grafiki1Label.TabIndex = 31;
            karta_grafiki1Label.Text = "Karta grafiki1:";
            karta_grafiki1Label.Click += new System.EventHandler(this.karta_grafiki1Label_Click);
            // 
            // karta_grafiki2Label
            // 
            karta_grafiki2Label.AutoSize = true;
            karta_grafiki2Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            karta_grafiki2Label.ForeColor = System.Drawing.Color.GhostWhite;
            karta_grafiki2Label.Location = new System.Drawing.Point(513, 121);
            karta_grafiki2Label.Name = "karta_grafiki2Label";
            karta_grafiki2Label.Size = new System.Drawing.Size(116, 19);
            karta_grafiki2Label.TabIndex = 33;
            karta_grafiki2Label.Text = "Karta grafiki2:";
            karta_grafiki2Label.Click += new System.EventHandler(this.karta_grafiki2Label_Click);
            // 
            // ramLabel
            // 
            ramLabel.AutoSize = true;
            ramLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            ramLabel.ForeColor = System.Drawing.Color.GhostWhite;
            ramLabel.Location = new System.Drawing.Point(513, 188);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new System.Drawing.Size(47, 19);
            ramLabel.TabIndex = 37;
            ramLabel.Text = "Ram:";
            ramLabel.Click += new System.EventHandler(this.ramLabel_Click);
            // 
            // dysk1Label
            // 
            dysk1Label.AutoSize = true;
            dysk1Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dysk1Label.ForeColor = System.Drawing.Color.GhostWhite;
            dysk1Label.Location = new System.Drawing.Point(513, 220);
            dysk1Label.Name = "dysk1Label";
            dysk1Label.Size = new System.Drawing.Size(57, 19);
            dysk1Label.TabIndex = 39;
            dysk1Label.Text = "Dysk1:";
            dysk1Label.Click += new System.EventHandler(this.dysk1Label_Click);
            // 
            // dysk2Label
            // 
            dysk2Label.AutoSize = true;
            dysk2Label.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dysk2Label.ForeColor = System.Drawing.Color.GhostWhite;
            dysk2Label.Location = new System.Drawing.Point(513, 252);
            dysk2Label.Name = "dysk2Label";
            dysk2Label.Size = new System.Drawing.Size(57, 19);
            dysk2Label.TabIndex = 41;
            dysk2Label.Text = "Dysk2:";
            dysk2Label.Click += new System.EventHandler(this.dysk2Label_Click);
            // 
            // budynekLabel
            // 
            budynekLabel.AutoSize = true;
            budynekLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            budynekLabel.ForeColor = System.Drawing.Color.GhostWhite;
            budynekLabel.Location = new System.Drawing.Point(513, 318);
            budynekLabel.Name = "budynekLabel";
            budynekLabel.Size = new System.Drawing.Size(78, 19);
            budynekLabel.TabIndex = 45;
            budynekLabel.Text = "Budynek:";
            budynekLabel.Click += new System.EventHandler(this.budynekLabel_Click);
            // 
            // pietroLabel
            // 
            pietroLabel.AutoSize = true;
            pietroLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            pietroLabel.ForeColor = System.Drawing.Color.GhostWhite;
            pietroLabel.Location = new System.Drawing.Point(513, 347);
            pietroLabel.Name = "pietroLabel";
            pietroLabel.Size = new System.Drawing.Size(58, 19);
            pietroLabel.TabIndex = 47;
            pietroLabel.Text = "Piętro:";
            pietroLabel.Click += new System.EventHandler(this.pietroLabel_Click);
            // 
            // pomieszczenieLabel
            // 
            pomieszczenieLabel.AutoSize = true;
            pomieszczenieLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            pomieszczenieLabel.ForeColor = System.Drawing.Color.GhostWhite;
            pomieszczenieLabel.Location = new System.Drawing.Point(513, 380);
            pomieszczenieLabel.Name = "pomieszczenieLabel";
            pomieszczenieLabel.Size = new System.Drawing.Size(121, 19);
            pomieszczenieLabel.TabIndex = 49;
            pomieszczenieLabel.Text = "Pomieszczenie:";
            pomieszczenieLabel.Click += new System.EventHandler(this.pomieszczenieLabel_Click);
            // 
            // informatyka_LacznoscLabel
            // 
            informatyka_LacznoscLabel.AutoSize = true;
            informatyka_LacznoscLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            informatyka_LacznoscLabel.ForeColor = System.Drawing.Color.GhostWhite;
            informatyka_LacznoscLabel.Location = new System.Drawing.Point(513, 412);
            informatyka_LacznoscLabel.Name = "informatyka_LacznoscLabel";
            informatyka_LacznoscLabel.Size = new System.Drawing.Size(177, 19);
            informatyka_LacznoscLabel.TabIndex = 51;
            informatyka_LacznoscLabel.Text = "Informatyka Łączność:";
            informatyka_LacznoscLabel.Click += new System.EventHandler(this.informatyka_LacznoscLabel_Click);
            // 
            // uwagiLabel
            // 
            uwagiLabel.AutoSize = true;
            uwagiLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            uwagiLabel.ForeColor = System.Drawing.Color.GhostWhite;
            uwagiLabel.Location = new System.Drawing.Point(513, 441);
            uwagiLabel.Name = "uwagiLabel";
            uwagiLabel.Size = new System.Drawing.Size(59, 19);
            uwagiLabel.TabIndex = 53;
            uwagiLabel.Text = "Uwagi:";
            uwagiLabel.Click += new System.EventHandler(this.uwagiLabel_Click);
            // 
            // numer_kartyLabel1
            // 
            numer_kartyLabel1.AutoSize = true;
            numer_kartyLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            numer_kartyLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            numer_kartyLabel1.Location = new System.Drawing.Point(513, 286);
            numer_kartyLabel1.Name = "numer_kartyLabel1";
            numer_kartyLabel1.Size = new System.Drawing.Size(106, 19);
            numer_kartyLabel1.TabIndex = 43;
            numer_kartyLabel1.Text = "Numer karty:";
            // 
            // system_operacyjnyLabel1
            // 
            system_operacyjnyLabel1.AutoSize = true;
            system_operacyjnyLabel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            system_operacyjnyLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            system_operacyjnyLabel1.Location = new System.Drawing.Point(513, 60);
            system_operacyjnyLabel1.Name = "system_operacyjnyLabel1";
            system_operacyjnyLabel1.Size = new System.Drawing.Size(149, 19);
            system_operacyjnyLabel1.TabIndex = 29;
            system_operacyjnyLabel1.Text = "System operacyjny:";
            // 
            // procesorLabel
            // 
            procesorLabel.AutoSize = true;
            procesorLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            procesorLabel.ForeColor = System.Drawing.Color.GhostWhite;
            procesorLabel.Location = new System.Drawing.Point(513, 156);
            procesorLabel.Name = "procesorLabel";
            procesorLabel.Size = new System.Drawing.Size(78, 19);
            procesorLabel.TabIndex = 35;
            procesorLabel.Text = "Procesor:";
            procesorLabel.Click += new System.EventHandler(this.procesorLabel_Click);
            // 
            // index_finansowyLabel
            // 
            index_finansowyLabel.AutoSize = true;
            index_finansowyLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            index_finansowyLabel.ForeColor = System.Drawing.Color.White;
            index_finansowyLabel.Location = new System.Drawing.Point(9, 472);
            index_finansowyLabel.Name = "index_finansowyLabel";
            index_finansowyLabel.Size = new System.Drawing.Size(135, 19);
            index_finansowyLabel.TabIndex = 155;
            index_finansowyLabel.Text = "Index finansowy:";
            // 
            // ewiBindingNavigator
            // 
            this.ewiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ewiBindingNavigator.BindingSource = this.ewiBindingSource;
            this.ewiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ewiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ewiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ewiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ewiBindingNavigatorSaveItem});
            this.ewiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ewiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ewiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ewiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ewiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ewiBindingNavigator.Name = "ewiBindingNavigator";
            this.ewiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ewiBindingNavigator.Size = new System.Drawing.Size(1024, 27);
            this.ewiBindingNavigator.TabIndex = 0;
            this.ewiBindingNavigator.Text = "bindingNavigator1";
            this.ewiBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // ewiBindingSource
            // 
            this.ewiBindingSource.DataMember = "Ewi";
            this.ewiBindingSource.DataSource = this.ewidencjaDataSet;
            // 
            // ewidencjaDataSet
            // 
            this.ewidencjaDataSet.DataSetName = "EwidencjaDataSet";
            this.ewidencjaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ewiBindingNavigatorSaveItem
            // 
            this.ewiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ewiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ewiBindingNavigatorSaveItem.Image")));
            this.ewiBindingNavigatorSaveItem.Name = "ewiBindingNavigatorSaveItem";
            this.ewiBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.ewiBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.ewiBindingNavigatorSaveItem.Click += new System.EventHandler(this.ewiBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.idTextBox.Location = new System.Drawing.Point(418, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(282, 19);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // nr_ewidencyjnyTextBox
            // 
            this.nr_ewidencyjnyTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.nr_ewidencyjnyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nr_ewidencyjnyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nr_ewidencyjnyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Nr_ewidencyjny", true));
            this.nr_ewidencyjnyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_ewidencyjnyTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.nr_ewidencyjnyTextBox.Location = new System.Drawing.Point(202, 60);
            this.nr_ewidencyjnyTextBox.Name = "nr_ewidencyjnyTextBox";
            this.nr_ewidencyjnyTextBox.Size = new System.Drawing.Size(282, 19);
            this.nr_ewidencyjnyTextBox.TabIndex = 2;
            this.nr_ewidencyjnyTextBox.TextChanged += new System.EventHandler(this.nr_ewidencyjnyTextBox_TextChanged);
            // 
            // rodzaj_sprzętuTextBox
            // 
            this.rodzaj_sprzętuTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.rodzaj_sprzętuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rodzaj_sprzętuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rodzaj_sprzętuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Rodzaj_sprzętu", true));
            this.rodzaj_sprzętuTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rodzaj_sprzętuTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.rodzaj_sprzętuTextBox.Location = new System.Drawing.Point(202, 92);
            this.rodzaj_sprzętuTextBox.Name = "rodzaj_sprzętuTextBox";
            this.rodzaj_sprzętuTextBox.Size = new System.Drawing.Size(253, 19);
            this.rodzaj_sprzętuTextBox.TabIndex = 6;
            this.rodzaj_sprzętuTextBox.TextChanged += new System.EventHandler(this.rodzaj_sprzętuTextBox_TextChanged);
            // 
            // nazwa_ProducentTextBox
            // 
            this.nazwa_ProducentTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.nazwa_ProducentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazwa_ProducentTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nazwa_ProducentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Nazwa_Producent", true));
            this.nazwa_ProducentTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwa_ProducentTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.nazwa_ProducentTextBox.Location = new System.Drawing.Point(202, 124);
            this.nazwa_ProducentTextBox.Name = "nazwa_ProducentTextBox";
            this.nazwa_ProducentTextBox.Size = new System.Drawing.Size(282, 19);
            this.nazwa_ProducentTextBox.TabIndex = 4;
            this.nazwa_ProducentTextBox.TextChanged += new System.EventHandler(this.nazwa_ProducentTextBox_TextChanged);
            // 
            // rok_produkcjiTextBox
            // 
            this.rok_produkcjiTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.rok_produkcjiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rok_produkcjiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rok_produkcjiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Rok_produkcji", true));
            this.rok_produkcjiTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rok_produkcjiTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.rok_produkcjiTextBox.Location = new System.Drawing.Point(202, 156);
            this.rok_produkcjiTextBox.Name = "rok_produkcjiTextBox";
            this.rok_produkcjiTextBox.Size = new System.Drawing.Size(282, 19);
            this.rok_produkcjiTextBox.TabIndex = 5;
            this.rok_produkcjiTextBox.TextChanged += new System.EventHandler(this.rok_produkcjiTextBox_TextChanged);
            // 
            // termin_gwarancjiTextBox
            // 
            this.termin_gwarancjiTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.termin_gwarancjiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.termin_gwarancjiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.termin_gwarancjiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Termin_gwarancji", true));
            this.termin_gwarancjiTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.termin_gwarancjiTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.termin_gwarancjiTextBox.Location = new System.Drawing.Point(202, 188);
            this.termin_gwarancjiTextBox.Name = "termin_gwarancjiTextBox";
            this.termin_gwarancjiTextBox.Size = new System.Drawing.Size(282, 19);
            this.termin_gwarancjiTextBox.TabIndex = 6;
            this.termin_gwarancjiTextBox.TextChanged += new System.EventHandler(this.termin_gwarancjiTextBox_TextChanged);
            // 
            // nr_seryjnyTextBox
            // 
            this.nr_seryjnyTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.nr_seryjnyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nr_seryjnyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nr_seryjnyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Nr_seryjny", true));
            this.nr_seryjnyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_seryjnyTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.nr_seryjnyTextBox.Location = new System.Drawing.Point(202, 220);
            this.nr_seryjnyTextBox.Name = "nr_seryjnyTextBox";
            this.nr_seryjnyTextBox.Size = new System.Drawing.Size(282, 19);
            this.nr_seryjnyTextBox.TabIndex = 7;
            this.nr_seryjnyTextBox.TextChanged += new System.EventHandler(this.nr_seryjnyTextBox_TextChanged);
            // 
            // wartosc_zakupuTextBox
            // 
            this.wartosc_zakupuTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.wartosc_zakupuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wartosc_zakupuTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wartosc_zakupuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Wartosc_zakupu", true));
            this.wartosc_zakupuTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wartosc_zakupuTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.wartosc_zakupuTextBox.Location = new System.Drawing.Point(202, 252);
            this.wartosc_zakupuTextBox.Name = "wartosc_zakupuTextBox";
            this.wartosc_zakupuTextBox.Size = new System.Drawing.Size(282, 19);
            this.wartosc_zakupuTextBox.TabIndex = 8;
            this.wartosc_zakupuTextBox.TextChanged += new System.EventHandler(this.wartosc_zakupuTextBox_TextChanged);
            // 
            // nr_fakturyTextBox
            // 
            this.nr_fakturyTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.nr_fakturyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nr_fakturyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nr_fakturyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Nr_faktury", true));
            this.nr_fakturyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nr_fakturyTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.nr_fakturyTextBox.Location = new System.Drawing.Point(202, 284);
            this.nr_fakturyTextBox.Name = "nr_fakturyTextBox";
            this.nr_fakturyTextBox.Size = new System.Drawing.Size(282, 19);
            this.nr_fakturyTextBox.TabIndex = 9;
            this.nr_fakturyTextBox.TextChanged += new System.EventHandler(this.nr_fakturyTextBox_TextChanged);
            // 
            // rodzaj_ewidencjiTextBox
            // 
            this.rodzaj_ewidencjiTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.rodzaj_ewidencjiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rodzaj_ewidencjiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rodzaj_ewidencjiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Rodzaj_ewidencji", true));
            this.rodzaj_ewidencjiTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rodzaj_ewidencjiTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.rodzaj_ewidencjiTextBox.Location = new System.Drawing.Point(202, 316);
            this.rodzaj_ewidencjiTextBox.Name = "rodzaj_ewidencjiTextBox";
            this.rodzaj_ewidencjiTextBox.Size = new System.Drawing.Size(282, 19);
            this.rodzaj_ewidencjiTextBox.TabIndex = 20;
            this.rodzaj_ewidencjiTextBox.TextChanged += new System.EventHandler(this.rodzaj_ewidencjiTextBox_TextChanged);
            // 
            // mac_adresTextBox
            // 
            this.mac_adresTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.mac_adresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mac_adresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mac_adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Mac_adres", true));
            this.mac_adresTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mac_adresTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.mac_adresTextBox.Location = new System.Drawing.Point(202, 348);
            this.mac_adresTextBox.Name = "mac_adresTextBox";
            this.mac_adresTextBox.Size = new System.Drawing.Size(282, 19);
            this.mac_adresTextBox.TabIndex = 11;
            this.mac_adresTextBox.TextChanged += new System.EventHandler(this.mac_adresTextBox_TextChanged);
            // 
            // iP_adres1TextBox
            // 
            this.iP_adres1TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.iP_adres1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iP_adres1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.iP_adres1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "IP_adres1", true));
            this.iP_adres1TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iP_adres1TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.iP_adres1TextBox.Location = new System.Drawing.Point(202, 379);
            this.iP_adres1TextBox.Name = "iP_adres1TextBox";
            this.iP_adres1TextBox.Size = new System.Drawing.Size(282, 19);
            this.iP_adres1TextBox.TabIndex = 12;
            this.iP_adres1TextBox.TextChanged += new System.EventHandler(this.iP_adres1TextBox_TextChanged);
            // 
            // iP_adres2TextBox
            // 
            this.iP_adres2TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.iP_adres2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iP_adres2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.iP_adres2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "IP_adres2", true));
            this.iP_adres2TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iP_adres2TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.iP_adres2TextBox.Location = new System.Drawing.Point(202, 409);
            this.iP_adres2TextBox.Name = "iP_adres2TextBox";
            this.iP_adres2TextBox.Size = new System.Drawing.Size(282, 19);
            this.iP_adres2TextBox.TabIndex = 13;
            this.iP_adres2TextBox.TextChanged += new System.EventHandler(this.iP_adres2TextBox_TextChanged);
            // 
            // iP_adres3TextBox
            // 
            this.iP_adres3TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.iP_adres3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iP_adres3TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.iP_adres3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "IP_adres3", true));
            this.iP_adres3TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iP_adres3TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.iP_adres3TextBox.Location = new System.Drawing.Point(202, 441);
            this.iP_adres3TextBox.Name = "iP_adres3TextBox";
            this.iP_adres3TextBox.Size = new System.Drawing.Size(282, 19);
            this.iP_adres3TextBox.TabIndex = 14;
            this.iP_adres3TextBox.TextChanged += new System.EventHandler(this.iP_adres3TextBox_TextChanged);
            // 
            // karta_grafiki1TextBox
            // 
            this.karta_grafiki1TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.karta_grafiki1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.karta_grafiki1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.karta_grafiki1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Karta_grafiki1", true));
            this.karta_grafiki1TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.karta_grafiki1TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.karta_grafiki1TextBox.Location = new System.Drawing.Point(702, 89);
            this.karta_grafiki1TextBox.Name = "karta_grafiki1TextBox";
            this.karta_grafiki1TextBox.Size = new System.Drawing.Size(282, 19);
            this.karta_grafiki1TextBox.TabIndex = 17;
            this.karta_grafiki1TextBox.TextChanged += new System.EventHandler(this.karta_grafiki1TextBox_TextChanged);
            // 
            // karta_grafiki2TextBox
            // 
            this.karta_grafiki2TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.karta_grafiki2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.karta_grafiki2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.karta_grafiki2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Karta_grafiki2", true));
            this.karta_grafiki2TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.karta_grafiki2TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.karta_grafiki2TextBox.Location = new System.Drawing.Point(702, 121);
            this.karta_grafiki2TextBox.Name = "karta_grafiki2TextBox";
            this.karta_grafiki2TextBox.Size = new System.Drawing.Size(282, 19);
            this.karta_grafiki2TextBox.TabIndex = 18;
            this.karta_grafiki2TextBox.TextChanged += new System.EventHandler(this.karta_grafiki2TextBox_TextChanged);
            // 
            // procesorTextBox
            // 
            this.procesorTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.procesorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.procesorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.procesorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Procesor", true));
            this.procesorTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.procesorTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.procesorTextBox.Location = new System.Drawing.Point(702, 153);
            this.procesorTextBox.Name = "procesorTextBox";
            this.procesorTextBox.Size = new System.Drawing.Size(282, 19);
            this.procesorTextBox.TabIndex = 19;
            this.procesorTextBox.TextChanged += new System.EventHandler(this.procesorTextBox_TextChanged);
            // 
            // ramTextBox
            // 
            this.ramTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.ramTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ramTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ramTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Ram", true));
            this.ramTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ramTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.ramTextBox.Location = new System.Drawing.Point(702, 185);
            this.ramTextBox.Name = "ramTextBox";
            this.ramTextBox.Size = new System.Drawing.Size(282, 19);
            this.ramTextBox.TabIndex = 20;
            this.ramTextBox.TextChanged += new System.EventHandler(this.ramTextBox_TextChanged);
            // 
            // dysk1TextBox
            // 
            this.dysk1TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.dysk1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dysk1TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dysk1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Dysk1", true));
            this.dysk1TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dysk1TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.dysk1TextBox.Location = new System.Drawing.Point(702, 217);
            this.dysk1TextBox.Name = "dysk1TextBox";
            this.dysk1TextBox.Size = new System.Drawing.Size(282, 19);
            this.dysk1TextBox.TabIndex = 21;
            this.dysk1TextBox.TextChanged += new System.EventHandler(this.dysk1TextBox_TextChanged);
            // 
            // dysk2TextBox
            // 
            this.dysk2TextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.dysk2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dysk2TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dysk2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Dysk2", true));
            this.dysk2TextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dysk2TextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.dysk2TextBox.Location = new System.Drawing.Point(702, 252);
            this.dysk2TextBox.Name = "dysk2TextBox";
            this.dysk2TextBox.Size = new System.Drawing.Size(282, 19);
            this.dysk2TextBox.TabIndex = 22;
            this.dysk2TextBox.TextChanged += new System.EventHandler(this.dysk2TextBox_TextChanged);
            // 
            // budynekTextBox
            // 
            this.budynekTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.budynekTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.budynekTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.budynekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Budynek", true));
            this.budynekTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.budynekTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.budynekTextBox.Location = new System.Drawing.Point(702, 315);
            this.budynekTextBox.Name = "budynekTextBox";
            this.budynekTextBox.Size = new System.Drawing.Size(253, 19);
            this.budynekTextBox.TabIndex = 46;
            this.budynekTextBox.TextChanged += new System.EventHandler(this.budynekTextBox_TextChanged);
            // 
            // pietroTextBox
            // 
            this.pietroTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.pietroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pietroTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pietroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Pietro", true));
            this.pietroTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pietroTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.pietroTextBox.Location = new System.Drawing.Point(702, 347);
            this.pietroTextBox.Name = "pietroTextBox";
            this.pietroTextBox.Size = new System.Drawing.Size(253, 19);
            this.pietroTextBox.TabIndex = 48;
            this.pietroTextBox.TextChanged += new System.EventHandler(this.pietroTextBox_TextChanged);
            // 
            // pomieszczenieTextBox
            // 
            this.pomieszczenieTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.pomieszczenieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pomieszczenieTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pomieszczenieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Pomieszczenie", true));
            this.pomieszczenieTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomieszczenieTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.pomieszczenieTextBox.Location = new System.Drawing.Point(702, 380);
            this.pomieszczenieTextBox.Name = "pomieszczenieTextBox";
            this.pomieszczenieTextBox.Size = new System.Drawing.Size(253, 19);
            this.pomieszczenieTextBox.TabIndex = 50;
            this.pomieszczenieTextBox.TextChanged += new System.EventHandler(this.pomieszczenieTextBox_TextChanged);
            // 
            // informatyka_LacznoscTextBox
            // 
            this.informatyka_LacznoscTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.informatyka_LacznoscTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informatyka_LacznoscTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.informatyka_LacznoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Informatyka_Lacznosc", true));
            this.informatyka_LacznoscTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informatyka_LacznoscTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.informatyka_LacznoscTextBox.Location = new System.Drawing.Point(702, 412);
            this.informatyka_LacznoscTextBox.Name = "informatyka_LacznoscTextBox";
            this.informatyka_LacznoscTextBox.Size = new System.Drawing.Size(282, 19);
            this.informatyka_LacznoscTextBox.TabIndex = 52;
            this.informatyka_LacznoscTextBox.TextChanged += new System.EventHandler(this.informatyka_LacznoscTextBox_TextChanged);
            // 
            // uwagiTextBox
            // 
            this.uwagiTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.uwagiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uwagiTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uwagiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Uwagi", true));
            this.uwagiTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uwagiTextBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.uwagiTextBox.Location = new System.Drawing.Point(702, 441);
            this.uwagiTextBox.Name = "uwagiTextBox";
            this.uwagiTextBox.Size = new System.Drawing.Size(282, 19);
            this.uwagiTextBox.TabIndex = 28;
            this.uwagiTextBox.TextChanged += new System.EventHandler(this.uwagiTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(926, 672);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Michał Manios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(942, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Wersja: 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(513, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Utwórz kartę urządzenia:";
            // 
            // checkBoxCreateCard
            // 
            this.checkBoxCreateCard.AutoSize = true;
            this.checkBoxCreateCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCreateCard.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxCreateCard.Location = new System.Drawing.Point(717, 593);
            this.checkBoxCreateCard.Name = "checkBoxCreateCard";
            this.checkBoxCreateCard.Size = new System.Drawing.Size(12, 11);
            this.checkBoxCreateCard.TabIndex = 29;
            this.checkBoxCreateCard.UseVisualStyleBackColor = true;
            this.checkBoxCreateCard.CheckedChanged += new System.EventHandler(this.checkBoxCreateCard_CheckedChanged);
            // 
            // comboBoxRodzajSprzetu
            // 
            this.comboBoxRodzajSprzetu.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxRodzajSprzetu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRodzajSprzetu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRodzajSprzetu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRodzajSprzetu.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxRodzajSprzetu.FormattingEnabled = true;
            this.comboBoxRodzajSprzetu.Items.AddRange(new object[] {
            "MONITOR",
            "KOMPUTER",
            "DRUKARKA",
            "TELEFON"});
            this.comboBoxRodzajSprzetu.Location = new System.Drawing.Point(202, 89);
            this.comboBoxRodzajSprzetu.Name = "comboBoxRodzajSprzetu";
            this.comboBoxRodzajSprzetu.Size = new System.Drawing.Size(253, 27);
            this.comboBoxRodzajSprzetu.TabIndex = 3;
            this.comboBoxRodzajSprzetu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxRodzajSprzetu_KeyPress);
            this.comboBoxRodzajSprzetu.Leave += new System.EventHandler(this.comboBoxRodzajSprzetu_Leave);
            // 
            // comboBoxRodzajEwidencji
            // 
            this.comboBoxRodzajEwidencji.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxRodzajEwidencji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRodzajEwidencji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRodzajEwidencji.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxRodzajEwidencji.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxRodzajEwidencji.FormattingEnabled = true;
            this.comboBoxRodzajEwidencji.Items.AddRange(new object[] {
            "PONIŻEJ",
            "POWYŻEJ",
            "ŚRODEK TRWAŁY"});
            this.comboBoxRodzajEwidencji.Location = new System.Drawing.Point(202, 312);
            this.comboBoxRodzajEwidencji.Name = "comboBoxRodzajEwidencji";
            this.comboBoxRodzajEwidencji.Size = new System.Drawing.Size(282, 27);
            this.comboBoxRodzajEwidencji.TabIndex = 10;
            this.comboBoxRodzajEwidencji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxRodzajEwidencji_KeyPress);
            // 
            // comboBoxBudynek
            // 
            this.comboBoxBudynek.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxBudynek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBudynek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBudynek.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBudynek.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxBudynek.FormattingEnabled = true;
            this.comboBoxBudynek.Location = new System.Drawing.Point(702, 310);
            this.comboBoxBudynek.Name = "comboBoxBudynek";
            this.comboBoxBudynek.Size = new System.Drawing.Size(253, 27);
            this.comboBoxBudynek.TabIndex = 24;
            this.comboBoxBudynek.SelectedIndexChanged += new System.EventHandler(this.comboBoxBudynek_SelectedIndexChanged);
            this.comboBoxBudynek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxBudynek_KeyPress);
            // 
            // comboBoxPietro
            // 
            this.comboBoxPietro.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxPietro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPietro.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPietro.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxPietro.FormattingEnabled = true;
            this.comboBoxPietro.Location = new System.Drawing.Point(702, 344);
            this.comboBoxPietro.Name = "comboBoxPietro";
            this.comboBoxPietro.Size = new System.Drawing.Size(253, 27);
            this.comboBoxPietro.TabIndex = 25;
            this.comboBoxPietro.SelectedIndexChanged += new System.EventHandler(this.comboBoxPietro_SelectedIndexChanged);
            this.comboBoxPietro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPietro_KeyPress);
            // 
            // comboBoxPomieszczenie
            // 
            this.comboBoxPomieszczenie.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxPomieszczenie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPomieszczenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPomieszczenie.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPomieszczenie.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxPomieszczenie.FormattingEnabled = true;
            this.comboBoxPomieszczenie.Location = new System.Drawing.Point(702, 377);
            this.comboBoxPomieszczenie.Name = "comboBoxPomieszczenie";
            this.comboBoxPomieszczenie.Size = new System.Drawing.Size(253, 27);
            this.comboBoxPomieszczenie.TabIndex = 26;
            this.comboBoxPomieszczenie.SelectedIndexChanged += new System.EventHandler(this.comboBoxPomieszczenie_SelectedIndexChanged);
            this.comboBoxPomieszczenie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPomieszczenie_KeyPress);
            // 
            // comboBoxInformatykaLacznosc
            // 
            this.comboBoxInformatykaLacznosc.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxInformatykaLacznosc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInformatykaLacznosc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInformatykaLacznosc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxInformatykaLacznosc.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxInformatykaLacznosc.FormattingEnabled = true;
            this.comboBoxInformatykaLacznosc.Items.AddRange(new object[] {
            "INFORMATYKA",
            "ŁĄCZNOŚĆ"});
            this.comboBoxInformatykaLacznosc.Location = new System.Drawing.Point(702, 409);
            this.comboBoxInformatykaLacznosc.Name = "comboBoxInformatykaLacznosc";
            this.comboBoxInformatykaLacznosc.Size = new System.Drawing.Size(282, 27);
            this.comboBoxInformatykaLacznosc.TabIndex = 27;
            // 
            // ewiTableAdapter
            // 
            this.ewiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ewidencja_ponizejTableAdapter = null;
            this.tableAdapterManager.Ewidencja_powyzejTableAdapter = null;
            this.tableAdapterManager.Ewidencja_STTableAdapter = null;
            this.tableAdapterManager.EwiTableAdapter = this.ewiTableAdapter;
            this.tableAdapterManager.HistoryTableAdapter = null;
            this.tableAdapterManager.Karta_konserwacjaTableAdapter = null;
            this.tableAdapterManager.Karta_naprawyTableAdapter = null;
            this.tableAdapterManager.KartaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EwiInf.EwidencjaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numer_kartyTextBox1
            // 
            this.numer_kartyTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.numer_kartyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numer_kartyTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.numer_kartyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Numer_karty", true));
            this.numer_kartyTextBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numer_kartyTextBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.numer_kartyTextBox1.Location = new System.Drawing.Point(702, 284);
            this.numer_kartyTextBox1.Name = "numer_kartyTextBox1";
            this.numer_kartyTextBox1.ReadOnly = true;
            this.numer_kartyTextBox1.Size = new System.Drawing.Size(285, 19);
            this.numer_kartyTextBox1.TabIndex = 23;
            // 
            // system_operacyjnyTextBox1
            // 
            this.system_operacyjnyTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.system_operacyjnyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.system_operacyjnyTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.system_operacyjnyTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "System_operacyjny", true));
            this.system_operacyjnyTextBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.system_operacyjnyTextBox1.ForeColor = System.Drawing.Color.GhostWhite;
            this.system_operacyjnyTextBox1.Location = new System.Drawing.Point(702, 60);
            this.system_operacyjnyTextBox1.Name = "system_operacyjnyTextBox1";
            this.system_operacyjnyTextBox1.Size = new System.Drawing.Size(282, 19);
            this.system_operacyjnyTextBox1.TabIndex = 16;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btPrintThisQR
            // 
            this.btPrintThisQR.BackColor = System.Drawing.Color.White;
            this.btPrintThisQR.BackgroundImage = global::EwiInf.Properties.Resources._1820249201578889576_64;
            this.btPrintThisQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrintThisQR.Cursor = System.Windows.Forms.Cursors.Default;
            this.btPrintThisQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrintThisQR.ForeColor = System.Drawing.Color.White;
            this.btPrintThisQR.Location = new System.Drawing.Point(22, 464);
            this.btPrintThisQR.Name = "btPrintThisQR";
            this.btPrintThisQR.Size = new System.Drawing.Size(60, 60);
            this.btPrintThisQR.TabIndex = 170;
            this.toolTip1.SetToolTip(this.btPrintThisQR, "Drukuj w wybranym miejscu");
            this.btPrintThisQR.UseVisualStyleBackColor = false;
            this.btPrintThisQR.Click += new System.EventHandler(this.btPrintThisQR_Click);
            // 
            // btBackPrintThisQr
            // 
            this.btBackPrintThisQr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBackPrintThisQr.BackgroundImage")));
            this.btBackPrintThisQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackPrintThisQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackPrintThisQr.ForeColor = System.Drawing.Color.White;
            this.btBackPrintThisQr.Location = new System.Drawing.Point(231, 464);
            this.btBackPrintThisQr.Name = "btBackPrintThisQr";
            this.btBackPrintThisQr.Size = new System.Drawing.Size(60, 60);
            this.btBackPrintThisQr.TabIndex = 171;
            this.toolTip1.SetToolTip(this.btBackPrintThisQr, "Anuluj drukowanie");
            this.btBackPrintThisQr.UseVisualStyleBackColor = true;
            this.btBackPrintThisQr.Click += new System.EventHandler(this.btBackPrintThisQr_Click);
            // 
            // PrintQRCode
            // 
            this.PrintQRCode.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PrintQRCode.BackgroundImage = global::EwiInf.Properties.Resources._1372266461582793676_64;
            this.PrintQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrintQRCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrintQRCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintQRCode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrintQRCode.Location = new System.Drawing.Point(943, 523);
            this.PrintQRCode.Name = "PrintQRCode";
            this.PrintQRCode.Size = new System.Drawing.Size(60, 60);
            this.PrintQRCode.TabIndex = 33;
            this.toolTip1.SetToolTip(this.PrintQRCode, "Drukuj QRCode");
            this.PrintQRCode.UseVisualStyleBackColor = false;
            this.PrintQRCode.Visible = false;
            this.PrintQRCode.Click += new System.EventHandler(this.PrintQRCode_Click);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.BackgroundImage = global::EwiInf.Properties.Resources._1820249201578889576_64;
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btPrint.Location = new System.Drawing.Point(574, 495);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(60, 60);
            this.btPrint.TabIndex = 154;
            this.toolTip1.SetToolTip(this.btPrint, "Zapisz widok urządzenia");
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Visible = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btForwardOne
            // 
            this.btForwardOne.BackgroundImage = global::EwiInf.Properties.Resources._4805666671554373173_64;
            this.btForwardOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btForwardOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btForwardOne.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btForwardOne.Location = new System.Drawing.Point(163, 11);
            this.btForwardOne.Name = "btForwardOne";
            this.btForwardOne.Size = new System.Drawing.Size(38, 41);
            this.btForwardOne.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btForwardOne, "Przejdź do następnej strony");
            this.btForwardOne.UseVisualStyleBackColor = true;
            this.btForwardOne.Click += new System.EventHandler(this.btForwardOne_Click);
            // 
            // btBackwardOne
            // 
            this.btBackwardOne.BackgroundImage = global::EwiInf.Properties.Resources._2935848591554373173_64;
            this.btBackwardOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackwardOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackwardOne.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btBackwardOne.Location = new System.Drawing.Point(57, 11);
            this.btBackwardOne.Name = "btBackwardOne";
            this.btBackwardOne.Size = new System.Drawing.Size(38, 41);
            this.btBackwardOne.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btBackwardOne, "Przejdź do poprzedniej strony");
            this.btBackwardOne.UseVisualStyleBackColor = true;
            this.btBackwardOne.Click += new System.EventHandler(this.btBackwardOne_Click);
            // 
            // btMoveLas
            // 
            this.btMoveLas.BackgroundImage = global::EwiInf.Properties.Resources._12915329811554373174_64;
            this.btMoveLas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMoveLas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMoveLas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btMoveLas.Location = new System.Drawing.Point(214, 11);
            this.btMoveLas.Name = "btMoveLas";
            this.btMoveLas.Size = new System.Drawing.Size(38, 41);
            this.btMoveLas.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btMoveLas, "Przejdź do ostatniej strony");
            this.btMoveLas.UseVisualStyleBackColor = true;
            this.btMoveLas.Click += new System.EventHandler(this.btMoveLas_Click);
            // 
            // btMoveFirst
            // 
            this.btMoveFirst.BackgroundImage = global::EwiInf.Properties.Resources._5709656181554373175_64;
            this.btMoveFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMoveFirst.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btMoveFirst.Location = new System.Drawing.Point(5, 11);
            this.btMoveFirst.Name = "btMoveFirst";
            this.btMoveFirst.Size = new System.Drawing.Size(38, 41);
            this.btMoveFirst.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btMoveFirst, "Przejdź do pierwszej strony");
            this.btMoveFirst.UseVisualStyleBackColor = true;
            this.btMoveFirst.Click += new System.EventHandler(this.btMoveFirst_Click);
            // 
            // btAddPomieszczenie
            // 
            this.btAddPomieszczenie.BackgroundImage = global::EwiInf.Properties.Resources._19265206991579511413_64;
            this.btAddPomieszczenie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddPomieszczenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPomieszczenie.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAddPomieszczenie.Location = new System.Drawing.Point(961, 375);
            this.btAddPomieszczenie.Name = "btAddPomieszczenie";
            this.btAddPomieszczenie.Size = new System.Drawing.Size(30, 30);
            this.btAddPomieszczenie.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btAddPomieszczenie, "Dodaj nową pozycję do wyboru");
            this.btAddPomieszczenie.UseVisualStyleBackColor = true;
            this.btAddPomieszczenie.Click += new System.EventHandler(this.btAddPomieszczenie_Click);
            // 
            // btAddPietro
            // 
            this.btAddPietro.BackgroundImage = global::EwiInf.Properties.Resources._19265206991579511413_64;
            this.btAddPietro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddPietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPietro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAddPietro.Location = new System.Drawing.Point(961, 342);
            this.btAddPietro.Name = "btAddPietro";
            this.btAddPietro.Size = new System.Drawing.Size(30, 30);
            this.btAddPietro.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btAddPietro, "Dodaj nową pozycję do wyboru");
            this.btAddPietro.UseVisualStyleBackColor = true;
            this.btAddPietro.Click += new System.EventHandler(this.btAddPietro_Click);
            // 
            // btAddBudynek
            // 
            this.btAddBudynek.BackgroundImage = global::EwiInf.Properties.Resources._19265206991579511413_64;
            this.btAddBudynek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddBudynek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddBudynek.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAddBudynek.Location = new System.Drawing.Point(961, 310);
            this.btAddBudynek.Name = "btAddBudynek";
            this.btAddBudynek.Size = new System.Drawing.Size(30, 30);
            this.btAddBudynek.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btAddBudynek, "Dodaj nową pozycję do wyboru");
            this.btAddBudynek.UseVisualStyleBackColor = true;
            this.btAddBudynek.Click += new System.EventHandler(this.btAddBudynek_Click);
            // 
            // btAddRodzajSprzetu
            // 
            this.btAddRodzajSprzetu.BackgroundImage = global::EwiInf.Properties.Resources._19265206991579511413_64;
            this.btAddRodzajSprzetu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddRodzajSprzetu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddRodzajSprzetu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAddRodzajSprzetu.Location = new System.Drawing.Point(461, 87);
            this.btAddRodzajSprzetu.Name = "btAddRodzajSprzetu";
            this.btAddRodzajSprzetu.Size = new System.Drawing.Size(30, 30);
            this.btAddRodzajSprzetu.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btAddRodzajSprzetu, "Dodaj nową pozycję do wyboru");
            this.btAddRodzajSprzetu.UseVisualStyleBackColor = true;
            this.btAddRodzajSprzetu.Click += new System.EventHandler(this.btAddRodzajSprzetu_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackgroundImage = global::EwiInf.Properties.Resources._5215451391579762107_64;
            this.bSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bSettings.Location = new System.Drawing.Point(287, 569);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(60, 60);
            this.bSettings.TabIndex = 32;
            this.toolTip1.SetToolTip(this.bSettings, "Pokaż kartę urządzenia");
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Visible = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCancel.BackgroundImage")));
            this.bCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bCancel.Location = new System.Drawing.Point(179, 569);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(60, 60);
            this.bCancel.TabIndex = 31;
            this.toolTip1.SetToolTip(this.bCancel, "Cofnij do okna głównego");
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.BackgroundImage = global::EwiInf.Properties.Resources._13898481211537356036_64;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bSave.Location = new System.Drawing.Point(70, 569);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(60, 60);
            this.bSave.TabIndex = 30;
            this.toolTip1.SetToolTip(this.bSave, "Zapisz");
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // comboBoxWhatItem
            // 
            this.comboBoxWhatItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxWhatItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhatItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxWhatItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxWhatItem.ForeColor = System.Drawing.Color.GhostWhite;
            this.comboBoxWhatItem.FormattingEnabled = true;
            this.comboBoxWhatItem.Location = new System.Drawing.Point(265, 37);
            this.comboBoxWhatItem.Name = "comboBoxWhatItem";
            this.comboBoxWhatItem.Size = new System.Drawing.Size(104, 27);
            this.comboBoxWhatItem.TabIndex = 40;
            this.comboBoxWhatItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxWhatItem_SelectedIndexChanged);
            // 
            // panelSteer
            // 
            this.panelSteer.Controls.Add(this.comboBoxWhatItem);
            this.panelSteer.Controls.Add(this.btForwardOne);
            this.panelSteer.Controls.Add(this.btBackwardOne);
            this.panelSteer.Controls.Add(this.btMoveLas);
            this.panelSteer.Controls.Add(this.btMoveFirst);
            this.panelSteer.Controls.Add(this.label5);
            this.panelSteer.Controls.Add(this.lbHowMuchOf);
            this.panelSteer.Location = new System.Drawing.Point(389, 620);
            this.panelSteer.Margin = new System.Windows.Forms.Padding(2);
            this.panelSteer.Name = "panelSteer";
            this.panelSteer.Size = new System.Drawing.Size(382, 66);
            this.panelSteer.TabIndex = 64;
            this.panelSteer.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.GhostWhite;
            this.label5.Location = new System.Drawing.Point(262, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Numer strony:";
            // 
            // lbHowMuchOf
            // 
            this.lbHowMuchOf.AutoSize = true;
            this.lbHowMuchOf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHowMuchOf.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbHowMuchOf.Location = new System.Drawing.Point(98, 20);
            this.lbHowMuchOf.Name = "lbHowMuchOf";
            this.lbHowMuchOf.Size = new System.Drawing.Size(63, 19);
            this.lbHowMuchOf.TabIndex = 60;
            this.lbHowMuchOf.Text = "ile z ilu";
            // 
            // panelChoiceWherePrint
            // 
            this.panelChoiceWherePrint.BackColor = System.Drawing.Color.White;
            this.panelChoiceWherePrint.Controls.Add(this.rb15);
            this.panelChoiceWherePrint.Controls.Add(this.rb12);
            this.panelChoiceWherePrint.Controls.Add(this.rb9);
            this.panelChoiceWherePrint.Controls.Add(this.rb6);
            this.panelChoiceWherePrint.Controls.Add(this.rb3);
            this.panelChoiceWherePrint.Controls.Add(this.rb14);
            this.panelChoiceWherePrint.Controls.Add(this.rb11);
            this.panelChoiceWherePrint.Controls.Add(this.rb8);
            this.panelChoiceWherePrint.Controls.Add(this.rb5);
            this.panelChoiceWherePrint.Controls.Add(this.rb2);
            this.panelChoiceWherePrint.Controls.Add(this.rb13);
            this.panelChoiceWherePrint.Controls.Add(this.rb10);
            this.panelChoiceWherePrint.Controls.Add(this.rb7);
            this.panelChoiceWherePrint.Controls.Add(this.rb4);
            this.panelChoiceWherePrint.Controls.Add(this.rb1);
            this.panelChoiceWherePrint.Controls.Add(this.btPrintThisQR);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox15);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox14);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox12);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox11);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox9);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox8);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox13);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox6);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox10);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox5);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox7);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox3);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox4);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox2);
            this.panelChoiceWherePrint.Controls.Add(this.pictureBox1);
            this.panelChoiceWherePrint.Controls.Add(this.btBackPrintThisQr);
            this.panelChoiceWherePrint.Location = new System.Drawing.Point(409, 50);
            this.panelChoiceWherePrint.Name = "panelChoiceWherePrint";
            this.panelChoiceWherePrint.Size = new System.Drawing.Size(320, 537);
            this.panelChoiceWherePrint.TabIndex = 155;
            this.panelChoiceWherePrint.Visible = false;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Location = new System.Drawing.Point(197, 414);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(14, 13);
            this.rb15.TabIndex = 169;
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(197, 324);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(14, 13);
            this.rb12.TabIndex = 166;
            this.rb12.UseVisualStyleBackColor = true;
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(197, 232);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(14, 13);
            this.rb9.TabIndex = 163;
            this.rb9.UseVisualStyleBackColor = true;
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(197, 141);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(14, 13);
            this.rb6.TabIndex = 160;
            this.rb6.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(197, 51);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(14, 13);
            this.rb3.TabIndex = 157;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb14
            // 
            this.rb14.AutoSize = true;
            this.rb14.Location = new System.Drawing.Point(101, 414);
            this.rb14.Name = "rb14";
            this.rb14.Size = new System.Drawing.Size(14, 13);
            this.rb14.TabIndex = 168;
            this.rb14.UseVisualStyleBackColor = true;
            // 
            // rb11
            // 
            this.rb11.AutoSize = true;
            this.rb11.Location = new System.Drawing.Point(101, 324);
            this.rb11.Name = "rb11";
            this.rb11.Size = new System.Drawing.Size(14, 13);
            this.rb11.TabIndex = 165;
            this.rb11.UseVisualStyleBackColor = true;
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(101, 232);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(14, 13);
            this.rb8.TabIndex = 162;
            this.rb8.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(101, 141);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(14, 13);
            this.rb5.TabIndex = 159;
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(101, 51);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(14, 13);
            this.rb2.TabIndex = 156;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb13
            // 
            this.rb13.AutoSize = true;
            this.rb13.Location = new System.Drawing.Point(3, 414);
            this.rb13.Name = "rb13";
            this.rb13.Size = new System.Drawing.Size(14, 13);
            this.rb13.TabIndex = 167;
            this.rb13.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(3, 324);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(14, 13);
            this.rb10.TabIndex = 164;
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Location = new System.Drawing.Point(3, 232);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(14, 13);
            this.rb7.TabIndex = 161;
            this.rb7.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(3, 141);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(14, 13);
            this.rb4.TabIndex = 158;
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(3, 51);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(14, 13);
            this.rb1.TabIndex = 155;
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox15.Location = new System.Drawing.Point(216, 382);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(75, 75);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox14.Location = new System.Drawing.Point(120, 382);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(75, 75);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox12.Location = new System.Drawing.Point(216, 292);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(75, 75);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox11.Location = new System.Drawing.Point(120, 292);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 75);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Location = new System.Drawing.Point(216, 200);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 75);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Location = new System.Drawing.Point(120, 200);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 75);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox13.Location = new System.Drawing.Point(22, 382);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(75, 75);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Location = new System.Drawing.Point(216, 109);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 75);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox10.Location = new System.Drawing.Point(22, 292);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(75, 75);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(120, 109);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(22, 200);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 75);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(216, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(22, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 75);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(120, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EwiInf.Properties.Resources._15488858171582779197_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbQRCode
            // 
            this.pbQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQRCode.Location = new System.Drawing.Point(776, 479);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(150, 150);
            this.pbQRCode.TabIndex = 65;
            this.pbQRCode.TabStop = false;
            this.pbQRCode.BackgroundImageChanged += new System.EventHandler(this.pbQRCode_BackgroundImageChanged);
            // 
            // index_finansowyTextBox
            // 
            this.index_finansowyTextBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.index_finansowyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.index_finansowyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.index_finansowyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ewiBindingSource, "Index_finansowy", true));
            this.index_finansowyTextBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.index_finansowyTextBox.ForeColor = System.Drawing.Color.White;
            this.index_finansowyTextBox.Location = new System.Drawing.Point(202, 472);
            this.index_finansowyTextBox.Name = "index_finansowyTextBox";
            this.index_finansowyTextBox.Size = new System.Drawing.Size(282, 19);
            this.index_finansowyTextBox.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1024, 706);
            this.Controls.Add(index_finansowyLabel);
            this.Controls.Add(this.index_finansowyTextBox);
            this.Controls.Add(this.panelChoiceWherePrint);
            this.Controls.Add(this.PrintQRCode);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.pbQRCode);
            this.Controls.Add(this.panelSteer);
            this.Controls.Add(system_operacyjnyLabel1);
            this.Controls.Add(this.system_operacyjnyTextBox1);
            this.Controls.Add(numer_kartyLabel1);
            this.Controls.Add(this.numer_kartyTextBox1);
            this.Controls.Add(this.comboBoxInformatykaLacznosc);
            this.Controls.Add(this.comboBoxPomieszczenie);
            this.Controls.Add(this.comboBoxPietro);
            this.Controls.Add(this.comboBoxBudynek);
            this.Controls.Add(this.comboBoxRodzajEwidencji);
            this.Controls.Add(this.comboBoxRodzajSprzetu);
            this.Controls.Add(this.checkBoxCreateCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddPomieszczenie);
            this.Controls.Add(this.btAddPietro);
            this.Controls.Add(this.btAddBudynek);
            this.Controls.Add(this.btAddRodzajSprzetu);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nr_ewidencyjnyLabel);
            this.Controls.Add(this.nr_ewidencyjnyTextBox);
            this.Controls.Add(rodzaj_sprzętuLabel);
            this.Controls.Add(this.rodzaj_sprzętuTextBox);
            this.Controls.Add(nazwa_ProducentLabel);
            this.Controls.Add(this.nazwa_ProducentTextBox);
            this.Controls.Add(rok_produkcjiLabel);
            this.Controls.Add(this.rok_produkcjiTextBox);
            this.Controls.Add(termin_gwarancjiLabel);
            this.Controls.Add(this.termin_gwarancjiTextBox);
            this.Controls.Add(nr_seryjnyLabel);
            this.Controls.Add(this.nr_seryjnyTextBox);
            this.Controls.Add(wartosc_zakupuLabel);
            this.Controls.Add(this.wartosc_zakupuTextBox);
            this.Controls.Add(nr_fakturyLabel);
            this.Controls.Add(this.nr_fakturyTextBox);
            this.Controls.Add(rodzaj_ewidencjiLabel);
            this.Controls.Add(this.rodzaj_ewidencjiTextBox);
            this.Controls.Add(mac_adresLabel);
            this.Controls.Add(this.mac_adresTextBox);
            this.Controls.Add(iP_adres1Label);
            this.Controls.Add(this.iP_adres1TextBox);
            this.Controls.Add(iP_adres2Label);
            this.Controls.Add(this.iP_adres2TextBox);
            this.Controls.Add(iP_adres3Label);
            this.Controls.Add(this.iP_adres3TextBox);
            this.Controls.Add(karta_grafiki1Label);
            this.Controls.Add(this.karta_grafiki1TextBox);
            this.Controls.Add(karta_grafiki2Label);
            this.Controls.Add(this.karta_grafiki2TextBox);
            this.Controls.Add(procesorLabel);
            this.Controls.Add(this.procesorTextBox);
            this.Controls.Add(ramLabel);
            this.Controls.Add(this.ramTextBox);
            this.Controls.Add(dysk1Label);
            this.Controls.Add(this.dysk1TextBox);
            this.Controls.Add(dysk2Label);
            this.Controls.Add(this.dysk2TextBox);
            this.Controls.Add(budynekLabel);
            this.Controls.Add(this.budynekTextBox);
            this.Controls.Add(pietroLabel);
            this.Controls.Add(this.pietroTextBox);
            this.Controls.Add(pomieszczenieLabel);
            this.Controls.Add(this.pomieszczenieTextBox);
            this.Controls.Add(informatyka_LacznoscLabel);
            this.Controls.Add(this.informatyka_LacznoscTextBox);
            this.Controls.Add(uwagiLabel);
            this.Controls.Add(this.uwagiTextBox);
            this.Controls.Add(this.ewiBindingNavigator);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EwiInf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ewiBindingNavigator)).EndInit();
            this.ewiBindingNavigator.ResumeLayout(false);
            this.ewiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ewiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ewidencjaDataSet)).EndInit();
            this.panelSteer.ResumeLayout(false);
            this.panelSteer.PerformLayout();
            this.panelChoiceWherePrint.ResumeLayout(false);
            this.panelChoiceWherePrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EwidencjaDataSet ewidencjaDataSet;
        private System.Windows.Forms.BindingSource ewiBindingSource;
        private EwidencjaDataSetTableAdapters.EwiTableAdapter ewiTableAdapter;
        private EwidencjaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ewiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ewiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nr_ewidencyjnyTextBox;
        private System.Windows.Forms.TextBox rodzaj_sprzętuTextBox;
        private System.Windows.Forms.TextBox nazwa_ProducentTextBox;
        private System.Windows.Forms.TextBox rok_produkcjiTextBox;
        private System.Windows.Forms.TextBox termin_gwarancjiTextBox;
        private System.Windows.Forms.TextBox nr_seryjnyTextBox;
        private System.Windows.Forms.TextBox wartosc_zakupuTextBox;
        private System.Windows.Forms.TextBox nr_fakturyTextBox;
        private System.Windows.Forms.TextBox rodzaj_ewidencjiTextBox;
        private System.Windows.Forms.TextBox mac_adresTextBox;
        private System.Windows.Forms.TextBox iP_adres1TextBox;
        private System.Windows.Forms.TextBox iP_adres2TextBox;
        private System.Windows.Forms.TextBox iP_adres3TextBox;
        private System.Windows.Forms.TextBox karta_grafiki1TextBox;
        private System.Windows.Forms.TextBox karta_grafiki2TextBox;
        private System.Windows.Forms.TextBox procesorTextBox;
        private System.Windows.Forms.TextBox ramTextBox;
        private System.Windows.Forms.TextBox dysk1TextBox;
        private System.Windows.Forms.TextBox dysk2TextBox;
        private System.Windows.Forms.TextBox budynekTextBox;
        private System.Windows.Forms.TextBox pietroTextBox;
        private System.Windows.Forms.TextBox pomieszczenieTextBox;
        private System.Windows.Forms.TextBox informatyka_LacznoscTextBox;
        private System.Windows.Forms.TextBox uwagiTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCreateCard;
        private System.Windows.Forms.ComboBox comboBoxRodzajSprzetu;
        private System.Windows.Forms.ComboBox comboBoxRodzajEwidencji;
        private System.Windows.Forms.ComboBox comboBoxBudynek;
        private System.Windows.Forms.ComboBox comboBoxPietro;
        private System.Windows.Forms.ComboBox comboBoxPomieszczenie;
        private System.Windows.Forms.ComboBox comboBoxInformatykaLacznosc;
        private System.Windows.Forms.TextBox numer_kartyTextBox1;
        private System.Windows.Forms.TextBox system_operacyjnyTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btAddRodzajSprzetu;
        private System.Windows.Forms.Button btAddBudynek;
        private System.Windows.Forms.Button btAddPietro;
        private System.Windows.Forms.Button btAddPomieszczenie;
        private System.Windows.Forms.Button btForwardOne;
        private System.Windows.Forms.Button btBackwardOne;
        private System.Windows.Forms.Button btMoveLas;
        private System.Windows.Forms.Button btMoveFirst;
        private System.Windows.Forms.ComboBox comboBoxWhatItem;
        private System.Windows.Forms.Panel panelSteer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbHowMuchOf;
        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button PrintQRCode;
        private System.Windows.Forms.Panel panelChoiceWherePrint;
        private System.Windows.Forms.Button btPrintThisQR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btBackPrintThisQr;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb14;
        private System.Windows.Forms.RadioButton rb11;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb13;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox index_finansowyTextBox;
    }
}