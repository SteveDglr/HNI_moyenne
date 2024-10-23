using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Classe
    {
        public string nomClasse { get; set; }
        public Eleve[] eleves { get; set; }
        public string[] matieres { get; set; }
        public int nombreMatieres;
        public int nombreEleves;
        public const int MaxEleves = 30; // max 30 eleves

        public Classe(string nomClasse)
        {
            
            eleves = new Eleve[MaxEleves];
            matieres = new string[10]; //max 10 matières
        }

        public void ajouterEleve(string prenom,string nom)
        {
            if (nombreEleves < 30)
            {
                eleves[nombreEleves] = new Eleve(prenom, nom, nombreMatieres);
                nombreEleves++;
            }
        }

        public void ajouterMatiere(string matiere)
        {
            if (nombreMatieres < 10)
            {
                matieres[nombreMatieres] = matiere;
                nombreMatieres++;
            }
        }

        public double moyenneMatiere(int matieres)
        {
            double somme = 0.00;
            int count = 0;
            double moyenne;

            for (int i = 0; i< nombreEleves; i++)
            {
                if (eleves[i] != null)
                {
                    
                        somme += eleves[i].moyenneMatiere(matieres);
                        count++;
                    
                }

            }
            if (nombreMatieres > 0) 
            {
                moyenne = somme / count;
                return Math.Round(moyenne, 2);
            }
            return 0.00;
        }

        public double moyenneGeneral()
        {
            double somme = 0.00;
            int count = 0;
            double moyenne;

            for (int i = 0; i < nombreMatieres; i++)
            {
                
                    somme += moyenneMatiere(i);
                count++;
                   
                
            }
            if (count > 0)
            {
                moyenne = somme / count;
                return Math.Round(moyenne, 2);
            }
            return 0.00;
            
        }

        
    }
}
