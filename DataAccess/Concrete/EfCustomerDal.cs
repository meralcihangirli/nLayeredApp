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
    public class EfCustomerDal : EfRepositoryBase<Customer, string, NorthwindContext>, ICustomerDal
    {
        NorthwindContext _context;
        public EfCustomerDal(NorthwindContext context) : base(context)
        {
            NorthwindContext _context;
        }
    }
}
