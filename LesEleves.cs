using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Alimentation
{
    class LesEleves
    {

        private List<Eleve> lesEleves;


        public LesEleves()
        {
            lesEleves = new List<Eleve>();
        }
        public List<Eleve> LoadCsv(PassWordType type,string chemin)
        {
            StreamReader sr;
            sr = new StreamReader(chemin);

            string s = sr.ReadLine();

            string nom, login, prenom, email;

            while (s != null)
            {
                string[] lineSplit = s.Split(';');

                prenom = lineSplit[0];
                nom = lineSplit[1];
                login = prenom[0] + lineSplit[1];
                email = login + "@sio.jjr.fr";

                Eleve unEleve = new Eleve(prenom, nom, email, "");

                unEleve.PassWord = unEleve.GetNewPassWord(type);

                lesEleves.Add(unEleve);

                s = sr.ReadLine();
            }
            sr.Close();
            return lesEleves;

        }
    }
}
