using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.PayeModelII;

public partial class Employee
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string EmployeeRin { get; set; } = null!;

    public string IndividualId { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string TaxOffice { get; set; } = null!;

    public string? EmailAddress { get; set; }
    [NotMapped]
    public virtual BusinessEmployee? BusinessEmployee { get; set; }
[NotMapped]
    public virtual EmployeesMonthlyIncome? EmployeesMonthlyIncome { get; set; }
}
