using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;

using RESTCountries.NET.Models;

namespace RESTCountries.NET.Services
{
    /// <summary>
    /// Defines a <see cref="RestCountriesService" />.
    /// <para>Get information about countries.</para>
    /// </summary>
    public static class RestCountriesService
    {
        private const string DataSourcePath = "RESTCountries.NET.Services.data.json";
        private static readonly IEnumerable<Country> Data;

        static RestCountriesService()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(DataSourcePath);
            Data = stream != null
                ? JsonSerializer.Deserialize<IEnumerable<Country>>(new StreamReader(stream).ReadToEnd())
                : throw new Exception("Unable to load data source.");
        }

        /// <summary>
        /// Get all countries.
        /// </summary>
        /// <returns>All countries.</returns>
        public static IEnumerable<Country> GetAllCountries() => Data.OrderBy(c => c.Name.Common);

        /// <summary>
        /// Search by country name. It can be the native name or partial name.
        /// If partial name, this method could return a list of Countries.
        /// </summary>
        /// <param name="name">Native name or partial name.</param>
        /// <returns>A list of countries or a List of one element.</returns>
        public static IEnumerable<Country> GetCountriesByNameContains(string name)
            => Data.Where(c => c.Name.Common.Contains(name, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(c => c.Name.Common);

        /// <summary>
        /// Search by country full name.
        /// </summary>
        /// <param name="fullName">Full name of the country.</param>
        /// <returns>The country which full name is provided.</returns>
        public static Country? GetCountryByFullName(string fullName)
        {
            return Data.FirstOrDefault(c =>
                c.Name.Official.Equals(fullName, StringComparison.InvariantCultureIgnoreCase) ||
                c.Name.Common.Equals(fullName, StringComparison.InvariantCultureIgnoreCase) ||
                (c.Name.NativeName != null && c.Name.NativeName.Any(n =>
                    n.Value.Common.Equals(fullName, StringComparison.InvariantCultureIgnoreCase) ||
                    n.Value.Official.Equals(fullName, StringComparison.InvariantCultureIgnoreCase))));
        }

        /// <summary>
        /// Search by Alpha 2 code or Alpha 3 code.
        /// Eg. "FR or FRA" for France. The case is not important.
        /// </summary>
        /// <param name="countryCode">Alpha 2 or Alpha 3 code.</param>
        /// <returns>The country which code is provided.</returns>
        public static Country? GetCountryByCode(string countryCode)
        {
            return Data.FirstOrDefault(c =>
                c.Cca2.Equals(countryCode, StringComparison.InvariantCultureIgnoreCase) ||
                c.Cca3.Equals(countryCode, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Search by currency code, name or currency symbol.
        /// Eg. "EUR" or "€" or "EURO" for Euro.
        /// Note: Note all countries have a currency property in the data source.
        /// </summary>
        /// <param name="currency">The currency of the desired countries.</param>
        /// <returns>Countries using the corresponding currency.</returns>
        public static IEnumerable<Country> GetCountriesByCurrency(string currency)
        {
            return Data.Where(c => c.Currencies != null && c.Currencies.Any(cc =>
                cc.Key.Equals(currency, StringComparison.InvariantCultureIgnoreCase) ||
                (cc.Value.Name != null &&
                 cc.Value.Name.Equals(currency, StringComparison.InvariantCultureIgnoreCase)) ||
                (cc.Value.Symbol != null &&
                 cc.Value.Symbol.Equals(currency, StringComparison.InvariantCultureIgnoreCase))))
                .OrderBy(c => c.Name.Common);
        }

        /// <summary>
        /// Search by language spoken the language name or code can be used.
        /// Eg. "FRA" or "French" for France.
        /// Note: Not all countries have a language property in the data source.
        /// </summary>
        /// <param name="language">The language name or code.</param>
        /// <returns>Countries that speak the provided language.</returns>
        public static IEnumerable<Country> GetCountriesByLanguage(string language)
        {
            return Data.Where(c => c.Languages != null && c.Languages.Any(l =>
                l.Key.Equals(language, StringComparison.InvariantCultureIgnoreCase) ||
                l.Value.Equals(language, StringComparison.InvariantCultureIgnoreCase)))
            .OrderBy(c => c.Name.Common);
        }

        /// <summary>
        /// Get the name of all countries.
        /// You can decide to get the official name or the common name. By default, common names are returned.
        /// You can also choose the language of the name.
        /// Use the <see cref="TranslationLanguage"/> to specify the language.
        /// Example: <code>var countries = RestCountriesService.GetAllCountriesNames(TranslationLanguage.French);</code>
        /// </summary>
        /// <param name="translationLanguage">The language.</param>
        /// <param name="useCommonName">Use the common name or the official name.</param>
        /// <returns>Enumerable of country names.</returns>
        public static IEnumerable<string> GetAllCountriesNames(
            string translationLanguage = "ENG",
            bool useCommonName = true)
        {
            // if the translation language is not provided, use the default one
            if (string.IsNullOrWhiteSpace(translationLanguage) ||
                translationLanguage.Equals("ENG", StringComparison.InvariantCultureIgnoreCase))
            {
                return Data.Select(c => useCommonName ? c.Name.Common : c.Name.Official)
                    .OrderBy(c => c);
            }

            // if the translation language is provided, use the Translation property
            return Data.Select(c => useCommonName
                    ? c.Translations.TryGetValue(translationLanguage, out var t) ? t.Common : null
                    : c.Translations.TryGetValue(translationLanguage, out var t2)
                        ? t2.Official
                        : null)
                .Where(c => c != null).OrderBy(c => c);
        }
    }
}