using System;

namespace RestaurantZ.Entities.Concrete
{
    public class BaseEntity
    {
        //her tabloda oluşturulma tarihi ve oluşturan kişinin id sini ve eğer güncelleme var ise güncelleme tarihi ve güncelleyen id sini tutmak için 
        public DateTime? CreatedDate { get; set; }    
        public DateTime? ModifiedDate { get; set; }
        public string SyncId { get; set; }
        public bool IsSync { get; set; }
    }
}
