
namespace RestaurantZ.Business.Abstract
{
    public interface IJoinService
    {
        object GetAllForBreakfastFormDgv();
        object GetAllForBreakfastFormDgv(string customerName);
        object GetAllForLunchFormDgv();
        object GetAllForLunchFormDgv(string customerName);
        object GetAllForDinnerFormDgv(string customerName);
        object GetAllForDinnerFormDgv();
    }
}
