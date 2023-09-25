using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class Lgaclass
{
    public int LgaclassId { get; set; }

    public string? LgaclassName { get; set; }

    public virtual ICollection<Lga> Lgas { get; } = new List<Lga>();
}
