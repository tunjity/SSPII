using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class BusinessType
{
    public int BusinessTypeId { get; set; }

    public string? BusinessTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<BusinessCategory> BusinessCategories { get; } = new List<BusinessCategory>();

    public virtual ICollection<BusinessOperation> BusinessOperations { get; } = new List<BusinessOperation>();

    public virtual ICollection<BusinessSector> BusinessSectors { get; } = new List<BusinessSector>();

    public virtual ICollection<BusinessStructure> BusinessStructures { get; } = new List<BusinessStructure>();

    public virtual ICollection<Business> Businesses { get; } = new List<Business>();
}
