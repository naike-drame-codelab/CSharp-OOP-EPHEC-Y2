using System;
using System.Collections.Generic;
using System.Text;

namespace SaisieClass
{
    internal static class Saisie
    {

        public static string LireString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        public static int LireInt(string msg)
        {
            return int.Parse(LireString(msg));
        }

        public static double LireDouble(string msg)
        {
            return double.Parse(LireString(msg));
        }

        public static bool LireBool(string msg)
        {
            return bool.Parse(LireString(msg));
        }
    }
}
