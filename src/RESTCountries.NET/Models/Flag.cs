using Newtonsoft.Json;

namespace RESTCountries.Models
{
    /// <summary>
    /// Country flag.
    /// </summary>
    public class Flag
    {
        /// <summary>
        /// Country flag in SVG format.
        /// </summary>
        [JsonProperty("svg")]
        public string Svg { get; set; }
        /// <summary>
        /// Country flag in PNG format.
        /// </summary>
        [JsonProperty("png")]
        public string Png { get; set; }
    }
}
