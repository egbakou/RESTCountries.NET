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
    /// Get information about countries via a RESTful API(Current version: 2.0.5)
    /// </summary>
    public class RESTCountriesAPI
    {
        /// <summary>
        /// Defines a RestClient static object.
        /// </summary>
        private static readonly RestClient client = new RestClient();

        /// <summary>
        /// The Get all Countries.
        /// </summary>
        /// <returns>The <see cref="Task{List{Country}}"/>Countries in List Object.</returns>
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
        /// <param name="name">The name<see cref="string"/>Native name or partial name</param>
        /// <returns>The <see cref="Task{List{Country}}"/>A list of countries or List of one element.</returns>
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
    }
}
