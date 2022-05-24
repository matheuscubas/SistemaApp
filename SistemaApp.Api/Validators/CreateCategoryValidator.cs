using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class CreateCategoryValidator : AbstractValidator<Category>
    {
        public CreateCategoryValidator()
        {
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
