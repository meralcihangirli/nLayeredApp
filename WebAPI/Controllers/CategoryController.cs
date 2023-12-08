using Business.Abstract;
using Business.Dtos.Request;
using Entitites.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryListAsync()
        {
           await _categoryService.GetListAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            await _categoryService.Add(createCategoryRequest);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Category category)
        {
            await _categoryService.Update(category);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Category category)
        {

            await _categoryService.Delete(category);
            return Ok();
        }

    }
}
