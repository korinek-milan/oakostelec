using System;
using System.Collections.Generic;

namespace CokoladaEF.Models;

public partial class Ingredient
{
    public int Id { get; set; }

    public string Ingredient1 { get; set; } = null!;

    public int Amount { get; set; }
}
