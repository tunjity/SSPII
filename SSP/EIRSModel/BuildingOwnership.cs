﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class BuildingOwnership
{
    public int BuildingOwnershipId { get; set; }

    public string? BuildingOwnershipName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Building> Buildings { get; } = new List<Building>();
}
