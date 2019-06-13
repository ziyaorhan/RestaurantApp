
using System;
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
        object GetDetailedReportByDate(DateTime firstDate, DateTime secondDate);
        object GetDetailedReportByDate(DateTime firstDate, DateTime secondDate, int customerId);
        object GetDetailedReportByDateAsGrouped(DateTime firstDate, DateTime secondDate);
        object GetDetailedReportByDateAsGrouped(DateTime firstDate, DateTime secondDate, int customerId);
    }
}
