using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class UpdateProductValidator : AbstractValidator<Product>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .Length(3, 50);

            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);


            RuleFor(x => x.SupplierId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Price)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Unit)
                .NotEmpty()
                .NotNull();
        }
    }
}
