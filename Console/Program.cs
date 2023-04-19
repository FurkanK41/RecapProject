using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Demo();

            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("create");
            carManager.AddCar(new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 100,
                Description="Bmw",
                ModelYear=2020
            });

            Console.WriteLine("Read");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.ColorName);
                Console.WriteLine(car.BrandName);

            }

            Console.WriteLine("Update");
            carManager.Update(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 299, Description = "Audi", ModelYear = 2000 });

            Console.WriteLine("Delete");
            carManager.Delete(new Car { Id = 1 });
        }

        private static void Demo()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.AddCar(new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2004, DailyPrice = 969, Description = "deneme arabası" });
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
        }
    }
}