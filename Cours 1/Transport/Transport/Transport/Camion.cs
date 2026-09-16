using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Camion
    {
        public string Description;
        public double ChargeMax;
        public double Charge;
        public string Localisation;
        private List<Marchandise> Chargement;

        public Camion(string Description, double ChargeMax,string Localisation)
        {
            this.Description = Description;
            this.ChargeMax = ChargeMax;
            this.Charge = 0;
            this.Localisation = Localisation;
            this.Chargement = new List<Marchandise>();
        }
        public string GetDescription()
        {
            return Description;
        }
        public double GetChargeMax()
        {
            return ChargeMax;
        }
        public double GetChargeDisponible()
        {
            return ChargeMax - Charge;
        }
        public double GetCharge()
        {
            return Charge;
        }
        public string GetLocalisation()
        {
            return Localisation;
        }

        public bool Charger(Marchandise March)
        {
            if (March.GetLocalisation()!=this.GetLocalisation())
            {
                ColoredConsole.WriteGreen("Impossible d'embarquer " + March.GetDescription() + " à bord de " + this.GetDescription() + "\n(Ils ne sont pas au même endroit)");
                return false;
            }
            else if (March.GetPoids() <= ChargeMax - Charge)
            {
                Chargement.Add(March);
                Charge += March.GetPoids();
                ColoredConsole.WriteGreen(March.GetDescription() + " embarqué(e)s à bord de " + this.GetDescription());
                return true;
            }
            else
            {
                ColoredConsole.WriteGreen("Impossible d'embarquer " + March.GetDescription() + " à bord de " + this.GetDescription());
                ColoredConsole.WriteGreen("Poids de la marchandise : " + March.GetPoids() + "kg. Charge disponible : " + GetChargeDisponible() + "kg");
                return false;
            }
        }
        public void DechargerTout()
        {
            for (int i = this.Chargement.Count() - 1; i >= 0; i--)
            {
                this.Chargement[i].SetLocalisation(this.GetLocalisation());
                Charge -= this.Chargement[i].GetPoids();
                Chargement.Remove(this.Chargement[i]);
            }
//            ColoredConsole.WriteGreen(GetDescription() + " déchargé");
        }

        public void RoulerVers(string Dest)
        {
            ColoredConsole.WriteGreen(GetDescription() + " roule de " + GetLocalisation() + " jusque " + Dest);
            Localisation = Dest;
        }

        public void Decrire()
        {
            ColoredConsole.WriteGreen(GetDescription() + " (charge: " + GetCharge() + " / "+ GetChargeMax() + "kg). Localisation: " + GetLocalisation());
        }


    }
}
