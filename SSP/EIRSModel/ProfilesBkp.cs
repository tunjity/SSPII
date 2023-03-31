using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class ProfilesBkp
{
    public int ProfileId { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string? ProfileDescription { get; set; }

    public int? AssetTypeStatus { get; set; }

    public int? AssetTypeId { get; set; }

    public int? ProfileTypeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentRule> AssessmentRules { get; } = new List<AssessmentRule>();

    public virtual AssetType? AssetType { get; set; }

    public virtual ICollection<MapTaxPayerAssetProfile> MapTaxPayerAssetProfiles { get; } = new List<MapTaxPayerAssetProfile>();

    public virtual ICollection<ProfileAttribute> ProfileAttributes { get; } = new List<ProfileAttribute>();

    public virtual ICollection<ProfileGroup> ProfileGroups { get; } = new List<ProfileGroup>();

    public virtual ICollection<ProfileSectorElement> ProfileSectorElements { get; } = new List<ProfileSectorElement>();

    public virtual ICollection<ProfileSectorSubElement> ProfileSectorSubElements { get; } = new List<ProfileSectorSubElement>();

    public virtual ICollection<ProfileSector> ProfileSectors { get; } = new List<ProfileSector>();

    public virtual ICollection<ProfileSubAttribute> ProfileSubAttributes { get; } = new List<ProfileSubAttribute>();

    public virtual ICollection<ProfileSubGroup> ProfileSubGroups { get; } = new List<ProfileSubGroup>();

    public virtual ICollection<ProfileSubSector> ProfileSubSectors { get; } = new List<ProfileSubSector>();

    public virtual ICollection<ProfileTaxPayerRole> ProfileTaxPayerRoles { get; } = new List<ProfileTaxPayerRole>();

    public virtual ICollection<ProfileTaxPayerType> ProfileTaxPayerTypes { get; } = new List<ProfileTaxPayerType>();
}
