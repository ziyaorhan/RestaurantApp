﻿
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.Business.Abstract
{
    public interface IJoinService
    {
        object GetAllForBreakfastFormDgv();
        object GetAllForBreakfastFormDgv(string customerName);
        //
        object GetAllForLunchFormDgv();
        object GetAllForLunchFormDgv(string customerName);
        //
        object GetAllForDinnerFormDgv();
        object GetAllForDinnerFormDgv(string customerName);
        //
        object GetAllForNightMaleFormDgv();
        object GetAllForNightMaleFormDgv(string customerName);
        object GetAllForMainDgv();
        object GetAllForMainDgv(string customerName);
        ModelForRecordCount GetRecordCount();
    }
}
