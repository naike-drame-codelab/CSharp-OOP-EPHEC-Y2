using System;
using System.Collections.Generic;
using System.Text;

namespace DiceMaker
{
    class De
    {
        private int valeur;

        // Rmq : pour éviter d'appeler à chaque fois le générateur à chaque appel de méthode Lancer(), on le crée une seule fois dans le constructeur de la classe De.
        private Random rng;
        public int nbFaces = 6;

        public De()
        {
            rng = new Random();
            valeur = 1;
        }

        public De (int nbFaces)
        {
            this.nbFaces = nbFaces;
            rng = new Random();
            valeur = 1;
        }

        public int Lancer()
        {
            valeur = rng.Next(1, nbFaces + 1);
            return valeur;
        }

        public int Lire()
        {
            return valeur;
        }
    }
}
