using FluentValidation;
using FluentValidation.Validators;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace RestaurantZ.Business.ValidationRules.FluentValidation
{
    //RestaurantZ.Entities.Concrete içerisindeki User Class'ı için validasyon kuralları
    public class UserValidator : AbstractValidator<User>
    {
        private IUserDal _userDal;//unique kontrolü için istendi.
        private User _incomingUser;//unique kontrolü için istendi.
        public UserValidator(IUserDal userDal, User user)
        {
            _userDal = userDal;
            _incomingUser = user;
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(12).WithMessage(RuleMessages.MaxLength(25));
            RuleFor(u => u.Surname)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(25).WithMessage(RuleMessages.MaxLength(25));
            RuleFor(u => u.Phone)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .Length(14).WithMessage(RuleMessages.Phone);
            RuleFor(u => u.Mail)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .EmailAddress().WithMessage(RuleMessages.EMail)
                .Must(UniqueMail).WithMessage("Bu mail adresi başka bir kullanıcıya aittir. Farklı bir mail adresi giriniz.");
            RuleFor(u => u.UserName)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(25).WithMessage(RuleMessages.MaxLength(25))
                .Must(UniqueUserName).WithMessage("Bu kullanıcı adı kullanılmıştır. Farklı bir kullanıcı adı giriniz.");
            RuleFor(u => u.Password)
               // .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MinimumLength(5).WithMessage(RuleMessages.MinLength(5));
                //.Must(PasswordRules).WithMessage(RuleMessages.Password);
        }

        //Update işleminde daha önce var olan mail adresi yeni bir mail gibi algılanıyordu.
        //incoming userid kontrolü ile bu durum engellendi.(içteki if)
        private bool UniqueUserName(string arg)
        {
            if (!String.IsNullOrEmpty(arg))
            {
                var result = _userDal.GetAll(x => x.UserName == arg);
                if (result.Count >= 1)
                {
                    if (_incomingUser.UserId == result[0].UserId)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        //Update işleminde daha önce var olan mail adresi yeni bir mail gibi algılanıyordu.
        //incoming userid kontrolü ile bu durum engellendi.(içteki if)
        private bool UniqueMail(string arg)
        {
            if (!String.IsNullOrEmpty(arg))
            {
                var result = _userDal.GetAll(x => x.Mail == arg);
                if (result.Count >= 1)
                {
                    if (_incomingUser.UserId == result[0].UserId)
                    {
                        return true;//benzersiz
                    }
                    return false;//benzersiz değil
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
           
        }

        //private bool PasswordRules(string arg)
        //{
        //    bool isThereABigLeter = false;//büyük harf
        //    bool isThereASmallLeter = false;//küçük harf
        //    bool isThereANumericChar = false;//sayısal karakter
        //    bool isThereASymbolChar = false;//harf ya da rakam dışındaki karakterler.
        //    if (!String.IsNullOrEmpty(arg))
        //    {
        //        foreach (char item in arg)
        //        {
        //            if (Char.IsUpper(item))
        //            {
        //                isThereABigLeter = true;
        //            }
        //            if (Char.IsLower(item))
        //            {
        //                isThereASmallLeter = true;
        //            }
        //            if (Char.IsNumber(item))
        //            {
        //                isThereANumericChar = true;
        //            }
        //            if (!Char.IsLetterOrDigit(item))
        //            {
        //                isThereASymbolChar = true;
        //            }
        //        }
        //    }
        //    if (isThereABigLeter == true && isThereASmallLeter == true && isThereANumericChar == true && isThereASymbolChar == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
