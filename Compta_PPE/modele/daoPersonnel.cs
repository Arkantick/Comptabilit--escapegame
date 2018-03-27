using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compta_PPE
{
    public class daoPersonnel
    {
        /// <summary>
        /// Vérification de l'existence d'un login et d'un mot de passe correspondant
        /// </summary>
        /// <param name="login">login saisis</param>
        /// <param name="password">mot de passe saisis</param>
        /// <returns>Chaine de caractère avec un message de validation ou d'erreur</returns>
        public string connexion(string login, string password)
        {
            string retour = "Identifiant ou mot de passe incorrect";
            Personnel a;

            using (var model = new BDD())
            {
                var requete = from personnel in model.Personnel
                              where personnel.identifiant == login && personnel.mdp==password && personnel.accreditation==2
                              select personnel;
                try
                {
                    a = requete.First<Personnel>();
                    retour = "Connexion réussie";
                }
                catch (Exception e)
                {
                    retour = "Echec de connexion : " + e.Message;
                }
            }
            return retour;
        }
    }
}
