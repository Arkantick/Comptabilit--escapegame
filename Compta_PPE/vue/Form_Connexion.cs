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
    public partial class Form_Connexion : Form
    {
        public controleur theControleur;
        public Form_Compta logiciel;
        /// <summary>
        /// Initialise la fenêtre
        /// </summary>
        public Form_Connexion()
        {
            theControleur = new controleur(); 
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        
        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur désire quitter le logiciel
        /// Déclenche une vérification de choix de quitter ou non le logiciel
        /// </summary>
        private void Form_Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(logiciel != null)
                Application.Exit();
            else
            {
                DialogResult rep = MessageBox.Show(this, "Etes vous sûr(e) de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur clic sur le bouton btn_Connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            string connexion = theControleur.connexion(txt_login.Text, txt_password.Text);
            if (connexion == "Connexion réussie")
            {
                logiciel = new Form_Compta();
                logiciel.Show();
                this.Hide();
            }
            else
                MessageBox.Show(connexion);
        }
        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur appuis sur une touche quand il se situe dans le textbox txt_password
        /// Si la touche correspond à la touche entré, alors l'evenement clic du bouton connexion se déclenchera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connexion_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Evenement qui se déclenche quand l'utilisateur appuis sur une touche quand il se situe dans le textbox txt_login
        /// Si la touche correspond à la touche entré, alors l'evenement clic du bouton connexion se déclenchera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Connexion_Click(this, new EventArgs());
            }
        }

    }
}
