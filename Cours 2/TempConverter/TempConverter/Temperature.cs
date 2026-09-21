using System;
using System.Collections.Generic;
using System.Text;

namespace TempConverter
{
    class Temperature
    {
        public float temp;
        public char unite; 

        public Temperature(float t, char u)
        {
            this.temp = t;
            this.unite = Char.ToUpper(u);
        }

        private float EnCel()
        {
            return (temp - 32) * 5f/9f;
        }

        private float EnFahr()
        {
            return temp * 9f/5f + 32;
        }


        public float Convertir()
        {
            if (unite == 'C')
            {
                temp = EnFahr();
                unite = 'F';
                return temp;
            }
            else if (unite == 'F')
            {
                temp = EnCel();
                unite = 'C';
                return temp;
            }
            else
            {
                throw new ArgumentException("Unité de température invalide. Utilisez 'C' pour Celsius ou 'F' pour Fahrenheit.");
            }
        }

        public void Chauffage()
        {

            float tempEnCel = (unite == 'F') ? EnCel() : temp;

            if (temp < 15)
            {
                Console.WriteLine("Il fait froid, allumez le chauffage !");
            }
            else
            {
                Console.WriteLine("Il fait chaud, éteignez le chauffage !");
            }
        }
    }
}
