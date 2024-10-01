using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl eingeben: ");
            
            while (true)
            {
                string number = Console.ReadLine();
                int zahl = 0;



                if (Int32.TryParse(number, out zahl) == true)
                {
                    if (zahl < 13 && zahl > 0)
                    {
                        switch (zahl)
                        {
                            case 1:
                                Console.WriteLine("Januar");
                                break;
                            case 2:
                                Console.WriteLine("Februar");
                                break;
                            case 3:
                                Console.WriteLine("märz");
                                break;
                            case 4:
                                Console.WriteLine("April");
                                break;
                            case 5:
                                Console.WriteLine("Mai");
                                break;
                            case 6:
                                Console.WriteLine("Juni");
                                break;
                            case 7:
                                Console.WriteLine("Juli");
                                break;
                            case 8:
                                Console.WriteLine("Augus");
                                break;
                            case 9:
                                Console.WriteLine("September");
                                break;
                            case 10:
                                Console.WriteLine("Oktober");
                                break;
                            case 11:
                                Console.WriteLine("November");
                                break;
                            case 12:
                                Console.WriteLine("Dezeber");
                                break;
                        }
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }
    }
}
