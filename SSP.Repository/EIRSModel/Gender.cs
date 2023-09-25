using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class Gender
{
    public int GenderId { get; set; }

    public string? GenderName { get; set; }

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();
}
