using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSP.PayeModelII;

public partial class EmployeesMonthlyIncome
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public int CompanyId { get; set; }

    public double Basic { get; set; }

    public double Rent { get; set; }

    public double Transport { get; set; }

    public double Ltg { get; set; }

    public double Utility { get; set; }

    public double Meal { get; set; }

    public double Others { get; set; }

    public double Nhf { get; set; }

    public double Nhis { get; set; }

    public double Pension { get; set; }
    [NotMapped]
    public double TotalIncome { get; set; }
    [NotMapped]
    public double TotalRelief { get; set; }

    public double LifeAssurance { get; set; }
    [NotMapped]
    public virtual Business Business { get; set; } = null!;
    [NotMapped]
    public virtual CompanyListApi Company { get; set; } = null!;
    [NotMapped]
    public virtual Employee Employee { get; set; } = null!;
    [NotMapped]
    public virtual EmployeesMonthlySchedule? EmployeesMonthlySchedule { get; set; }
}
