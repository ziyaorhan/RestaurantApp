using System;
using System.Collections.Generic;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.Business.Abstract
{
    public interface IJoinService
    {
        object GetAllForBreakfastFormDgv();
        object GetAllForBreakfastFormDgv(string customerName);
        object GetAllForBreakfastPastRecord(DateTime firstDate, DateTime secondDate);
        object GetAllForBreakfastPastRecord(DateTime firstDate, DateTime secondDate, int customerId);
        //
        object GetAllForLunchFormDgv();
        object GetAllForLunchFormDgv(string customerName);
        object GetAllForLunchPastRecord(DateTime firstDate, DateTime secondDate);
        object GetAllForLunchPastRecord(DateTime firstDate, DateTime secondDate, int customerId);
        //
        object GetAllForDinnerFormDgv();
        object GetAllForDinnerFormDgv(string customerName);
        object GetAllForDinnerPastRecord(DateTime firstDate, DateTime secondDate);
        object GetAllForDinnerPastRecord(DateTime firstDate, DateTime secondDate, int customerId);
        //
        object GetAllForNightMaleFormDgv();
        object GetAllForNightMaleFormDgv(string customerName);
        object GetAllForNightMalePastRecord(DateTime firstDate, DateTime secondDate);
        object GetAllForNightMalePastRecord(DateTime firstDate, DateTime secondDate, int customerId);
        //
        object GetAllForMainDgv();
        object GetAllForMainDgv(string customerName);
        ModelForRecordCount GetRecordCount();
        object GetDetailedReportByDate(DateTime firstDate, DateTime secondDate);
        object GetDetailedReportByDate(DateTime firstDate, DateTime secondDate, int customerId);
        object GetDetailedReportByDateAsGrouped(DateTime firstDate, DateTime secondDate);
        object GetDetailedReportByDateAsGrouped(DateTime firstDate, DateTime secondDate, int customerId);
        //
        List<ModelForDetailedReport> GetDetailedReportForMail(DateTime firstDate, DateTime secondDate);
        List<ModelForGroupedReport> GetGroupedReportForMail(DateTime firstDate, DateTime secondDate);

    }
}
