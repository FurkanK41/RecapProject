using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        Car GetById(int id);
        List<Car> GetCarsByColorId(int colorId);
        void AddCar(Car car);
        List<CarDetailDto> GetCarDetails();
        void Update(Car car);
        void Delete(Car car);
    }
}
