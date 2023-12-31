﻿using Core.DataAccess.Repositories;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product, int>, IAsyncRepository<Product,int>
    {

    }
}
