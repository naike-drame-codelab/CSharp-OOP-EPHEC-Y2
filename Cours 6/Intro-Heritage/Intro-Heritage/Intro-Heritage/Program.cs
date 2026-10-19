using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personne Durand = new Personne("Durand", "Alain", "alain.durand@gmail.com");
            //Employe Alami = new Employe("Alami", "Noûr", "nour.alami@gmail.com", "n.alami@bigcompany.com", 2250);
            //Belge Mercier = new Belge("Mercier", "Luc", "luc.mercier@gmail.com", "Communauté wallonne");
            //Console.WriteLine(Mercier.Afficher());

            Personne p1 = new Personne("Dupont", "Jean", "jean.dupont@gmail.com");
            Belge p2 = new Belge("Dubois", "Marie", "marie.dubois@gmail.com", "Communauté flamande");
            Personne p3 = new Belge("De Smet", "Luc", "luc.de_smet@gmail.com", "Communauté wallonne");
            Console.WriteLine(p1.Afficher());
            Console.WriteLine(p2.Afficher());
            Console.WriteLine(p3.Afficher());


            // Console.WriteLine("les deux héros de notre histoire: ");
            //Console.WriteLine("    " + Durand.ToString());
            //Console.WriteLine("    " + Alami.ToString());

            //Alami.RecevoirSalaire();
            //if (Alami.Depenser(1200))
            //    Console.WriteLine(Alami.GetPrenom() + " s'achète un nouveau PC");
            //else Console.WriteLine(Alami.GetPrenom() + " n'a pas assez d'argent pour un nouveau PC");

            //Alami.Epouser(Durand);
            //if (Alami.GetConjoint() != null)
            //    Console.WriteLine(Alami.GetPrenom() + " est mariée à " + Alami.GetConjoint().GetPrenom() + " " + Alami.GetConjoint().GetNom());
            //else Console.WriteLine(Alami.GetPrenom() + " est célibataire");

            //Console.WriteLine("Les deux héros de notre histoire: ");
            //Console.WriteLine("    " + Durand.ToString());
            //Console.WriteLine("    " + Alami.ToString());
        }
    }
}
