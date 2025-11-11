using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPriklad
{
    //samostatný datový typ
    //nemá nic společného s třídou - leží mimo závorky class
    enum EdnyVTydnu
    {
        None = 0,
        Pondeli,
        Utery,
        Streda,
        Ctvrtek,
        Patek
    }

    //hodnoty v Enum jsou v základu číslované od nuly, ale mohu si je přečíslovat...pozor na dvě shodná číslování
    //pokud u něčeho hodnotu nezadám, číslování bude pokračovat dle posledního, což znamená, že může vzniknout opět dvojí číslování
    /*enum EdnyVTydnu
    {
        None = 30,
        Pondeli = 29,
        Utery, //zde bude automaticky 30, což je problém
        Streda = 50,
        Ctvrtek = 30,//není chyba ale už zde mám opakovaně číslo 30, což bude dělat problém
        Patek//zde bude další v řadě, takže 31
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //chová se jako statická třída
            int i = 6;
            EdnyVTydnu mujDen = EdnyVTydnu.Pondeli;

            //uživatel zadá den, ale ten vstupuje jako string
            //i když vypadá stejně jako enum, jsou to dva rozdílné datové typy

            //na vstupu je např 'abc',
            //spadne to, protože taková hodnota neexistuje a funkce Parse spadne
            //dnyVTydnu denOdUzivatele = (dnyVTydnu)Enum.Parse(typeof(dnyVTydnu), Console.ReadLine());
            EdnyVTydnu vystupOdUzivatele;
            
            Console.WriteLine("Napište den v týdnu bez diakritiky");
            //pokud TryParse nenalezne, vrací hodnotu 0, což může být první prvek v seznamu, pokud nemám přečíslováno
            Enum.TryParse<EdnyVTydnu>(Console.ReadLine(),true, out vystupOdUzivatele);//na vstupu je např 'Streda',
            
            if (vystupOdUzivatele == EdnyVTydnu.Streda)
            {
                Console.WriteLine("ano, je to středa");
            }
            else
            {
                Console.WriteLine("Jiný den nebo špatná hodnota");
            }

            //na vstupu je číselná hodnota např. 5
            //Enum je implicitně indexovaný, takže ví, že pod 5 je schovaná hodnota Pátek
            //Pokud zadám nějaké číslo, které není v seznamu, vrátí to jen toto číslo a nenalezne to k tomu enum, nic se nestane, resp. zde to skočí do else
            Console.WriteLine("Napište číslo dne v týdnu");
            int cisloOdUzivatele = Int32.Parse(Console.ReadLine());
            EdnyVTydnu enumOdUzivatele = (EdnyVTydnu)cisloOdUzivatele;
            if (enumOdUzivatele == EdnyVTydnu.Patek)
            {
                Console.WriteLine("ano, je to pátek");
            }
            else
            {
                Console.WriteLine("Jiný den nebo špatná hodnota");
            }

            //Enum lze jednoduše převést na string
            Console.WriteLine(EdnyVTydnu.Utery.ToString());
        }
    }
}
