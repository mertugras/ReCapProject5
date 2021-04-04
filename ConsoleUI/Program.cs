using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.add(new Car {CarId = 4,BrandId = 1, ColorId = 1, CarName = "F", DailyPrice = 150000, ModelYear = 2020, Description = "Ticari" });
            foreach (var car in carManager.GetCarsByColordId(2))
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
