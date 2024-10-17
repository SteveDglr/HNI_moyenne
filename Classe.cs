using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPMoyennes
{
    class Classe
    {
        public Eleve[] eleves;
        public int nombreEleves;

        public Classe(int maxEleves)
        {
            eleves = new Eleve[maxEleves];
            nombreEleves = 0;
        }

        public void AjouterEleve(Eleve eleve)
        {
            if (nombreEleves < eleves.Length)
            {
                eleves[nombreEleves] = eleve;
                nombreEleves++;
            }
        }

        public double MoyenneClasseMatiere(int index)
        {
            double sommeMoyennes = 0.00;
            int nombreMatieres = 0;

            foreach (var eleve in eleves)
            {
                if (eleve != null)
                {
                    if (eleve.MoyenneMatiere(index) > 0)
                    {
                        sommeMoyennes += eleve.MoyenneMatiere(index);
                        nombreMatieres++;
                    }
                }

            }
            if (nombreMatieres > 0) 
            {
                return (sommeMoyennes / nombreMatieres);
            }
            return 0.00;
        }

        public double MoyenneGeneraleClasse()
        {
            double sommeMoyennes = 0.00;
            int nombreElevesAvecNotes = 0;

            foreach (var eleve in eleves)
            {
                if (eleve != null)
                {
                    sommeMoyennes += eleve.MoyenneGenerale();
                    if (eleve.MoyenneGenerale() > 0)
                    {
                        nombreElevesAvecNotes++;
                    }
                }
            }
            if (nombreElevesAvecNotes > 0)
            {
                return (sommeMoyennes / nombreElevesAvecNotes);
            }
            return 0.00;
            
        }

        
    }
}
