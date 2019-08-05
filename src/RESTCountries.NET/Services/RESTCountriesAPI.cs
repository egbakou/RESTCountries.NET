/*
RESTCountriesAPI.cs
04/08/2019 21:51:32
Kodjo Laurent Egbakou
*/

using AppREstCountries.Helpers;
using Newtonsoft.Json.Linq;
using RESTCountries.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using static RESTCountries.Constants.APIResources;

namespace RESTCountries.Services
{
    /// <summary>
    /// Defines a <see cref="RESTCountriesAPI" />.
    ///<para>Get information about countries via a RESTful API(Current version: 2.0.5)</para>
    /// </summary>
    public class RESTCountriesAPI
    {
        /// <summary>
        /// Defines a RestClient static object.
        /// </summary>
        private static readonly RestClient client = new RestClient();

        /// <summary>
        /// The Get all countries.
        /// </summary>
        /// <returns>All countries.</returns>
        public static async Task<List<Country>> GetAllCountriesAsync()
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{ALL_COUNTRY_SIFFIX_URI}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new Exception("No country found. Please check if https://restcountries.eu is avialable.");
        }

        /// <summary>
        /// Search by country name. It can be the native name or partial name.
        /// If partial name, this method could return a list of Countries.
        /// </summary>
        /// <param name="name">Native name or partial name.</param>
        /// <returns>A list of countries or a List of one element.</returns>
        public static async Task<List<Country>> GetCountriesByNameContainsAsync(string name)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_NAME_SIFFIX_URI}{name}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("name", name);
        }

        /// <summary>
        /// Search by country full name.
        /// </summary>
        /// <param name="fullName">Full name of the country.</param>
        /// <returns>The country which full name is provided.</returns>
        public static async Task<Country> GetCountryByFullNameAsync(string fullName)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_NAME_SIFFIX_URI}{fullName}{COUNTRY_BY_FULLNAME_SUFFIX_URI}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray[0].ToObject<Country>();
            }
            throw new CountryNotFoundException("fullName", fullName);
        }

        /// <summary>
        /// Search by ISO 3166-1 2-letter or 3-letter country code.
        /// </summary>
        /// <param name="countryCode">ISO 3166-1 2-letter or 3-letter country code.</param>
        /// <returns>The country which ISO 3166-1 code is provided.</returns>
        public static async Task<Country> GetCountryByCodeAsync(string countryCode)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_CODE_SIFFIX_URI}{countryCode}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JObject jsonObject = JObject.Parse(response.Content);
                return jsonObject.ToObject<Country>();
            }
            throw new CountryNotFoundException("countryCode", countryCode);
        }

        /// <summary>
        /// Search by list of ISO 3166-1 2-letter or 3-letter country codes.
        /// </summary>
        /// <param name="codes">A list of ISO 3166-1 2-letter or 3-letter country codes.</param>
        /// <returns>Countries which ISO 3166-1 codes is provided.</returns>
        public static async Task<List<Country>> GetCountriesByCodesAsync(params string[] codes)
        {
            if (codes.Length == 0)
                throw new Exception("Parameter(s) can't not be null for argument 'codes'");

            string queryParams = string.Join(";", codes);
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_LISTOFCODES_SIFFIX_URI}{queryParams}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("codes", queryParams);
        }

        /// <summary>
        /// Search by ISO 4217 currency code.
        /// </summary>
        /// <param name="currencyCode">ISO 4217 currency code.</param>
        /// <returns>Countries using the corresponding currency.</returns>
        public static async Task<List<Country>> GetCountriesByCurrencyCodeAsync(string currencyCode)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_CURRENCYCODE}{currencyCode}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("currencycode", currencyCode);
        }

        /// <summary>
        /// Search by ISO 639-1 language code.
        /// </summary>
        /// <param name="languageCode">ISO 639-1 language code.</param>
        /// <returns>The country which ISO 639-1 language code is provided.</returns>
        public static async Task<List<Country>> GetCountriesByLanguageCodeAsync(string languageCode)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_LANGUAGECODE}{languageCode}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("languageCode", languageCode);
        }

        /// <summary>
        /// Search by capital city.
        /// </summary>
        /// <param name="capitalCity">Capital city name.</param>
        /// <returns>The country which capital city name is provided.</returns>
        public static async Task<Country> GetCountriesByCapitalCityAsync(string capitalCity)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_CAPITALCITY}{capitalCity}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray[0].ToObject<Country>();
            }
            throw new CountryNotFoundException("capitalCity", capitalCity);
        }

        /// <summary>
        /// Search by calling code.
        /// </summary>
        /// <param name="callingCode">Calling code.</param>
        /// <returns>The country or countries using the calling code.</returns>
        public static async Task<List<Country>> GetCountriesByCallingcodeAsync(string callingCode)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_CALLINGCODE}{callingCode}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("callingCode", callingCode);
        }

        /// <summary>
        /// Search by continent: Africa, Americas, Asia, Europe, Oceania.
        /// </summary>
        /// <param name="continent">Continent name.</param>
        /// <returns>Countries which is in the continent.</returns>
        public static async Task<List<Country>> GetCountriesByContinentAsync(string continent)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_CONTINENT}{continent}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("continent", continent);
        }

        /// <summary>
        /// Search by regional bloc:
        /// <para>- EU(European Union)</para>
        /// <para>- EFTA(European Free Trade Association)</para>
        /// <para>- CARICOM(Caribbean Community)</para>
        /// <para>- PA(Pacific Alliance)</para>
        /// <para>- AU(African Union)</para>
        /// <para>- USAN(Union of South American Nations)</para>
        /// <para>- EEU(Eurasian Economic Union)</para>
        /// <para>- AL(Arab League)</para>
        /// <para>- ASEAN(Association of Southeast Asian Nations)</para>
        /// <para>- CAIS(Central American Integration System)</para>
        /// <para>- CEFTA(Central European Free Trade Agreement)</para>
        /// <para>- NAFTA(North American Free Trade Agreement)</para>
        /// <para>- SAARC(South Asian Association for Regional Cooperation)</para>
        /// </summary>
        /// <param name="regionalBloc">Regional bloc(eg: EU).</param>
        /// <returns>Countries which is in the regional bloc.</returns>
        public static async Task<List<Country>> GetCountriesByRegionalBlocAsync(string regionalBloc)
        {
            var request = new RestRequest(
                $"{RESTCOUNTRIES_BASE_URI}{COUNTRY_BY_REGIONALBLOC}{regionalBloc}",
                Method.GET,
                DataFormat.Json);
            IRestResponse response = await client.ExecuteGetTaskAsync(request);
            if (response.IsSuccessful && response.StatusCode.HasFlag(HttpStatusCode.OK))
            {
                JArray jsonArray = JArray.Parse(response.Content);
                return jsonArray.ToObject<List<Country>>();
            }
            throw new CountryNotFoundException("regionalBloc", regionalBloc);
        }
    }
}
