using System;
using System.Collections.Generic;

namespace SSP.EIRSModel;

public partial class AssessmentRule
{
    public int AssessmentRuleId { get; set; }

    public string? AssessmentRuleCode { get; set; }

    public int? ProfileId { get; set; }

    public string? AssessmentRuleName { get; set; }

    public int? RuleRunId { get; set; }

    public int? PaymentFrequencyId { get; set; }

    public decimal? AssessmentAmount { get; set; }

    public int? TaxYear { get; set; }

    public int? TaxMonth { get; set; }

    public int? PaymentOptionId { get; set; }

    public bool? Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<MapAssessmentRuleAssessmentItem> MapAssessmentRuleAssessmentItems { get; } = new List<MapAssessmentRuleAssessmentItem>();

    public virtual ICollection<MapAssessmentRuleSettlementMethod> MapAssessmentRuleSettlementMethods { get; } = new List<MapAssessmentRuleSettlementMethod>();

    public virtual PaymentFrequency? PaymentFrequency { get; set; }

    public virtual PaymentOption? PaymentOption { get; set; }

    public virtual ProfilesBkp? Profile { get; set; }

    public virtual MstRuleRun? RuleRun { get; set; }
}
