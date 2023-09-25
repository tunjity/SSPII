using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class EmployeeAnnualTax
{
    public string? EmployeeRin { get; set; }

    public string? AssessmentYear { get; set; }

    public decimal? AnnualTax { get; set; }
}
