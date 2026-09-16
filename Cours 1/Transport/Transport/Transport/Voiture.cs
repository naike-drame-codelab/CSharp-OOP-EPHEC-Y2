using System;
using System.Collections.Generic;
using System.Text;

namespace Transport
{
    class Voiture
    {
        public string Marque;
        public string Modele;
        public int NumSerie;
        public double PrixCatalogue;
        public double PrixVente;

        public Voiture(string Marque, string Modele, int NumSerie, double PrixCatalogue)
        {
            this.Marque = Marque;
            this.Modele = Modele;
            this.NumSerie = NumSerie;

            this.PrixCatalogue = PrixCatalogue;
        }

        public void CalculerPrixVente(double TauxReduction)
        {
            PrixVente = PrixCatalogue * (1 - TauxReduction / 100);
        }

        public void Afficher()
        {
            Console.WriteLine($"Marque: {Marque}, Modèle: {Modele}, Numéro de série: {NumSerie}, Prix catalogue: {PrixCatalogue}, Prix vente: {PrixVente}");
        }

    }
}
