using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// International Direct Dialing.
    /// </summary>
    public class Idd
    {
        /// <summary>
        /// Gets or sets eg. The call prefix for Togo is +228.
        /// The root is +2.
        /// </summary>
        [JsonPropertyName("root")]
        public string Root { get; set; }

        /// <summary>
        /// Gets or sets eg. The call prefix for Togo is +228.
        /// The suffixes are [28].
        /// </summary>
        [JsonPropertyName("suffixes")]
        public string[] Suffixes { get; set; }
    }
}