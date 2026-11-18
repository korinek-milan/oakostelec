using System.Threading.Channels;

namespace PoleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Karel";
            string jmeno2 = "Honza";

            //pole se vytváří stejně jako normální proměnná
            //RAlt + F, RAlt+G []
            string[] poleJmen = new string[10];//u pole musím říct kolik je položek
            poleJmen[0] = "Jirka";
            poleJmen[6] = "Jonáš";

            Console.WriteLine(poleJmen);//neumí tímto způsobem vypsat všechny položky, tak jen vypíše datový typ dané proměnné - string[]
            Console.WriteLine(poleJmen[6]);

            //Console.WriteLine(poleJmen[50]);//index mimo pole, aplikace šahá, kam nemá a spadne


            //můžu hned při vytváření naplnit hodnoty do složených závorek - tím se samo doplní počet položek
            int[] sudaCislaDoDeseti = new int[] {2,4,6,8,10 };
            Console.WriteLine(sudaCislaDoDeseti[4]);

            //posílám do funkce celé pole
            funkceNaVypisVsechHodnotVPoli(poleJmen);



            //List
            List<int> listCisel = new List<int>();
            listCisel.Add(42);
            listCisel.Add(11);
            listCisel.Add(9);

            //odebere položku podle hodnoty a přeskládá indexy
            listCisel.Remove(11);

            //odebere položku na daném indexu
            //listCisel.RemoveAt(0);

            //stejně jako pole, jsou zde indexy
            Console.WriteLine(listCisel[0]);

            //stejně jako u pole, pokud šáhnu do paměti kam nemám, spadne mi aplikace na chybu
            //Console.WriteLine(listCisel[50]);


            funkceSForeachCyklem(listCisel);


        }

        static void funkceNaVypisVsechHodnotVPoli(string[] x)//datový typ pole je včetně hranatých závorek
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        static void funkceNaVypisListuCisel(List<int> x)
        {
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        static void funkceSForeachCyklem(List<int> x)
        {
            foreach (int item in x)
            {
                Console.WriteLine(item);
            }
        }

    }
}
