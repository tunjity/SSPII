﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MstTccrequestStatus
{
    public int StatusId { get; set; }

    public string? StatusName { get; set; }

    public bool? Active { get; set; }
}
