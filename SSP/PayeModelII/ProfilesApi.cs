﻿using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class ProfilesApi
{
    public long ProfileId { get; set; }

    public string ProfileReferenceNo { get; set; } = null!;

    public string ProfileDescription { get; set; } = null!;
}
