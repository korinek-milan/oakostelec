namespace ServisPC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string volba = "";
            Random r = new Random();
            double castka = r.Next(500, 2001);
            DatabaseManager db = new DatabaseManager();

            while (volba != "99")
            {
                Console.WriteLine("Moje částka je: " + castka);
                Console.WriteLine("1 - Výpis úkonů");
                Console.WriteLine("2 - Provedení úkonu");
                Console.WriteLine("99 - Konec aplikace");
                volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        foreach (var item in db.vratVsechnyUkony())
                        {
                            Console.WriteLine($"id: {item.ServiceTaskId}, název: {item.Name}, čas: {item.EstimatedHours}, cena: {item.Price}, přirážka za specialistu: {item.SpecialistCharge}");
                        }
                        break;

                    case "2":
                        
                        int idUkonu = Convert.ToInt32(Console.ReadLine());
                        List<double> ceny = db.vratInfoOUkonuPodleID(idUkonu);
                        //TODO vypočítat cenu, zkontrolovat, že si to zákazník může dovolit a případně vykonat a strhnout částku
                        break;
                }

                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
