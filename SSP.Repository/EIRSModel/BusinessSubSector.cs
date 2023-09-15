using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class BusinessSubSector
{
    public int BusinessSubSectorId { get; set; }

    public string? BusinessSubSectorName { get; set; }

    public int? BusinessSectorId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual BusinessSector? BusinessSector { get; set; }

    public virtual ICollection<Business> Businesses { get; } = new List<Business>();
}
