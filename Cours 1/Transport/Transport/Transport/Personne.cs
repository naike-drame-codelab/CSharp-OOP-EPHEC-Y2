using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Personne(string Nom, string Prenom, int AnneeNaissance)
    {
        public string Nom = Nom;
        public string Prenom = Prenom;
        public int AnneeNaissance = AnneeNaissance;

        public Voiture? Voiture = null;

        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}, Année de naissance: {AnneeNaissance}");
            if (Voiture != null)
            {
                Voiture.Afficher();
            }
        }   
    }
}
