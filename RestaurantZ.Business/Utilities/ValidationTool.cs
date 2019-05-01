using FluentValidation;
using RestaurantZ.Business.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantZ.Business.Utilities
{

    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            var ex = new List<MessagesAndProperties>();
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ex.Add(new MessagesAndProperties
                    {
                        PropertyName = error.PropertyName,
                        ErrorMessage = error.ErrorMessage
                    });
                }
                throw new CustomExceptionForValidation(ex);
            }
        }
    }
}
