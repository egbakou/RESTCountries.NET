using Newtonsoft.Json;

namespace RESTCountries.Models
{
    /// <summary>
    /// Defines a <see cref="Translations" />.
    /// It contains some tranlations of country name in another languages.
    /// </summary>
    public class Translations
    {
        /// <summary>
        /// Country name translated in German language
        /// </summary>
        [JsonProperty("de")]
        public string De { get; set; }

        /// <summary>
        /// Country name translated in Spanish, Castilian language
        /// </summary>
        [JsonProperty("es")]
        public string Es { get; set; }

        /// <summary>
        /// Country name translated in French language
        /// </summary>
        [JsonProperty("fr")]
        public string Fr { get; set; }

        /// <summary>
        /// Country name translated in Japanese language
        /// </summary>
        [JsonProperty("ja")]
        public string Ja { get; set; }

        /// <summary>
        /// Country name translated in Italian language
        /// </summary>
        [JsonProperty("it")]
        public string It { get; set; }

        /// <summary>
        /// Country name translated in Breton language
        /// </summary>
        [JsonProperty("br")]
        public string Br { get; set; }

        /// <summary>
        /// Country name translated in Portuguese language.
        /// </summary>
        [JsonProperty("pt")]
        public string Pt { get; set; }

        /// <summary>
        /// Country name translated in Dutch language
        /// </summary>
        [JsonProperty("nl")]
        public string Nl { get; set; }

        /// <summary>
        /// Country name translated in Croatian language
        /// </summary>
        [JsonProperty("hr")]
        public string Hr { get; set; }

        /// <summary>
        /// Country name translated in Persian language
        /// </summary>
        [JsonProperty("fa")]
        public string Fa { get; set; }
    }
}