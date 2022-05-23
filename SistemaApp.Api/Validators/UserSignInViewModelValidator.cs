using FluentValidation;
using SistemaApp.Core.Dtos;

namespace SistemaApp.Api.Validators
{
    public class UserSignInViewModelValidator : AbstractValidator<CrateUserDto>
    {
        public UserSignInViewModelValidator()
        {
            RuleFor(x => x.Username)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3);

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(6)
                .MaximumLength(25);

            RuleFor(x => x.RoleId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}
