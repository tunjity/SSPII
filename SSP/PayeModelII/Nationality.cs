﻿using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class Nationality
{
    public int NationalityId { get; set; }

    public string? Country { get; set; }

    public string? CountryCode { get; set; }

    public string? Adjective { get; set; }
}
