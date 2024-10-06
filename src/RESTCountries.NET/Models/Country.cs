using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Country class.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Gets or sets country name.
        /// </summary>
        [JsonPropertyName("name")]
        public CountryName Name { get; set; }

        /// <summary>
        /// Gets or sets top Level Domain of the country.
        /// </summary>
        [JsonPropertyName("tld")]
        public string[]? Tld { get; set; }

        /// <summary>
        /// Gets or sets the alpha-2 code of the country.
        /// </summary>
        [JsonPropertyName("cca2")]
        public string Cca2 { get; set; }

        /// <summary>
        /// Gets or sets iSO 3166-1 numeric : https://en.wikipedia.org/wiki/ISO_3166-1_numeric.
        /// </summary>
        [JsonPropertyName("ccn3")]
        public string? Ccn3 { get; set; }

        /// <summary>
        /// Gets or sets the alpha-3 code of the country.
        /// </summary>
        [JsonPropertyName("cca3")]
        public string Cca3 { get; set; }

        /// <summary>
        /// Gets or sets international Olympic Committee Code.
        /// </summary>
        [JsonPropertyName("cioc")]
        public string Cioc { get; set; }

        /// <summary>
        /// Gets or sets is the country independent?.
        /// </summary>
        [JsonPropertyName("independent")]
        public bool? Independent { get; set; }

        /// <summary>
        /// Gets or sets status of the country. check out the https://restcountries.com/ for more info.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is the country member of the United Nations ?.
        /// </summary>
        [JsonPropertyName("unMember")]
        public bool UnMember { get; set; }

        /// <summary>
        /// Gets or sets currencies used in the country.
        /// The dictionary is the currency code, the value is a Currency
        /// object: {name: string, symbol: string}.
        /// </summary>
        [JsonPropertyName("currencies")]
        public Dictionary<string, Currency>? Currencies { get; set; }

        /// <summary>
        /// Gets or sets international direct dialing.
        /// </summary>
        [JsonPropertyName("idd")]
        public Idd Idd { get; set; }

        /// <summary>
        /// Gets or sets capital(s) of the country.
        /// </summary>
        [JsonPropertyName("capital")]
        public string[] Capital { get; set; }

        /// <summary>
        /// Gets or sets alternative spellings of the country.
        /// </summary>
        [JsonPropertyName("altSpellings")]
        public string[] AltSpellings { get; set; }

        /// <summary>
        /// Gets or sets region of the country (eg. Africa, Americas, Asia, Europe, Oceania, Antarctic).
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the subregion of the country(eg. Western Africa, Western Europe, ...)
        /// <remarks>Can be null.</remarks>
        /// </summary>
        [JsonPropertyName("subregion")]
        public string? Subregion { get; set; }

        /// <summary>
        /// Gets or sets languages spoken in the country.
        /// The key of the dictionary is the language code, the value is a
        /// the language name in english.
        /// </summary>
        [JsonPropertyName("languages")]
        public Dictionary<string, string>? Languages { get; set; }

        /// <summary>
        /// Gets or sets translations of the country name in other languages:
        /// <list type="string">
        ///     <item>arb: Arabic </item>
        ///     <item>bre: Breton </item>
        ///     <item>ces: Czech </item>
        ///     <item>cym: Welsh </item>
        ///     <item>deu: German </item>
        ///     <item>est: Estonian </item>
        ///     <item>fin: Finnish </item>
        ///     <item>fra: French </item>
        ///     <item>hrv: Croatian </item>
        ///     <item>hun: Hungarian </item>
        ///     <item>ita: Italian </item>
        ///     <item>jpn: Japanese </item>
        ///     <item>kor: Korean </item>
        ///     <item>nld: Dutch </item>
        ///     <item>per: Persian </item>
        ///     <item>pol: Polish </item>
        ///     <item>rus: Russian </item>
        ///     <item>slk: Slovak </item>
        ///     <item>spa: Spanish </item>
        ///     <item>swe: Swedish </item>
        ///     <item>tur: Turkish </item>
        ///     <item>urd: Urdu </item>
        ///     <item>zho: Chinese </item>
        /// </list>
        /// </summary>
        [JsonPropertyName("translations")]
        public Dictionary<string, Translation> Translations { get; set; }

        /// <summary>
        /// Gets or sets gps coordinates of the country in the format: [latitude, longitude].
        /// </summary>
        [JsonPropertyName("latlng")]
        public double[] LatLng { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is the country landlocked ?.
        /// </summary>
        [JsonPropertyName("landlocked")]
        public bool Landlocked { get; set; }

        /// <summary>
        /// Gets or sets neighboring countries.
        /// </summary>
        [JsonPropertyName("borders")]
        public string[] Borders { get; set; }

        /// <summary>
        /// Gets or sets the area of the country in square kilometers.
        /// </summary>
        [JsonPropertyName("area")]
        public double? Area { get; set; }

        /// <summary>
        /// Gets or sets demonym.
        /// </summary>
        [JsonPropertyName("demonyms")]
        public Demonyms? Demonyms { get; set; }

        /// <summary>
        /// Gets or sets unicode flag.
        /// </summary>
        [JsonPropertyName("flag")]
        public string UnicodeFlag { get; set; }

        /// <summary>
        /// Gets or sets google maps or OpenStreetMap link.
        /// </summary>
        [JsonPropertyName("maps")]
        public Maps Maps { get; set; }

        // [JsonPropertyName("population")]
        // public int Population { get; set; }

        // [JsonPropertyName("gini")]
        // public Gini Gini { get; set; }

        /// <summary>
        /// Gets or sets fIFA code.
        /// </summary>
        [JsonPropertyName("fifa")]
        public string? Fifa { get; set; }

        /// <summary>
        /// Gets or sets car information.
        /// </summary>
        [JsonPropertyName("car")]
        public Car? Car { get; set; }

        /// <summary>
        /// Gets or sets list of timezones.
        /// </summary>
        [JsonPropertyName("timezones")]
        public string[] Timezones { get; set; }

        /// <summary>
        /// Gets or sets continent of the country. Only one continent is possible.
        /// The data source taken from https://restcountries.com/ return a list of
        /// one continent. That's why it's an array.
        /// </summary>
        [JsonPropertyName("continents")]
        public string[] Continents { get; set; }

        /// <summary>
        /// Gets or sets flag(Url) of the country in png and svg format.
        /// </summary>
        [JsonPropertyName("flags")]
        public Flag Flag { get; set; }

        // [JsonPropertyName("coatOfArms")]
        // public CoatOfArms CoatOfArms { get; set; }

        /// <summary>
        /// Gets or sets the week start by which day ? (eg. Sunday, Monday, ...)
        /// </summary>
        [JsonPropertyName("startOfWeek")]
        public string StartOfWeek { get; set; }

        /// <summary>
        /// Gets or sets capital details. (eg. latitude, longitude, ...)
        /// </summary>
        [JsonPropertyName("capitalInfo")]
        public CapitalInformation CapitalInformation { get; set; }

        /// <summary>
        /// Gets or sets postal code information (eg. format, regex).
        /// </summary>
        [JsonPropertyName("postalCode")]
        public PostalCode? PostalCode { get; set; }
    }
}