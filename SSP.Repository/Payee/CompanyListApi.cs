using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class CompanyListApi
{
    public int? Id { get; set; }

    public long? TaxPayerId { get; set; }

    public int? TaxPayerTypeId { get; set; }

    public string? TaxPayerTypeName { get; set; }

    public string? TaxPayerName { get; set; }

    public string? TaxPayerRin { get; set; }

    public string? MobileNumber { get; set; }

    public string? ContactAddress { get; set; }

    public string? EmailAddress { get; set; }

    public string? Tin { get; set; }

    public string? TaxOffice { get; set; }

    public int CompanyListId { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ApiId { get; set; }

    public virtual ICollection<EmployeesMonthlyIncome> EmployeesMonthlyIncomes { get; } = new List<EmployeesMonthlyIncome>();

    public virtual ICollection<EmployeesMonthlySchedule> EmployeesMonthlySchedules { get; } = new List<EmployeesMonthlySchedule>();
}
