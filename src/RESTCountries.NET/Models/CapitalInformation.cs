using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Capital Information class.
    /// </summary>
    public class CapitalInformation
    {
        /// <summary>
        /// Gets or sets gPS coordinates of the capital. [latitude, longitude].
        /// </summary>
        [JsonPropertyName("latlng")]
        private string[] Latlng { get; set; }
    }
}
