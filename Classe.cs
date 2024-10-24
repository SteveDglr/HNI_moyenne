using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Classe
    {
        public required string nomClasse { get; set; }
        public List<Eleve> eleves { get; set; }
        public List<string> matieres { get; set; }
        public int nombreMatieres;
        //public int nombreEleves;
        public const int MaxEleves = 30; // max 30 eleves

        public Classe(string nomClasse)
        {
            
            eleves = new List<Eleve>();
            matieres = new List<string>();
        }

        public void ajouterEleve(string prenom,string nom)
        {
            if (eleves.Count < 30)
            {
                eleves.Add(new Eleve(prenom, nom));

            }
            else
            {
                Console.WriteLine("Le nombre d'élève est trop important pour cette classe");
            }
        }

        public void ajouterMatiere(string matiere)
        {
            if (matieres.Count < 10)
            {
                matieres.Add(matiere);
                
            }
        }

        public double moyenneMatiere(int matieres)
        {
            var MoyClasse = eleves.Select(e => e.moyenneMatiere(matieres));
            return Math.Round((MoyClasse.Average()), 2);
        }

        public double moyenneGeneral()
        {
            var MoyGenClasse = new List<double>();
            for (int i = 0; i< 10; i++)
            {
                MoyGenClasse.Add(moyenneGeneral());
            }
            return Math.Round((MoyGenClasse).Average(), 2); 
              
        }

        
    }
}
