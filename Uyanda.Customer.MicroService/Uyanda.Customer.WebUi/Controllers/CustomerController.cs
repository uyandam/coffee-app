using Microsoft.AspNetCore.Mvc;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;
using Uyanda.Customer.Application.Features.CustomerManagement.Requests;
using Uyanda.Customer.Application.Features.CustomerManagement.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Uyanda.Customer.WebUi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerManagementService customerManagementService;

        public CustomerController(ICustomerManagementService customerManagementService)
        {
            this.customerManagementService = customerManagementService;
        }

        [HttpPost("GetCustomers")]
        public async Task<IActionResult> GetCustomersAsync()
        {
            try
            {
                var result = await customerManagementService.GetCustomersAsync();

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }


        [HttpPost("GetCustomerStatus")]
        public async Task<IActionResult> GetCustomerStatusAsync(GetCustomerStatusCommand customerStatus)
        {
            try
            {
                var result = await customerManagementService.GetCustomerStatusAsync(customerStatus);

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        //---------------------------------
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
