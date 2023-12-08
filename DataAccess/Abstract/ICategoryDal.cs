using Core.DataAccess.Dynamic;
using Core.DataAccess.Repositories;
using Entitites.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal :IRepository<Category,Guid> ,IAsyncRepository<Category, Guid>   
    {
       
    }
}
