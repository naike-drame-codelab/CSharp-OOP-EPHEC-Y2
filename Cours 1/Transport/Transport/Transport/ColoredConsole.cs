using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    static class ColoredConsole
    {
        static ConsoleColor Orig;

        public static void SetTo(ConsoleColor Col)
        {
            Orig = Console.ForegroundColor;
            Console.ForegroundColor = Col;
        }
        public static void SetBack()
        {
            Console.ForegroundColor = Orig;
        }
        public static void WriteGreen(string S)
        {
            SetTo(ConsoleColor.Green);
            Console.WriteLine(S);
            SetBack();
        }
    }
}
