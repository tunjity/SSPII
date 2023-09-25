﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class DealerType
{
    public int DealerTypeId { get; set; }

    public string? DealerTypeName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
