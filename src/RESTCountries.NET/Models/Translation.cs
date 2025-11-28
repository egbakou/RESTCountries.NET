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
        /// English language.
        /// </summary>
        public const string English = "eng";

        /// <summary>
        /// Arabic language.
        /// </summary>
        public const string Arabic = "arb";

        /// <summary>
        /// Breton language.
        /// </summary>
        public const string Breton = "bre";

        /// <summary>
        /// Czech language.
        /// </summary>
        public const string Czech = "ces";

        /// <summary>
        /// Welsh language.
        /// </summary>
        public const string Welsh = "cym";

        /// <summary>
        /// German language.
        /// </summary>
        public const string German = "deu";

        /// <summary>
        /// Estonian language.
        /// </summary>
        public const string Estonian = "est";

        /// <summary>
        /// Finnish language.
        /// </summary>
        public const string Finnish = "fin";

        /// <summary>
        /// French language.
        /// </summary>
        public const string French = "fra";

        /// <summary>
        /// Croatian language.
        /// </summary>
        public const string Croatian = "hrv";

        /// <summary>
        /// Hungarian language.
        /// </summary>
        public const string Hungarian = "hun";

        /// <summary>
        /// Italian language.
        /// </summary>
        public const string Italian = "ita";

        /// <summary>
        /// Japanese language.
        /// </summary>
        public const string Japanese = "jpn";

        /// <summary>
        /// Korean language.
        /// </summary>
        public const string Korean = "kor";

        /// <summary>
        /// Dutch language.
        /// </summary>
        public const string Dutch = "nld";

        /// <summary>
        /// Persian language.
        /// </summary>
        public const string Persian = "per";

        /// <summary>
        /// Polish language.
        /// </summary>
        public const string Polish = "pol";

        /// <summary>
        /// Russian language.
        /// </summary>
        public const string Russian = "rus";

        /// <summary>
        /// Slovak language.
        /// </summary>
        public const string Slovak = "slk";

        /// <summary>
        /// Spanish language.
        /// </summary>
        public const string Spanish = "spa";

        /// <summary>
        /// Swedish language.
        /// </summary>
        public const string Swedish = "swe";

        /// <summary>
        /// Turkish language.
        /// </summary>
        public const string Turkish = "tur";

        /// <summary>
        /// Urdu language.
        /// </summary>
        public const string Urdu = "urd";

        /// <summary>
        /// Chinese language.
        /// </summary>
        public const string Chinese = "zho";
    }
}