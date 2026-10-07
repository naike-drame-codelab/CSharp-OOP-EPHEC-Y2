using System;
using System.Collections.Generic;
using System.Text;

namespace RPGV1
{
    class Arena
    {
       public Arena (Hero h1, Hero h2) 
       { }

       public void Combat(Hero h1, Hero h2)
        {
            while (h1.GetPointsDeVie() > 0 && h2.GetPointsDeVie() > 0)
            {
                h1.Attaquer(h2);
                Console.WriteLine("Hero 1 attaque Hero 2. Hero 2 a " + h2.GetPointsDeVie() + " points de vie.");
                if (h2.GetPointsDeVie() <= 0)
                {
                    Console.WriteLine("Hero 1 a gagné !");
                    break;
                }
                h2.Attaquer(h1);
                Console.WriteLine("Hero 2 attaque Hero 1. Hero 1 a " + h1.GetPointsDeVie() + " points de vie.");
                if (h1.GetPointsDeVie() <= 0)
                {
                    Console.WriteLine("Hero 2 a gagné !");
                    
                }
            }
        }
    }
}
