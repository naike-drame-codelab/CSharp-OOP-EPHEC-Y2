using System;
using System.Collections.Generic;
using System.Text;

namespace TempConverter
{
        class Temperaturev2
        {
            // Attributs privés pour conserver l'encapsulation
            private double TempInCelsius;
            private double TempInFahrenheit;

            // Constructeur
            public Temperaturev2(double T, char Unite)
            {
                Unite = char.ToUpper(Unite);
                if (Unite == 'C')
                {
                    SetCel(T); // On peut directement utiliser le Setter pour initialiser de manière cohérente
                }
                else
                {
                    SetFar(T);
                }
            }

            // Getters (lecture des attributs)
            public double GetCel()
            {
                return TempInCelsius;
            }

            public double GetFar()
            {
                return TempInFahrenheit;
            }

            // Setters (modification tout en maintenant la cohérence des deux attributs avec les conversions automatiques)
            public void SetCel(double c)
            {
                TempInCelsius = c;
                TempInFahrenheit = CtoF(c);
            }

            public void SetFar(double f)
            {
                TempInFahrenheit = f;
                TempInCelsius = FtoC(f);
            }

            // Méthodes de conversion privées ("cuisine interne")
            // Elles ne sont pas accessibles en dehors de la classe
            private double CtoF(double c)
            {
                return c * 9.0 / 5.0 + 32.0;
            }

            private double FtoC(double f)
            {
                return (f - 32.0) * 5.0 / 9.0;
            }

            // Méthode métier
            public bool Chauffage()
            {
                if (TempInCelsius < 15.0) return true;
                else return false;
            }
        }
}
