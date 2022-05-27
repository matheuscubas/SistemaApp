using FluentValidation;
using SistemaApp.Api.ViewModels;

namespace SistemaApp.Api.Validators
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderDto>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            //EmployeeId Validation
            RuleFor(x => x.EmployeeId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            //ProductId Validation
            RuleFor(x => x.ProductId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            //ShipperId Validation
            RuleFor(x => x.ShipperId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            //Quantity
            RuleFor(x => x.Quantity)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
