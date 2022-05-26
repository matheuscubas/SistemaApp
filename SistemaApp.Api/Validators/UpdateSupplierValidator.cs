using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class UpdateSupplierValidator : AbstractValidator<Supplier>
    {
        public UpdateSupplierValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotEmpty()
                .Length(3, 80);

            RuleFor(x => x.ContactName)
                .NotEmpty()
                .NotEmpty()
                .Length(3, 120);

            RuleFor(x => x.Address)
                .NotEmpty()
                .NotEmpty()
                .Length(3, 120);

            RuleFor(x => x.City)
                .NotEmpty()
                .NotEmpty()
                .Length(3, 80);

            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .NotEmpty()
                .Length(5, 20);

            RuleFor(x => x.Country)
                .NotEmpty()
                .NotEmpty()
                .Length(3, 80);

            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotEmpty()
                .Length(8, 20);
        }
    }
}
