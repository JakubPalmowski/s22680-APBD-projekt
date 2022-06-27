using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projekt.Shared.Models
{
    public class TickersGet
    {
        [JsonPropertyName("results")]
        public List<TickerData> Results { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next_url")]
        public string NextUrl { get; set; }

    }
}
