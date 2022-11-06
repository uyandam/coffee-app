using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.GateWay.Application.Microservices.CoffeeShopMicroService;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Uyanda.GateWay.Application.Microservices.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace Uyanda.GateWay.Integration.Microservices.CoffeeShopMicroService
{
    public class CoffeeShopMicroService: ICoffeeShopMicroService
    {
        private readonly IMapper mapper;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IConfiguration configuration;

        public CoffeeShopMicroService(IMapper mapper, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            this.mapper = mapper;
            this.httpClientFactory = httpClientFactory;
            this.configuration = configuration;
        }


        public async Task<BeverageModel []> MenuAsync()
        {
            var url = CoffeeShopConstants.BaseUrl + "/menu";

            var client = httpClientFactory.CreateClient();

            var payload = new StringContent(JsonSerializer.Serialize("{}"));

            var data = await client.PostAsync(url, payload);

            var content = await data.Content.ReadAsStringAsync();

            var rs = JObject.Parse(content);

            var extractedResult = rs["menu"];

            IEnumerable<BeverageModel> menu = extractedResult.ToObject<IEnumerable<BeverageModel>>();

            return menu.ToArray();

        }
    }
}
