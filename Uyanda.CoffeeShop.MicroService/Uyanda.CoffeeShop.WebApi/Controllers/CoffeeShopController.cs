using Microsoft.AspNetCore.Mvc;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Uyanda.CoffeeShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {

        private readonly IBeverageManagementService beverageManagementService;


        public CoffeeShopController(IBeverageManagementService beverageManagementService)
        {
            this.beverageManagementService = beverageManagementService;
        }


        [HttpPost("menu")]
        public async Task<IActionResult> Menu()
        {
            try
            {
                var result = await beverageManagementService.GetMenuAsync();

                return Ok(result);

            }catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        

        // GET: api/<CoffeeShopController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CoffeeShopController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CoffeeShopController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CoffeeShopController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CoffeeShopController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
