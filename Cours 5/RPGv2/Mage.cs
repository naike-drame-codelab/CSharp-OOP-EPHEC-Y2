using System;
using System.Collections.Generic;
using System.Text;

namespace RPGv2
{
    class Mage : Heros
    {
        private int _puissance;

        public Mage(string nom, int vie, int puissance) : base(nom, vie)
        {
            _puissance = puissance;
        }

        public override void Attaquer(Heros p2) {
            
            int totalDegats = 0;
            for (int i = 0; i < _puissance; i++)
            {
                _deHeros.Lancer();
                totalDegats += _deHeros.Lire();
            }

            p2.Blessure(totalDegats);
            Console.WriteLine(_nom + " lance un sort sur " + p2.GetNom() + " et lui inflige " + totalDegats + " points de dégâts (puissance: " + _puissance + ").\n\t\t" + _nom + ": " + _pointsDeVie + " PV\t\t" + p2.GetNom() + ": " + p2.GetPointsDeVie() + " PV");
            
        }
    }
}
