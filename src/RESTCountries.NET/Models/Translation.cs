using System.Text.Json.Serialization;

namespace RESTCountries.NET.Models
{
    /// <summary>
    /// Translation class.
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// Gets or sets official name.
        /// </summary>
        [JsonPropertyName("official")]
        public string Official { get; set; }

        /// <summary>
        /// Gets or sets common used name.
        /// </summary>
        [JsonPropertyName("common")]
        public string Common { get; set; }
    }

    /// <summary>
    /// https://iso639-3.sil.org/code/{code}.
    /// </summary>
    public static class TranslationLanguage
    {
        /// <summary>
        /// Arabic language.
        /// </summary>
        public static readonly string Arabic = "arb";

        /// <summary>
        /// Breton language.
        /// </summary>
        public static readonly string Breton = "bre";

        /// <summary>
        /// Czech language.
        /// </summary>
        public static readonly string Czech = "ces";

        /// <summary>
        /// Welsh language.
        /// </summary>
        public static readonly string Welsh = "cym";

        /// <summary>
        /// German language.
        /// </summary>
        public static readonly string German = "deu";

        /// <summary>
        /// Estonian language.
        /// </summary>
        public static readonly string Estonian = "est";

        /// <summary>
        /// Finnish language.
        /// </summary>
        public static readonly string Finnish = "fin";

        /// <summary>
        /// French language.
        /// </summary>
        public static readonly string French = "fra";

        /// <summary>
        /// Croatian language.
        /// </summary>
        public static readonly string Croatian = "hrv";

        /// <summary>
        /// Hungarian language.
        /// </summary>
        public static readonly string Hungarian = "hun";

        /// <summary>
        /// Italian language.
        /// </summary>
        public static readonly string Italian = "ita";

        /// <summary>
        /// Japanese language.
        /// </summary>
        public static readonly string Japanese = "jpn";

        /// <summary>
        /// Korean language.
        /// </summary>
        public static readonly string Korean = "kor";

        /// <summary>
        /// Dutch language.
        /// </summary>
        public static readonly string Dutch = "nld";

        /// <summary>
        /// Persian language.
        /// </summary>
        public static readonly string Persian = "per";

        /// <summary>
        /// Polish language.
        /// </summary>
        public static readonly string Polish = "pol";

        /// <summary>
        /// Russian language.
        /// </summary>
        public static readonly string Russian = "rus";

        /// <summary>
        /// Slovak language.
        /// </summary>
        public static readonly string Slovak = "slk";

        /// <summary>
        /// Spanish language.
        /// </summary>
        public static readonly string Spanish = "spa";

        /// <summary>
        /// Swedish language.
        /// </summary>
        public static readonly string Swedish = "swe";

        /// <summary>
        /// Turkish language.
        /// </summary>
        public static readonly string Turkish = "tur";

        /// <summary>
        /// Urdu language.
        /// </summary>
        public static readonly string Urdu = "urd";

        /// <summary>
        /// Chinese language.
        /// </summary>
        public static readonly string Chinese = "zho";
    }
}