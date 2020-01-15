using CurrencyExchangeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CurrencyExchangeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        //GET: api/ExchangeRates/All
        [HttpGet("All")]
        public CurrencyRates Get()
        {
            var currencyRate = new CurrencyRates("USD"); ;
            return currencyRate;
        }

        // GET: api/ExchangeRates?from=GBP&to=EUR
        [HttpGet]
        public double Get([FromQuery]string from, [FromQuery]string to)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
                throw new Exception("From Currency & To Currency are required. E.g. api/ExchangeRates?from=GBP&to=EUR");

            if (from.ToLower() == to.ToLower()) return 1;

            var currencyRate = new CurrencyRates("USD");
            if(currencyRate.Rates.ContainsKey(from) && currencyRate.Rates.ContainsKey(to)
                && currencyRate.Rates[from] != 0)
                return Math.Round(currencyRate.Rates[to]/currencyRate.Rates[from],2);

            return 0;
        }        
    }
}
