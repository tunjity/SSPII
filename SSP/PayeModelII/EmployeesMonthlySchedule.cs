using System;
using System.Collections.Generic;

namespace SSP.PayeModelII;

public partial class EmployeesMonthlySchedule
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int BusinessId { get; set; }

    public int CompanyId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int StatusId { get; set; }

    public double Basic { get; set; }

    public double Rent { get; set; }

    public double Transport { get; set; }

    public double Ltg { get; set; }

    public double Others { get; set; }

    public double TotalIncome { get; set; }

    public double Nhf { get; set; }

    public double Nhis { get; set; }

    public double Pension { get; set; }

    public double GrossIncome { get; set; }

    public double Cra { get; set; }

    public double TaxFreePay { get; set; }

    public double ChargableIncome { get; set; }

    public double Tax { get; set; }

    public virtual CompanyListApi Company { get; set; } = null!;

    public virtual EmployeesMonthlyIncome Employee { get; set; } = null!;
}
