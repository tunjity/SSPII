using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace SSP.Repository.Models.CreationModel
{
    public class SignIn
    {
        public string UserType { get; set; }
        public string PhoneNumber_RIN { get; set; }
        public string Password { get; set; }
    }

    public class SignInValidator : AbstractValidator<SignIn>
    {
        public SignInValidator()
        {
            RuleFor(x => x.UserType).NotEmpty();
            RuleFor(x => x.UserType).MaximumLength(20);
            RuleFor(x => x.PhoneNumber_RIN).NotEmpty();
            RuleFor(x => x.PhoneNumber_RIN).MaximumLength(15);
            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(6);
        }
    }
    public class ForgetPassword
    {

        [Required(ErrorMessage = "Please enter PhoneNumber or RIN")]
        [Display(Name = "PhoneNumber or RIN")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
