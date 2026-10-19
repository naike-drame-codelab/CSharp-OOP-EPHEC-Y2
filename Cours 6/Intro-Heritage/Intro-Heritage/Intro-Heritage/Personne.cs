using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Heritage
{
    class Personne
    {
        protected string Nom;
        protected string Prenom;
        protected string Email;
        private int Fortune;
        private Personne Conjoint;

        public Personne(string Nom, string Prenom, string Email)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.Fortune = 0;
        }
        public string GetNom()
        {
            return Nom;
        }
        public string GetPrenom()
        {
            return Prenom;
        }
        public virtual string GetEmail()
        {
            return Email;
        }
        public int GetFortune()
        {
            return Fortune;
        }
        public Personne GetConjoint()
        {
            return this.Conjoint;
        }
        public void Recevoir(int Somme)
        {
            Fortune += Somme;
        }
        public bool Depenser(int Somme)
        // Si la fortune de la personne est supérieure à Somme, retranche somme de la fortune et renvoie true.
        // Sinon, ne modifie pas la fortune et renvoie false.
        {
            if (Fortune >= Somme)
            {
                Fortune -= Somme;
                return true;
            }
            else return false;
        }
        public bool Epouser(Personne Candidat)
        // Si la personne et Candidat sont tous deux célibataires, leur attribue chacun l'autre pour conjoint et renvoie true.
        // Sinon, ne modifie rien et renvoie false.
        {
            if ((this.Conjoint == null) && (Candidat.Conjoint == null))
            {
                this.Conjoint = Candidat;
                Candidat.Conjoint = this;
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            string Descriptif;
            Descriptif= this.GetPrenom() + " " + this.GetNom() + " <" + this.GetEmail() + ">";
            if (this.Conjoint != null) Descriptif += " (ép. " + Conjoint.GetPrenom() + " " + Conjoint.GetNom() + ")";
            else Descriptif += " (célibataire)";
            return Descriptif;
        }

        public virtual void Afficher() {
            Console.WriteLine("Nom : " + this.GetNom() + ", Prénom : " + this.GetPrenom());
        }
    }
}
