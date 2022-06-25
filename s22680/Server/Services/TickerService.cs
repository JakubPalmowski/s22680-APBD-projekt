using Newtonsoft.Json;
using s22680.Shared.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace s22680.Server.Services

{
    public class TickerService : ITickerService
    {
        public async Task<IEnumerable<TickerData>> GetTickers(string request)
        {
            var url = "https://api.polygon.io/v3/reference/tickers?ticker.gt="+request+"&active=true&sort=ticker&order=asc&limit=10&apiKey=9pFjWPppUCFwVZ4WlFsSUlXrpFniSKEO";

            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var data = await result.Content.ReadAsStringAsync();
            TickersGet tickers = JsonConvert.DeserializeObject<TickersGet>(data);

            return tickers.Results;
        }
    }
}
