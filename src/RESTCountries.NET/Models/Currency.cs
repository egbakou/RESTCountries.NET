using Newtonsoft.Json;

namespace RESTCountries.Models
{
    /// <summary>
    /// Defines a <see cref="Currency" />
    /// </summary>
    public class Currency
    {
        /// <summary>
        /// Gets or sets the curency code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the currency name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}