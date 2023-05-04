﻿using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class AgencyType
{
    public int AgencyId { get; set; }

    public int AgencyCreateBy { get; set; }

    public DateTime AgencyCreateAt { get; set; }

    public string AgencyType1 { get; set; } = null!;

    public string AgencyStatus { get; set; } = null!;
}
