﻿using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class VwShowBusiness
{
    public string? BusinessRin { get; set; }

    public string? BusinessName { get; set; }

    public int? Totalcount { get; set; }

    public string? TaxYear { get; set; }

    public string? CompanyRin { get; set; }

    public int? Flag { get; set; }

    public string Status { get; set; } = null!;
}
