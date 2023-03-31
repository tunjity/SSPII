using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class Nationality
{
    public int NationalityId { get; set; }

    public string? NationalityName { get; set; }

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();
}
