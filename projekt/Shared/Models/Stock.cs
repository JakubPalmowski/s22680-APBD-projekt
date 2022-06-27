using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projekt.Shared.Models
{
    public class Stock
    {
        

        [JsonPropertyName("v")]
        public double V { get; set; }

        [JsonPropertyName("vw")]
        public double Vw { get; set; }

        [JsonPropertyName("o")]
        public double O { get; set; }

        [JsonPropertyName("c")]
        public double C { get; set; }

        [JsonPropertyName("h")]
        public double H { get; set; }

        [JsonPropertyName("l")]
        public double L { get; set; }

        [JsonPropertyName("t")]
        public object T { get; set; }

        [JsonPropertyName("n")]
        public int N { get; set; }

        public DateTime date { get; set; }
    }
}
