using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Compta_PPE
{

    public class controleur
    {
        public daoJoueur theDaoJoueur;
        public daoPersonnel theDaoPersonnel;

        /// <summary>
        /// Initialise les dao qui vont être utilisé pendant l'utilisation de l'application
        /// </summary>
        public controleur()
        {
            theDaoJoueur = new daoJoueur();
            theDaoPersonnel = new daoPersonnel();
        }

        /// <summary>
        /// Fonction vérifie que les données envoyés sont prête a être soumis dans une requete de base de donnée
        /// </summary>
        /// <param name="login">Identifiant saisis dans le textbox txt_Nom</param>
        /// <param name="password">Mot de passe saisis dans le textbox txt_Password</param>
        /// <returns>Chaine qui indique le succès ou l'échec de la requette</returns>
        public string connexion(string login, string password)
        {
            string retour = "";
            if (login == "")
            {
                retour = "Champ identifiant vide";
            }
            else
            {
                if (password == "")
                {
                    retour =  "Champ mot de passe vide";
                }
                else
                {
                    retour =  theDaoPersonnel.connexion(login, password);
                }
            }
            return retour;
        }
        /// <summary>
        /// Fonction qui récupère l'ensemble des joueurs de la BDD via le diaoJoueur
        /// </summary>
        /// <returns>Tableau au format dataTable qui contient tout les joueurs</returns>
        public DataTable getAllJoueur()
        {
            return theDaoJoueur.getAllJoueur();
        }
        /// <summary>
        /// Fonction qui récupère un joueur spécifique de la BDD via le daoJoueur grâce à l'ID du joueur
        /// </summary>
        /// <param name="ID">ID du joueur</param>
        /// <returns>Objet de type Joueurs</returns>
        public Joueurs getJoueur(int ID)
        {
            return theDaoJoueur.getJoueur(ID);
        }

        /// <summary>
        /// Fonction qui récupère un joueur spécifique de la BDD via le daoJoueur grâce au pseudo du joueur
        /// </summary>
        /// <param name="unPseudo">pseudo du joueur</param>
        /// <returns>Objet de type Joueurs</returns>
        public Joueurs getJoueurByPseudo(string unPseudo)
        {
            return theDaoJoueur.getJoueurByPseudo(unPseudo);
        }

        /// <summary>
        /// Fonction qui récupère les transactions d'un joueur de la BDD via le daoTransactions, grâce à l'ID du joueur
        /// </summary>
        /// <param name="unIdJoueur">ID du joueur</param>
        /// <returns>Tableau de type DataTable de Transactions</returns>
        public DataTable getTransactions(int unIdJoueur)
        {
            return theDaoJoueur.getTransactions(unIdJoueur);
        }

        /// <summary>
        /// Fonction qui ajoute du crédit à un joueur, via le daoJoueur, grâce à l'ID du joueur
        /// </summary>
        /// <param name="credit">Credit à ajouter au joueur</param>
        /// <param name="idJoueurSelect">ID du joueur sélectionné</param>
        /// <returns>Chaine de caractère qui confirme ou pas l'ajout du crédit au joueur</returns>
        public string addCredit(string credit, int idJoueurSelect)
        {
            string retour = "";
            float validationCredit = 0;
            if (float.TryParse(credit, out validationCredit) == true)
                retour = theDaoJoueur.addCredit(validationCredit, idJoueurSelect);
            else
                retour = "Le crédit ajouté n'est pas un nombre";

            return retour;
        }
        /// <summary>
        /// Fonction qui va vérifier si l'utilisateur est en mode création d'un joueur ou en mode mise à jour
        /// En fonction du mode, soit la fonction création du joueur sera éxécuté, soit la fonction mise à jour
        /// Tout les paramètres seront contrôlé s'ils sont vide ou non, et si la date peut-être convertis en DateTime
        /// </summary>
        /// <param name="typeControle">Mode création d'un joueur ou mise à jour</param>
        /// <param name="unIdJoueur">ID du joueur à modifier (utile seulement si on est en mode mise à jour, sinon vide)</param>
        /// <param name="unNom">nom</param>
        /// <param name="unPrenom">prenom</param>
        /// <param name="unMail">mail</param>
        /// <param name="unPseudo">pseudo</param>
        /// <param name="uneDate">date</param>
        /// <returns>Chaine de caractère qui contient un message de validation ou d'erreur</returns>
        public string controlValiderOuCreer(string typeControle, int unIdJoueur,string unNom, string unPrenom, string unMail, string unPseudo, string uneDate)
        {
            string retour = "";
            if (unNom == null)
                retour = "Le champ nom est vide";
            else
            {
                if (unPrenom == null)
                    retour = "Le champ prenom est vide";
                else
                {
                    if (unMail == null)
                        retour = "Le champ mail est vide";
                    else
                    {
                        if (unPseudo == null)
                            retour = "Le champ pseudo est vide";
                        else
                        {
                            if (uneDate == null)
                                retour = "Le champ date est vide";
                            else
                            {
                                if (typeControle == "Valider les mises à jour")
                                    retour = updateJoueur(unIdJoueur, unNom, unPrenom, unPseudo, unMail);
                                else
                                {
                                    DateTime laDate;
                                    bool checkUnedate = DateTime.TryParse(uneDate, out laDate);
                                    if (checkUnedate == true)
                                    {
                                        retour = createJoueur(unNom, unPrenom, unMail, unPseudo, laDate);
                                    }
                                    else
                                        retour = "Le format de la date n'est pas correct";
                                }                                    
                            }
                        }
                    }
                }
            }
            return retour;
        }

        /// <summary>
        /// Fonction qui crée un joueur
        /// </summary>
        /// <param name="unNom">nom</param>
        /// <param name="unPrenom">prénom</param>
        /// <param name="unMail">mail</param>
        /// <param name="unPseudo">pseudo</param>
        /// <param name="uneDate">date</param>
        /// <returns>Chaine de caractère qui contient un message de validation ou d'erreur</returns>
        public string createJoueur(string unNom, string unPrenom, string unMail, string unPseudo, DateTime uneDate)
        {
            return theDaoJoueur.createJoueur(unNom, unPrenom, unMail, unPseudo, uneDate.Date);
        }
        /// <summary>
        /// Fonction qui met à jour un joueur déjà existant
        /// </summary>
        /// <param name="unIdJoueur">ID du joueur qui va être modifié</param>
        /// <param name="unNom">nom</param>
        /// <param name="unPrenom">prenom</param>
        /// <param name="unPseudo">pseudo</param>
        /// <param name="unMail">mail</param>
        /// <returns>Chaine de caractère qui contient un message de validation ou d'erreur</returns>
        public string updateJoueur(int unIdJoueur, string unNom, string unPrenom, string unPseudo, string unMail)
        {
            return theDaoJoueur.updateJoueur(unIdJoueur, unNom, unPrenom, unPseudo, unMail);
        }

    }
}