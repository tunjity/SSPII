﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class ApiJsonStr
{
    public int? Id { get; set; }

    public string? Json { get; set; }

    public string? Type { get; set; }

    public DateTime? CreatedOn { get; set; }
}
