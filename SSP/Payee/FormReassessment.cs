using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class FormReassessment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int BusinessId { get; set; }

    public decimal SumMonthlyassessment { get; set; }

    public decimal Formassessment { get; set; }

    public DateTime TaxYear { get; set; }

    public string UnderAssessment { get; set; } = null!;

    public decimal Penalty { get; set; }

    public decimal Interest { get; set; }

    public decimal TotalReassessment { get; set; }
}
