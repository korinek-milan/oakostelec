using System;
using System.Collections.Generic;

namespace CokoladaEF;

public partial class ChocolateType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CocoaBeans { get; set; }

    public int Sugar { get; set; }

    public int Milk { get; set; }

    public int CocoaButter { get; set; }

    public int Vanilla { get; set; }
}
