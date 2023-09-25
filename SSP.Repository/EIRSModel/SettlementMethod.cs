using System;
using System.Collections.Generic;

namespace SSP.Repository.EIRSModel;

public partial class SettlementMethod
{
    public int SettlementMethodId { get; set; }

    public string? SettlementMethodName { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapAssessmentRuleSettlementMethod> MapAssessmentRuleSettlementMethods { get; } = new List<MapAssessmentRuleSettlementMethod>();

    public virtual ICollection<MapMdaserviceSettlementMethod> MapMdaserviceSettlementMethods { get; } = new List<MapMdaserviceSettlementMethod>();

    public virtual ICollection<PaymentAccount> PaymentAccounts { get; } = new List<PaymentAccount>();

    public virtual ICollection<Settlement> Settlements { get; } = new List<Settlement>();
}
