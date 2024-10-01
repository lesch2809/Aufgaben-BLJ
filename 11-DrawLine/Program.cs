using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DrawLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int length) == true)
            {
                for ( int i = 0;  i < length; i++)
                {
                    for (int j = 0;  j < length; j++)
                    {
                        if (i-j!=0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }Console.WriteLine("\t");
                }Console.ReadKey();
            }
        }
    }
}
