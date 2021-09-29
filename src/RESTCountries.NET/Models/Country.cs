using Newtonsoft.Json;
using System.Collections.Generic;

namespace RESTCountries.Models
{
    /// <summary>
    /// Defines a <see cref="Country" />
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Top Level Domain
        /// </summary>
        [JsonProperty("topLevelDomain")]
        public IList<string> TopLevelDomain { get; set; }

        /// <summary>
        /// Gets or sets the Alpha2 Code
        /// </summary>
        [JsonProperty("alpha2Code")]
        public string Alpha2Code { get; set; }

        /// <summary>
        /// Gets or sets the Alpha3 Code
        /// </summary>
        [JsonProperty("alpha3Code")]
        public string Alpha3Code { get; set; }

        /// <summary>
        /// Gets or sets the Calling Codes
        /// </summary>
        [JsonProperty("callingCodes")]
        public IList<string> CallingCodes { get; set; }

        /// <summary>
        /// Gets or sets the Capital
        /// </summary>
        [JsonProperty("capital")]
        public string Capital { get; set; }

        /// <summary>
        /// Gets or sets the Alt Spellings
        /// </summary>
        [JsonProperty("altSpellings")]
        public IList<string> AltSpellings { get; set; }

        /// <summary>
        /// Gets or sets the Region
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the Subregion
        /// </summary>
        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        /// <summary>
        /// Gets or sets the Population
        /// </summary>
        [JsonProperty("population")]
        public int Population { get; set; }

        /// <summary>
        /// Gets or sets the Latlng(Latitude and Longitude)
        /// </summary>
        [JsonProperty("latlng")]
        public IList<double> Latlng { get; set; }

        /// <summary>
        /// Gets or sets the Demonym
        /// </summary>
        [JsonProperty("demonym")]
        public string Demonym { get; set; }

        /// <summary>
        /// Gets or sets the Area
        /// </summary>
        [JsonProperty("area")]
        public double? Area { get; set; }

        /// <summary>
        /// Gets or sets the Gini
        /// </summary>
        [JsonProperty("gini")]
        public double? Gini { get; set; }

        /// <summary>
        /// Gets or sets the Timezones
        /// </summary>
        [JsonProperty("timezones")]
        public IList<string> Timezones { get; set; }

        /// <summary>
        /// Gets or sets the Borders
        /// </summary>
        [JsonProperty("borders")]
        public IList<string> Borders { get; set; }

        /// <summary>
        /// Gets or sets the Native Name
        /// </summary>
        [JsonProperty("nativeName")]
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the Numeric Code
        /// </summary>
        [JsonProperty("numericCode")]
        public string NumericCode { get; set; }

        /// <summary>
        /// Gets or sets the Currencies
        /// </summary>
        [JsonProperty("currencies")]
        public IList<Currency> Currencies { get; set; }

        /// <summary>
        /// Gets or sets the Languages
        /// </summary>
        [JsonProperty("languages")]
        public IList<Language> Languages { get; set; }

        /// <summary>
        /// Gets or sets the Translations
        /// </summary>
        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        /// <summary>
        /// Gets or sets the Flag
        /// </summary>
        [JsonProperty("flags")]
        public Flag Flag { get; set; }

        /// <summary>
        /// Gets or sets the Regional Blocs
        /// </summary>
        [JsonProperty("regionalBlocs")]
        public IList<RegionalBloc> RegionalBlocs { get; set; }

        /// <summary>
        /// Gets or sets the Cioc(International Olympic Committee Code)
        /// </summary>
        [JsonProperty("cioc")]
        public string Cioc { get; set; }
    }
}