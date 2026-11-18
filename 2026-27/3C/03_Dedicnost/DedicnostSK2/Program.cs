using System.Drawing;

namespace DedicnostSK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("neurčito");
            o.Login();


            Student s1 = new Student("Karel", true);

            //student zná vše z rodičovské třídy -> z osoby
            s1.Login();
            s1.OdpovezNaOtazku();

            o.Login();
            //osoba funkci ze studenta nezná
            //o.OdpovezNaOtazku();

            Ucitel u1 = new Ucitel(50000, "Jiří");

            //svoji funkci zná
            u1.PolozOtazku();
            //funkci Login zná od rodičovské třídy
            u1.Login();

            List<Ucitel> seznamUcitelu = new List<Ucitel>();
            seznamUcitelu.Add(u1);
            //seznamUcitelu.Add(o);//do seznamu učitelů nemůžu přidat osoby
            //seznamUcitelu.Add(s1);//do seznamu učitelů nemůžu přidat studenty

            List<Osoba> seznamOsob = new List<Osoba>();
            seznamOsob.Add(s1);
            seznamOsob.Add(u1);


            foreach (Osoba item in seznamOsob)
            {
                item.Login();//je jedno, jestli je to učitel nebo student, všichni jsou zároveň osoby a osoba zná funkci Login
                Console.WriteLine(item.Jmeno);//stejně všechny osoby mají vlastnost jméno

                //sice zde může být schovaný učitel, ale já přistupuji jako o obecné osobě a ta to nezná
                //navíc by zde mohl být schovaný i student, který funkci nezná
                //item.PolozOtazku();
            }
        }
    }
}
