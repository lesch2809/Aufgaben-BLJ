using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondsOfMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm Rechnet die Sekundne eines Monats aus.");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Wieviele Tage hat dein Monat?");
            while (true)
            {
                string dayMonth = Console.ReadLine();
                int zahl = 0;
            


                if (Int32.TryParse(dayMonth, out zahl) == true)
                {
                    zahl = Convert.ToInt32(dayMonth);
                    if (zahl < 32 && zahl > 27)
                    {

                        Console.WriteLine("Ein Monat mit " + dayMonth + " Tagen hat " + (Convert.ToInt32(dayMonth) * 24 * 60 * 60));
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("es gibt kein Monat mit " + zahl + " Tagen.");

                    }


                }
                else
                {
                    Console.WriteLine("Es wird eine Gazzahl gefordert.");

                }

            }
        }
    }
}
