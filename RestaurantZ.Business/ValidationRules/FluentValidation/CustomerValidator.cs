using FluentValidation;
using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        private ICustomerDal _customerDal;
        private Customer _incomingCustomer;
        public CustomerValidator(ICustomerDal customerDal, Customer incomingCustomer)
        {
            _customerDal = customerDal;
            _incomingCustomer = incomingCustomer;
            RuleFor(c => c.CustomerName)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .MaximumLength(75).WithMessage(RuleMessages.MaxLength(75))
                .Must(UniqueCustomerName).WithMessage("Bu firma adı kayıtlıdır. Farklı bir firma adı giriniz."); ;
            RuleFor(c => c.CustomerRepresentative)
                .NotEmpty().WithMessage(RuleMessages.NotEmty);
            RuleFor(c => c.Phone1)
                .NotEmpty().WithMessage(RuleMessages.NotEmty)
                .Length(14).WithMessage(RuleMessages.Phone);
            RuleFor(c => c.Mail)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress().When(c => c.Mail != string.Empty).WithMessage(RuleMessages.EMail)
                .Must(UniqueMail).WithMessage("Bu mail adresi başka bir müşteriye aittir. Farklı bir mail adresi giriniz.");
            RuleFor(c => c.BreakfastPrice).
                GreaterThanOrEqualTo(0).WithMessage(RuleMessages.GreaterThanOrEqualTo(0));
            RuleFor(c => c.LunchPrice).
                GreaterThanOrEqualTo(0).WithMessage(RuleMessages.GreaterThanOrEqualTo(0));
            RuleFor(c => c.DinnerPrice).
                GreaterThanOrEqualTo(0).WithMessage(RuleMessages.GreaterThanOrEqualTo(0));
            RuleFor(c => c.NightMalePrice).
                GreaterThanOrEqualTo(0).WithMessage(RuleMessages.GreaterThanOrEqualTo(0));
        }
        private bool UniqueMail(string arg)
        {
            if (!String.IsNullOrEmpty(arg))
            {
                var result = _customerDal.GetAll(x => x.Mail == arg);
                if (result.Count >= 1)
                {
                    if (_incomingCustomer.CustomerId == result[0].CustomerId)
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
        private bool UniqueCustomerName(string arg)
        {
            if (!String.IsNullOrEmpty(arg))
            {
                var result = _customerDal.GetAll(x => x.CustomerName.ToLower() == arg.ToLower());
                if (result.Count >= 1)
                {
                    if (_incomingCustomer.CustomerId == result[0].CustomerId)
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
    }
}
