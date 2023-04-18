using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class PaymentOption
{
    public int PaymentId { get; set; }

    public int PaymentCreateBy { get; set; }

    public DateTime PaymentCreateAt { get; set; }

    public string PaymentOption1 { get; set; } = null!;

    public string PaymentStatus { get; set; } = null!;
}
