using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkazkaTrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jednoduchá proměnná -> datový typ, název = hodnota
            int x = 5;

            //složitější datový typ se vytváří stejně -> datový typ (Název třídy), název proměnné = hodnota (zde klíčové slovo new + Název třídy a závorky)
            //s1 je složitější proměnná - struktura (krabička), která obsahuje spousta dalších proměnných
            Student s1 = new Student();
            Student s2 = new Student();

            Predmet p1 = new Predmet();
            Predmet p2 = new Predmet();
            p1.Nazev = "ČJ";
            p2.Nazev = "MAT";

            //Přes tečku se "podívám dovnitř krabičky", zde chci uvnitř krabičky studenda s1 nastavit jeho jméno
            s1.Jmeno = "Karel";
            s1.RokNarozeni = 2025;

            s2.Jmeno = "Jirka";

            //podívám se do krabičky a chci nastavit studentovi s1 jeho oblíbený předmět, ale zde je datového typu Predmet
            //tzn. nemůžu naplnit hodnotu přímo, ale pouze mu dám odkaz (ukazatel) na už exisutjící instanci, zde p1
            s1.OblibenyPredmet = p1;

            //studentovi s1 jsem nastavil, že jeho neoblíbený přdmět ukazuje na předmět p2
            s1.NeoblibenyPredmet = p2;

            //student s2, ukazuje na stejný předmět p2, ale tentokrát je to jeho oblíbený předmět
            //oba studenti ukazují na stjený předmět, každý ale jiným ukazatelem (ukazatel má každý uložený v jiném atributu)
            s2.OblibenyPredmet = p2;

            //chci vypsat název oblíbeného předmětu studenta s1
            //pracuji se studentem s1
            //přes tečku se podívám dovnitř krabičky na oblíbený předmět
            //oblíbený předmět je ale opět krabička, tzn. do ní se musím znovu podívat přes tečku na název předmětu
            Console.WriteLine(s1.OblibenyPredmet.Nazev);

            //chci po studentovi s1, aby si spustil funkci InfoOStudentovi()
            s1.InfoOStudentovi();



            //s1.Uceni(2);
            //s1.Uceni(5);
            //s2.Uceni(1);

            


            //p1.vypisNazevPredmetu();
            //p2.vypisNazevPredmetu();

        }
    }

}
