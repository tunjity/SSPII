using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.Repository.Payee;

public partial class Employee
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    [NotMapped]
    public string Fullname => $"{FirstName} {MiddleName} {LastName}";
    public string EmployeeRin { get; set; } = null!;

    public string IndividualId { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string TaxOffice { get; set; } = null!;

    public byte[] EmailAddress { get; set; } = null!;

    public virtual BusinessEmployee1? BusinessEmployee1 { get; set; }

    public virtual EmployeesMonthlyIncome? EmployeesMonthlyIncome { get; set; }
}
