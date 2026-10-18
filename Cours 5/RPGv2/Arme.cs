using System;
using System.Collections.Generic;
using System.Text;

namespace RPGv2
{
    internal class Arme
    {
        private string _nom;
        private int _bonus;

        public Arme(string n, int b)
        {
            _nom = n;
            _bonus = b;
        }
        public string GetNom()
        {
            return _nom;
        }
        public int GetBonus()
        {
            return _bonus;
        }

    }
}
