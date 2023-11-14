using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test1
    {
        public static void KjørDa()
        {
            Console.WriteLine("Denne linjen er ny");
        }
        public static void KjørDaVidere()
        {
            var inputLine = Console.ReadLine();
            Console.WriteLine($"Du sa: {inputLine}");
        }
    }
}
