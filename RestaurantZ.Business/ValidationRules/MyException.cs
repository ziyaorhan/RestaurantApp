using System;
using System.Collections.Generic;
using System.Linq;


namespace RestaurantZ.Business.ValidationRules
{
    //Normal Exception'dan farklı olarak, 
    //public List<MyExceptionModel> MyExceptions { get; private set; } property'sine sahip.
    // Bu class validasyon sonucu oluşan hataların property isimlerini ve o propertylerde oluşan hataların stringlerinin bir listesini throw ile fırlatabilmek için yazıldı.
    //Burdan gönderilen liste UI tarafındaki try catch ile yakalanıp propertyName'ine göre kullanılabilir.
    public class MyException : Exception
    {
        public MyException(List<MyExceptionModel> myException )
        {
            this.MyExceptions = myException;
        }
        public List<MyExceptionModel> MyExceptions { get; private set; }
    }

    //model
    public class MyExceptionModel
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
