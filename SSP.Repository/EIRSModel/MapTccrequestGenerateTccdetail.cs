﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class MapTccrequestGenerateTccdetail
{
    public long GtccdetailId { get; set; }

    public long? RequestId { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TccRequest? Request { get; set; }
}
