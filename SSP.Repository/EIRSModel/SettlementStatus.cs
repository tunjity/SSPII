using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class SettlementStatus
{
    public int SettlementStatusId { get; set; }

    public string? SettlementStatusName { get; set; }

    public string? StatusDescription { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount>();
}
