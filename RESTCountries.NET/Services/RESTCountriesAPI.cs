/*
RESTCountriesAPI.cs
04/08/2019 21:51:32
Kodjo Laurent Egbakou
*/

using RestSharp;

namespace RESTCountries.Services
{
    /// <summary>
    /// Defines a <see cref="RESTCountriesAPI" />
    /// </summary>
    public class RESTCountriesAPI
    {
        /// <summary>
        /// Defines a RestClient static object.
        /// </summary>
        private static readonly RestClient client = new RestClient();
    }
}
