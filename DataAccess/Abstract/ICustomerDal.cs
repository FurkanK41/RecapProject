using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //sonradan interface e çektim...
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
