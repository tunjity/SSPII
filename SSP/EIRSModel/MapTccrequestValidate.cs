﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MapTccrequestValidate
{
    public long Rvid { get; set; }

    public long? RequestId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TccRequest? Request { get; set; }
}
