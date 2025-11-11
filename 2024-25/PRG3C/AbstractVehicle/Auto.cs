using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVehicle
{
    internal class Auto: Vozidlo
    {
        private static int pocetAut;

        public int PocetDveri;
        public Auto(int _PocetDveri, int _Rychlost, int _PocetKol, int _Zrychleni) : base(_Rychlost, _PocetKol, _Zrychleni)
        {
            PocetDveri = _PocetDveri;

            pocetAut++;
        
        }

        //statická metoda může pracovat pouze se statickými attributy
        public static int vypisMiPocetAut()
        {
            //statická metoda nevidí na nestatické attributy
            //return Rychlost
            return pocetAut;
        }

        //statická metoda nemusí vůbec používat statické attributy
        public static string infoOTride()
        {
            return "tato třída se stará o práci s autem o rychlosti";
        }

        public static string statickaMetodaSParametrem(int x)
        {
            return "tato třída pracuje se vstupním parametrem: " + x;
        }

        //pomoci klicoveho slova base rikam - zavolej puvodni metodu
        //zde: nejdriv mi dej to, co vraci puvodni metoda, nasledne k tomu prihod neco meho
        public override string vypisInfo()
        {
            return base.vypisInfo() + ", Počet dveří: " + this.PocetDveri.ToString();
        }

        public string specifickaMetodaProAuto()
        {
            return "specifický text pro auto";
        }

        //pokud bych tuto vynucenou metodu nemel, jedna se o chybu programu
        public override string vypisInfoZbytecnaVarianta()
        {
            return base.vypisInfo() + ", Počet dveří: " + this.PocetDveri.ToString();
            //return "Rychlost: " + this.Rychlost.ToString() + ", Pocet Kol: " + this.PocetKol.ToString() + ", Zrychleni: " + this.Zrychleni.ToString() + ", Počet dveří: " + this.PocetDveri.ToString();
        }
    }
}
