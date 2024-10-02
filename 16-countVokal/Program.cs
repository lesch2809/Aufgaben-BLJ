using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _16_countVokal
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Gib hier dein Text ein.");
            string text = Console.ReadLine();
            string letter = "";

            int countletter = 0;
            string[] a = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U", "ä", "Ä", "ö", "Ö", "ü", "Ü" };

            for (int i = 0; i < a.Length; i++)
            {
                letter = a[i];
                if (text.Contains(letter))
                {
                    countletter = zähleBuchstabe(letter, countletter, text);
                    Console.WriteLine("Der Buchstbe " + letter + " ist " + countletter + " mal vorhnden.");
                }
            }
            Console.ReadKey();
            
        }
        static int zähleBuchstabe(string Buchstabe, int gezählterBuchstabe, string modText)
        {
            int gezählterBuchstabediv1 = modText.Length;
            
            
               modText = modText.Replace(Buchstabe,"");
                int gezählterBuchstabediv2 = modText.Length;
                gezählterBuchstabe = gezählterBuchstabediv1 - gezählterBuchstabediv2;
                return gezählterBuchstabe;
            
        } 
    }
}

