﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class BusinessSector
{
    public int BusinessSectorId { get; set; }

    public string? BusinessSectorName { get; set; }

    public int? BusinessTypeId { get; set; }

    public int? BusinessCategoryId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual BusinessCategory? BusinessCategory { get; set; }

    public virtual ICollection<BusinessSubSector> BusinessSubSectors { get; } = new List<BusinessSubSector>();

    public virtual BusinessType? BusinessType { get; set; }

    public virtual ICollection<Business> Businesses { get; } = new List<Business>();
}
