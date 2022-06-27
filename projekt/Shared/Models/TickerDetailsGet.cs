using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projekt.Shared.Models
{
    public class TickerDetailsGet
    {
        [JsonPropertyName("results")]
        public TickerDetails Results { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

    }
}
