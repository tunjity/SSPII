﻿using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class Town
{
    public int TownId { get; set; }

    public int TownCreateBy { get; set; }

    public DateTime TownCreateAt { get; set; }

    public int Lga { get; set; }

    public string Towns { get; set; } = null!;

    public string TownStatus { get; set; } = null!;
}
