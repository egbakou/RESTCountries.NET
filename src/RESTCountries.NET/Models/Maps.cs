using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Represent location of a country on a map.
    /// </summary>
    public class Maps
    {
        /// <summary>
        /// Google Maps location URL.
        /// </summary>
        [JsonPropertyName("googleMaps")]
        public string GoogleMaps { get; set; }

        /// <summary>
        /// Open Street Maps location URL.
        /// </summary>
        [JsonPropertyName("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }
}