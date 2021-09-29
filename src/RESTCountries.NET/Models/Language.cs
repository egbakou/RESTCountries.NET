using Newtonsoft.Json;

namespace RESTCountries.Models
{
    /// <summary>
    /// Defines a <see cref="Language" />
    /// </summary>
    public class Language
    {
        /// <summary>
        /// Gets or sets the Iso639_1 format of the language
        /// </summary>
        [JsonProperty("iso639_1")]
        public string Iso639_1 { get; set; }

        /// <summary>
        /// Gets or sets the Iso639_2 format of the language
        /// </summary>
        [JsonProperty("iso639_2")]
        public string Iso639_2 { get; set; }

        /// <summary>
        /// Gets or sets the Name of the language
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the NativeName of the language
        /// </summary>
        [JsonProperty("nativeName")]
        public string NativeName { get; set; }
    }
}