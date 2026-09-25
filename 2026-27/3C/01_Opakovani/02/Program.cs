namespace UvodV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sčítací aplikace");

            Console.WriteLine("Zadej první celé číslo");
            try
            {
                int cislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadej druhé celé číslo");
                int cislo2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(scitej(cislo1, cislo2));

            }
            catch (Exception lama)
            {
                Console.WriteLine("Nastala neočekávaná chyba:");
                Console.WriteLine(lama.Message);
            }


            int[] poleCisel = new int[5];
            poleCisel[0] = 42;

            List<string> listTextu = new List<string>();
            listTextu.Add("abc");


            int x = 42;
            Auto a1 = new Auto(4, "Audi");
            a1.zmenaPoctuKol(5);
            Auto a2 = new Auto(4, "Peugeot");
            Auto a3 = new Auto(6, "Škoda");

            List<Auto> listAut = new List<Auto>();
            listAut.Add(a1);
            listAut.Add(a2);
            listAut.Add(a3);

            foreach (Auto item in listAut)
            {
                Console.WriteLine($"Auto s názvem {item.znackaAuta} má {item.pocetKol} kol");
            }

            for (int i = 0; i < listAut.Count; i++)
            {
                Console.WriteLine($"Auto s názvem {listAut[i].znackaAuta} má {listAut[i].pocetKol} kol");
            }

            Console.WriteLine("Konec programu");
        }

        public static int scitej(int c1, int c2)
        {
            int soucet = c1 + c2;
            return soucet;

            //return c1 + c2 → vracím hned bez tvorby mezi proměnné
        }
    }

}
