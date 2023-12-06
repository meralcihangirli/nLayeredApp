
using Core.DataAccess.Paging;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IPaginate<Product>> GetListAsync();
        Task Add(Product product);

        Task Update(Product product);
        Task Delete(Product product);
    }
}
