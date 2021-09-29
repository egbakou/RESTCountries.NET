using Newtonsoft.Json;
using System.Collections.Generic;

namespace RESTCountries.Models
{
    /// <summary>
    /// Defines a <see cref="RegionalBloc" />
    /// </summary>
    public class RegionalBloc
    {
        /// <summary>
        /// Gets or sets the acronym of the regional bloc
        /// </summary>
        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        /// <summary>
        /// Gets or sets the name of the regional bloc
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets other acronyms of the regional bloc
        /// </summary>
        [JsonProperty("otherAcronyms")]
        public IList<object> OtherAcronyms { get; set; }

        /// <summary>
        /// Gets or sets other names of the regional bloc
        /// </summary>
        [JsonProperty("otherNames")]
        public IList<string> OtherNames { get; set; }
    }
}