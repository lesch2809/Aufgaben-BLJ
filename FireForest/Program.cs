using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FireForest
{
    internal class Program
    {

        static string[,] forest;
        static int fireCordinateX;
        static int fireCordinateY;
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Wie hoch ist die Wahrscheindlichkeit dass ein Baumm begint zu Brennen?(in %)");
            int z = 100/Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie hoch ist die Wahrscheindlichkeit dass ein neuer Baum wächst (in %)");
            int w = 100/Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wiel lang soll das Feld sein?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie Hoch soll das Feld sein?");
            int column = Convert.ToInt32(Console.ReadLine());
            forest = new string[row, column];
            Random rnde = new Random();
            //generat forrest first time
            

                for (int i = 0; i <= column - 1; i++) // i = row <->
                {
                    for (int j = 0; j <= row - 1; j++) // j = columns |
                    {
                        int chance2 = rnde.Next(1, 10);
                        if (chance2 >= 3)
                        {
                            forest[j, i] = "🌳";
                        }

                        if (chance2 == 2)
                        {
                            forest[j, i] = "🏞️";
                        }
                        if (chance2 == 1)
                        {
                            forest[j, i] = "🗿";
                        }
                        Console.Write(forest[j, i]);

                    }
                    Console.WriteLine();
                }
            while (true)
            {
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                drawField(row, column, forest, z);
                BiggerBurning(row, column, w);
               // Console.WriteLine("Enter q to quit...");
                // Console.ReadKey();

                //drawField(row, column, forest, z);

                //Console.WriteLine("");
                /*if (Console.ReadLine()=="q")
                {
                    break;
                }*/


            }
        }
        static void StartBurning(int chance, int row, int column, Random rnd)
        {
            int random = rnd.Next(chance);
            if (random == 0 && forest[row, column] == "🌳")
            {

                fireCordinateY = column;
                fireCordinateX = row;
                forest[fireCordinateX, fireCordinateY] = "🔥";

            }
        }

        static void drawField(int row, int column, string[,] forest , int z)
        {
            
            Random rnd = new Random();
            for (int i = 0; i <= column - 1; i++) // i = row <->
            {
                for (int j = 0; j <= row - 1; j++) // j = columns |
                {
                    
                    StartBurning(z, j, i, rnd);
                }

            }
            Console.Clear();
            for (int i = 0; i <= column - 1; i++) // i = row <->
            {
                for (int j = 0; j <= row - 1; j++) // j = columns |
                {
                    Console.Write(forest[j, i]);
                }
                Console.WriteLine();
            }
        }
        static void BiggerBurning(int row, int column, int w)
        {
            Random rnd = new Random();
            int UnderFlameX = 0;
            int UnderFlameY = 0;
            //feure punk finden
            for (int i = 0; i <= column - 1; i++)
            {
                for (int j = 0; j <= row - 1; j++)
                {
                    if (forest[j, i] == "🔥")
                    {
                        
                        if (i != 0 && forest[UnderFlameX, UnderFlameY] == forest[j, i-1] && forest[j, i - 1] == "🔸") // && UnderFlameY != 0 && UnderFlameX != 0 
                        {
                            j++;
                        }
                        else
                        {
                            forest[j, i] = "🔸";
                            //BAum Unten Anzünden
                            if (i + 1 < row && forest[j, i + 1] == "🌳")
                            {
                                forest[j, i + 1] = "🔥";
                                forest[j, i] = "🔸";
                                UnderFlameY = i;
                                UnderFlameX = j;
                            }
                            //Baum Oben ANzünden
                            if (i > 0 && forest[j, i - 1] == "🌳")
                            {
                                forest[j, i - 1] = "🔥";
                                forest[j, i] = "🔸";

                            }
                            //baum hinten anzünden
                            if (j > 0 && forest[j - 1, i] == "🌳" && forest[j - 1, i] != "🔥" && forest[j - 1, i] != "🏞️" && forest[j - 1, i] != "🗿" && forest[j - 1, i] != "🔸")
                            {
                                forest[j - 1, i] = "🔥";
                                forest[j, i] = "🔸";

                            }
                            //BAum vorne Anzünden
                            if (j + 1 < row && forest[j + 1, i] == "🌳")
                            {
                                forest[j + 1, i] = "🔥";
                                forest[j, i] = "🔸";
                                j++;
                            }
                            

                        }
                    }
                    else if (forest[j, i] == "🔸")
                    {
                        forest[j, i] = "💩";
                    }
                    else if (forest[j, i] == "💩")
                    {

                        int random = rnd.Next(w);
                        if (random == 0 && forest[j, i] == "💩")
                        {

                            forest[j, i] = "🌳";

                        }
                    }
                }

                }

            }
            
        }
    }

//🌳🔥🗿🏞️🔸💩
