using System;
using System.Collections.Generic;

namespace RestaurantZ.Business.ValidationRules
{
    //Normal Exception'dan farklı olarak, 
    //public List<MessagesAndProperties> ExceptionDetails { get; private set; } property'sine sahip.
    //Bu property verilen model türünde bir listeyi de exception ile götürür.(throw ile)
    //Burdan gönderilen liste UI tarafındaki try catch ile yakalanıp kullanılabilir.
    public class CustomExceptionForValidation : Exception
    {
        public CustomExceptionForValidation(List<MessagesAndProperties> validationExceptionDetails)
        {
            this.ExceptionDetails = validationExceptionDetails;
        }

        public List<MessagesAndProperties> ExceptionDetails { get; private set; }
    }
 
    // Bu model validasyon sonucu oluşan hataların property isimlerini ve o propertylerde oluşan hataların stringlerinin bir listesini throw ile fırlatabilmek için yazıldı.
    public class MessagesAndProperties
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
