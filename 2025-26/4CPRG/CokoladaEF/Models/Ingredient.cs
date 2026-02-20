using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokoladaEF.Models
{
    //musí být partial, což mi říká, ještě někde je jiná část, která popisuje tuto třídu
    public partial class Ingredient
    {
        //Moje funkce, která je součástí vygenerované třídy, ale zde se mi nesmaže
        public string vratIngredience()
        {
            return $"Ingredience: {Ingredient1} má množství {Amount}";
        }
    }
}
