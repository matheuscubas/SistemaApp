using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class UpdateEmployeeValidator : AbstractValidator<Employee>
    {
        public UpdateEmployeeValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.FirstName)
                .NotNull()
                .NotEmpty()
                .Length(3, 50);

            RuleFor(x => x.LastName)
                .NotNull()
                .NotEmpty()
                .Length(3, 50);

            RuleFor(x => x.BirthDate)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Photo)
                .NotEmpty()
                .NotNull();
        }
    }
}
