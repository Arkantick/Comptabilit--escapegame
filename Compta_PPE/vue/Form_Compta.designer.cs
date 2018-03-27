namespace Compta_PPE
{
    partial class Form_Compta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_CreationClient = new System.Windows.Forms.Button();
            this.groupBox_Accueil = new System.Windows.Forms.GroupBox();
            this.lbl_ResultatValidation = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.groupBox_Credit = new System.Windows.Forms.GroupBox();
            this.lbl_ResultatCredit = new System.Windows.Forms.Label();
            this.btn_addCredit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_addCredit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Pseudo = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Pseudo = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Naissance = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.dataGridView_Transaction = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_quit = new System.Windows.Forms.Button();
            this.ep_Nom = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_Prenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_Pseudo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_Mail = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_Joueur = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Recherche = new System.Windows.Forms.GroupBox();
            this.comboBox_Recherche = new System.Windows.Forms.ComboBox();
            this.txt_searchBar = new System.Windows.Forms.TextBox();
            this.toolTip_All = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_Accueil.SuspendLayout();
            this.groupBox_Credit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Prenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Pseudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Joueur)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CreationClient
            // 
            this.btn_CreationClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CreationClient.Location = new System.Drawing.Point(3, 717);
            this.btn_CreationClient.Name = "btn_CreationClient";
            this.btn_CreationClient.Size = new System.Drawing.Size(382, 44);
            this.btn_CreationClient.TabIndex = 1;
            this.btn_CreationClient.Text = "Création d\'un client";
            this.btn_CreationClient.UseVisualStyleBackColor = true;
            this.btn_CreationClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_Accueil
            // 
            this.groupBox_Accueil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Accueil.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox_Accueil.Controls.Add(this.lbl_ResultatValidation);
            this.groupBox_Accueil.Controls.Add(this.txt_Date);
            this.groupBox_Accueil.Controls.Add(this.groupBox_Credit);
            this.groupBox_Accueil.Controls.Add(this.txt_Mail);
            this.groupBox_Accueil.Controls.Add(this.txt_Pseudo);
            this.groupBox_Accueil.Controls.Add(this.txt_Prenom);
            this.groupBox_Accueil.Controls.Add(this.txt_Nom);
            this.groupBox_Accueil.Controls.Add(this.btn_Valider);
            this.groupBox_Accueil.Controls.Add(this.lbl_Mail);
            this.groupBox_Accueil.Controls.Add(this.lbl_Pseudo);
            this.groupBox_Accueil.Controls.Add(this.lbl_Prenom);
            this.groupBox_Accueil.Controls.Add(this.lbl_Naissance);
            this.groupBox_Accueil.Controls.Add(this.lbl_Nom);
            this.groupBox_Accueil.Location = new System.Drawing.Point(391, 53);
            this.groupBox_Accueil.Name = "groupBox_Accueil";
            this.groupBox_Accueil.Size = new System.Drawing.Size(382, 658);
            this.groupBox_Accueil.TabIndex = 2;
            this.groupBox_Accueil.TabStop = false;
            this.groupBox_Accueil.Text = "Création d\'un joueur";
            // 
            // lbl_ResultatValidation
            // 
            this.lbl_ResultatValidation.AutoSize = true;
            this.lbl_ResultatValidation.Location = new System.Drawing.Point(27, 190);
            this.lbl_ResultatValidation.Name = "lbl_ResultatValidation";
            this.lbl_ResultatValidation.Size = new System.Drawing.Size(35, 13);
            this.lbl_ResultatValidation.TabIndex = 7;
            this.lbl_ResultatValidation.Text = "label1";
            // 
            // txt_Date
            // 
            this.txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Date.Location = new System.Drawing.Point(128, 140);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(222, 20);
            this.txt_Date.TabIndex = 4;
            this.toolTip_All.SetToolTip(this.txt_Date, "DD/MM/YYYY");
            this.txt_Date.TextChanged += new System.EventHandler(this.txt_Date_TextChanged);
            // 
            // groupBox_Credit
            // 
            this.groupBox_Credit.Controls.Add(this.lbl_ResultatCredit);
            this.groupBox_Credit.Controls.Add(this.btn_addCredit);
            this.groupBox_Credit.Controls.Add(this.label9);
            this.groupBox_Credit.Controls.Add(this.txt_addCredit);
            this.groupBox_Credit.Controls.Add(this.label8);
            this.groupBox_Credit.Controls.Add(this.txt_montant);
            this.groupBox_Credit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Credit.Location = new System.Drawing.Point(3, 363);
            this.groupBox_Credit.Name = "groupBox_Credit";
            this.groupBox_Credit.Size = new System.Drawing.Size(376, 292);
            this.groupBox_Credit.TabIndex = 6;
            this.groupBox_Credit.TabStop = false;
            this.groupBox_Credit.Text = "Gestion du crédit";
            // 
            // lbl_ResultatCredit
            // 
            this.lbl_ResultatCredit.AutoSize = true;
            this.lbl_ResultatCredit.Location = new System.Drawing.Point(24, 173);
            this.lbl_ResultatCredit.Name = "lbl_ResultatCredit";
            this.lbl_ResultatCredit.Size = new System.Drawing.Size(35, 13);
            this.lbl_ResultatCredit.TabIndex = 5;
            this.lbl_ResultatCredit.Text = "label1";
            // 
            // btn_addCredit
            // 
            this.btn_addCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCredit.Location = new System.Drawing.Point(19, 205);
            this.btn_addCredit.Name = "btn_addCredit";
            this.btn_addCredit.Size = new System.Drawing.Size(328, 48);
            this.btn_addCredit.TabIndex = 3;
            this.btn_addCredit.Text = "Ajouter du Crédit";
            this.btn_addCredit.UseVisualStyleBackColor = true;
            this.btn_addCredit.Click += new System.EventHandler(this.btn_addCredit_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Montant : ";
            // 
            // txt_addCredit
            // 
            this.txt_addCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addCredit.Location = new System.Drawing.Point(125, 122);
            this.txt_addCredit.Name = "txt_addCredit";
            this.txt_addCredit.Size = new System.Drawing.Size(222, 20);
            this.txt_addCredit.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Crédit actuel :";
            // 
            // txt_montant
            // 
            this.txt_montant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_montant.Location = new System.Drawing.Point(125, 59);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.ReadOnly = true;
            this.txt_montant.Size = new System.Drawing.Size(222, 20);
            this.txt_montant.TabIndex = 1;
            this.txt_montant.TabStop = false;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Mail.Location = new System.Drawing.Point(128, 114);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(222, 20);
            this.txt_Mail.TabIndex = 3;
            this.txt_Mail.Leave += new System.EventHandler(this.txt_Mail_Leave);
            // 
            // txt_Pseudo
            // 
            this.txt_Pseudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Pseudo.Location = new System.Drawing.Point(128, 88);
            this.txt_Pseudo.Name = "txt_Pseudo";
            this.txt_Pseudo.Size = new System.Drawing.Size(222, 20);
            this.txt_Pseudo.TabIndex = 2;
            this.txt_Pseudo.Leave += new System.EventHandler(this.txt_Pseudo_Leave);
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Prenom.Location = new System.Drawing.Point(128, 62);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(222, 20);
            this.txt_Prenom.TabIndex = 1;
            this.txt_Prenom.Leave += new System.EventHandler(this.txt_Prenom_Leave);
            // 
            // txt_Nom
            // 
            this.txt_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nom.Location = new System.Drawing.Point(128, 36);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(222, 20);
            this.txt_Nom.TabIndex = 0;
            this.txt_Nom.Leave += new System.EventHandler(this.txt_Nom_Leave);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Valider.Location = new System.Drawing.Point(22, 223);
            this.btn_Valider.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(328, 51);
            this.btn_Valider.TabIndex = 5;
            this.btn_Valider.Text = "Valider création d\'un joueur";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(19, 117);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_Mail.TabIndex = 4;
            this.lbl_Mail.Text = "Mail";
            // 
            // lbl_Pseudo
            // 
            this.lbl_Pseudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pseudo.AutoSize = true;
            this.lbl_Pseudo.Location = new System.Drawing.Point(19, 91);
            this.lbl_Pseudo.Name = "lbl_Pseudo";
            this.lbl_Pseudo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Pseudo.TabIndex = 3;
            this.lbl_Pseudo.Text = "Pseudo";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(19, 65);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_Prenom.TabIndex = 1;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // lbl_Naissance
            // 
            this.lbl_Naissance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Naissance.AutoSize = true;
            this.lbl_Naissance.Location = new System.Drawing.Point(19, 145);
            this.lbl_Naissance.Name = "lbl_Naissance";
            this.lbl_Naissance.Size = new System.Drawing.Size(96, 13);
            this.lbl_Naissance.TabIndex = 2;
            this.lbl_Naissance.Text = "Date de naissance";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(19, 39);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_Nom.TabIndex = 0;
            this.lbl_Nom.Text = "Nom";
            // 
            // dataGridView_Transaction
            // 
            this.dataGridView_Transaction.AllowUserToAddRows = false;
            this.dataGridView_Transaction.AllowUserToDeleteRows = false;
            this.dataGridView_Transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Transaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Transaction.Location = new System.Drawing.Point(779, 53);
            this.dataGridView_Transaction.Name = "dataGridView_Transaction";
            this.dataGridView_Transaction.ReadOnly = true;
            this.dataGridView_Transaction.Size = new System.Drawing.Size(384, 658);
            this.dataGridView_Transaction.TabIndex = 5;
            this.dataGridView_Transaction.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Historique du compte";
            // 
            // btn_quit
            // 
            this.btn_quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_quit.Location = new System.Drawing.Point(779, 717);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(384, 44);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // ep_Nom
            // 
            this.ep_Nom.BlinkRate = 0;
            this.ep_Nom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_Nom.ContainerControl = this;
            // 
            // ep_Prenom
            // 
            this.ep_Prenom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_Prenom.ContainerControl = this;
            // 
            // ep_Pseudo
            // 
            this.ep_Pseudo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_Pseudo.ContainerControl = this;
            // 
            // ep_Mail
            // 
            this.ep_Mail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_Mail.ContainerControl = this;
            // 
            // dataGridView_Joueur
            // 
            this.dataGridView_Joueur.AllowUserToAddRows = false;
            this.dataGridView_Joueur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_Joueur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Joueur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Joueur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Joueur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Joueur.Location = new System.Drawing.Point(3, 53);
            this.dataGridView_Joueur.Name = "dataGridView_Joueur";
            this.dataGridView_Joueur.ReadOnly = true;
            this.dataGridView_Joueur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Joueur.Size = new System.Drawing.Size(382, 658);
            this.dataGridView_Joueur.TabIndex = 9;
            this.dataGridView_Joueur.TabStop = false;
            this.dataGridView_Joueur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Joueur_CellContentClick);
            this.dataGridView_Joueur.SelectionChanged += new System.EventHandler(this.dataGridView_Joueur_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Joueur, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_quit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Transaction, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_CreationClient, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Accueil, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Recherche, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 764);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox_Recherche
            // 
            this.groupBox_Recherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Recherche.Controls.Add(this.comboBox_Recherche);
            this.groupBox_Recherche.Controls.Add(this.txt_searchBar);
            this.groupBox_Recherche.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Recherche.Name = "groupBox_Recherche";
            this.groupBox_Recherche.Size = new System.Drawing.Size(382, 44);
            this.groupBox_Recherche.TabIndex = 11;
            this.groupBox_Recherche.TabStop = false;
            this.groupBox_Recherche.Text = "Recherche de joueur";
            // 
            // comboBox_Recherche
            // 
            this.comboBox_Recherche.FormattingEnabled = true;
            this.comboBox_Recherche.Items.AddRange(new object[] {
            "nom",
            "pseudo"});
            this.comboBox_Recherche.Location = new System.Drawing.Point(9, 14);
            this.comboBox_Recherche.Name = "comboBox_Recherche";
            this.comboBox_Recherche.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Recherche.TabIndex = 11;
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchBar.Location = new System.Drawing.Point(154, 15);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(222, 20);
            this.txt_searchBar.TabIndex = 0;
            this.txt_searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_Compta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 764);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Compta";
            this.Text = "EscapeGame Comptabilité";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Compta_FormClosed);
            this.groupBox_Accueil.ResumeLayout(false);
            this.groupBox_Accueil.PerformLayout();
            this.groupBox_Credit.ResumeLayout(false);
            this.groupBox_Credit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Prenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Pseudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Joueur)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_Recherche.ResumeLayout(false);
            this.groupBox_Recherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_CreationClient;
        private System.Windows.Forms.GroupBox groupBox_Accueil;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.DataGridView dataGridView_Transaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_Credit;
        private System.Windows.Forms.Label lbl_Pseudo;
        private System.Windows.Forms.Label lbl_Naissance;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Button btn_addCredit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_addCredit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_montant;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_Pseudo;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.ErrorProvider ep_Nom;
        private System.Windows.Forms.ErrorProvider ep_Prenom;
        private System.Windows.Forms.ErrorProvider ep_Pseudo;
        private System.Windows.Forms.ErrorProvider ep_Mail;
        private System.Windows.Forms.DataGridView dataGridView_Joueur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_searchBar;
        private System.Windows.Forms.GroupBox groupBox_Recherche;
        private System.Windows.Forms.ComboBox comboBox_Recherche;
        private System.Windows.Forms.ToolTip toolTip_All;
        private System.Windows.Forms.Label lbl_ResultatValidation;
        private System.Windows.Forms.Label lbl_ResultatCredit;
    }
}