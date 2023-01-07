using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.GateWay.Application.Microservices.ForeignCurrencyMicroService;
using Uyanda.GateWay.Application.Microservices.Models;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Uyanda.GateWay.Integration.Microservices.ForeignCurrencyMicroService
{
    public class ForeignCurrencyMicroService : IForeignCurrencyMicroService
    {

        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly IHttpClientFactory httpClientFactory;

        public ForeignCurrencyMicroService(IMapper mapper, IConfiguration configuration,IHttpClientFactory httpClientFactory)
        {
            this.mapper = mapper;
            this.configuration = configuration;
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<ExchangeRateModel> GetExchangeRateAsync(string sourceCurrency, string targetCurrency)
        {
            var url = ForeignCurrencyConstants.BaseUrl + "/GetCurrencyExchangeRate";

            var client = this.httpClientFactory.CreateClient();

            var data = new ExchangeRateModel { SourceCurrency = sourceCurrency, DestinationCurrency = targetCurrency };

            var payload = new StringContent(JsonSerializer.Serialize(data));

            var request = await client.PostAsync(url, payload);

            var content = await request.Content.ReadAsStringAsync();

            var rs = JObject.Parse(content);

            Console.WriteLine(rs);

            return new ExchangeRateModel { SourceCurrency = sourceCurrency, DestinationCurrency = targetCurrency};

        }
    }
}
