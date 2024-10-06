using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Flag of a country in different formats: PNG, SVG, ...
    /// </summary>
    public class Flag
    {
        /// <summary>
        /// Gets or sets url to the PNG flag.
        /// </summary>
        [JsonPropertyName("png")]
        public string Png { get; set; }

        /// <summary>
        /// Gets or sets url to the SVG flag.
        /// </summary>
        [JsonPropertyName("svg")]
        public string Svg { get; set; }
    }
}