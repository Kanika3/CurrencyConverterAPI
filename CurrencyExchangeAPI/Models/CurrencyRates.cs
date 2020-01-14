using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyExchangeAPI.Models
{    
    public class CurrencyRates
    {
        public string BaseCurrency { get; }
        public string Time { get; set; }
        public long Timestamp { get; set; }        
        public Dictionary<string, double> Rates { get; set; }

        public CurrencyRates(string baseCurrency)
        {
            BaseCurrency = baseCurrency;
            var currentDate = DateTime.UtcNow;
            Time = currentDate.ToString();
            Timestamp = new DateTimeOffset(currentDate).ToUnixTimeSeconds();

            Rates = new Dictionary<string, double>
            {
                {"AED", 3.6733 },
                {"AFN", 76.05 }
            };
        }
    }
}
