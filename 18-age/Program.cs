using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_age
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            DateTime today = DateTime.Today;
            
            Console.Write("Gib dein Geburtsdatum (01.01.2000) an: ");
            string birth = Console.ReadLine();
            if (DateTime.TryParse(birth, out DateTime birthday) == true)
            {

                
                

                TimeSpan oldDay = today - birthday;
                int week = oldDay.Days / 7 ;
                int year = oldDay.Days / 365;
                int month = year * 12 ;
                 
                Console.WriteLine("Du bist " + oldDay.Days + " Tage alt.\n Du bist " + week + " Tage alt.\n Du bist " + month + " Tage alt.\n Du bist " + year + " Tage alt.\n ");
                Console.ReadKey();
            }
        }
    }
}
