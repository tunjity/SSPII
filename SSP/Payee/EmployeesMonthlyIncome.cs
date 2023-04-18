using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.Payee;

public partial class EmployeesMonthlyIncome
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public int CompanyId { get; set; }

    public string Basic { get; set; } = null!;

    public decimal Rent { get; set; }

    public string Transport { get; set; } = null!;

    public string Ltg { get; set; } = null!;

    public decimal Utility { get; set; }

    public decimal Meal { get; set; }
 
    


    public string Others { get; set; } = null!;

    public string Nhf { get; set; } = null!;

    public string Nhis { get; set; } = null!;

    public decimal Pension { get; set; }

    public decimal LifeAssurance { get; set; }

    public virtual Business Business { get; set; } = null!;

    public virtual CompanyListApi Company { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual EmployeesMonthlySchedule? EmployeesMonthlySchedule { get; set; }
}
