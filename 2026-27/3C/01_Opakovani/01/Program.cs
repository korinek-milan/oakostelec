namespace Opakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Zadej první číslo");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadej druhé číslo");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Soucet(x,y));

                int[] poleCisel = new int[10];
                List<int> seznamCisel = new List<int>();
                seznamCisel.Add(42);


                Random r = new Random();
                poleCisel[0] = r.Next(5);


                Auto a1 = new Auto(100, "fialová");
                Auto a2 = new Auto(120, "červená");
                Auto a3 = new Auto(150, "fialová");
                Console.WriteLine(a1.barva);
                a1.ZmenBarvu("modrá");
                Console.WriteLine(a1.barva);

                List<Auto> listAut = new List<Auto>();
                listAut.Add(a1);
                listAut.Add(a2);
                listAut.Add(a3);

                foreach (Auto a in listAut)
                {
                    Console.WriteLine($"Auto barvy: {a.barva} má rychlost: {a.rychlost}");
                }
            }
            catch (Exception poník)
            {
                Console.WriteLine("Nastala následující chyba:");
                Console.WriteLine(poník.Message);
            }

        }

        static int Soucet(int x, int y)
        {
            return x + y; 
        }
    }

}
