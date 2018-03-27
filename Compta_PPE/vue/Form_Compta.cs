using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compta_PPE
{
    public partial class Form_Compta : Form
    {
        private Timer timer1;
        public controleur theControleur;
        int iDJoueurSelect = 0;
        public Form_Compta()
        {
            theControleur = new controleur();
            InitializeComponent();
            lbl_ResultatValidation.Text = "";
            lbl_ResultatCredit.Text = "";
            WindowState = FormWindowState.Maximized;
            comboBox_Recherche.SelectedIndex=0;
            getAllJoueur();
            InitTimer();
        }
        /// <summary>
        /// Méthode qui permet d'afficher l'ensemble des joueurs de la BDD dans le dataGridView_Joueur
        /// </summary>
        public void getAllJoueur()
        {
            dataGridView_Joueur.DataSource = theControleur.getAllJoueur();
            string dateConcat = "";
            for (int i = 0; i < dataGridView_Joueur.RowCount; i++)
            {
                dateConcat = Convert.ToString(dataGridView_Joueur[3, i].Value);
                dataGridView_Joueur[3, i].Value = dateConcat.Split(' ')[0];
            }

            dataGridView_Joueur.Columns[1].DisplayIndex = 0; //nom
            dataGridView_Joueur.Columns[2].DisplayIndex = 1; //prenom
            dataGridView_Joueur.Columns[7].DisplayIndex = 3; //pseudo
            dataGridView_Joueur.Columns[6].DisplayIndex = 4; //mail
            dataGridView_Joueur.Columns[3].DisplayIndex = 5; //dateNaissance

            dataGridView_Joueur.Columns[4].Visible = false; //dateInscription
            dataGridView_Joueur.Columns[5].Visible = false; //credit
            dataGridView_Joueur.Columns[0].Visible = false; //id
            dataGridView_Joueur.Columns[8].Visible = false; //clé étrangère transactions
        }

        /// <summary>
        /// Méthode qui permet de rénitialiser les errorProvider sur les textbox Nom,Prenom,Pseudo,Mail
        /// </summary>
        public void clearErrorProvider()
        {
            ep_Nom.Clear();
            ep_Prenom.Clear();
            ep_Pseudo.Clear();
            ep_Mail.Clear();
        }

        /// <summary>
        /// Methode qui initialise le compte a rebourt, utiliser pour recharger la BDD toute les 5 minutes
        /// </summary>
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 300000; // en milisecondes, soit 5 minutes
            timer1.Start();
        }
        /// <summary>
        /// Evement qui s'éxécute quand le compte à rebourt de rafraichissement arrive à sa fin
        /// Les données de la liste des joueurs sont rechargés depuis la bDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            getAllJoueur();
        }

        /// <summary>
        /// Evenement qui se déclenche suite au clic sur le bouton btn_Valider, il correspond à la la création d'un joueur, ou la mise à jour si le joueur est déjà existant
        /// nom du contrôle : btn_Valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string retour = theControleur.controlValiderOuCreer(btn_Valider.Text,iDJoueurSelect,txt_Nom.Text, txt_Prenom.Text, txt_Mail.Text, txt_Pseudo.Text, txt_Date.Text);
            lbl_ResultatValidation.Text = retour;
            if (retour == "Joueur crée" || retour == "Joueur mis à jour")
                lbl_ResultatValidation.ForeColor = System.Drawing.Color.Green;
            else
                lbl_ResultatValidation.ForeColor = System.Drawing.Color.Red;

            clearErrorProvider();
            getAllJoueur();
        }

        /// <summary>
        /// Evenement qui se déclenche suite au clic sur le bouton btn_CreationClient, il permet de passer le logiciel en mode création d'un client pour être inséré dans la bdd
        /// nom du contrôle : btn_CreationClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ResultatValidation.Text = "";
            dataGridView_Joueur.ClearSelection();
            dataGridView_Transaction.DataSource = new DataTable();
            groupBox_Accueil.Text = "Création d'un joueur";
            btn_Valider.Text = "Valider création d'un joueur";
            txt_Date.ReadOnly = false;
            txt_Nom.Clear();
            txt_Prenom.Clear();
            txt_Pseudo.Clear();
            txt_Mail.Clear();
            txt_Date.Clear();
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur quitte le textbox txt_Nom, il vérifie que l'utilisateur a bien remplis les textbox
        /// Un icone apparait en fonction de si le textbox est remplis, ou s'il est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Nom_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_Nom.Text) || string.IsNullOrWhiteSpace(txt_Nom.Text))
            {
                ep_Nom.Icon = Properties.Resources.error1;
                ep_Nom.SetError(txt_Nom, "Champs vide");
            }
            else
            {
                ep_Nom.Icon = Properties.Resources.mark;
                ep_Nom.SetError(txt_Nom, "Ok");
            }
        }

        private void txt_Date_TextChanged(object sender, EventArgs e)
        {
            //Fonctionnalité à faire : Controler le format de la date via un textbox, auto completion de / quand l'utilisateur saisis une date
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur quitte le textbox txt_Prenom, il vérifie que l'utilisateur a bien remplis les textbox
        /// Un icone apparait en fonction de si le textbox est remplis, ou s'il est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Prenom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Prenom.Text) || string.IsNullOrWhiteSpace(txt_Prenom.Text))
            {
                ep_Prenom.Icon = Properties.Resources.error1;
                ep_Prenom.SetError(txt_Prenom, "Champs vide ou avec des espaces");
            }
            else
            {
                ep_Prenom.Icon = Properties.Resources.mark;
                ep_Prenom.SetError(txt_Prenom, "Ok");
            }
        }
        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur quitte le textbox txt_Pseudo, il vérifie que l'utilisateur a bien remplis les textbox
        /// Un icone apparait en fonction de si le textbox est remplis, ou s'il est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Pseudo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Prenom.Text) || string.IsNullOrWhiteSpace(txt_Prenom.Text))
            {
                ep_Pseudo.Icon = Properties.Resources.error1;
                ep_Pseudo.SetError(txt_Pseudo, "Champs vide ou avec des espaces");
            }
            else
            {
                ep_Pseudo.Icon = Properties.Resources.mark;
                ep_Pseudo.SetError(txt_Pseudo, "Ok");
            }
        }
        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur quitte le textbox txt_Mail, il vérifie que l'utilisateur a bien remplis les textbox
        /// Un icone apparait en fonction de si le textbox est remplis, ou s'il est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Mail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Prenom.Text) || string.IsNullOrWhiteSpace(txt_Prenom.Text))
            {
                ep_Mail.Icon = Properties.Resources.error1;
                ep_Mail.SetError(txt_Mail, "Champs vide ou avec des espaces");
            }
            else
            {
                ep_Mail.Icon = Properties.Resources.mark;
                ep_Mail.SetError(txt_Mail, "Ok");
            }
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur clic sur la croix pour fermer la fenêtre.
        /// Une vérification du choix sera demandé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Méthode qui déclenche une vérification de choix de quitter ou non le logiciel
        /// </summary>
        private void verificationQuitter()
        {
            DialogResult rep = MessageBox.Show(this, "Etes vous sûr(e) de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur change la selection sur le dataGridView_Joueur
        /// Tout les textbox sont remplis en fonction du joueur sélectionné dans la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Joueur_SelectionChanged(object sender, EventArgs e)
        {
            txt_Nom.Text = dataGridView_Joueur.Rows[dataGridView_Joueur.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txt_Prenom.Text = dataGridView_Joueur.Rows[dataGridView_Joueur.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txt_Pseudo.Text = dataGridView_Joueur.Rows[dataGridView_Joueur.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txt_Mail.Text = dataGridView_Joueur.Rows[dataGridView_Joueur.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txt_Date.Text = dataGridView_Joueur.Rows[dataGridView_Joueur.CurrentCell.RowIndex].Cells[3].Value.ToString();

            iDJoueurSelect = Convert.ToInt32(dataGridView_Joueur.Rows[dataGridView_Joueur.CurrentCell.RowIndex].Cells[0].Value);
            dataGridView_Transaction.DataSource = theControleur.getTransactions(iDJoueurSelect);
            dataGridView_Transaction.Columns[1].Visible = false;
            dataGridView_Transaction.Columns[4].Visible = false;

            txt_montant.Text = theControleur.getJoueur(iDJoueurSelect).credit.ToString();// Requette à la BDD pour avoir le crédit du joueur le plus récent possible
            groupBox_Accueil.Text = "Informations du joueur";
            btn_Valider.Text = "Valider les mises à jour";
            txt_Date.ReadOnly = true;
            clearErrorProvider();
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur saisis un texte ou fait un retour arrière
        /// Le dataGridView_Joueur est mis à jour en fonction du contenu du textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView_Joueur.DataSource).DefaultView.RowFilter = string.Format("" + comboBox_Recherche.Text + " like '%{0}%'", txt_searchBar.Text.Trim().Replace("'", "''"));
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur clic sur le bouton pour ajouter du crédit à un utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addCredit_Click(object sender, EventArgs e)
        {
            string retour = theControleur.addCredit(txt_addCredit.Text, iDJoueurSelect);
            lbl_ResultatCredit.Text = retour;
            if (retour == "Crédit ajouté")
            {
                lbl_ResultatCredit.ForeColor = System.Drawing.Color.Green;
                dataGridView_Transaction.DataSource = theControleur.getTransactions(iDJoueurSelect);
            }
                
            else
                lbl_ResultatCredit.ForeColor = System.Drawing.Color.Red;
            txt_addCredit.Clear();
            txt_montant.Text = theControleur.getJoueur(iDJoueurSelect).credit.ToString();
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur clic sur la croix pour fermer la fenêtre.
        /// Une vérification du choix sera demandé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Compta_FormClosed(object sender, FormClosedEventArgs e)
        {
            verificationQuitter();
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur clic sur le dataGridViewJoueurs
        /// Il déclenche la rénitialisation des messages d'erreurs ou de validation des ajouts/mise à jours/ajout crédit des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Joueur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ResultatValidation.Text = "";
            lbl_ResultatCredit.Text = "";
        }
    }
}
