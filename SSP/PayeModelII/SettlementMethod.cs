using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class SettlementMethod
{
    public int SettId { get; set; }

    public int? SettCreateBy { get; set; }

    public DateTime? SettCreateAt { get; set; }

    public string? SettlementMethod1 { get; set; }
}
