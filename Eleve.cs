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
        public required string prenom {  get; set; }
        public required string nom { get; set;  }
        public int NbMatieres { get; set; }
        //public Note[,] notes; // { get; set; }
        public  const int compteurNotes=5;
       

        public List<Note> Notes = new List<Note>(); 
        public Eleve(string prenom, string nom)
        {
            //Prenom = prenom;
            //Nom = nom;
            Notes = new List<Note>();
            
        }

        
        public void ajouterNote(Note note)
        {
        
                Notes.Add(note);
            
        }


        public double moyenneMatiere(int matiere)
        {

            // filtre par moyenne et par note
            var notesMatiere = Notes.Where(n => n.matiere == matiere).Select(n => n.note);
            // s'il y a des notes =>
            return Math.Round((notesMatiere.Any() ? notesMatiere.Average() : 0),2);
            
               
                
            
           
        }

        public double moyenneGeneral()
        {
            var MoyGen = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                MoyGen.Add(moyenneGeneral());
            }
            return Math.Round((MoyGen).Average(), 2);
            /*
            double sommeMoyennes = 0.00;
            int count = 0;
            double Moyenne;

            for (int i = 0; i < 10; i++)
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
            */


        }


    }
}
