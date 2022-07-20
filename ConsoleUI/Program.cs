using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car();

            car.CarId = 1;
            car.BrandId = 2;
            car.ColorId = 28;
            car.DailyPrice = 500;
            car.Description = "fast like ferrari";
            car.ModelYear = 1969;

            carManager.Add(car);


        }
    }
}
