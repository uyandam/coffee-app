using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.ForeignCurrency.Application.Features.CurrencyManagement.Models;

namespace Uyanda.ForeignCurrency.Application.Features.CurrencyManagement.Services
{
    public interface ICurrencyManagementService
    {
        Task<ExchangeRateModel> GetExchangeRateAsync(string sourceCurrency, string targetCurrency);
    }
}
