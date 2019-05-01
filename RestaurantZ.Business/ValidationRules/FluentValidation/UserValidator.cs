using FluentValidation;
using RestaurantZ.Entities.Concrete;
using System;

namespace RestaurantZ.Business.ValidationRules.FluentValidation
{
    //RestaurantZ.Entities.Concrete içerisindeki User Class'ı için validasyon kuralları
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(12).WithMessage(RuleMessages.MaxLength(25));
            RuleFor(p => p.Surname)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(25).WithMessage(RuleMessages.MaxLength(25));
            RuleFor(p => p.Phone)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .Length(14).WithMessage(RuleMessages.Phone);
            RuleFor(p => p.Mail)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .EmailAddress().WithMessage(RuleMessages.EMail);
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(25).WithMessage(RuleMessages.MaxLength(25));
            RuleFor(p => p.Password)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MinimumLength(8).WithMessage(RuleMessages.MinLength(8))
                .Must(ConfirmPwd).WithMessage(RuleMessages.Password);
            RuleFor(p => p.IsActive)
                .NotEmpty().WithMessage(RuleMessages.NotEmty);
            RuleFor(p => p.SyncId)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .Length(36).WithMessage(RuleMessages.Length(36));
            RuleFor(p => p.Role)
                .NotEmpty().WithMessage(RuleMessages.NotEmty);
            RuleFor(p => p.TransactionDate)
                .NotEmpty().WithMessage(RuleMessages.NotEmty);
        }
        //Parola için yazılan kurallar MyCustomRules'tan çekildi.
        private bool ConfirmPwd(string arg) => CustomRules.RuleForPassword(arg);
        //Bu metot aşağıdaki ile aynı.Aşağıdaki blok tipinde, bu ise expression.
        //private bool ConfirmPwd(string arg)
        //{
        //    return MyCustomRules.RuleForPassword(arg);
        //}

    }
}
