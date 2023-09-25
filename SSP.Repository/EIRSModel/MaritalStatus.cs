using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MaritalStatus
{
    public int MaritalStatusId { get; set; }

    public string? MaritalStatusName { get; set; }

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();
}
