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
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .MaximumLength(25).WithMessage(MyMessages.MaxLength(25));
            RuleFor(p => p.Surname)
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .MaximumLength(25).WithMessage(MyMessages.MaxLength(25));
            RuleFor(p => p.Phone)
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .Length(14).WithMessage(MyMessages.Phone);
            RuleFor(p => p.Mail)
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .EmailAddress().WithMessage(MyMessages.EMail);
            RuleFor(p => p.UserName)
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .MaximumLength(25).WithMessage(MyMessages.MaxLength(25));
            RuleFor(p => p.Password)
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .MinimumLength(8).WithMessage(MyMessages.MinLength(8))
                .Must(ConfirmPwd).WithMessage(MyMessages.Password);
            RuleFor(p => p.IsActive)
                .NotEmpty().WithMessage(MyMessages.NotEmty);
            RuleFor(p => p.SyncId)
                .NotEmpty().WithMessage(MyMessages.NotEmty)
                .Length(36).WithMessage(MyMessages.Length(36));
            RuleFor(p => p.Role)
                .NotEmpty().WithMessage(MyMessages.NotEmty);
            RuleFor(p => p.TransactionDate)
                .NotEmpty().WithMessage(MyMessages.NotEmty);
        }
        //Parola için yazılan kurallar MyCustomRules'tan çekildi.
        private bool ConfirmPwd(string arg) => MyCustomRules.RuleForPassword(arg);
        //Bu metot aşağıdaki ile aynı.Aşağıdaki blok tipinde, bu ise expression.
        //private bool ConfirmPwd(string arg)
        //{
        //    return MyCustomRules.RuleForPassword(arg);
        //}

    }
}
