using System;
using System.Collections.Generic;

namespace SSP.Repository.Payee;

public partial class BusinessEmployee1
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public bool EmpployeeStatus { get; set; }

    public string Designation { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public virtual Business Business { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
