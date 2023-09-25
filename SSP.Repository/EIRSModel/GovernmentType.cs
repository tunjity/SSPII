using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class GovernmentType
{
    public int GovernmentTypeId { get; set; }

    public string? GovernmentTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Government> Governments { get; } = new List<Government>();
}
