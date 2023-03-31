using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class TaxOffice
{
    public int TaxOfficeId { get; set; }

    public string? TaxOfficeName { get; set; }

    public int? AddressTypeId { get; set; }

    public int? BuildingId { get; set; }

    public int? Approver1 { get; set; }

    public int? Approver2 { get; set; }

    public int? Approver3 { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual AddressType? AddressType { get; set; }

    public virtual Building? Building { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Government> Governments { get; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();

    public virtual ICollection<MapTaxOfficeTarget> MapTaxOfficeTargets { get; } = new List<MapTaxOfficeTarget>();

    public virtual ICollection<MapTaxOfficerTarget> MapTaxOfficerTargets { get; } = new List<MapTaxOfficerTarget>();

    public virtual ICollection<Special> Specials { get; } = new List<Special>();
}
