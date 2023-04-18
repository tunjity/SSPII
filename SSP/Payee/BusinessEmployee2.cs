using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class BusinessEmployee2
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public string FirstName { get; set; } = null!;

    public string OtherName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string EmployeeStatus { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string EmployerRin { get; set; } = null!;

    public string AssetRin { get; set; } = null!;

    public string EmployeeRin { get; set; } = null!;
}
