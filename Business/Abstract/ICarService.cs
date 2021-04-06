using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void add(Car car);
        void update(Car car);
        void delete(Car car);

        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetByUnitPrice(decimal min,decimal max);
        List<Car> GetCarsByColordId(int colorId);
        List<CarDetailDto> GetCarDetails();
    }
}
