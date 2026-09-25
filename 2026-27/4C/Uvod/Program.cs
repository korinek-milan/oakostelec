namespace Uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celeCislo;
            string nejakyText = "";//může být nula nebo více znaků
            char jedenZnak = 'x';//musí být právě jeden znak
            bool trueFalseHodnota;
            double desetinneCislo;//float

            //ReadLine vždy načítá string, proto, pokud chci číslo, musím převést
            //int cislo1 = Convert.ToInt32(Console.ReadLine());
            //int cislo2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(soucet(cislo1, cislo2));

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            int j = 1;
            while (j<11)
            {

                j++;
            }

            List<int> listCisel = new List<int>();
            listCisel.Add(42);
            listCisel.Add(98);


            foreach (int item in listCisel)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------");

            Auto a1 = new Auto("modrá");
            Auto a2 = new Auto("červná");
            Auto a3 = new Auto("zelená");

            List<Auto> listAut = new List<Auto>();
            listAut.Add(a1);
            listAut.Add(a2);
            listAut.Add(a3);

            foreach (Auto a in listAut)
            {
                Console.WriteLine("Množství paliva je: " + a.MnozstviPaliva);
            }

            Console.WriteLine("Množství paliva je: " + a1.MnozstviPaliva);
            a1.Natankovani(5);
            Console.WriteLine("Množství paliva je: " + a1.MnozstviPaliva);

            SpecializovaneAuto s1 = new SpecializovaneAuto("speciální modrá");

            Console.WriteLine(s1.Barva);
            s1.Natankovani(6);
            Console.WriteLine(s1.MnozstviPaliva);
            listAut.Add(s1);

            foreach (Auto a in listAut)
            {
                a.Natankovani(30);
                Console.WriteLine(a.Barva + " " + a.MnozstviPaliva);
            }
        }

        //nezapomenout v Program.cs musí každá funkce být static
        public static int soucet(int x, int cislo2)
        {
            return x + cislo2;
        }
    }

}
