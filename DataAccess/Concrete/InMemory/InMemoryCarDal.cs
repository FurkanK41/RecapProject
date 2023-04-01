using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=350,ModelYear=2020,Description="2.0 Motor"},
                 new Car{Id=2,BrandId=1,ColorId=3,DailyPrice=150,ModelYear=2005,Description="1.5 Motor"},
                  new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=700,ModelYear=2022,Description="4.0 Motor"},
                   new Car{Id=4,BrandId=2,ColorId=5,DailyPrice=1000,ModelYear=2018,Description="4.5 Motor"},
                    new Car{Id=5,BrandId=3,ColorId=12,DailyPrice=500,ModelYear=2015,Description="1.6 Motor"},
            };            
        }

        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete=null;
            
            //foreach (var c in cars)
            //{
            //    if (c.Id==car.Id)
            //    {
            //        CarToDelete = car;
            //    }
            //}
            //cars.Remove(CarToDelete);

            var ctd = cars.SingleOrDefault(c=>c.Id==car.Id);
            cars.Remove(ctd);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int id)
        {
            return cars.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
           // Car CarToUpdate = null;
            Car ctu = cars.SingleOrDefault(c => c.Id == car.Id);
            ctu.BrandId= car.BrandId;
            ctu.ColorId = car.ColorId;
            ctu.ModelYear = car.ModelYear;
            ctu.DailyPrice = car.DailyPrice;
            ctu.Description = car.Description;

        }
    }
}
