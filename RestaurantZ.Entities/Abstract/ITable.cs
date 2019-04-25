using System;


namespace RestaurantZ.Entities.Abstract
{
    //Tüm tablolarda olması zorunlu sütunlar. syncId veritabanları arasındaki muhtemel bir senkronizasyon için bırakıldı.
   public interface ITable
    {
        string SyncId { get; set; }
        DateTime TransactionDate { get; set; }
    }
}
