using FluentValidation;
using SistemaApp.Core.Dtos;

namespace SistemaApp.Api.Validators
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerDto>
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .Length(3, 50);

            RuleFor(x => x.ContactName)
                .NotEmpty()
                .NotNull()
                .Length(3, 50);

            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .NotNull()
                .MaximumLength(12);
        }
    }
}
