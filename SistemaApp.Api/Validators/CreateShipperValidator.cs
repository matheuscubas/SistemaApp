using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class CreateShipperValidator : AbstractValidator<Shipper>
    {
        public CreateShipperValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .Length(3, 120);

            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotNull()
                .Length(8, 20);
        }
    }
}
