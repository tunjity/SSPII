using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class LandPurpose
{
    public int LandPurposeId { get; set; }

    public string? LandPurposeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<LandFunction> LandFunctions { get; } = new List<LandFunction>();

    public virtual ICollection<Land> Lands { get; } = new List<Land>();
}
