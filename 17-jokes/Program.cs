using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aufgabe_17
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReturnJoke());
            while (true)
            {
                char nj = char.Parse(FragenSpeichern("Nächsten Witz holen?").ToLower());
                if (nj == 'j')
                {
                    Console.WriteLine(ReturnJoke());
                    Console.WriteLine();
                }
                else
                {
                    
                    break;
                }
            }

        }
        static string ReturnJoke()
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");

            WebResponse response = request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd().ToString();

            JArray array = JArray.Parse(json);
            return array[0]["text"].ToString();



        }
        static string FragenSpeichern(string frage)
        {
            Console.Write(frage + " ");
            return Console.ReadLine();
        }
    }

}