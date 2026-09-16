using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Marchandise
    {
        public string Description;
        public double Poids;
        public string Localisation;

        public Marchandise(string Description, double Poids, string Localisation)
        {
            this.Description = Description;
            this.Poids = Poids;
            this.Localisation = Localisation;
        }
        public string GetDescription()
        {
            return Description;
        }
        public double GetPoids()
        {
            return Poids;
        }
        public string GetLocalisation()
        {
            return Localisation;
        }
        public void SetLocalisation(string Loc)
        {
            Localisation = Loc;
        }
        public void Decrire()
        {
            ColoredConsole.WriteGreen(GetDescription() + " (" + GetPoids() + "kg). Localisation: " + GetLocalisation());
        }
    }
}
