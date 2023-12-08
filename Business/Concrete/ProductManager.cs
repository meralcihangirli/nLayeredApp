using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            Product product = new Product();
            product.Id = Guid.NewGuid();
            product.ProductName = createProductRequest.ProductName;
            product.UnitPrice = createProductRequest.UnitPrice;
            product.QuantityPerUnit = createProductRequest.QuantityPerUnit;
            product.UnitsInStock = createProductRequest.UnitsInStock;

            Product createdProduct = await _productDal.AddAsync(product);

            CreatedProductResponse createdProductResponse = new CreatedProductResponse();
            createdProductResponse.Id = createdProduct.Id;
            createdProductResponse.ProductName = createdProduct.ProductName;
            createdProductResponse.UnitPrice = createdProduct.UnitPrice;
            createdProductResponse.QuantityPerUnit = createdProduct.QuantityPerUnit;
            createdProductResponse.UnitsInStock = createdProduct.UnitsInStock;

            return createdProductResponse;
        }

        public async Task<IPaginate<Product>> GetListAsync()
        {
            return await _productDal.GetListAsync();
        }

        public Task Delete(Product product)
        {
            throw new NotImplementedException();
        }

       
        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
