namespace Compta_PPE
{
    partial class Form_Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Connexion = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_Connexion = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Connexion
            // 
            this.btn_Connexion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connexion.Location = new System.Drawing.Point(49, 122);
            this.btn_Connexion.Name = "btn_Connexion";
            this.btn_Connexion.Size = new System.Drawing.Size(270, 35);
            this.btn_Connexion.TabIndex = 9;
            this.btn_Connexion.Text = "Connexion";
            this.btn_Connexion.UseVisualStyleBackColor = true;
            this.btn_Connexion.Click += new System.EventHandler(this.btn_Connexion_Click);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.Location = new System.Drawing.Point(162, 74);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(157, 20);
            this.txt_password.TabIndex = 8;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // txt_login
            // 
            this.txt_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_login.Location = new System.Drawing.Point(162, 33);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(157, 20);
            this.txt_login.TabIndex = 7;
            this.txt_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_login_KeyDown);
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(46, 77);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(71, 13);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Mot de passe";
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(46, 37);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(84, 13);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Text = "Nom d\'utilisateur";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_Connexion, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 547);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // groupBox_Connexion
            // 
            this.groupBox_Connexion.Controls.Add(this.txt_login);
            this.groupBox_Connexion.Controls.Add(this.lbl_login);
            this.groupBox_Connexion.Controls.Add(this.btn_Connexion);
            this.groupBox_Connexion.Controls.Add(this.lbl_password);
            this.groupBox_Connexion.Controls.Add(this.txt_password);
            this.groupBox_Connexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Connexion.Location = new System.Drawing.Point(386, 185);
            this.groupBox_Connexion.Name = "groupBox_Connexion";
            this.groupBox_Connexion.Size = new System.Drawing.Size(377, 176);
            this.groupBox_Connexion.TabIndex = 11;
            this.groupBox_Connexion.TabStop = false;
            this.groupBox_Connexion.Text = "Connexion";
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Connexion";
            this.Text = "EscapeGame Connexion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Connexion_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_Connexion.ResumeLayout(false);
            this.groupBox_Connexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Connexion;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Connexion;
    }
}

