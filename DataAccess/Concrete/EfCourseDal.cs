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
    public class EfCourseDal : EfRepositoryBase<Course, Guid, NorthwindContext>, ICourseDal
    {
        public EfCourseDal(NorthwindContext context) : base(context)
        {
        }
    }
}
