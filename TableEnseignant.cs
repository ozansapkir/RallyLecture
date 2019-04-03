using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace Alimentation
{
    class TableEnseignant
    {

        //[visibilié] [type de retour] [nom de la fonction] (paramettre){}  
        public List<Niveau> lesNiveaux()
        {
            List<Niveau> lesNiv = new List<Niveau>();
            //interogation avec la requette sql
            //new MySqlCommand("[requette]",connection) 
            MySqlCommand req = new MySqlCommand("select * from niveau", Connection.GetConnection());
            //ouvrir la bdd
            Connection.GetConnection().Open();
            //executer la requette
            MySqlDataReader rdr = req.ExecuteReader();
            //boucler si il y a plusieur donnée
            while (rdr.Read())
            {
                lesNiv.Add(new Niveau(Convert.ToInt32(rdr["id"]), Convert.ToString(rdr["niveauScolaire"])));
            }
            //fermer la bdd
            Connection.GetConnection().Close();
            return lesNiv;
        }
    }
}
