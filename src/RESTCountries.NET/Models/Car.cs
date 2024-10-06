using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Car information.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets or sets signs that can be found on the vehicle.
        /// </summary>
        [JsonPropertyName("signs")]
        public string[] Signs { get; set; }

        /// <summary>
        /// Gets or sets the name of the side of the road that traffic drives on: left or right.
        /// </summary>
        [JsonPropertyName("side")]
        public string Side { get; set; }
    }
}
