using Microsoft.AspNetCore.Mvc;
using Uyanda.GateWay.Application.Microservices.Models;
using Uyanda.GateWay.Application.Microservices.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Uyanda.GateWay.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GateWayController : ControllerBase
    {
        private readonly IGateWayManagementService gateWayManagementService;


        public GateWayController(IGateWayManagementService gateWayManagementService)
        {
            this.gateWayManagementService = gateWayManagementService;
        }

        [HttpPost("menu")]
        public async Task<IActionResult> Menu()
        {
            try
            {
                var result = await gateWayManagementService.MenuAsync();

                return Ok(result);

            }catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("GetCurrencyExchangeRate")]
        public async Task<IActionResult> ExchangeRate(ExchangeRateModel exchangeRate)
        {
            try
            {
                var result = await gateWayManagementService.ExchangeRate(exchangeRate);

                return Ok(result);
            }catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // GET: api/<GateWayController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GateWayController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GateWayController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GateWayController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GateWayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
