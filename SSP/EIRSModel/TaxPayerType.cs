using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class TaxPayerType
{
    public int TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<EconomicActivity> EconomicActivities { get; } = new List<EconomicActivity>();

    public virtual ICollection<Government> Governments { get; } = new List<Government>();

    public virtual ICollection<Individual> Individuals { get; } = new List<Individual>();

    public virtual ICollection<MapTaxPayerAsset> MapTaxPayerAssets { get; } = new List<MapTaxPayerAsset>();

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount>();

    public virtual ICollection<Special> Specials { get; } = new List<Special>();

    public virtual ICollection<TaxPayerRole> TaxPayerRoles { get; } = new List<TaxPayerRole>();
}
