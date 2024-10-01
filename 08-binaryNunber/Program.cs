using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _08_binaryNunber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int bin = 0;
            int number = 0;
            int wert;
            int rest;
            


                string n = Console.ReadLine();
                if (int.TryParse(n, out number) == true)
                {
                    while (true)
                    {

                        rest = number % 2;
                        bin = rest + bin;
                        wert = number / 2;
                        number = wert;
                        if (number == 0)
                        {
                            Console.WriteLine(bin);
                            break;
                        }
                        else
                        {
                            Console.Write(bin);
                            bin = 0;
                        }
                    }
                }
                else if (n == "q")
                {
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valide number");
                }
                
            }
            

        }
    }
}
