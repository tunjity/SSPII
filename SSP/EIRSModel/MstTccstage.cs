﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MstTccstage
{
    public int TccstageId { get; set; }

    public string? TccstageName { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }
}
