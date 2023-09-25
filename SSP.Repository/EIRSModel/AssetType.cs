using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class AssetType
{
    public int AssetTypeId { get; set; }

    public string? AssetTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentGroup> AssessmentGroups { get; } = new List<AssessmentGroup>();

    public virtual ICollection<AssessmentItem> AssessmentItems { get; } = new List<AssessmentItem>();

    public virtual ICollection<Building> Buildings { get; } = new List<Building>();

    public virtual ICollection<Business> Businesses { get; } = new List<Business>();

    public virtual ICollection<Land> Lands { get; } = new List<Land>();

    public virtual ICollection<MapTaxPayerAsset> MapTaxPayerAssets { get; } = new List<MapTaxPayerAsset>();

    public virtual ICollection<Profile> Profiles { get; } = new List<Profile>();

    public virtual ICollection<ProfilesBkp> ProfilesBkps { get; } = new List<ProfilesBkp>();

    public virtual ICollection<TaxPayerRole> TaxPayerRoles { get; } = new List<TaxPayerRole>();

    public virtual ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
