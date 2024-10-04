using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _19_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Make your Calculation ( or press qto quit):");
                string calculation = Console.ReadLine();
                try
                {

                    calculation = calculation.Replace(" ", "");
                    char operat = 'x';
                    int resault = 0;
                    if (calculation.Contains("+"))
                    {
                        operat = '+';
                    }
                    else if (calculation.Contains("-"))
                    {
                        operat = '-';
                    }
                    else if (calculation.Contains("*"))
                    {
                        operat = '*';
                    }
                    else if (calculation.Contains("/"))
                    {
                        operat = '/';
                    }
                    else if (calculation.Contains("q"))
                    {
                        break;
                    }
                    int num1 = int.Parse(calculation.Split(operat)[0]);
                    int num2 = int.Parse(calculation.Split(operat)[1]);

                    if (calculation.Contains("+"))
                    {
                        resault = num1 + num2;
                    }
                    else if (calculation.Contains("-"))
                    {
                        resault = num1 - num2;
                    }
                    else if (calculation.Contains("*"))
                    {
                        resault = num1 * num2;
                    }
                    else if (calculation.Contains("/"))
                    {
                        if (num2 != 0)
                        {
                            resault = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("You can't divide by 0");
                        }

                    }
                    Console.WriteLine(resault);
                    

                }
                catch
                {
                    Console.WriteLine("!Something went Wrong!");

                }
            }
        }

    }
}
