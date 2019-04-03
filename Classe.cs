using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alimentation
{
    class Classe
    {

        private int idEnseignant;
        private string anneScolaire;
        private int idNiveau;

        public Classe(int idEnseignant, string anneScolaire, int idNiveau)
        {
            this.idEnseignant = idEnseignant;
            this.anneScolaire = anneScolaire;
            this.idNiveau = idNiveau;
        }
    }
}
