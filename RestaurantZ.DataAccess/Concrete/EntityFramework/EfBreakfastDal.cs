﻿using RestaurantZ.DataAccess.Abstract;
using RestaurantZ.Entities.Concrete;

namespace RestaurantZ.DataAccess.Concrete.EntityFramework
{
    public class EfBreakfastDal :EfEntityRepositoryBase<Breakfast,EfRestaurantContext>, IBreakfastDal
    {

    }
}
