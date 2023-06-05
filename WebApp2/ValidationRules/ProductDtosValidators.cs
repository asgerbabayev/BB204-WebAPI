using FluentValidation;
using WebApp2.DTO_s.ProductDto_s;

namespace WebApp2.ValidationRules;

public class ProductDtosValidators : AbstractValidator<ProductPostDto>
{
    public ProductDtosValidators()
    {
        RuleFor(x => x.Name).NotNull()
            .NotEmpty()
            .WithMessage("Mehsul adi bosh kecilemez")
            .MaximumLength(200);
        RuleFor(x => x.Price).NotEmpty().NotNull();
    }
}
