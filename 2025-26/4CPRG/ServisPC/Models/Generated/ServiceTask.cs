using System;
using System.Collections.Generic;

namespace ServisPC;

public partial class ServiceTask
{
    public int ServiceTaskId { get; set; }

    public string Name { get; set; } = null!;

    public double EstimatedHours { get; set; }

    public double Price { get; set; }

    public int SpecialistCharge { get; set; }
}
