﻿using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class TokenManagement
{
    public int Id { get; set; }

    public string? Token { get; set; }

    public string? CreatedAt { get; set; }

    public string? UpdatedAt { get; set; }
}
