﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class VwProfilePayePcMe
{
    public int ProfileId { get; set; }

    public string? ProfileReferenceNo { get; set; }

    public string? ProfileDescription { get; set; }

    public int? TaxPayerCount { get; set; }
}
