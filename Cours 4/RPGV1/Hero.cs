using System;
using System.Collections.Generic;
using System.Text;

namespace RPGV1
{
    class Hero
    {
        private int _pointsDeVie;
        private De _de = new De();

        public Hero(int vie)
        {
            this._pointsDeVie = vie;
        }

        public int GetPointsDeVie()
        {
            return _pointsDeVie;
        }

        public void SetPointsDeVie(int vie)
        {
            _pointsDeVie = vie;
        }

        public void Attaquer(Hero adversaire) 
        {
            int degats = _de.Lancer();
            adversaire.SetPointsDeVie(adversaire.GetPointsDeVie() - degats);
        }

        public override string ToString()
        {
            return this.GetPointsDeVie() + " points de vie.";
        }


    }
}
