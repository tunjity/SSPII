using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class BusinessOperation
{
    public int BusinessOperationId { get; set; }

    public string? BusinessOperationName { get; set; }

    public int? BusinessTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual BusinessType? BusinessType { get; set; }

    public virtual ICollection<Business> Businesses { get; } = new List<Business>();
}
