using LSMWebApi.Data;
using LSMWebApi.Model;
using LSMWebApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LSMWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly ILSMRepository _lSMRepository;
        public CustomerController(ILSMRepository lSMRepository)
        {
            _lSMRepository = lSMRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllCustomers() 
        {
            var customers = await _lSMRepository.GetAllCustomersAsync();
            return Ok(customers);
        
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] int id)
        {
            var customer = await _lSMRepository.GetCustomerByIdAsync(id);
            if(customer == null) 
            { 
                return NotFound ();
            }
            return Ok(customer);

        }
        [HttpPost("post")]
        public async Task<IActionResult> AddNewCustomer([FromBody] CustomerModel customerModel)
        {
            var id = await _lSMRepository.AddCustomerAsync(customerModel);
            return CreatedAtAction(nameof(GetCustomerById), new { id = id, controller = "customers" }, id);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int id)
        {
            await _lSMRepository.DeleteCustomerAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerModel customerModel, [FromRoute] int id)
        {
            await _lSMRepository.UpdateCustomerAsync(id, customerModel);
            return Ok();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateCustomerPatch([FromBody] JsonPatchDocument customerModel, [FromRoute] int id)
        {
            await _lSMRepository.UpdateCustomerPatchAsync(id, customerModel);
            return Ok();
        }
    }
}
