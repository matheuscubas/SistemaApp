using FluentValidation;
using SistemaApp.Core.Models;

namespace SistemaApp.Api.Validators
{
    public class UpdateShipperValidator : AbstractValidator<Shipper>
    {
        public UpdateShipperValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(3, 100);

            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotNull()
                .Length(8, 20);
        }
    }
}
