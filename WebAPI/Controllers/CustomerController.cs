using Business.Abstract;
using Business.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _customerService.GetCustomerListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCustomerRequest createCustomerRequest)
        {
            var result = await _customerService.Add(createCustomerRequest);
            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomerRequest updateCustomerRequest)
        {
            var result = await _customerService.Update(updateCustomerRequest);
            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteCustomerRequest deleteCustomerRequest)
        {

            var result = await _customerService.Delete(deleteCustomerRequest);
            return Ok(result);
        }
    }
}
