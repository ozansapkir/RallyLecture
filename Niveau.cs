using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation
{
    class Niveau
    {
        private int id;
        private string niveauScolaire;

         public Niveau(int id, string niveauScolaire)
        {
            this.id = id;
            this.niveauScolaire = niveauScolaire;
        }


         public int Id
         {
             get { return id; }
             set { id = value; }
         }

         public string NiveauScolaire
         {
             get { return niveauScolaire; }
             set { niveauScolaire = value; }
         }

    }
}
