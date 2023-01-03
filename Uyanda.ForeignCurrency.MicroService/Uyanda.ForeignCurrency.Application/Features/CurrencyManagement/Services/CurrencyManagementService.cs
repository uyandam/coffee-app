using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.ForeignCurrency.Application.Integration;

namespace Uyanda.ForeignCurrency.Application.Features.CurrencyManagement.Services
{
    public class CurrencyManagementService: ICurrencyManagementService
    {
        private readonly IApiLayerIntegration apiLayerIntegration;

        public CurrencyManagementService(IApiLayerIntegration apiLayerIntegration)
        {
            this.apiLayerIntegration = apiLayerIntegration;
        }

        public async Task<decimal> GetExchangeRateAsync(string sourceCurrency, string targetCurrency)
        {
            var exchangeRate = await apiLayerIntegration.GetExchangeRateAsync(sourceCurrency, targetCurrency);

            return exchangeRate;
        }

    }
}
