using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgyeletFigyelo
{
    public partial class Form1 : Form
    {
        private List<BindingSourceClass> bindingslist = new List<BindingSourceClass>();
        private List<string> groupList = new List<string>();
        private List<string> szakugylist = new List<string>();
        private List<string> infolist = new List<string>();
        private List<string> muszaklist = new List<string>();
        private List<string> allatilist = new List<string>();
        private string[] osztalyTomb = new string[] { "Pénzügyi Osztály", "Majomházi Bemutató Körzet", "Pálmaházi Bemutató Körzet", "Pannon Park Gyűjteményi Körzet", "Parasztudvari Bemutató Körzet", "Ismeretterjesztő Osztály - Holnemvolt Vár", "Beléptetési-, és Jegyértékesítési Csoport", "Kereskedelmi Csoport", "Beszerzési és Ellátási Osztály", "Informatikai Csoport", "Intézményi Titkárság", "Kertészeti és Botanikai Osztály", "Munkaügyi Osztály", "Pannon Park Létesítményi Osztály", "Üzemeltetési Osztály", "Madármentő állomás", "Ismeretterjesztő Osztály", "Marketing és Kommunikációs Osztály", "Természetvédelmi- és Állategészségügyi Igazgatóság", "Jegyértékesítési, Kereskedelmi és Vagyonhasznosítási Osztály" };
        private string checkcell = string.Empty;
        private string duplicate = string.Empty;
        private bool specVisible = false;
        private DataTable dtn = new DataTable("portalDB");
        private DataGridViewComboBoxColumn szakugyiCol = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn infoCol = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn allatiCol = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn muszakCol = new DataGridViewComboBoxColumn();
        private List<string> jogosultallat = new List<string>();
        private List<string> jogosultinfo = new List<string>();
        private List<string> jogosultmuszak = new List<string>();
        private List<string> jogosultszak = new List<string>();


        public Form1()
        {
            InitializeComponent();
            statusLabel.Text = Environment.MachineName + " / " + Environment.UserDomainName + " / " + Environment.UserName;
        }
        // _____________________________________________________________________________________________________________________________________
        private void permissionMet()
        {
            ConnectionADgroupMet("Szakügyelet szerkesztő", 'j');
            ConnectionADgroupMet("Állatorvosi ügyelet szerkesztő", 'k');
            ConnectionADgroupMet("Informatikai ügyelet szerkesztő", 'l');
            ConnectionADgroupMet("Műszaki ügyelet szerkesztő", 'm');
            foreach (var keres in bindingslist)
            {
                if (jogosultinfo.Contains(keres.registrationNumber)) if (keres.userAdmin.Contains(Environment.UserName)) permissionVoid('1','1','1', '1', '1', '1', '1','1');
                if (jogosultallat.Contains(keres.registrationNumber)) if (keres.userAdmin.Contains(Environment.UserName)) permissionVoid('1', '1', '0', '0', '0', '1', '0','0');
                if (jogosultmuszak.Contains(keres.registrationNumber)) if (keres.userAdmin.Contains(Environment.UserName)) permissionVoid('1', '1', '0', '0', '0', '0', '1', '0');
                if (jogosultszak.Contains(keres.registrationNumber)) if (keres.userAdmin.Contains(Environment.UserName)) permissionVoid('1', '1', '0', '0', '1', '0', '0', '0');
            }
        }

        private void permissionVoid(char key, char key2, char key3, char key4, char key5, char key6, char key7, char key8)
        {
            if (key == '1') specSrcBtn.Enabled = true;
            if (key2 == '1') hidepanel.Visible = false;
            if (key3 == '1') dataGridViewF.Columns["registrationNumber"].Visible = true;
            if (key4 == '0') infoCol.ReadOnly = true;
            if (key5 == '0') szakugyiCol.ReadOnly = true;
            if (key6 == '0') allatiCol.ReadOnly = true;
            if (key7 == '0') muszakCol.ReadOnly = true;
            if (key8 == '1') clearBtn.Enabled = true;
        }
        // _____________________________________________________________________________________________________________________________________
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWindow lw = new LoadWindow();
            lw.Show();
            ConnectionADuserMet();
            portalDBload();
            ugyeletDatagridFeltolt();
            userSearchInsert();
            duplicatedRowRemoveandStyle();
            permissionMet();
            lw.Close();
        }

        private void ugyeletDatagridFeltolt()
        {
            ConnectionADgroupMet("Szakugyeletesek", 's');
            ConnectionADgroupMet("Informatikai ügyelet", 'i');
            ConnectionADgroupMet("Állatorvosi ügyelet", 'a');
            ConnectionADgroupMet("Műszaki ügyelet", 'u');

            szakugyiCol.HeaderText = "Szakügyi ügyeletes";
            szakugyiCol.Width = 215;
            szakugyiCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            szakugyiCol.DefaultCellStyle.BackColor = Color.LightCyan;
            szakugyiCol.Name = "szakugyiCol";
            szakugyiCol.Sorted = true;
            infoCol.HeaderText = "Informatikai ügyeletes";
            infoCol.Width = 215;
            infoCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            infoCol.Name = "infoCol";
            infoCol.DefaultCellStyle.BackColor = Color.LightCyan;
            infoCol.Sorted = true;
            allatiCol.HeaderText = "Állatorvosi ügyeletes";
            allatiCol.Width = 215;
            allatiCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            allatiCol.Name = "allatiCol";
            allatiCol.DefaultCellStyle.BackColor = Color.LightCyan;
            allatiCol.Sorted = true;
            muszakCol.HeaderText = "Műszaki ügyeletes";
            muszakCol.Width = 215;
            muszakCol.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            muszakCol.Name = "muszakCol";
            muszakCol.DefaultCellStyle.BackColor = Color.LightCyan;
            muszakCol.Sorted = true;

            foreach (var nevek in bindingslist)
            {
                try
                {
                    if (szakugylist.Contains(nevek.registrationNumber)) szakugyiCol.Items.Add(nevek.userName);
                    if (infolist.Contains(nevek.registrationNumber)) infoCol.Items.Add(nevek.userName);
                    if (allatilist.Contains(nevek.registrationNumber)) allatiCol.Items.Add(nevek.userName);
                    if (muszaklist.Contains(nevek.registrationNumber)) muszakCol.Items.Add(nevek.userName);
                } catch (Exception) {}
            }
            dataGridViewU.Columns.Add(szakugyiCol);
            dataGridViewU.Columns.Add(infoCol);
            dataGridViewU.Columns.Add(allatiCol);
            dataGridViewU.Columns.Add(muszakCol);

            foreach (DataRow napokSor in dtn.Rows) dataGridViewU.Rows.Add(napokSor["napId"].ToString(), napokSor["nap"].ToString(), napokSor["tipus"].ToString(), napokSor["fId"].ToString(), napokSor["ugyeletTipus"].ToString());
        }

        private void userSearchInsert()
        {

            if (dataGridViewU.Rows.Count > 0)
            {
                foreach (var lists in bindingslist)
                {
                    foreach (DataGridViewRow row in dataGridViewU.Rows)
                    {
                        DataGridViewComboBoxCell szakBoxCell = (row.Cells["szakugyiCol"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell infoBoxCell = (row.Cells["infoCol"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell allatBoxCell = (row.Cells["allatiCol"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell muszakBoxCell = (row.Cells["muszakCol"] as DataGridViewComboBoxCell);

                        if (row.Cells["userID"].Value != null || szakBoxCell.Value != null || allatBoxCell.Value != null || infoBoxCell.Value != null || muszakBoxCell.Value != null)
                        {
                            if (row.Cells["userID"].Value.ToString() == lists.registrationNumber)
                            {
                                switch (row.Cells["ugyelettipus"].Value.ToString())
                                {
                                    case "1":
                                        szakBoxCell.Value = lists.userName;
                                        break;
                                    case "2":
                                        allatBoxCell.Value = lists.userName;
                                        break;
                                    case "3":
                                        infoBoxCell.Value = lists.userName;
                                        break;
                                    case "4":
                                        muszakBoxCell.Value = lists.userName;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void duplicatedRowRemoveandStyle()
        {
            dataGridViewU.AllowUserToAddRows = false;
            foreach (DataGridViewRow rows in dataGridViewU.Rows) rows.Cells["datum"].Value = rows.Cells["datum"].Value.ToString().Remove(14, 7);
            duplicatedRowLoop();
            duplicatedRowLoop();
        }
        //                                      ▲ ▼
        private void duplicatedRowLoop()
        {
            for (int r = 0; r < dataGridViewU.Rows.Count - 1; r++)
            {
                if (dataGridViewU.Rows[r].Cells["datum"].Value.ToString() == dataGridViewU.Rows[r + 1].Cells["datum"].Value.ToString())
                {
                    DataGridViewComboBoxCell szakBoxCell = (dataGridViewU.Rows[r].Cells["szakugyiCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell infoBoxCell = (dataGridViewU.Rows[r].Cells["infoCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell allatBoxCell = (dataGridViewU.Rows[r].Cells["allatiCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell muszakBoxCell = (dataGridViewU.Rows[r].Cells["muszakCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell szakBoxCell2 = (dataGridViewU.Rows[r + 1].Cells["szakugyiCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell infoBoxCell2 = (dataGridViewU.Rows[r + 1].Cells["infoCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell allatBoxCell2 = (dataGridViewU.Rows[r + 1].Cells["allatiCol"] as DataGridViewComboBoxCell);
                    DataGridViewComboBoxCell muszakBoxCell2 = (dataGridViewU.Rows[r + 1].Cells["muszakCol"] as DataGridViewComboBoxCell);

                    if (szakBoxCell.Value == null) szakBoxCell.Value = szakBoxCell2.Value;
                    if (infoBoxCell.Value == null) infoBoxCell.Value = infoBoxCell2.Value;
                    if (allatBoxCell.Value == null) allatBoxCell.Value = allatBoxCell2.Value;
                    if (muszakBoxCell.Value == null) muszakBoxCell.Value = muszakBoxCell2.Value;

                    dataGridViewU.Rows.Remove(dataGridViewU.Rows[r + 1]);
                }
                if (dataGridViewU.Rows[r].Cells["napTyp"].Value.ToString() == "pihenőnap") dataGridViewU.Rows[r].DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }

        private void ConnectionADgroupMet(string groupname, char bar)
        {
            try
            {
                groupList.Clear();

                PrincipalContext context = new PrincipalContext(ContextType.Domain, "10.1.1.2");
                PrincipalSearcher searcher = new PrincipalSearcher(new UserPrincipal(context));

                GroupPrincipal sp = new GroupPrincipal(context, groupname);
                searcher.QueryFilter = sp;
                GroupPrincipal group = searcher.FindOne() as GroupPrincipal;
                foreach (var f in group.GetMembers())
                {
                    var principal = f as UserPrincipal;

                    if (principal == null || string.IsNullOrEmpty(principal.Description))
                        continue;

                    switch (bar)
                    {
                        case 's':
                            szakugylist.Add(principal.Description);
                            break;
                        case 'i':
                            infolist.Add(principal.Description);
                            break;
                        case 'a':
                            allatilist.Add(principal.Description);
                            break;
                        case 'g':
                            groupList.Add(principal.Description);
                            break;
                        case 'j':
                            jogosultszak.Add(principal.Description);
                            break;
                        case 'k':
                            jogosultallat.Add(principal.Description);
                            break;
                        case 'l':
                            jogosultinfo.Add(principal.Description);
                            break;
                        case 'm':
                            jogosultmuszak.Add(principal.Description);
                            break;
                        case 'u':
                            muszaklist.Add(principal.Description);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                if (MessageBox.Show("Nem lehet csatlakozni a tartomány kiszolgálóhoz, hiba a csoportok lekérdezésekor.\nLehet nem vagy rajta a FÁNK hálózatán!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void ConnectionADuserMet()
        {
            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Domain, "10.1.1.2");
                PrincipalSearcher searcher = new PrincipalSearcher(new UserPrincipal(context));

                foreach (var result in searcher.FindAll())
                {
                    DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                    BindingSourceClass bsc = new BindingSourceClass();
                    if (de.Properties["cn"].Value != null)
                    {
                        bsc.userName = (string)de.Properties["cn"].Value;
                        bsc.userAdmin = (string)de.Properties["sAMAccountName"].Value;
                        bsc.company = (string)de.Properties["company"].Value;
                        bsc.department = (string)de.Properties["department"].Value;
                        bsc.registrationNumber = (string)de.Properties["description"].Value;
                        bsc.mail = (string)de.Properties["mail"].Value;
                        bsc.telNumber = (string)de.Properties["telephoneNumber"].Value;
                        bsc.title = (string)de.Properties["title"].Value;
                        bindingslist.Add(bsc);
                    }
                }
            }
            catch (Exception)
            {
                if (MessageBox.Show("Nem lehet csatlakozni a tartomány kiszolgálóhoz, hiba a felhasználók lekérdezésekor.\nLehet nem vagy rajta a FÁNK hálózatán!", "Hiba!") == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void portalDBload()
        {
            string myConnectionString = "server=10.90.123.2;uid=zoomgmt;" +
                                    "pwd=cu9GtPAgXdjLu4rN;database=portal";
            try
            {
                string query = "SELECT e.napId, e.nap, e.tipus, m.napId, m.fId, m.ugyeletTipus FROM napok e LEFT OUTER JOIN ugyelet m ON (e.napId = m.napId) WHERE tipus='pihenőnap' OR tipus='hétvége' ORDER BY e.napId";
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, connection);
                returnVal.Fill(dtn);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fankBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            osztalyBox.Items.Clear();
            osztalyBox.Text = string.Empty;
            switch (fankBox.SelectedIndex)
            {
                case 0:
                    osztalyBox.Items.Add(osztalyTomb[0]);
                    break;
                case 1:
                    osztalyBox.Items.Add(osztalyTomb[1]);
                    osztalyBox.Items.Add(osztalyTomb[2]);
                    osztalyBox.Items.Add(osztalyTomb[3]);
                    osztalyBox.Items.Add(osztalyTomb[4]);
                    break;
                case 2:
                    osztalyBox.Items.Add(osztalyTomb[5]);
                    osztalyBox.Items.Add(osztalyTomb[16]);
                    break;
                case 3:
                    osztalyBox.Items.Add(osztalyTomb[6]);
                    osztalyBox.Items.Add(osztalyTomb[7]);
                    osztalyBox.Items.Add(osztalyTomb[19]);
                    break;
                case 4:
                    osztalyBox.Items.Add("...");
                    break;
                case 5:
                    osztalyBox.Items.Add(osztalyTomb[17]);
                    break;
                case 6:
                    osztalyBox.Items.Add(osztalyTomb[8]);
                    osztalyBox.Items.Add(osztalyTomb[9]);
                    osztalyBox.Items.Add(osztalyTomb[10]);
                    osztalyBox.Items.Add(osztalyTomb[11]);
                    osztalyBox.Items.Add(osztalyTomb[12]);
                    osztalyBox.Items.Add(osztalyTomb[13]);
                    osztalyBox.Items.Add(osztalyTomb[14]);
                    break;
                case 7:
                    osztalyBox.Items.Add(osztalyTomb[18]);
                    break;

            }
            osztalyBox.Enabled = true;
        }

        private void osztalyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewF.Rows.Clear();
            foreach (var lista in bindingslist)
            {
                if (lista.department != null)
                {
                    if (lista.department.ToLowerInvariant() == osztalyBox.SelectedItem.ToString().ToLowerInvariant())
                    {
                        dataGridViewF.Rows.Add(lista.registrationNumber, lista.userName, lista.title, lista.mail, lista.telNumber, lista.department);

                    }
                }     
            }
            
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
        }

        private void userSearch()
        {
            foreach (var lista in bindingslist)
            {
                if (lista.userName != null)
                {
                    if (lista.userName.ToLowerInvariant().Contains(searchBox.Text.ToLowerInvariant()))
                    {
                        dataGridViewF.Rows.Add(lista.registrationNumber, lista.userName, lista.title, lista.mail, lista.telNumber, lista.department);
                    }
                }
            }  
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridViewF.Rows.Clear();
                userSearch();
            }
        }

        private void névjegyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About nv = new About();
            nv.Show();
        }

        private void specSrcBtn_Click(object sender, EventArgs e)
        {
            if (specVisible == false)
            {
                specPanel.Visible = true;
                specVisible = true;
            }
            else 
            {
                specVisible = false;
                specPanel.Visible = false;
            }

        }

        private void specPanel_Leave(object sender, EventArgs e)
        {
            specPanel.Visible = false;
        }

        private void dataGridViewF_Click(object sender, EventArgs e)
        {
            specPanel.Visible = false;
        }

        private void groupBtn1_Click(object sender, EventArgs e)
        {
            ConnectionADgroupMet("VPN-felhasznalok",'g');
            DataGridWriteS('g');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionADgroupMet("Szakügyeletesek", 's');
            DataGridWriteS('s');
        }

        private void DataGridWriteS(char intext)
        {
            dataGridViewF.Rows.Clear();
            foreach (var nevek in bindingslist)
            {
                if (groupList.Contains(nevek.registrationNumber) && intext == 'g') dataGridViewF.Rows.Add(nevek.registrationNumber, nevek.userName, nevek.title, nevek.mail, nevek.telNumber, nevek.department);
                if (szakugylist.Contains(nevek.registrationNumber) && intext == 's') dataGridViewF.Rows.Add(nevek.registrationNumber, nevek.userName, nevek.title, nevek.mail, nevek.telNumber, nevek.department);
                if (infolist.Contains(nevek.registrationNumber) && intext == 'i') dataGridViewF.Rows.Add(nevek.registrationNumber, nevek.userName, nevek.title, nevek.mail, nevek.telNumber, nevek.department);
                if (allatilist.Contains(nevek.registrationNumber) && intext == 'a') dataGridViewF.Rows.Add(nevek.registrationNumber, nevek.userName, nevek.title, nevek.mail, nevek.telNumber, nevek.department);

            }
            specPanel.Visible = false;
        }

        private void dataGridViewU_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewU.CurrentCell.Value == null) return;
            string uploadmemDate = string.Empty;
            string uploaddatum = string.Empty;
            string uploadinfo = string.Empty;
            string uploaduser = string.Empty;
            string uploaduserreg = string.Empty;
            string uploadkozl = string.Empty;

            string myConnectionString = "server=10.90.123.2;uid=zoomgmt;" +
                                    "pwd=cu9GtPAgXdjLu4rN;database=portal";
            try
            {
                MySqlConnection connection = new MySqlConnection(myConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                
                uploadmemDate = dataGridViewU.CurrentRow.Cells["ID"].Value.ToString();
                uploaddatum = dataGridViewU.CurrentRow.Cells["datum"].Value.ToString();
                switch (e.ColumnIndex)
                {
                    case 5:
                        uploadinfo = "1";
                        uploaduser = dataGridViewU.CurrentCell.Value.ToString();
                        uploadkozl = "Szakügyeletes";
                        break;
                    case 6:
                        uploadinfo = "3";
                        uploaduser = dataGridViewU.CurrentCell.Value.ToString();
                        uploadkozl = "Informatikus";
                        break;
                    case 7:
                        uploadinfo = "2";
                        uploaduser = dataGridViewU.CurrentCell.Value.ToString();
                        uploadkozl = "Állatorvos";
                        break;
                    case 8:
                        uploadinfo = "4";
                        uploaduser = dataGridViewU.CurrentCell.Value.ToString();
                        uploadkozl = "Műszakos";
                        break;
                }

                foreach (var listitem in bindingslist)
                {
                    if (uploaduser == listitem.userName)
                    {
                        uploaduserreg = listitem.registrationNumber;
                    }
                }

                cmd.Transaction = null;
                cmd.CommandText = "REPLACE INTO ugyelet(napId,fId,ugyeletTipus) VALUES(@napId, @fId, @ugyeletTipus)"; // ON DUPLICATE KEY UPDATE ugyelet = @napId, @fId, @ugyeletTipus
                cmd.Parameters.AddWithValue("@napId", uploadmemDate);
                cmd.Parameters.AddWithValue("@fId", uploaduserreg);
                cmd.Parameters.AddWithValue("@ugyeletTipus", uploadinfo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("új bejegyzés: " + uploaddatum + " - " + uploaduser + " / " + uploadkozl, "Rögzítés...");

                connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionADgroupMet("Informatikai ügyelet", 'i');
            DataGridWriteS('i');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectionADgroupMet("Állatorvosi ügyelet", 'a');
            DataGridWriteS('a');
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=10.90.123.2;uid=zoomgmt;" +
                                    "pwd=cu9GtPAgXdjLu4rN;database=portal";
            if (MessageBox.Show("Tényleg törölni szeretnéd az összes bejegyzést?", "Törlés...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection(myConnectionString);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.Transaction = null;
                    cmd.CommandText = "DELETE FROM ugyelet";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ügyelet tábla adatai törölve lettek!", "Törlés...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
    