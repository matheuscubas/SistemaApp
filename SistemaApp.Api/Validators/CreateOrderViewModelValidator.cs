using FluentValidation;
using SistemaApp.Api.ViewModels;

namespace SistemaApp.Api.Validators
{
    public class CreateOrderViewModelValidator : AbstractValidator<CreateOrderViewModel>
    {
        public CreateOrderViewModelValidator()
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
                .GreaterThan(0)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
