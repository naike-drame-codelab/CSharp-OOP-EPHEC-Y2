using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Heritage
{
    class Belge : Personne
    {
        private string _communaute;

        public Belge(string nom, string prenom, string email, string communaute) : base(nom, prenom, email)
        {
            _communaute = communaute;
        }

        public string GetCommunaute()
        {
            return _communaute;
        }

        public override string ToString()
        {
            return base.ToString() + " - Communauté : " + this.GetCommunaute();
        }

        public override void Afficher()
        {
             Console.WriteLine(base.Afficher() + " - Communauté : " + this.GetCommunaute());
        }
    }
}
