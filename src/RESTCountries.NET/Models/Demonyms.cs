using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Demonym class: a noun used to denote the natives or inhabitants of a particular country, state, city, etc.
    /// </summary>
    public class Demonyms
    {
        /// <summary>
        ///  French demonym.
        /// </summary>
        [JsonPropertyName("fra")]
        public FrenchDemonym? French { get; set; }

        /// <summary>
        /// English demonym.
        /// </summary>
        [JsonPropertyName("eng")]
        public EnglishDemonym? English { get; set; }
    }

    /// <summary>
    /// Demonym base class.
    /// </summary>
    public abstract class DemonymBase
    {
        /// <summary>
        /// Feminine form.
        /// </summary>
        [JsonPropertyName("f")]
        public string F { get; set; }

        /// <summary>
        /// Masculine form.
        /// </summary>
        [JsonPropertyName("m")]
        public string M { get; set; }
    }


    /// <summary>
    /// French demonym class.
    /// </summary>
    public class FrenchDemonym : DemonymBase
    {
    }

    /// <summary>
    /// English demonym class.
    /// </summary>
    public class EnglishDemonym : DemonymBase
    {
    }
}