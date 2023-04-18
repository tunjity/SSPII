using System;
using System.Collections.Generic;

namespace SSP.Payee;

public partial class Business
{
    public int Id { get; set; }

    public int BusinessId { get; set; }

    public string BusinessName { get; set; } = null!;

    public virtual ICollection<BusinessEmployee1> BusinessEmployee1s { get; } = new List<BusinessEmployee1>();

    public virtual ICollection<EmployeesMonthlyIncome> EmployeesMonthlyIncomes { get; } = new List<EmployeesMonthlyIncome>();
}
