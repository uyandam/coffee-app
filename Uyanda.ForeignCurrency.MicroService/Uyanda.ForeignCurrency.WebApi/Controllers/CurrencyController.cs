using Microsoft.AspNetCore.Mvc;
using Uyanda.ForeignCurrency.Application.Features.CurrencyManagement.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Uyanda.ForeignCurrency.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyManagementService currencyManagementService;
        public CurrencyController(ICurrencyManagementService currencyManagementService) 
        {
            this.currencyManagementService = currencyManagementService;
        }

        [HttpPost("GetCurrencyExchangeRate")]
        public async Task<IActionResult> GetForeignCurrency(string sourceCurrency)
        {
            try
            {
                var result = await currencyManagementService.GetExchangeRateAsync(sourceCurrency);

                return Ok(result);

            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }


        // GET: api/<CurrencyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CurrencyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CurrencyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CurrencyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CurrencyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
