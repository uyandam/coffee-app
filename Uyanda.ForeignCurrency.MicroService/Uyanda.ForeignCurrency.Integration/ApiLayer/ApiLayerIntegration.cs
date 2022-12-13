﻿
using Uyanda.ForeignCurrency.Application.Integration;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace Uyanda.ForeignCurrency.Integration.ApiLayer
{
    public class ApiLayerIntegration: IApiLayerIntegration
    {
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly HttpClient http;
        

        public ApiLayerIntegration(IMapper mapper, HttpClient httpClient, IConfiguration configuration)
        {
            this.mapper = mapper;
            this.http = httpClient;
            this.configuration = configuration;
        }


        public async Task<decimal> GetExchangeRateAsync(string currencycode)
        {
            currencycode.ToUpper();

            var client = new RestClient("https://api.apilayer.com/currency_data/convert?to=ZAR&from=" + currencycode + "&amount=1");
            
            var apiKey = configuration.GetSection("Secret:apilayer").Value;

            var request = new RestRequest();

            request.Method = Method.Get;
            
            request.AddHeader("apikey", apiKey);

            var response = await client.ExecuteAsync(request);

            return Convert.ToDecimal(JObject.Parse(response.Content)["result"]);

        }
    }
}