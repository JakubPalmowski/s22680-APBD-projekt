using Newtonsoft.Json;
using s22680.Shared.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace s22680.Server.Services

{
    public class TickerService : ITickerService
    {
        public async Task<IEnumerable<Stock>> GetStocks(string request, string from)
        {
             string today = DateTime.Now.ToString("yyyy-MM-dd");
             var url = "https://api.polygon.io/v2/aggs/ticker/"+request+"/range/1/day/"+from+"/"+today+"?adjusted=true&sort=asc&limit=120&apiKey=9pFjWPppUCFwVZ4WlFsSUlXrpFniSKEO";

            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var data = await result.Content.ReadAsStringAsync();
            StocksGet stocks= JsonConvert.DeserializeObject<StocksGet>(data);

            foreach (Stock s in stocks.Results)
            {
                DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                s.date = unixStart.AddMilliseconds(Convert.ToDouble(s.T));

            }

            return stocks.Results;



        }

        public async Task<TickerDetails> GetTickerDetails(string request)
        {
            
            var url = "https://api.polygon.io/v3/reference/tickers/"+request+"?apiKey=9pFjWPppUCFwVZ4WlFsSUlXrpFniSKEO";

            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var data = await result.Content.ReadAsStringAsync();
            TickerDetailsGet ticker = JsonConvert.DeserializeObject<TickerDetailsGet>(data);

            return ticker.Results;
        }

        public async Task<IEnumerable<TickerData>> GetTickers(string request)
        {
            var url = "https://api.polygon.io/v3/reference/tickers?ticker.gte="+request+"&active=true&sort=ticker&order=asc&limit=10&apiKey=9pFjWPppUCFwVZ4WlFsSUlXrpFniSKEO";

            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var data = await result.Content.ReadAsStringAsync();
            TickersGet tickers = JsonConvert.DeserializeObject<TickersGet>(data);

            return tickers.Results;
        }
    }
}
