using Business.Abstract;
using Business.Dtos.Request;
using Entitites.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication.ExtendedProtection;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]

        public async Task<IActionResult> Add([FromBody] CreateProductRequest createProductRequest)
        {
           var result= await _productService.Add(createProductRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _productService.GetProductListAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductRequest updateProductRequest )
        {
            await _productService.Update(updateProductRequest);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteProductRequest deleteProductRequest)
        {
            await _productService.Delete(deleteProductRequest);
            return Ok();
        }
    }
}
