using System;
using System.Collections.Generic;
using System.Text;

namespace RPGv2
{
    internal class De
    {
        private int _valeur;
        private static Random s_rng = new Random();   // Statique et partagé entre tous les objets Dé

        public De()
        {
        }
        public void Lancer()
        {
            _valeur = s_rng.Next(6);       // Résultat dans [0,5]
            _valeur = _valeur + 1;        // Résultat dans [1,6]
        }
        public int Lire()
        {
            return _valeur;
        }
    }
}
