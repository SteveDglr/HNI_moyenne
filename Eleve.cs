using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HNI_TPMoyennes
{
    class Eleve
    {
        public string Nom { get; set;  }
        public int NbMatieres { get; set; }
        public double[,] notes { get; set; }
        public int[] compteurNotes;

        public Eleve(string nom, int NbMaxMatieres)
        {
            Nom = nom;
            NbMatieres = NbMaxMatieres;
            notes = new double[NbMaxMatieres,200];
            compteurNotes = new int [NbMaxMatieres];
        }

        // index => matière
        public void AjoutNote(int index, double note) {
        
                if (compteurNotes[index] < 200)
                {
                    notes[index, compteurNotes[index]] = note;
                    compteurNotes[index]++;
                }
            
        }


        public double MoyenneMatiere(int index) {
            if (compteurNotes[index] > 0)
            {
                double somme = 0.0;
                for (int i = 0; i < compteurNotes[index]; i++)
                {
                     somme += notes[index, i];
                }
                return (somme / compteurNotes[index]);
               

            
            }
            return 0.00;
        }

        public double MoyenneGenerale()
        {
            double sommeMoyennes = 0.00;
            int nombreMatieres = 0;

            for (int i = 0; i < NbMatieres; i++)
            {
                if (compteurNotes[i] > 0)
                {
                    sommeMoyennes += MoyenneMatiere(i);
                    nombreMatieres++;
                }
            }
            if (nombreMatieres > 0)
            {
                return (sommeMoyennes/nombreMatieres);
            }
            return 0.00;
            

        }


    }
}
