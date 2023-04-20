using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public IResult AddColor(Color color)
        {
            if (color.Name.Length > 2)
            {
                return new SuccessResult(ColorMessages.ColorAdded);
                _colorDal.Add(color);
            }
            return new ErrorResult();
        }

        public IResult DeleteColor(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(ColorMessages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult GetById(int id)
        {
            if (id < 1)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
            _colorDal.Get(c => c.Id == id);
        }

        public IResult UpdateColor(Color color)
        {
            return new SuccessResult();
            _colorDal.Update(color);
        }
    }
}
