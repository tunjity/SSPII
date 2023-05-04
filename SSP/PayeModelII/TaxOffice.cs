﻿using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class TaxOffice
{
    public int ToId { get; set; }

    public int ToCreateBy { get; set; }

    public DateTime ToCreateAt { get; set; }

    public string TaxOffice1 { get; set; } = null!;

    public string TaStatus { get; set; } = null!;
}
