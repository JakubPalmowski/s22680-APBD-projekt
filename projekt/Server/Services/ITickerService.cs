using projekt.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace projekt.Server.Services
{
    public interface ITickerService
    {
        public Task<IEnumerable<TickerData>> GetTickers(string request);

        public Task<TickerDetails> GetTickerDetails(string request);

        public Task<IEnumerable<Stock>> GetStocks(string request,string from);

    }
}
