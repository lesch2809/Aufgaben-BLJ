using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_schaltjahre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm überprüft ob es sich beim angegebene Jahr um ein Schaltjahr handelt");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            while (true)
            {


                Console.Write("Eingabe Jahr (q to Quit):");
                String input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                if (int.TryParse(input, out int year) == true)
                {
                    if (year % 4 == 0)
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                            {
                                Console.WriteLine("Das ist ein  Schaltjahr");
                            }
                            else
                            {
                                Console.WriteLine("Das ist KEIN Schaltjahr");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Das ist ein Schaltjahr");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das ist KEIN  Schaltjahr");
                    }
                }
                
            }
        }
    }
}
