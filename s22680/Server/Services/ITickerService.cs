using s22680.Shared.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace s22680.Server.Services
{
    public interface ITickerService
    {
        public Task<IEnumerable<TickerData>> GetTickers(string request);

        public Task<TickerDetails> GetTickerDetails(string request);

        public Task<IEnumerable<Stock>> GetStocks(string request,string from);

    }
}
