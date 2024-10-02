using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_guessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string again = "a";
                int counter = 0;
                int number = 0;
                Random rnd = new Random();
                number = rnd.Next(100);
                while (true)
                {
                    counter++;

                    Console.WriteLine("Welche nummer ist es?");
                    string guess = Console.ReadLine();
                    if (int.TryParse(guess, out int guessNumb) == true)
                    {
                        if (number - guessNumb > 0)
                        {
                            Console.WriteLine("Zu Tief");
                        }
                        else if (number - guessNumb < 0)
                        {
                            Console.WriteLine("Zu Hoch");
                        }
                        else
                        {
                            Console.WriteLine("Du hast es Geschafft. Du hast " + counter + " Versuche gebraucht. Nochmals? [y/n]");
                            again = Console.ReadLine();
                            if (again == "y")
                            {
                                break;
                            }
                            else { 
                                break;
                                
                            }
                        }
                    }
                }
                if (again != "y")
                {
                    break;
                }
            }
        }
    }
}
