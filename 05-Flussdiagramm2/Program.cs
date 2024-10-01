using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Flussdiagramm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wieviele Kilometer wilst du rennen?");
            while (true)
            {
                string km = Console.ReadLine();
                double kmZahl = 0;
                if (double.TryParse(km, out kmZahl) == true)
                {
                    if (kmZahl > 42)
                    {
                        Console.WriteLine("Das schaffst du nicht");
                        break;
                    }
                    else
                    {
                        kmZahl = kmZahl / 0.4;
                        Console.WriteLine("Ready? y/n");
                        string ready = Console.ReadLine();
                        if (char.TryParse(ready, out char letter) == true)
                        {
                            if (letter == 'y')
                            {
                                int i = 1;
                                while (true)
                                {
                                    
                                if (i <= kmZahl)
                                    {
                                        Console.WriteLine("DU läufst Runde " + i);
                                        i++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Du hast es Geschaft");
                                        break;
                                    }

                                }
                                break;
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }
                else {
                    Console.WriteLine("Gib eine Zahl ein");
                 }
            }
            Console.ReadKey();
        }
    }
}
