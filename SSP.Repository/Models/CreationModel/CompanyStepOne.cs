using System.ComponentModel.DataAnnotations;

namespace SSP.Repository.Models.CreationModel
{
    public class CompanyStepOne
    {
        //[Required(ErrorMessage = "Please enter Company RIN")]
        //[Display(Name = "CompanyRin")]
        //[StringLength(12, MinimumLength = 7)]
        public string? CompanyRin { get; set; }
        [Required(ErrorMessage = "Please enter Company Name")]
        [Display(Name = "CompanyName")]
        [StringLength(140, MinimumLength = 5)]
        public string? CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        [StringLength(14, MinimumLength = 10)]
        public string? MobileNumber1 { get; set; }
        [Required(ErrorMessage = "Please enter Contact Address")]
        [Display(Name = "Contact Address")]
        public string? ContactAddress { get; set; }
    } 
    public class CompanyStepTwo
    {
        public int? CompanyId { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        public int? VerificationOtp { get; set; }
    }
}
