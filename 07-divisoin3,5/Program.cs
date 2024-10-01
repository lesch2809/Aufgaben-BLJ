using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_divisoin3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlen die durch 3 oder 5 Teilbar sind ohne Rest:");
            for (int i = 0; i < 30; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    Console.Write(i + ", ");
                }
                
            }Console.Write("30");
            Console.ReadKey();
        }
    }
}
