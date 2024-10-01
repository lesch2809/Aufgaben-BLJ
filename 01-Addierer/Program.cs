using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Addierer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berechtnet die Summe von 2 Zahlen.");
            Console.Write("Zahl1: ");
            string number1 = Console.ReadLine();


            Console.Write("Zahl2: ");
            string number2 = Console.ReadLine();

            int summe = Convert.ToInt32(number1) + Convert.ToInt32(number2);
            Console.WriteLine("Summe: " + summe);
            Console.ReadKey();
        }
    }
}
