using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new EfCarDal());
            carManager.AddCar(new Car
            {
                BrandId = 1,
                ModelYear = 2020
            });
            Console.WriteLine("çalştı");

        }
    }
}