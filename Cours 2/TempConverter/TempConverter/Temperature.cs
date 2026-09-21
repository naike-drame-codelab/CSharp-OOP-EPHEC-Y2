using System;
using System.Collections.Generic;
using System.Text;

namespace TempConverter
{
    class Temperature
    {

        // ================ Grand classique des examens : conversion d'unités ================

        //public double temp;
        //public char unite; 

        //public Temperature(double t, char u)
        //{
        //    this.temp = t;
        //    this.unite = Char.ToUpper(u);
        //}

        //private double EnCel()
        //{
        //    return (temp - 32) * 5.0/9.0;
        //}

        //private double EnFahr()
        //{
        //    return temp * 9.0/5.0 + 32;
        //}


        //public double Convertir()
        //{
        //    if (unite == 'C')
        //    {
        //        temp = EnFahr();
        //        unite = 'F';
        //        return temp;
        //    }
        //    else if (unite == 'F')
        //    {
        //        temp = EnCel();
        //        unite = 'C';
        //        return temp;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Unité de température invalide. Utilisez 'C' pour Celsius ou 'F' pour Fahrenheit.");
        //    }
        //}

        //public void Chauffage()
        //{
        //    double tempEnCel = (unite == 'F') ? EnCel() : temp;

        //    if (temp < 15.0)
        //    {
        //        Console.WriteLine("Il fait froid, allumez le chauffage !");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Il fait chaud, éteignez le chauffage !");
        //    }
        //}

        // Getters et Setters
        private double TempInCelsius;
        private double TempInFahrenheit;
        public Temperature(double T, char Unité)
        {
            this.TempInCelsius = T;
            this.TempInFahrenheit = Unité;
        }

        // Jouent le rôle de getters
        public double EnCel() // GetCel()
        {
            return TempInCelsius;
        }
        public double EnFar()
        {
            return TempInFahrenheit;
        }

        // Fonction qui joue le rôle de setter
        public double SetTemp(double T, char Unité)
        {
            if (Unité == 'C')
            {
                TempInCelsius = T;
                TempInFahrenheit = T * 9.0 / 5 + 32;
            }
            else
            {
                TempInFahrenheit = T;
                TempInCelsius = (T - 32) * 5.0 / 9;
            }
            return T;
        }

        public bool Chauffage()
        {
            if (TempInCelsius < 15.0) return true;
            else return false;
        }

    }
}
