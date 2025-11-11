using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramovani
{
    internal class Program
    {
        //Návratová hodnota je Task<string> 
        //Funkce je typu async
        static async Task<string> StahniData()
        {
            Console.WriteLine("📥 Začínám stahovat data...");
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=50.08&longitude=14.44&current_weather=true";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            

            Console.WriteLine("✅ Data stažena!");
            return json;
        }


        //Návratová hodnota je Task
        static async Task Main(string[] args)
        {
            //zavoláním metody začne stahování a výsledek bude na konci uložen do proměnné stahovani
            Task<string> stahovani = StahniData();

            //protože StahniData je AsyncTask, program jde dál - task běží v samostatném vlákně a neblokuje program
            Console.WriteLine("něco napiš");
            string odUzivatele = Console.ReadLine();
            //Hned vypíšu něco od uživatele
            Console.WriteLine("vypíšu hned hodnotu od uživatele, ale stahování stále běží na pozadí. odUzivatele: " + odUzivatele);

            //Budu potřebovat vypsat výsledek stahování, a proto pomocí await počkám, až se funkce dokončí
            //Zde program už stojí a čeká na dokončení
            string vysledek = await stahovani;

            //Zde mohu vypsat vysledek, protože už mám staženo
            Console.WriteLine($"Výsledek stahování:");
            Console.WriteLine($"{vysledek}");
        }
    }
}
