using RESTCountries.Models;
using RESTCountries.Services;
using Shouldly;
using System;
using Xunit;

namespace RESTCountries.NET.Tests
{
    public class UnitTests
    {
        [Fact]
        public async void GetAllCountriesAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetAllCountriesAsync();
            result.ShouldNotBeNull();
            result.ShouldNotBeEmpty();
            result.Count.ShouldBeGreaterThan(100);
        }

        [Fact]
        public async void GetCountriesByNameContainsAsync_Should_Return_Country()
        {
            var result = await RESTCountriesAPI.GetCountriesByNameContainsAsync("tog");
            result.ShouldNotBeNull();
            result.Count.ShouldBe(1);
        }

        [Fact]
        public async void GetCountryByFullNameAsync_Should_Return_Country()
        {
            var result = await RESTCountriesAPI.GetCountryByFullNameAsync("italy");
            result.ShouldNotBeNull();
            result.ShouldBeOfType<Country>();
        }

        [Fact]
        public async void GetCountryByCodeAsync_Should_Return_Country()
        {
            var result = await RESTCountriesAPI.GetCountryByCodeAsync("us");
            result.ShouldNotBeNull();
            result.Name.ShouldBe("United States of America");
        }

        [Fact]
        public async void GetCountriesByCodesAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountriesByCodesAsync("us", "fr", "ca");
            result.ShouldNotBeNull();
            result.Count.ShouldBe(3);
        }

        [Fact]
        public async void GetCountriesByCurrencyCodeAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountriesByCurrencyCodeAsync("eur");
            result.ShouldNotBeNull();
            result.Count.ShouldBeGreaterThan(2);
        }

        [Fact]
        public async void GetCountriesByLanguageCodeAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountriesByLanguageCodeAsync("en");
            result.ShouldNotBeNull();
            result.Count.ShouldBeGreaterThan(2);
        }

        [Fact]
        public async void GetCountryByCapitalCityAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountryByCapitalCityAsync("lome");
            result.ShouldNotBeNull();
            result.Name.ShouldBe("Togo");
        }

        [Fact]
        public async void GetCountriesByCallingCodeAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountriesByCallingCodeAsync("33");
            result.ShouldNotBeNull();
            result.Count.ShouldBeGreaterThanOrEqualTo(1);
        }

        [Fact]
        public async void GetCountriesByContinentAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountriesByContinentAsync("africa");
            result.ShouldNotBeNull();
            result.Count.ShouldBeGreaterThanOrEqualTo(54);
        }

        [Fact]
        public async void GetCountriesByRegionalBlocAsync_Should_Return_List()
        {
            var result = await RESTCountriesAPI.GetCountriesByRegionalBlocAsync("eu");
            result.ShouldNotBeNull();
            var test = await RESTCountriesAPI.GetCountryByCapitalCityAsync("london");
            result.ShouldNotContain(test);
        }
    }
}
