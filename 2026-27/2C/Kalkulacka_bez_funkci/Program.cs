namespace Kalkulacka_bez_funkci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("nějaký text do konzole");
            string textZKonzole = Console.ReadLine();

            double x;
            bool povedloSe = Double.TryParse(Console.ReadLine(),out x);



            //Console.WriteLine("Zadej první číslo");
            //double x;
            //double.TryParse(Console.ReadLine(), out x);

            //Console.WriteLine("Zadej druhé číslo");
            //double y;
            //double.TryParse(Console.ReadLine(), out y);

            //Console.WriteLine("zadej operaci + - * /");
            //string operace = Console.ReadLine();
        }
    }
}
