﻿using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class PaymentFrequency
{
    public int PaymentFrequencyId { get; set; }

    public string? PaymentFrequencyName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentRule> AssessmentRules { get; } = new List<AssessmentRule>();

    public virtual ICollection<MdaService> MdaServices { get; } = new List<MdaService>();
}
