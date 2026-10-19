using System;
using System.Collections.Generic;
using System.Text;

namespace RPGv2
{
    internal class Heros
    {
        protected int _pointsDeVie;
        protected string _nom;
        protected De _deHeros;
        private Arme? _armeHeros;

        public Heros(string Nom, int PV, Arme a)
        {
            this._nom = Nom;
            this._pointsDeVie = PV;
            this._armeHeros = a;
            this._deHeros = new De();
        }

        public Heros(string Nom, int PV)
        {
            this._nom = Nom;
            this._pointsDeVie = PV;
            this._deHeros = new De();
        }
        public bool IsVivant()
        {
            return (_pointsDeVie >= 0);
        }
        public void Blessure(int b)
        {
            _pointsDeVie -= b;
        }
        public string GetNom() { return _nom; }
        public int GetPointsDeVie() { return _pointsDeVie; }
        public Arme? GetArme() { return _armeHeros; }

        public virtual void Attaquer(Heros p2)
        {
            int degats;
            int bonus = 0;
            _deHeros.Lancer();
            degats = _deHeros.Lire();
            if (_armeHeros != null)      // Obligatoire de tester ceci si l'on veut la possibilité qu'un héros ne soit pas armé, autrement l'accès _armeHeros.GetBonus() générera une erreur
            {
                bonus = _armeHeros.GetBonus();
                degats += bonus;
            }
            p2.Blessure(degats);
            Console.WriteLine(_nom + " frappe " + p2.GetNom() + " et lui inflige " + degats + " points de dégâts (bonus arme: " + bonus + ").\n\t\t" + _nom + ": " + _pointsDeVie + " PV\t\t" + p2.GetNom() + ": " + p2.GetPointsDeVie() + " PV");
        }
        public void Afficher()
        {
            Console.WriteLine(_nom + " : " + _pointsDeVie + " PV");
        }
        public void Duel(Heros p2)
        {
            while (IsVivant() && p2.IsVivant())
            {
                Attaquer(p2);
                if (p2.IsVivant())            // Pas de riposte si le dernier coup porté a tué p2
                    p2.Attaquer(this);
            }
            if (!IsVivant()) Console.WriteLine(_nom + " a succombé.");
            if (!p2.IsVivant()) Console.WriteLine(p2.GetNom() + " a succombé.");
        }
    }
}
