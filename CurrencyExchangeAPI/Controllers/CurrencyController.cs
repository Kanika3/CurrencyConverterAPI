using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CurrencyExchangeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        // GET: api/Currency
        [HttpGet]
        public IDictionary<string,string> Get()
        {
            return new Dictionary<string,string>
            {
                
                {
                    "AFN","Afghani"
                },
                
                {
                    "AED","United Arab Emirates Dirham"
                },

                {
                    "USD", "US Dollar"
                },

                {
                    "GBP" ,"Pound Sterling"
                },

                {
                    "EUR" ,"Euro"
                }
            };
        }        
    }
}
