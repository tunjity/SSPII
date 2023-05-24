using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.PayeModelII;

public partial class Business
{
    public int Id { get; set; }

    public int BusinessId { get; set; }

    public string BusinessName { get; set; } = null!;
    [NotMapped]
    public virtual ICollection<BusinessEmployee> BusinessEmployees { get; } = new List<BusinessEmployee>();

    public virtual ICollection<EmployeesMonthlyIncome> EmployeesMonthlyIncomes { get; } = new List<EmployeesMonthlyIncome>();
}
