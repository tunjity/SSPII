using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class FormReassessment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int BusinessId { get; set; }

    public double SumMonthlyassessment { get; set; }

    public double Formassessment { get; set; }

    public DateTime TaxYear { get; set; }

    public double UnderAssessment { get; set; }

    public double Penalty { get; set; }

    public double Interest { get; set; }

    public double TotalReassessment { get; set; }
}
