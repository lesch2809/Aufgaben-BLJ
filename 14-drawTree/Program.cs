using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_drawTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.Write("Breite des Stammes: ");
                String withLog = Console.ReadLine();
                if (int.TryParse(withLog, out int BLog) == true)
                {
                    Console.Write("Höhe des Stammes: ");
                    String heigthLog = Console.ReadLine();
                    if (int.TryParse(heigthLog, out int HLog) == true)
                    {
                        Console.Write("Höhe der Krone : ");
                        String heigthTree = Console.ReadLine();
                        if (int.TryParse(heigthTree, out int HTree) == true)
                        {
                            int BTree = HTree * 2 -1;
                            int Star = -1;
                            for (int i =0; i<HTree; i++)
                            {


                                for (int j= 0; j < HTree -i; j++)
                                {
                                    Console.Write(" ");
                                }
                                Star += 2;
                                for (int k = 0; k<Star; k++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                            int spaceToLog = HTree - (BLog / 2);
                            for (int m = 0;  m < HLog;  m++)
                            {
                                for (int l = 0; l < spaceToLog; l++)
                                {
                                    Console.Write(" ");
                                }
                                for (int n = 0; n < BLog; n++)
                                {
                                    Console.Write("*");
                                }
                                Console.Write("\n");
                            }
                            

                        }
                        else
                        {
                            Console.WriteLine("Enter a Correct number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a Correct number");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a Correct number");
                }
            }
        }
    }
}
