using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Postal code class.
    /// </summary>
    public class PostalCode
    {
        /// <summary>
        /// Gets or sets the postal code format.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets regex pattern for the postal code.
        /// </summary>
        [JsonPropertyName("regex")]
        public string Regex { get; set; }
    }
}