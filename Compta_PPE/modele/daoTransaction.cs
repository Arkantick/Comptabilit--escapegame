using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace Compta_PPE
{
    public class daoTransaction
    {
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
        /// Récupère l'historique de transaction d'un joueur
        /// </summary>
        /// <param name="unIdJoueur">ID du joueur</param>
        /// <returns>Datatable contenant tout l'historique des transactions d'un joueur</returns>
        public DataTable getTransactions(int unIdJoueur)
        {
            DataTable dataTableTransactions = new DataTable();

            var model = new BDD();
            var requete = from transactions in model.Transactions
                          where transactions.joueur == unIdJoueur
                          select transactions;

            List <Transactions> listeTransactions = requete.ToList<Transactions>();
            dataTableTransactions = ToDataTable<Transactions>(listeTransactions);
            return dataTableTransactions;
        }

    }
}
