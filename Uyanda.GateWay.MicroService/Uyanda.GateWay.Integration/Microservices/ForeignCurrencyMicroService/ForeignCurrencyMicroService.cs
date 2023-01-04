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

namespace Uyanda.GateWay.Integration.Microservices.ForeignCurrencyMicroService
{
    public class ForeignCurrencyMicroService : IForeignCurrencyMicroService
    {

        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly HttpClient http;

        public ForeignCurrencyMicroService(IMapper mapper, IConfiguration configuration, HttpClient http)
        {
            this.mapper = mapper;
            this.configuration = configuration;
            this.http = http;
        }

        public async Task<ExchangeRateModel> GetExchangeRateAsync(string sourceCurrency, string targetCurrency, RestClient restClient)
        {

        }
    }
}
