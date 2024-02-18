using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Represents a state or region within a country, including its cities.
    /// </summary>
    public class State
    {
        /// <summary>
        /// Gets or sets the ISO country code.
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the state or region.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the state or region code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the list of cities within the state or region.
        /// </summary>
        [JsonPropertyName("cities")]
        public List<City> Cities { get; set; }
    }

    /// <summary>
    /// Represents a city within a state or region.
    /// </summary>
    public class City
    {
        /// <summary>
        /// Gets or sets the name of the city.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}