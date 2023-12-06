using Business.Abstract;
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

        public async Task<IActionResult> Add([FromBody] Product product)
        {
            await _productService.Add(product);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _productService.GetListAsync();
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Product product )
        {
            await _productService.Update(product);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Product product)
        {
            await _productService.Delete(product);
            return Ok();
        }
    }
}
