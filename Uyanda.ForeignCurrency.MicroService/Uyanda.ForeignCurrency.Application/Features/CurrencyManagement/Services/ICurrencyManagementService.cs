using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.ForeignCurrency.Application.Features.CurrencyManagement.Services
{
    public interface ICurrencyManagementService
    {
        Task<decimal> GetExchangeRateAsync(string sourceCurrency, string targetCurrency);
    }
}
