using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandService _brandDal;
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(BrandMessages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            if (brand.Id < 1)
            {
                return new ErrorResult(BrandMessages.BrandNameInvalid);
            }
            _brandDal.Delete(brand);
            return new SuccessResult(BrandMessages.BrandDeleted);

        }

        public IDataResult<List<Brand>> GetAll()
        {

            _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(BrandMessages.BrandsListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(BrandMessages.BrandsListed);
            _brandDal.GetById(id);
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult();
            _brandDal.Update(brand);
        }
    }
}
