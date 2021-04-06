using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car {CarId=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=200000,Description="Egea"},
                new Car {CarId=2,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=130000,Description="Fiorino"},
                new Car {CarId=3,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=420000,Description="Megane"},
                new Car {CarId=4,BrandId=3,ColorId=3,ModelYear=2021,DailyPrice=600000,Description="Focus"},
                new Car {CarId=5,BrandId=3,ColorId=5,ModelYear=2021,DailyPrice=340000,Description="Fiesta"}
            };


        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public List<Car> GetAllByBrand(int brandID)
        {
            return _car.Where(p => p.BrandId == brandID).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

    }
}