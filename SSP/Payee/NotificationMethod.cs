﻿using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class NotificationMethod
{
    public int NotemId { get; set; }

    public int NotemCreateBy { get; set; }

    public DateTime NotemCreateAt { get; set; }

    public string NotificationMethod1 { get; set; } = null!;
}
