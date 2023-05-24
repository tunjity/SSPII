using System.ComponentModel.DataAnnotations;

namespace SSP.Models.CreationModel
{
    public class CompanyFormModel
    {
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        [StringLength(14, MinimumLength = 13)]
        public string? MobileNumber1orRIN { get; set; }
    }
    public class CompanyStepOne
    {

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
        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Enter your Confirm password")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string? ConfirmPassword { get; set; }
        public int? VerificationOtp { get; set; }
    }
}
