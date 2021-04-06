using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsContext carsContext = new CarsContext())
            {
                var result = from car in carsContext.Cars
                             join brand in carsContext.Brands on car.BrandId equals brand.BrandId
                             join color in carsContext.Colors on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
