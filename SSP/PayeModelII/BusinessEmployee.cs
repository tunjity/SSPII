using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.PayeModelII;

public partial class BusinessEmployee
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? BusinessId { get; set; }

    public string? FirstName { get; set; }

    public string? OtherName { get; set; }

    public string? Surname { get; set; }

    public string? EmployeeStatus { get; set; }

    //[NotMapped]
    //public string? FullName => $"{FirstName} {OtherName} {Surname}";
    public string? Designation { get; set; }

    public DateTime? StartDate { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? EmployerRin { get; set; }

    public string? AssetRin { get; set; }

    public string? EmployeeRin { get; set; }
}
public partial class BusinessEmployeeViewModel
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? BusinessId { get; set; }

    public string? FirstName { get; set; }

    public string? OtherName { get; set; }

    public string? Surname { get; set; }

    public string? EmployeeStatus { get; set; }

    public string? FullName => $"{FirstName} {OtherName} {Surname}";
    public string? Designation { get; set; }

    public DateTime? StartDate { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? EmployerRin { get; set; }

    public string? AssetRin { get; set; }

    public string? EmployeeRin { get; set; }
}
