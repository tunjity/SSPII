﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class Directorate
{
    public int DirectorateId { get; set; }

    public string? DirectorateName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapDirectoratesRevenueStream> MapDirectoratesRevenueStreams { get; } = new List<MapDirectoratesRevenueStream>();
}
