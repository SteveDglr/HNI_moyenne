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
       
        public  const int compteurNotes=5;
       

        public List<Note> Notes = new List<Note>(); 
        public Eleve(string Prenom, string Nom)
        {
            this.prenom = Prenom;
            this.nom = Nom;
            
            
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
                MoyGen.Add(moyenneMatiere(i));
            }
            return Math.Round((MoyGen).Average(), 2);
            


        }


    }
}
