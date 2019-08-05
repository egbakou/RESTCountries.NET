/*
CountryNotFoundException.cs
04/08/2019 21:44:30
Kodjo Laurent Egbakou
*/

using System;

namespace AppREstCountries.Helpers
{
    /// <summary>
    /// Defines a <see cref="CountryNotFoundException" />
    /// </summary>
    public class CountryNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryNotFoundException"/> class.
        /// </summary>
        /// <param name="field">Field</param>
        /// <param name="value">Value</param>
        public CountryNotFoundException(string field, String value)
        : base(String.Format("Country not found using field '{0}' with value '{1}.", field, value))
        {
        }
    }
}
