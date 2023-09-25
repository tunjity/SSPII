﻿using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class ProfileAttribute
{
    public int ProfileAttributeId { get; set; }

    public int? ProfileId { get; set; }

    public int? AttributeId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ProfilesBkp? Profile { get; set; }
}
