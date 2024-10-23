using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TPMoyennes
{
    class Eleve
    {
        public string prenom {  get; set; }
        public string nom { get; set;  }
        public int NbMatieres { get; set; }
        public Note[,] notes; // { get; set; }
        public  const int compteurNotes=5;

        public Eleve(string prenom, string nom, int NbMaxMatieres)
        {
            //Prenom = prenom;
            //Nom = nom;
            notes = new Note[NbMaxMatieres,compteurNotes];
            
        }

        
        public void ajouterNote(int matiere, Note note,int index)
        {
        
                notes[matiere, index] = note;
            
        }


        public double moyenneMatiere(int matiere)
        {
            
                double somme = 0;
                int count = 0;
                double moyenne = 0;
                for (int i = 0; i < compteurNotes; i++)
                {
                    if (notes[matiere,i] != null)
                    {
                        somme = somme + notes[matiere, i].note;
                        count++;
                    }
                     
                }
                if (count > 0)
                {
                    moyenne = (somme/count);
                return Math.Round(moyenne, 2);
                }
                return 0.00;
                
               

            
           
        }

        public double moyenneGeneral()
        {
            double sommeMoyennes = 0.00;
            int count = 0;
            double Moyenne;

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                if (moyenneMatiere(i) > 0)
                {
                    sommeMoyennes += moyenneMatiere(i);
                    count++;
                }
            }
            if (count > 0)
            {
                Moyenne = (sommeMoyennes/count);
                return Math.Round(Moyenne, 2);
            }
            return 0.00;
            

        }


    }
}
