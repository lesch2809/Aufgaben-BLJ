using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Quersumme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Zahl = Console.ReadLine();
            if (int.TryParse(Zahl, out int num) == true)
            {
                
                
                num = BerechneQuersumme(num);
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("enter a Valide number");
                
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
                else { 
                break;
                }
            }return sum;
        }
    }
}
