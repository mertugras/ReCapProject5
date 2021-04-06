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
            //carAddTest();
            //carDeleteTest();
            //carUpdateTest();
            carDetailsDtoTest();


            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColordId(2))
            {
                Console.WriteLine(car.Description);
            }
            
        }

        private static void carDetailsDtoTest()
        {
            CarManager carManager3 = new CarManager(new EfCarDal());
            foreach (var car in carManager3.GetCarDetails())
            {
                Console.WriteLine(car.CarName+" "+ car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
                
            }
        }

        private static void carUpdateTest()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.update(new Car { CarId = 6, BrandId = 2, ColorId = 1, CarName = "Pratico222", ModelYear = 201922, DailyPrice = 200000, Description = "Mini Kamyonet" });
        }

        private static void carDeleteTest()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.delete(new Car { CarId = 4 });
        }

        public static void carAddTest() {
            CarManager carManager2 = new CarManager(new EfCarDal());
            carManager2.add(new Car { BrandId =2,ColorId=1,CarName="Pratico",ModelYear=2019,DailyPrice=200000,Description="Mini Kamyonet"});
        }
    }
}
