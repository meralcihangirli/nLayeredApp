using Business.Abstract;
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
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Category category)
        {
            await _categoryService.Add(category);
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
