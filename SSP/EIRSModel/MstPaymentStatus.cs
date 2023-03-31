using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class MstPaymentStatus
{
    public int PaymentStatusId { get; set; }

    public string? PaymentStatusName { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<MapAssessmentAssessmentItem> MapAssessmentAssessmentItems { get; } = new List<MapAssessmentAssessmentItem>();
}
