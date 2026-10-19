using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Heritage
{
    class Employe : Personne
    {
        private string EmailProfessionnel;
        public int SalaireMensuel;

        public Employe(string Nom, string Prenom, string EmailPerso, string EmailProf, int SalaireMensuel) : base(Nom,Prenom,EmailPerso)
        {
            this.EmailProfessionnel = EmailProf;
            this.SalaireMensuel = SalaireMensuel;
        }
        public void RecevoirSalaire()
        {
            this.Recevoir(this.SalaireMensuel);
        }
        public override string GetEmail()
        {
            return EmailProfessionnel;
        }
        public override string ToString()
        {
            string Descriptif;
            Descriptif = this.GetPrenom() + " " + this.GetNom() + " <" + this.GetEmail() + ">";
            return Descriptif;
        }
    }
}
