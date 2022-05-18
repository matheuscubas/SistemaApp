using FluentValidation;
using SistemaApp.Api.ViewModels;

namespace SistemaApp.Api.Validators
{
    public class CreateOrderViewModelValidator : AbstractValidator<CreateOrderViewModel>
    {
        public CreateOrderViewModelValidator()
        {
            //EmployeeId Validation
            RuleFor(x => x.EmployeeId)
                .NotNull();

            //ProductId Validation
            RuleFor(x => x.ProductId)
                .NotNull();

            //ShipperId Validation
            RuleFor(x => x.ShipperId)
                .NotNull();

            //Quantity
            RuleFor(x => x.Quantity)
                .GreaterThan(0);
        }
    }
}
