using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class CreateEmployeeValidator : AbstractValidator<Employee>
    {
        public CreateEmployeeValidator()
        {
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
