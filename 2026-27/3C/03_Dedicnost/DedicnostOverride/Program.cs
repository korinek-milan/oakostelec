namespace DedicnostOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();

            a.vydejZvuk();
            a.funkceNemaSmyslZPohleduRodice();

            //z abstraktní třídy nemohu vytvořit instanci
            //Vozidlo v = new Vozidlo();
        }
    }
}
