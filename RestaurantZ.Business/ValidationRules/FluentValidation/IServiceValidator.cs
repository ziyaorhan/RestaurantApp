using FluentValidation;
using RestaurantZ.Entities.Abstract;

namespace RestaurantZ.Business.ValidationRules.FluentValidation
{
    //breakfast, lunch, dinner ve nightMale sınıfları IService implemente edilerek  oluşturulduğundan sadece IService için validator yazıldı. 
    public class IServiceValidator : AbstractValidator<IService>
    {
        public IServiceValidator()
        {
            RuleFor(s => s.NumberOfPerson)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .GreaterThanOrEqualTo(1).WithMessage(RuleMessages.GreaterThanOrEqualTo(1));

            RuleFor(s => s.ExtraPrice)
                
                     .GreaterThanOrEqualTo(0).WithMessage(RuleMessages.GreaterThanOrEqualTo(0));
            RuleFor(s => s.CustomerId)
                .NotEmpty().WithMessage(RuleMessages.NotEmty);
            RuleFor(s => s.Description)
                .MaximumLength(100).WithMessage(RuleMessages.MaxLength(100));
        }
    }
}
