using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void add(Car car);
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetByUnitPrice(decimal min,decimal max);
        List<Car> GetCarsByColordId(int colorId);
    }
}
