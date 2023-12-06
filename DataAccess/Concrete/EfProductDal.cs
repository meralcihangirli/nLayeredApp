using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Contexts;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfProductDal : EfRepositoryBase<Product, int, NorthwindContext>, IProductDal
    {
        public EfProductDal(NorthwindContext context) : base(context)
        {
        }
    }
}
