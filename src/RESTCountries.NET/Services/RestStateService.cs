using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using RESTCountries.NET.Models;

namespace RESTCountries.NET.Services
{
    /// <summary>
    /// Serves as a static repository for geographical data, specifically states and cities, within applications. This class provides efficient, read-only access to structured geographical information, making it ideal for applications that require reliable and quick access to such data without the overhead of dynamic data loading or external database dependencies.
    ///
    /// Functionality:
    /// - Retrieves lists of states within a specified country, identified by ISO2 country codes.
    /// - Retrieves lists of cities within a specified state, supporting both state-only and state-country queries.
    ///
    /// Designed to be used as part of a larger library, RestStateService abstracts away the complexities of geographical data management, offering straightforward methods for accessing the data. This approach allows developers to incorporate geographical information into their applications seamlessly, with minimal setup or configuration.
    ///
    /// Example Usage:
    /// var statesInUS = RestStateService.GetStatesInCountry("US");
    /// var citiesInCalifornia = RestStateService.GetCitiesInState("CA");
    ///
    /// Note:
    /// The geographical data is preloaded from an embedded JSON resource, ensuring fast access times and consistency across application instances. As such, no external data loading or initialization is required from the consumer's side.
    /// </summary>
    internal static class RestStateService
    {
        private static readonly Dictionary<string, IEnumerable<State>> statesByCountry;
        private static readonly Dictionary<string, State> statesByCountryAndStateCode;

        /// <summary>
        ///     Instantiates the RestStateService by loading state and city location data embedded within the assembly.
        ///     This constructor attempts to locate and deserialize the JSON data from an embedded resource, organizing it into
        ///     useful structures for quick access. It ensures the service is ready to use immediately after instantiation by
        ///     pre-loading all necessary data.
        ///     The data is organized into two primary dictionaries for efficient retrieval: one mapping country codes to their
        ///     corresponding states, and another mapping state codes to their detailed state information. This organization
        ///     facilitates rapid lookup operations for states and cities by their respective codes.
        ///     Exception Handling:
        ///     If the JSON data file cannot be found or an error occurs during deserialization, the constructor throws an
        ///     exception,
        ///     preventing the instantiation of the class with invalid or incomplete data. This approach ensures that any instance
        ///     of RestStateService is fully operational and contains all necessary location data upon creation.
        ///     Usage Note:
        ///     Ensure the JSON data file is correctly embedded within the assembly and accessible via the specified resource path.
        ///     Incorrect file paths or missing resources will result in exceptions, indicating initialization failures.
        /// </summary>
        static RestStateService()
        {
            IEnumerable<State> allStates;
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string zipResourcePath = "RESTCountries.NET.Services.states.json.zip";

                using var zipStream = assembly.GetManifestResourceStream(zipResourcePath);
                if (zipStream == null) throw new Exception("Unable to load ZIP resource.");

                using var archive = new ZipArchive(zipStream, ZipArchiveMode.Read);
                ZipArchiveEntry entry = archive.GetEntry("states.json"); 

                if (entry == null) throw new Exception("JSON file not found inside ZIP.");

                using var entryStream = entry.Open();
                using var streamReader = new StreamReader(entryStream);
                
                allStates = streamReader != null
                    ? JsonSerializer.Deserialize<IEnumerable<State>>(streamReader.ReadToEnd())
                    : throw new Exception("Unable to load data source.");


                // Organizes states by country code for efficient retrieval.
                if (allStates != null)
                {
                    statesByCountry = allStates.GroupBy(s => s.CountryCode)
                        .ToDictionary(g => g.Key, g => g.AsEnumerable());

                    // Organizes states by concatenating country code and state code for unique access.
                    statesByCountryAndStateCode = allStates
                        .ToDictionary(s => $"{s.CountryCode}:{s.Code}", s => s);
                }
            }
            catch (Exception ex)
            {
                statesByCountry = new Dictionary<string, IEnumerable<State>>();
                statesByCountryAndStateCode = new Dictionary<string, State>();
                allStates = new List<State>();
                throw new Exception($"An error occurred while initializing state location data: {ex.Message}");
            }
        }

        /// <summary>
        ///     Retrieves all states within a given country, identified by its ISO2 country code.
        /// </summary>
        /// <param name="countryCode">The ISO2 country code of the country.</param>
        /// <returns>A list of State objects within the specified country. Returns an empty list if no states are found.</returns>
        public static IEnumerable<State> GetStatesInCountry(string countryCode)
        {
            return statesByCountry.TryGetValue(countryCode, out var states) ? states : new List<State>();
        }

        /// <summary>
        ///     Retrieves all cities within a given state, identified by its state code and country code.
        /// </summary>
        /// <param name="stateCode">The code of the state.</param>
        /// <param name="countryCode">The ISO2 code of the country.</param>
        /// <returns>
        ///     A list of City objects within the specified state. Returns an empty list if no cities are found or the state
        ///     does not exist.
        /// </returns>
        public static IEnumerable<City> GetCitiesInState(string stateCode, string countryCode)
        {
            var key = $"{countryCode}:{stateCode}";
            if (statesByCountryAndStateCode.TryGetValue(key, out var state))
            {
                return state.Cities;
            }

            return new List<City>();
        }
    }
}