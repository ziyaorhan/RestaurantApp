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
        //verilen validator'e göre verilen entity için validasyon yapar. eğer validasyon false ise CustomExceptionForValidation tipinde exception fırlatır.
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);//burdaki Validate FluentValidation'a ait.
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

        //Gelen exception listesinde(UI tarafındaki try-catch ile yakalanan) ilgili property için hataları döndürür.
        public static string GetExceptionsByProperty(List<MessagesAndProperties> exceptions, string propertyName)
        {
            string message = "";
            foreach (var exception in exceptions)
            {
                if (exception.PropertyName == propertyName)
                {
                    message += "-" + exception.ErrorMessage + Environment.NewLine;
                }
            }
            return message;
        }

        //Gelen exception listesinde(UI tarafındaki try-catch ile yakalanan) ilgili property için hatanın varlığını kontrol eden metot.
        public static bool IsThereAExceptionByProperty(List<MessagesAndProperties> exceptions, string propertyName)
        {
            if (exceptions != null)
            {
                foreach (var exception in exceptions)
                {
                    if (exception.PropertyName == propertyName)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
