namespace Dedicnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //můžu udělat obecnou instanci
            Vehicle v = new Vehicle(0, 0,false,"něco neurčitého");

            Car c = new Car(4, 1000,true,"BMW",4);
            //c.Nazev = "BMW";
            //c.PocetDveri = 4;
            
            v.vratNazev();
            c.vratNazev();

            c.OtevriDvere();
            //v.OtevriDvere(); třída Vehicle nemá funkci OtevriDvere

            Bicycle b = new Bicycle(2,500,false,"Author");
            //b.Nazev = "Author";
            b.NastavPrevodovyStupen(3);
            //b.OtevriDvere(); třída Bicycle nemá funkci OtevriDvere

            List<Car> auta = new List<Car>();
            auta.Add(c);
            //auta.Add(b); nemůžu dát do listu aut kolo

            List<Bicycle> kola = new List<Bicycle>();
            kola.Add(b);
            //kola.Add(c);
            //nemůžu přidat auto do listu kol
            //kola.Add(v);

            foreach (Car auto in auta)
            {
                Console.WriteLine(auto.vratNazev());
                auto.OtevriDvere();
            }

            foreach (Bicycle kolo in kola)
            {
                Console.WriteLine(kolo.vratNazev());
                kolo.NastavPrevodovyStupen(4);
            }

            List<Vehicle> vozidla = new List<Vehicle>();
            vozidla.Add(c);
            vozidla.Add(b);

            foreach (Vehicle vozidlo in vozidla)
            {
                Console.WriteLine(vozidlo.vratNazev());
                //vozidlo.OtevriDvere();
            }

        }
    }
}
