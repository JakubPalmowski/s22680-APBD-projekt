using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projekt.Shared.Models
{
    public class TickerDetails
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("market")]
        public string Market { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("primary_exchange")]
        public string PrimaryExchange { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("currency_name")]
        public string CurrencyName { get; set; }

        [JsonPropertyName("cik")]
        public string Cik { get; set; }

        [JsonPropertyName("composite_figi")]
        public string CompositeFigi { get; set; }

        [JsonPropertyName("share_class_figi")]
        public string ShareClassFigi { get; set; }

        [JsonPropertyName("market_cap")]
        public long MarketCap { get; set; }

        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("sic_code")]
        public string SicCode { get; set; }

        [JsonPropertyName("sic_description")]
        public string sic_description { get; set; }

        [JsonPropertyName("ticker_root")]
        public string TickerRoot { get; set; }

        [JsonPropertyName("homepage_url")]
        public string HomepageUrl { get; set; }

        [JsonPropertyName("total_employees")]
        public int TotalEmployees { get; set; }

        [JsonPropertyName("list_date")]
        public string ListDate { get; set; }

        [JsonPropertyName("branding")]
        public Branding Branding { get; set; }

        [JsonPropertyName("share_class_shares_outstanding")]
        public long ShareClassSharesOutstanding { get; set; }

        [JsonPropertyName("weighted_shares_outstanding")]
        public long WeightedSharesOutstanding { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }
    }

    public class Branding
    {
        [JsonPropertyName("logo_url")]
        public string logo_url { get; set; }

        [JsonPropertyName("icon_url")]
        public string icon_url { get; set; }
    }
}
