﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class BuildingCompletion
{
    public int BuildingCompletionId { get; set; }

    public string? BuildingCompletionName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Building> Buildings { get; } = new List<Building>();
}
