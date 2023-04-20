using Core.Utilities.Results;
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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IResult AddCar(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
