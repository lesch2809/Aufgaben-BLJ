using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_divisionQuersumme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Zahl 1: ");
                string num1 = Console.ReadLine();
                if (int.TryParse(num1, out int number1) == true)
                {
                    while (true)
                    {
                        Console.WriteLine("Zahl 2: ");
                        string num2 = Console.ReadLine();
                        if (int.TryParse(num2, out int number2) == true)
                        {
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Zahl \t | Quersumme \t | Zahl / Quersumme");
                            Console.WriteLine("-----------------------------------------");
                            for (int i = number1; i <= number2; i++)
                            {
                                int quersum = BerechneQuersumme(i);
                                if (i % quersum == 0)
                                {
                                    
                                    Console.WriteLine(i + "\t | " + quersum + "\t \t | "+(i/quersum));
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("GetIndexBinder eine Gültige zahl ein.");
                        }
                    }break;
                }
                else
                {
                    Console.WriteLine("GetIndexBinder eine Gültige zahl ein.");
                }
            }Console.ReadKey();
        }
        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;
            while (true)
            {
                if (zahl != 0)
                {
                    sum = sum + (zahl % 10);
                    zahl = zahl / 10;

                    // todo: Quersumme von 'zahl' berechnen und zurückgeben (return)
                }
                else
                {
                    break;
                }
            }
            return sum;
        }
    }
}
