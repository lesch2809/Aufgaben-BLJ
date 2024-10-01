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
            int bin = 0;
            string n = Console.ReadLine();
            if (int.TryParse(n, out int number) == true)
            {
                while (true)
                {


                    int rest = number % 2;
                    bin = rest + bin;
                    int wert = number / 2;
                    number = rest;
                    if (number == 0)
                    {
                        Console.WriteLine(bin);
                        break
                    }
                }
            }
            else {
                Console.WriteLine("Enter a valide number");
                    }Console.ReadKey();

        }
    }
}
