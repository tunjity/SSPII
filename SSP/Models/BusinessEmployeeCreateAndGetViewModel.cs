using Microsoft.EntityFrameworkCore;
using SSP.Models.CreationModel;
using SSP.PayeModelII;
using System.ComponentModel.DataAnnotations;

namespace SSP.Models
{
    public class BusinessEmployeeCreateAndGetViewModel
    {
        public EmployeeBusinessFilter employeeBusinessFilter { get; set; }
        public IEnumerable<EmployeesMonthlyIncome> empList { get; set; }
    }

    public class CreateSingleEmployeeModel
    {
        [Key]
        public int Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string BVN { get; set; }
        public string TIN { get; set; }
        public string RIN { get; set; }
        public string NIN { get; set; }
        public string LGA { get; set; }
        public string Designation { get; set; }
        public string ZipCode { get; set; }
        public double BasicIncome { get; set; }
        public double Rent { get; set; }
        public double Transport { get; set; }
        public double OtherIncome { get; set; }
        public double TotalIncome { get; set; }
        public double Pension { get; set; }
        public double NHF { get; set; }
        public double NHIS { get; set; }
        public double LifeAssurance { get; set; }
        public int StartMonth { get; set; }
        public string Nationality { get; set; } 
    }
    public class ExcelModel
    {
        public string title { get; set; }
        public string employee_tin { get; set; }
        public string employer_name { get; set; }
        public string annual_basic { get; set; }
        public string annual_rent { get; set; }
        public string annual_transport { get; set; }
        public string annual_utility { get; set; }
        public string annual_meal { get; set; }
        public string other_allowances_annual { get; set; }
        public string leave_transport_grant_annual { get; set; }
        public string pension_contribution_declared { get; set; }
        public string nhf_contribution_declared { get; set; }
        public string nhis_contribution_declared { get; set; }
        public string assessment_year { get; set; }
        public string employee_phone { get; set; }
        public string employer_address { get; set; }
        public string employer_rin { get; set; }
        public string start_month { get; set; }
        public string end_month { get; set; }
        public string nationality { get; set; }
        public string first_name { get; set; }
        public string surname { get; set; }
        public string middle_name { get; set; }
        public string employee_rin { get; set; }
    }
}
