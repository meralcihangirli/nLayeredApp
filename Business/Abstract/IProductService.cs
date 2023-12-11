
using Business.Dtos.Request;
using Business.Dtos.Response;
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
        Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
        Task<IPaginate<GetListProductResponse>> GetProductListAsync(PageRequest pageRequest);
        Task<UpdatedProductResponse> Update(UpdateProductRequest updateProductRequest);
        // Task<Product> GetProductById(int id);
        Task<DeletedProductResponse> Delete(DeleteProductRequest deleteProductRequest);

    }
}
