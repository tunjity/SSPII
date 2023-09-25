﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class BusinessOperation
{
    public int BsOpId { get; set; }

    public int BsOpCreateBy { get; set; }

    public DateTime BsOpCreateAt { get; set; }

    public int BusinessType { get; set; }

    public string BusinessOperations { get; set; } = null!;

    public string BsOpStatus { get; set; } = null!;
}
