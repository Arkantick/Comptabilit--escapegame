using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

namespace Compta_PPE
{
    public class daoJoueur
    {
        public daoTransaction theDaoTransactions;

        public daoJoueur()
        {
            theDaoTransactions = new daoTransaction();
        }

        /// <summary>
        /// Récupère l'historique de transaction d'un joueur
        /// </summary>
        /// <param name="unIdJoueur">ID du joueur</param>
        /// <returns>Datatable contenant tout l'historique des transactions d'un joueur</returns>
        public DataTable getTransactions(int unIdJoueur)
        {
            return theDaoTransactions.getTransactions(unIdJoueur);
        }

        /// <summary>
        /// Fonction qui convertis les list au format dataTable, permettant de récupérer des données encapsuler dans un format 100% compatible avec les datagridview
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Récupère toutes les propriétés
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Met les noms des colonnes comme les noms des propriétés
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //Ajoute les valeurs des propriétés aux lignes de datatable
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        /// <summary>
        /// Récupère un joueur grâce à son ID
        /// </summary>
        /// <param name="id">ID d'un joueur existant</param>
        /// <returns>Objet Joueurs</returns>
        public Joueurs getJoueur(int id)
        {
            Joueurs retour;
            using (var model = new BDD())
            {
                    var requete = from joueurs in model.Joueurs
                                  where joueurs.id == id
                                  select joueurs;
                    retour = requete.First<Joueurs>();
            }
            return retour;
        }

        /// <summary>
        /// Récupère un joueur grâce à son pseudo
        /// </summary>
        /// <param name="unPseudo">pseudo d'un joueur existant</param>
        /// <returns>Objet Joueurs</returns>
        public Joueurs getJoueurByPseudo(string unPseudo)
        {
            Joueurs retour;
            using (var model = new BDD())
            {
                var requete = from joueurs in model.Joueurs
                              where joueurs.pseudo == unPseudo
                              select joueurs;
                retour = requete.First<Joueurs>();
            }
            return retour;
        }

        /// <summary>
        /// Creer un joueur directement en BDD
        /// </summary>
        /// <param name="unNom">Nom</param>
        /// <param name="unPrenom">Prenom</param>
        /// <param name="unMail">Mail</param>
        /// <param name="unPseudo">Pseudo</param>
        /// <param name="uneDate">Date</param>
        /// <returns>Chaine de caractère avec un message de validation ou d'erreur</returns>
        public string createJoueur(string unNom, string unPrenom, string unMail, string unPseudo, DateTime uneDate)
        {
            string retour = "";
            Joueurs unJoueur = new Joueurs();

            using (var model = new BDD())
            {
                int maxID = model.Joueurs.Max(p => p.id);
                try
                {
                    unJoueur.id = maxID + 1;
                    unJoueur.nom = unNom;
                    unJoueur.prenom = unPrenom;
                    unJoueur.pseudo = unPseudo;
                    unJoueur.mail = unMail;
                    unJoueur.dateNaissance = uneDate;

                    model.Joueurs.Add(unJoueur);
                    model.SaveChanges();

                    retour = "Joueur crée";
                }
                catch(Exception e)
                {
                    retour = "Erreur, joueur non crée" + e.Message;
                }
                //model.Joueurs.Add(unJoueur);
            }
            return retour;
        }

        /// <summary>
        /// Rajoute du crédit à un joueur grâce à son ID
        /// </summary>
        /// <param name="credit">Credit à ajouter</param>
        /// <param name="idJoueurSelect">ID du joueur qui doit recevoir les crédits</param>
        /// <returns>Chaine de caractère avec un message de validation ou d'erreur</returns>
        public string addCredit(float credit,int idJoueurSelect)
        {
            string retour = "";
            float ajoutCredit = 0;

            using (var model = new BDD())
            {
                int maxID = model.Transactions.Max(p => p.id);

                Joueurs modifié = getJoueur(idJoueurSelect);
                Transactions ajout = new Transactions();
                try
                {
                    ajoutCredit = modifié.credit + credit;
                    model.Joueurs.Attach(modifié);
                    modifié.credit = ajoutCredit;

                    var entry = model.Entry(modifié);
                    entry.Property(e => e.credit).IsModified = true;

                    ajout.date = DateTime.Now;
                    ajout.id = maxID + 1;
                    ajout.joueur = idJoueurSelect;
                    ajout.valeur = Convert.ToInt32(credit);
                    model.Transactions.Add(ajout);

                    model.SaveChanges();

                    retour = "Crédit ajouté";
                }
                catch (Exception e)
                {
                    retour = "Erreur, le crédit n'a pas été ajouté " + e.Message;
                }
            }
            return retour;
        }

        /// <summary>
        /// Met à jour un joueur grâce à son ID
        /// </summary>
        /// <param name="unIdJoueur">ID du joueur</param>
        /// <param name="unNom">Nom</param>
        /// <param name="unPrenom">prenom</param>
        /// <param name="unPseudo">pseudo</param>
        /// <param name="unMail">mail</param>
        /// <returns>Chaine de caractère avec un message de validation ou d'erreur</returns>
        public string updateJoueur(int unIdJoueur, string unNom, string unPrenom, string unPseudo,string unMail)
        {
                string retour = "";
                using (var model = new BDD())
                {
                Joueurs modifié = getJoueur(unIdJoueur);
                    try
                    {
                        model.Joueurs.Attach(modifié);
                        modifié.nom = unNom;
                        modifié.prenom = unPrenom;
                        modifié.pseudo = unPseudo;
                        modifié.mail = unMail;

                        var entry = model.Entry(modifié);
                        entry.Property(e => e.nom).IsModified = true;
                        entry.Property(e => e.prenom).IsModified = true;
                        entry.Property(e => e.pseudo).IsModified = true;
                        entry.Property(e => e.mail).IsModified = true;
                        model.SaveChanges();

                        retour = "Joueur mis à jour";
                    }
                    catch (Exception e)
                    {
                        retour = "Erreur, le joueur n'a pas été mis à jour " + e.Message;
                    }
                }
                return retour;
        }

        /// <summary>
        /// Récupère tout les joueurs de la BDD
        /// </summary>
        /// <returns>Datatable contenant tout les joueurs</returns>
        public DataTable getAllJoueur()
        {
            DataTable datatable_Joueurs = new DataTable();

            var model = new BDD();
            var requete = from joueurs in model.Joueurs
                          select joueurs;

            List<Joueurs> liste_Joueurs = requete.ToList<Joueurs>();
            datatable_Joueurs = ToDataTable<Joueurs>(liste_Joueurs);

            return datatable_Joueurs;
        }
    }
}
