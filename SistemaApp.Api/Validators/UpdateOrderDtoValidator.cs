using FluentValidation;
using SistemaApp.Core.Dtos;

namespace SistemaApp.Api.Validators
{
    public class UpdateOrderDtoValidator  : AbstractValidator<UpdateOrderDto>
    {
        public UpdateOrderDtoValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.ShipperId)
               .NotEmpty()
               .NotNull()
               .GreaterThan(0);

            RuleFor(x => x.ProductId)
               .NotEmpty()
               .NotNull()
               .GreaterThan(0);

            RuleFor(x => x.Quantity)
               .NotEmpty()
               .NotNull()
               .GreaterThan(0);
        }
    }
}
