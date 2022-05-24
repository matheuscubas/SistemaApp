using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class UpdateCategoryValidator : AbstractValidator<Category>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .Length(5, 80);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .Length(5, 50);
        }
    }
}
