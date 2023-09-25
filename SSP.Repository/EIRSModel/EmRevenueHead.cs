using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class EmRevenueHead
{
    public int RevenueHeadId { get; set; }

    public int? CategoryId { get; set; }

    public string? RevenueHeadName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual EmCategory? Category { get; set; }
}
