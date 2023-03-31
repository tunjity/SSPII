﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class EmDataSource
{
    public int DataSourceId { get; set; }

    public string? DataSourceName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
