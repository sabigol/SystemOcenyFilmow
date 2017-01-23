using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication12
{

    class Program
    {
        public static void Main(string[] args)
        {
            var json = new WebClient().DownloadString("http://www.omdbapi.com/?s=name");

            dynamic stuff = JsonConvert.DeserializeObject(json);

            foreach (var film in stuff.Search)
            {
                Console.WriteLine("tytuł filmu: " + film.Title + " Rok powstania: " + film.Year);
            }

            Console.ReadLine();
        }

    }
}