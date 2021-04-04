using Business.Abstract;
using Entity.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void add(Car car)
        {
            if (car.CarName.Length>=2 & car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araç ismi en az iki karakter olmalıdır ve araç günlük fiyatı 0 dan büyük olmalıdır!");
            }
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(p=> p.BrandId==brandId);
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p=> p.DailyPrice>=min && p.DailyPrice<=max);
        }

        public List<Car> GetCarsByColordId(int colorId)
        {
            return _carDal.GetAll(p=> p.ColorId==colorId);
        }
    }
}
