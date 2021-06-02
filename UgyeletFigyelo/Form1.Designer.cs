namespace UgyeletFigyelo
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.specSrcBtn = new System.Windows.Forms.Button();
            this.specPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBtn1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewF = new System.Windows.Forms.DataGridView();
            this.registrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osztalyBox = new System.Windows.Forms.ComboBox();
            this.fankBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearBtn = new System.Windows.Forms.Button();
            this.hidepanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.datumvalaszto = new System.Windows.Forms.DateTimePicker();
            this.ugyeletBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewU = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyelettipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tesztGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.specPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.hidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewU)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tesztGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1232, 25);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Menü";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem,
            this.toolStripSeparator1,
            this.kilépésToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(19, 604);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(55, 15);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "machine";
            // 
            // tabPages
            // 
            this.tabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPages.Controls.Add(this.tabPage1);
            this.tabPages.Controls.Add(this.tabPage2);
            this.tabPages.Controls.Add(this.tabPage3);
            this.tabPages.Location = new System.Drawing.Point(12, 28);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(1208, 577);
            this.tabPages.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.specSrcBtn);
            this.tabPage1.Controls.Add(this.specPanel);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewF);
            this.tabPage1.Controls.Add(this.osztalyBox);
            this.tabPage1.Controls.Add(this.fankBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alkalmazottak";
            this.tabPage1.ToolTipText = "FÁNK dolgozóinak keresése";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // specSrcBtn
            // 
            this.specSrcBtn.Enabled = false;
            this.specSrcBtn.Location = new System.Drawing.Point(971, 6);
            this.specSrcBtn.Name = "specSrcBtn";
            this.specSrcBtn.Size = new System.Drawing.Size(115, 27);
            this.specSrcBtn.TabIndex = 10;
            this.specSrcBtn.Text = "Speciális keresés";
            this.toolTip1.SetToolTip(this.specSrcBtn, "Speciális kereséshez csak az informatikának van hozzáférése");
            this.specSrcBtn.UseVisualStyleBackColor = true;
            this.specSrcBtn.Click += new System.EventHandler(this.specSrcBtn_Click);
            // 
            // specPanel
            // 
            this.specPanel.BackColor = System.Drawing.Color.Gray;
            this.specPanel.Controls.Add(this.button3);
            this.specPanel.Controls.Add(this.groupBox1);
            this.specPanel.Location = new System.Drawing.Point(971, 33);
            this.specPanel.Name = "specPanel";
            this.specPanel.Size = new System.Drawing.Size(184, 167);
            this.specPanel.TabIndex = 11;
            this.specPanel.Visible = false;
            this.specPanel.Leave += new System.EventHandler(this.specPanel_Leave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Állatorvosi lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBtn1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "csoport alapján:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Informatika lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Szakügyelet lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBtn1
            // 
            this.groupBtn1.Location = new System.Drawing.Point(15, 19);
            this.groupBtn1.Name = "groupBtn1";
            this.groupBtn1.Size = new System.Drawing.Size(145, 27);
            this.groupBtn1.TabIndex = 1;
            this.groupBtn1.Text = "VPN Felhasználók";
            this.groupBtn1.UseVisualStyleBackColor = true;
            this.groupBtn1.Click += new System.EventHandler(this.groupBtn1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(446, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(182, 20);
            this.searchBox.TabIndex = 9;
            this.searchBox.Text = "keresés ...";
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(426, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "|";
            // 
            // dataGridViewF
            // 
            this.dataGridViewF.AllowUserToAddRows = false;
            this.dataGridViewF.AllowUserToDeleteRows = false;
            this.dataGridViewF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumber,
            this.userName,
            this.title,
            this.mail,
            this.telNumber,
            this.department});
            this.dataGridViewF.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewF.Name = "dataGridViewF";
            this.dataGridViewF.ReadOnly = true;
            this.dataGridViewF.RowHeadersWidth = 43;
            this.dataGridViewF.Size = new System.Drawing.Size(1188, 512);
            this.dataGridViewF.TabIndex = 7;
            this.dataGridViewF.Click += new System.EventHandler(this.dataGridViewF_Click);
            // 
            // registrationNumber
            // 
            this.registrationNumber.HeaderText = "Törzsszám";
            this.registrationNumber.Name = "registrationNumber";
            this.registrationNumber.ReadOnly = true;
            this.registrationNumber.Visible = false;
            this.registrationNumber.Width = 70;
            // 
            // userName
            // 
            this.userName.HeaderText = "Név";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Width = 190;
            // 
            // title
            // 
            this.title.HeaderText = "Beosztás";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 150;
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 190;
            // 
            // telNumber
            // 
            this.telNumber.HeaderText = "Telefonszám";
            this.telNumber.Name = "telNumber";
            this.telNumber.ReadOnly = true;
            this.telNumber.Width = 150;
            // 
            // department
            // 
            this.department.HeaderText = "Osztály";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Width = 210;
            // 
            // osztalyBox
            // 
            this.osztalyBox.Enabled = false;
            this.osztalyBox.FormattingEnabled = true;
            this.osztalyBox.Location = new System.Drawing.Point(216, 6);
            this.osztalyBox.Name = "osztalyBox";
            this.osztalyBox.Size = new System.Drawing.Size(204, 21);
            this.osztalyBox.TabIndex = 7;
            this.osztalyBox.SelectedIndexChanged += new System.EventHandler(this.osztalyBox_SelectedIndexChanged);
            // 
            // fankBox
            // 
            this.fankBox.FormattingEnabled = true;
            this.fankBox.Items.AddRange(new object[] {
            "Gazdasági Igazgatóság",
            "Gyűjteményi Körzetek",
            "Ismeretterjesztő Osztály",
            "Jegyértékesítési, Kereskedelmi és Vagyonhasznosítási Osztály",
            "Külsősök",
            "Marketing és Kommunikációs Osztály",
            "Operatív Igazgatóság",
            "Természetvédelmi- és Állategészségügyi Igazgatóság"});
            this.fankBox.Location = new System.Drawing.Point(6, 6);
            this.fankBox.Name = "fankBox";
            this.fankBox.Size = new System.Drawing.Size(204, 21);
            this.fankBox.TabIndex = 6;
            this.fankBox.Text = "bontás hiearchia szerint ...";
            this.fankBox.SelectedIndexChanged += new System.EventHandler(this.fankBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearBtn);
            this.tabPage2.Controls.Add(this.hidepanel);
            this.tabPage2.Controls.Add(this.datumvalaszto);
            this.tabPage2.Controls.Add(this.ugyeletBox);
            this.tabPage2.Controls.Add(this.dataGridViewU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ügyelet";
            this.tabPage2.ToolTipText = "Hétvégi ügyelet ellenőrzése és rögzítése";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Enabled = false;
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(1095, 5);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 27);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Adatok törlése";
            this.toolTip1.SetToolTip(this.clearBtn, "Speciális kereséshez csak az informatikának van hozzáférése");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // hidepanel
            // 
            this.hidepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hidepanel.BackColor = System.Drawing.Color.Salmon;
            this.hidepanel.Controls.Add(this.label2);
            this.hidepanel.Location = new System.Drawing.Point(6, 33);
            this.hidepanel.Name = "hidepanel";
            this.hidepanel.Size = new System.Drawing.Size(1188, 512);
            this.hidepanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(121, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1044, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Az Ügyelet beosztásának megtekintésére, illetve szerkesztésére nincs jogosultságo" +
    "d!  :-(";
            // 
            // datumvalaszto
            // 
            this.datumvalaszto.Location = new System.Drawing.Point(311, 6);
            this.datumvalaszto.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.datumvalaszto.MinDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.datumvalaszto.Name = "datumvalaszto";
            this.datumvalaszto.Size = new System.Drawing.Size(200, 20);
            this.datumvalaszto.TabIndex = 9;
            // 
            // ugyeletBox
            // 
            this.ugyeletBox.Enabled = false;
            this.ugyeletBox.FormattingEnabled = true;
            this.ugyeletBox.Items.AddRange(new object[] {
            "Mind",
            "Szakügyi ügyelet",
            "Állatorvosi ügyelet",
            "Informatikai ügyelet"});
            this.ugyeletBox.Location = new System.Drawing.Point(6, 6);
            this.ugyeletBox.Name = "ugyeletBox";
            this.ugyeletBox.Size = new System.Drawing.Size(204, 21);
            this.ugyeletBox.TabIndex = 8;
            this.ugyeletBox.Text = "Ügyelet típusok ...";
            // 
            // dataGridViewU
            // 
            this.dataGridViewU.AllowUserToDeleteRows = false;
            this.dataGridViewU.AllowUserToOrderColumns = true;
            this.dataGridViewU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewU.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.datum,
            this.napTyp,
            this.userID,
            this.ugyelettipus});
            this.dataGridViewU.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewU.Name = "dataGridViewU";
            this.dataGridViewU.RowHeadersWidth = 43;
            this.dataGridViewU.Size = new System.Drawing.Size(1188, 512);
            this.dataGridViewU.TabIndex = 1;
            this.dataGridViewU.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewU_CellEndEdit);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 40;
            // 
            // datum
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.datum.DefaultCellStyle = dataGridViewCellStyle2;
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.Width = 150;
            // 
            // napTyp
            // 
            this.napTyp.HeaderText = "Naptípus";
            this.napTyp.Name = "napTyp";
            this.napTyp.Width = 105;
            // 
            // userID
            // 
            this.userID.HeaderText = "User ID";
            this.userID.Name = "userID";
            this.userID.Visible = false;
            this.userID.Width = 60;
            // 
            // ugyelettipus
            // 
            this.ugyelettipus.HeaderText = "Ügyelet típus";
            this.ugyelettipus.Name = "ugyelettipus";
            this.ugyelettipus.Visible = false;
            this.ugyelettipus.Width = 50;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tesztGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1200, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Egyéb (szerkesztés alatt)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tesztGridView
            // 
            this.tesztGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tesztGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tesztGridView.Location = new System.Drawing.Point(6, 6);
            this.tesztGridView.Name = "tesztGridView";
            this.tesztGridView.RowHeadersWidth = 43;
            this.tesztGridView.Size = new System.Drawing.Size(1188, 539);
            this.tesztGridView.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 622);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZOOBudapest Foglalkoztatott Kezelő 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.specPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewF)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.hidepanel.ResumeLayout(false);
            this.hidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewU)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tesztGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox fankBox;
        private System.Windows.Forms.ComboBox osztalyBox;
        private System.Windows.Forms.DataGridView dataGridViewF;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.Button specSrcBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel specPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button groupBtn1;
        private System.Windows.Forms.DataGridView dataGridViewU;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datumvalaszto;
        private System.Windows.Forms.ComboBox ugyeletBox;
        private System.Windows.Forms.DataGridView tesztGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel hidepanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn napTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyelettipus;
        private System.Windows.Forms.Button clearBtn;
    }
}

