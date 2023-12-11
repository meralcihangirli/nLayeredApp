using AutoMapper;
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
        IMapper _mapper;

        public ProductManager(IProductDal productDal,IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
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

        public async Task<DeletedProductResponse> Delete(DeleteProductRequest deleteProductRequest)
        {
            var product=_mapper.Map<Product>(deleteProductRequest);
            var deletedProduct= await _productDal.DeleteAsync(product,true);
            var deletedProductResponse = _mapper.Map<DeletedProductResponse>(deletedProduct);
            return deletedProductResponse;
        }

        public async Task<IPaginate<GetListProductResponse>> GetProductListAsync()
        {
            var productList= await _productDal.GetListAsync();
            var mapped=_mapper.Map<Paginate<GetListProductResponse>>(productList);
            return mapped;
        }

        public async Task<UpdatedProductResponse> Update(UpdateProductRequest updateProductRequest)
        {
            var product = _mapper.Map<Product>(updateProductRequest);
            var updatedProduct= await _productDal.UpdateAsync(product);
            var updatedProductResponse=_mapper.Map<UpdatedProductResponse>(updatedProduct);
            return updatedProductResponse;
        }
    }
}
