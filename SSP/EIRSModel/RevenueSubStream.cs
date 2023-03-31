using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class RevenueSubStream
{
    public int RevenueSubStreamId { get; set; }

    public int? RevenueStreamId { get; set; }

    public string? RevenueSubStreamName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AssessmentItem> AssessmentItems { get; } = new List<AssessmentItem>();

    public virtual ICollection<MdaServiceItem> MdaServiceItems { get; } = new List<MdaServiceItem>();

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount>();

    public virtual RevenueStream? RevenueStream { get; set; }
}
