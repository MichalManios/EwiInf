using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EwiInf
{
    class ConectAndModifyData
    {
        //zmienne 
        SqlConnection connection; //= new SqlConnection(@"Data Source = DESKTOP-DOSSHB6\SQLEXPRESS; Initial Catalog = C:\USERS\1133183\SOURCE\REPOS\EWIINF\EWIINF\EWIDENCJA.MDF;User ID = Administrator; Password=789kaoz");//(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\1133183\source\repos\EwiInf\EwiInf\Ewidencja.mdf;Integrated Security=True");
        public void ConnectionString(string ConnectionString)
        {
            connection = new SqlConnection(ConnectionString);
        }
        List<string> listaCombo = new List<string>();
        IEnumerable<string> sortCombo;
        List<ComboBox> comboBoxes = new List<ComboBox>();
        List<Button> buttons = new List<Button>();
        List<string> listaComboPietra = new List<string>();
        IEnumerable<string> sortComboPietra;
        List<string> listaComboPomieszczenia = new List<string>();
        IEnumerable<string> sortComboPomieszczenia;
        List<Pietra> pietra = new List<Pietra>();
        List<Pomieszczenia> pomieszczenia = new List<Pomieszczenia>();
        //zmienne pomieszczenia do sprawdzenia czy uległu zmianie przy edycji
        string sBudynek = "";
        string sPietro = "";
        string sPomieszczenie = "";
        string sGdzie = "";

        //generowanie stringu z lokalizacja sprzetu
        public string LocalizationString(string sBudynek, string sPietro, string sPomieszczenie)
        {
            sGdzie= sBudynek + " \\ " + sPietro + " \\ " + sPomieszczenie;
            return sGdzie;
        }

        //zapis do zmiennych pomieszczenia
        public void Where(string Budynek, string Pietro, string Pomieszczenie)
        {
            sBudynek = Budynek;
            sPietro = Pietro;
            sPomieszczenie = Pomieszczenie;
        }
        //sprawdzenie czy któras z danych lokalizacji sie zmieniła
        public bool LocalizationChange(string Budynek, string Pietro, string Pomieszczenie)
        {
            if (Budynek != sBudynek || Pietro != sPietro || Pomieszczenie != sPomieszczenie) return true;
            else return false;
            
        }


        //wyszukiwanie w bazie
        public void FindInBase(DataSet dataSet, TextBox textBox, string text)
        {
            string query = "";
            try
            {
                connection.Open();
                //if(textBox.Text!="") query = "SELECT * FROM Ewi WHERE "+text+"='"+textBox.Text.Trim()+"'";
                if (textBox.Text != "" && text != "SZUKAJ W CAŁEJ TABELI") query = "SELECT * FROM Ewi WHERE " + text + " LIKE '%" + textBox.Text + "%'";
                if (textBox.Text != "" && text == "SZUKAJ W CAŁEJ TABELI") query = "SELECT * FROM Ewi WHERE Nr_ewidencyjny LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Rodzaj_sprzętu LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Nazwa_Producent LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Rok_produkcji LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Termin_gwarancji LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Nr_seryjny LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Wartosc_zakupu LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Nr_faktury LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Rodzaj_ewidencji LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Mac_adres LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "IP_adres1 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "IP_adres2 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "IP_adres3 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Karta_grafiki1 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Karta_grafiki2 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Procesor LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Ram LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Dysk1 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Dysk2 LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Budynek LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Pietro LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Pomieszczenie LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Informatyka_Lacznosc LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "System_operacyjny LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Numer_karty LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Uwagi LIKE '%" + textBox.Text + "%' OR " +
                                                                                                            "Index_finansowy LIKE '%" + textBox.Text + "%'";
                if (textBox.Text == "") query = "SELECT * FROM Ewi";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables["Ewi"]);
                dataSet.Tables["Ewi"].Clear();
                SDA.Fill(dataSet.Tables["Ewi"]);
                connection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        //odswieżenie widoku bazy danych
        public void RefreshBase(DataSet dataSet)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Ewi";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables[0]);
                dataSet.Tables[0].Clear();
                SDA.Fill(dataSet.Tables[0]);
                connection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        //zapis do bazy danych
        public void SaveData(TextBox textBox1, TextBox textBox2, ComboBox comboBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, ComboBox comboBox10,
                            TextBox textBox11, TextBox textBox12, TextBox textBox13, TextBox textBox14, TextBox textBox15,
                            TextBox textBox16, TextBox textBox17, TextBox textBox18, TextBox textBox19, TextBox textBox20,
                            ComboBox comboBox23, ComboBox comboBox24, ComboBox comboBox25,
                            ComboBox comboBox26, TextBox textBox21, TextBox textBox22, TextBox textBox27, TextBox textBox28)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Ewi (Id, Nr_ewidencyjny, Rodzaj_sprzętu, Nazwa_Producent, Rok_produkcji, Termin_gwarancji, Nr_seryjny, Wartosc_zakupu, Nr_faktury, Rodzaj_ewidencji, Mac_adres, IP_adres1, IP_adres2, IP_adres3, Karta_grafiki1, Karta_grafiki2, Procesor, Ram, Dysk1, Dysk2, Budynek, Pietro, Pomieszczenie, Informatyka_Lacznosc, System_operacyjny, Numer_karty, Uwagi, Index_finansowy)" +
                    "VALUES (N'" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + comboBox3.Text + "', N'" + textBox4.Text + "', N'" + textBox5.Text + "', N'" + textBox6.Text + "', N'" + textBox7.Text + "', N'" + textBox8.Text + "', N'" + textBox9.Text + "', N'" + comboBox10.Text + "', N'" + textBox11.Text + "', N'" + textBox12.Text + "', N'" + textBox13.Text + "', N'" + textBox14.Text + "', N'" + textBox15.Text + "', N'" + textBox16.Text + "', N'" + textBox17.Text + "', N'" + textBox18.Text + "', N'" + textBox19.Text + "', N'" + textBox20.Text + "', N'" + comboBox23.Text + "', N'" + comboBox24.Text + "', N'" + comboBox25.Text + "', N'" + comboBox26.Text + "', N'" + textBox21.Text + "', N'" + textBox22.Text + "', N'" + textBox27.Text + "', N'" + textBox28.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Zapisano!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        //modyfikacja rekordu i zapis modyfikacji
        public void ModifyData(TextBox textBox1, TextBox textBox2, ComboBox comboBox3, TextBox textBox4, TextBox textBox5,
                            TextBox textBox6, TextBox textBox7, TextBox textBox8, TextBox textBox9, ComboBox comboBox10,
                            TextBox textBox11, TextBox textBox12, TextBox textBox13, TextBox textBox14, TextBox textBox15,
                            TextBox textBox16, TextBox textBox17, TextBox textBox18, TextBox textBox19, TextBox textBox20,
                            ComboBox comboBox23, ComboBox comboBox24, ComboBox comboBox25,
                            ComboBox comboBox26, TextBox textBox21, TextBox textBox22, TextBox textBox27, TextBox textBox28)
        {
            try
            {
                connection.Open();
                string query = "UPDATE Ewi SET Nr_ewidencyjny = N'" + textBox2.Text +
                    "', Rodzaj_sprzętu = N'" + comboBox3.Text +
                    "', Nazwa_Producent = N'" + textBox4.Text +
                    "', Rok_produkcji = N'" + textBox5.Text +
                    "', Termin_gwarancji = N'" + textBox6.Text +
                    "', Nr_seryjny = N'" + textBox7.Text +
                    "', Wartosc_zakupu = N'" + textBox8.Text +
                    "', Nr_faktury = N'" + textBox9.Text +
                    "', Rodzaj_ewidencji = N'" + comboBox10.Text +
                    "', Mac_adres = N'" + textBox11.Text +
                    "', IP_adres1 = N'" + textBox12.Text +
                    "', IP_adres2 = N'" + textBox13.Text +
                    "', IP_adres3 = N'" + textBox14.Text +
                    "', Karta_grafiki1 = N'" + textBox15.Text +
                    "', Karta_grafiki2 = N'" + textBox16.Text +
                    "', Procesor = N'" + textBox17.Text +
                    "', Ram = N'" + textBox18.Text +
                    "', Dysk1 = N'" + textBox19.Text +
                    "', Dysk2 = N'" + textBox20.Text +
                    "', Budynek = N'" + comboBox23.Text +
                    "', Pietro = N'" + comboBox24.Text +
                    "', Pomieszczenie = N'" + comboBox25.Text +
                    "', Informatyka_Lacznosc = N'" + comboBox26.Text +
                   "', System_operacyjny = N'" + textBox21.Text +
                    "', Numer_karty = N'" + textBox22.Text +
                    "', Uwagi = N'" + textBox27.Text +
                    "', Index_finansowy = N'" + textBox28.Text +
                    "'WHERE Id = N'" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Dokonano zmian!!!", "INFORMACJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        //usunięcie z bazy danych
        public void DeleteData(DataGridView dataGridView1)
        {
            //dodanie do histori danych z usuwanego rekordu z tabeli ewi
            try
            {
                connection.Open();
                string query = "INSERT INTO History (Id, Nr_ewidencyjny, Rodzaj_sprzetu, Nazwa_producenta, Nr_seryjny, Wartosc_zakupu, Nr_faktury, Rodzaj_ewidencji, Budynek, Pietro, Pomieszczenie, Informatyka_Lacznosc, Uwagi, Index_finansowy, Kto_modyfikowal, Data_usuniecia)" +
                    "VALUES (N'" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) + "', N'" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + 
                    "', N'" + dataGridView1.SelectedRows[0].Cells[6].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[7].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[8].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[9].Value.ToString() + 
                    "', N'" + dataGridView1.SelectedRows[0].Cells[21].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[22].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[23].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[24].Value.ToString() +
                    "', N'" + dataGridView1.SelectedRows[0].Cells[27].Value.ToString() + "', N'" + dataGridView1.SelectedRows[0].Cells[10].Value.ToString() + "', N'" + Environment.UserName + "', N'" + DateTime.Now + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            //usuniecie karty urzadzenia ktore jest usuwane
            //if (dataGridView1.SelectedRows[0].Cells[25].Value.ToString() != null)
            //{
                //dane karty do usuniecia
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Karta Where Nr_karty='" + dataGridView1.SelectedRows[0].Cells[26].Value.ToString().Trim() + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

                //dane karty konserwacja do usuniecia
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Karta_konserwacja Where Nr_karty='" + dataGridView1.SelectedRows[0].Cells[26].Value.ToString().Trim() + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }

                //karta naprawa
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Karta_naprawy Where Nr_karty='" + dataGridView1.SelectedRows[0].Cells[26].Value.ToString().Trim() + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            //}

            //usunięcie rekordu z bazy danych z tabeli Ewi
            try
            {
                connection.Open();
                string query = "DELETE FROM Ewi Where Id='" + Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value) + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        
        //podział na pomieszczenia
        public void CompleteRoomII(ComboBox comboBoxPietro, ComboBox comboBoxPomieszczenie)
        {
            for (int i = 0; i < pomieszczenia.Count; i++)
            {
                if (comboBoxPietro.SelectedItem.ToString().ToUpper() == pomieszczenia[i].sID.ToString().ToUpper())
                    listaComboPomieszczenia.Add(pomieszczenia[i].sPomieszczenie.ToString().ToUpper());
            }
            sortComboPomieszczenia = listaComboPomieszczenia.Distinct<string>() as IEnumerable<string>;

            foreach (var item in sortComboPomieszczenia)
            {
                comboBoxPomieszczenie.Items.Add(item);
            }
            //czyszczenie listy i posortowanej listy
            listaComboPomieszczenia.Clear();
            sortComboPomieszczenia = listaCombo;
        }
        
        //podział na pietra
        public void CompleteFloorII(ComboBox comboBoxBudynek, ComboBox comboBoxPietro)
        {
            for (int i = 0; i < pietra.Count; i++)
            {
                if (comboBoxBudynek.SelectedItem.ToString().ToUpper() == pietra[i].sID.ToString().ToUpper())
                    listaComboPietra.Add(pietra[i].sPietro.ToString().ToUpper());
            }
            sortComboPietra = listaComboPietra.Distinct<string>() as IEnumerable<string>;

            foreach (var item in sortComboPietra)
            {
                comboBoxPietro.Items.Add(item);
            }
            //czyszczenie listy i posortowanej listy
            listaComboPietra.Clear();
            sortComboPietra = listaCombo;
        }
        //uzupełnienie combosow danymi do wyboru z bazy danych
        public void CompleteComboII(DataSet dataSet, ComboBox comboBox, int iID)
        {
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                listaCombo.Add(dataSet.Tables[0].Rows[i][iID].ToString().ToUpper());
            }
            sortCombo = listaCombo.Distinct<string>() as IEnumerable<string>;

            foreach (var item in sortCombo)
            {
                comboBox.Items.Add(item);
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if(item.ToString().ToUpper() == dataSet.Tables[0].Rows[i][iID].ToString().ToUpper())
                    pietra.Add(new Pietra() { sID = item, sPietro = dataSet.Tables[0].Rows[i][21].ToString().ToUpper() });
                }
            }
            for (int a = 0; a < pietra.Count; a++)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if (pietra[a].sPietro.ToString().ToUpper()== dataSet.Tables[0].Rows[i][21].ToString().ToUpper())
                        pomieszczenia.Add(new Pomieszczenia() { sID = pietra[a].sPietro.ToString().ToUpper(), sPomieszczenie = dataSet.Tables[0].Rows[i][22].ToString().ToUpper() });
                }
            }
            //czyszczenie listy i posortowanej listy
            listaCombo.Clear();
            sortCombo = listaCombo;
        }
        //uzupełnienie combosow danymi do wyboru z bazy danych
        public void CompleteCombo(DataSet dataSet, ComboBox comboBox, int iID)
        {
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                listaCombo.Add(dataSet.Tables[0].Rows[i][iID].ToString().ToUpper());
            }
            sortCombo = listaCombo.Distinct<string>() as IEnumerable<string>;

            foreach (var item in sortCombo)
            {
                if(item !="MONITOR" && item != "KOMPUTER" && item != "TELEFON" && item != "DRUKARKA" &&
                    item != "PONIŻEJ" && item != "POWYŻEJ" && item != "ŚRODEK TRWAŁY" &&
                    item != "INFORMATYKA" && item != "ŁĄCZNOŚĆ")
                comboBox.Items.Add(item);
            }
            //czyszczenie listy i posortowanej listy
            listaCombo.Clear();
            sortCombo = listaCombo;
        }
        //dodawanie combosow i buttonow
        public void AddComboBox(ComboBox comboBox, Button button)
        {
            button.Visible = false;
            comboBox.DropDownStyle = ComboBoxStyle.Simple;
            comboBox.Text = "";
            comboBox.Focus();
            comboBoxes.Add(comboBox);
            buttons.Add(button);
        }
        //czyszczenie list combosów i bottonow
        public void ClearCombosAndButtons()
        {
            buttons.Clear();
            comboBoxes.Clear();
        }
        //dodawanie nowych itemow do combosow
        public void AddItemToComboBox()
        {
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                comboBoxes[i].Items.Add(comboBoxes[i].Text);
                comboBoxes[i].SelectedIndex = comboBoxes[i].Items.Count - 1;
            }
            //comboBoxes.Clear();
        }
        //visible true button to add items to combo
        public void ButtonAndComboNormal()
        {
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                comboBoxes[i].DropDownStyle = ComboBoxStyle.DropDownList;
            }
            comboBoxes.Clear();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Visible = true;
            }
            buttons.Clear();
        }
        //dodanie do comboboxa tytułów z datagridview
        public void GetHeaderDGV(DataGridView dataGridView, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("SZUKAJ W CAŁEJ TABELI");
            if (dataGridView.Rows.Count > 0)
            {
                for (int i = 1; i < dataGridView.ColumnCount; i++)
                {
                    if(dataGridView.Columns[i].Visible==true)
                    comboBox.Items.Add(dataGridView.Columns[i].HeaderText.ToString());
                }
            }
            comboBox.SelectedIndex = 0;
        }

        //wczytanie danych do uzupełnienia treeview
        public void TreeView(DataSet dataSet, int iID)
        {
            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                listaCombo.Add(dataSet.Tables[0].Rows[i][iID].ToString().ToUpper());
            }
            sortCombo = listaCombo.Distinct<string>() as IEnumerable<string>;

            foreach (var item in sortCombo)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    if (item.ToString().ToUpper() == dataSet.Tables[0].Rows[i][iID].ToString().ToUpper())
                        pietra.Add(new Pietra() { sID = item, sPietro = dataSet.Tables[0].Rows[i][21].ToString().ToUpper() });
                }
            }
        }

        //uzupełnienie treeview
        public void CompleteTreeView(TreeView treeView, DataSet dataSet)
        {
            List<string> SPietra = new List<string>();
            List<string> SPomieszczenia = new List<string>();
            TreeNode treeNode;
            //dodawanie budynków do drzewa
            foreach (string item in sortCombo)
            {
                treeNode = treeView.Nodes.Add(item.ToUpper());
            }
            //dodawanie pieter do drzewa
            int x = 0;
            foreach (var item in sortCombo)
            {
                for (int i = 0; i < pietra.Count; i++)
                {
                    if (item.ToString().ToUpper() == pietra[i].sID.ToUpper())
                    {
                        int ileRazyPietro = 0;
                        SPietra.Add(pietra[i].sPietro.ToUpper());
                        if(SPietra.Count==1) treeView.Nodes[x].Nodes.Add(pietra[i].sPietro.ToUpper());
                        else
                        {
                            for (int y = 0; y < SPietra.Count; y++)
                            {
                                
                                if (pietra[i].sPietro.ToUpper() == SPietra[y].ToUpper()) ileRazyPietro++;
                            }
                            if(ileRazyPietro==1) treeView.Nodes[x].Nodes.Add(pietra[i].sPietro.ToUpper());
                        }
                    }
                }
                x++;
            }

            //dodawanie pomieszczeń do drzewa
            for (int a = 0; a < treeView.Nodes.Count; a++)
            {
                for (int i = 0; i < treeView.Nodes[a].Nodes.Count; i++)
                {
                    
                    for (int z = 0; z < dataSet.Tables[0].Rows.Count; z++)
                    {
                        
                        if (treeView.Nodes[a].Text.ToUpper() == dataSet.Tables[0].Rows[z][20].ToString().ToUpper() && treeView.Nodes[a].Nodes[i].Text.ToUpper() == dataSet.Tables[0].Rows[z][21].ToString().ToUpper())
                        {
                            int ileRazyPomieszczenie = 0;
                            SPomieszczenia.Add(dataSet.Tables[0].Rows[z][22].ToString().ToUpper());
                            if (SPomieszczenia.Count == 1) treeView.Nodes[a].Nodes[i].Nodes.Add(dataSet.Tables[0].Rows[z][22].ToString().ToUpper());
                            else
                            {
                                for (int y = 0; y < SPomieszczenia.Count; y++)
                                {

                                    if (dataSet.Tables[0].Rows[z][22].ToString().ToUpper()==SPomieszczenia[y].ToUpper()) ileRazyPomieszczenie++;
                                }
                                if (ileRazyPomieszczenie == 1) treeView.Nodes[a].Nodes[i].Nodes.Add(dataSet.Tables[0].Rows[z][22].ToString().ToUpper());
                               
                            }
                            
                        }
                        
                    }
                    SPomieszczenia.Clear();
                }
            }
            treeView.Sort();
            treeView.ExpandAll();
        }

        //wyszukiwanie w bazie po numerze dokumentu zakupu
        public void FindInBaseByNumberDoc(DataSet dataSet, string sNumerDokumentu)
        {
            string query = "";
            try
            {
                connection.Open();
                query = "SELECT * FROM Ewi WHERE Nr_faktury LIKE N'" + sNumerDokumentu + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
                SDA.Update(dataSet.Tables["Ewi"]);
                dataSet.Tables["Ewi"].Clear();
                SDA.Fill(dataSet.Tables["Ewi"]);
                connection.Close();
            }
            catch (SqlException exp)
            {
                MessageBox.Show(exp.Message, "Błąd!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
