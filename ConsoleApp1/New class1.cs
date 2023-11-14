using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class New_class1
    {
        static int a = 5;
        static int b = 3;
        
        static string tekst = "ballær";
        public static string ReturnAString()
        {
            return tekst;
        }
        public static int ReturnTall(int x, int y)
        {
            return x+y;
        }
        public static void Run()
        {
            Console.WriteLine($"Dette er en string: {ReturnAString()}");
            Console.WriteLine($"Dette er et tall: {ReturnTall(a, b)}");
        }
      
    }   
}
