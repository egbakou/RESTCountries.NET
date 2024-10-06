using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Country name class.
    /// </summary>
    public class CountryName : Translation
    {
        /// <summary>
        /// Gets or sets native name of the country.
        /// The key of the dictionary is the language code, value is the native name
        /// object: {Official: string, Common: string}.
        /// The number of native names is the same as the number of languages.
        /// </summary>
        [JsonPropertyName("nativeName")]
        public Dictionary<string, Translation>? NativeName { get; set; }
    }
}