using System.Linq;

using RESTCountries.NET.Models;
using RESTCountries.NET.Services;

using Shouldly;

using Xunit;

namespace RESTCountries.NET.Tests
{
    public class RestCountriesServiceTests
    {
        [Fact]
        public void GetAllCountries_Should_Return_List()
        {
            var result = RestCountriesService.GetAllCountries().ToList();
            result.ShouldNotBeEmpty();
            result.Count().ShouldBeGreaterThan(100);

            // Check if the first country is Afghanistan
            result.First().Name.Common.ShouldBe("Afghanistan");
        }

        [Fact]
        public void GetCountriesByNameContains_Should_Return_Corrected_Countries()
        {
            var result = RestCountriesService.GetCountriesByNameContains("a").ToList();
            result.ShouldNotBeEmpty();
            result.ShouldContain(c => c.Name.Common.Equals("France"));
            result.ShouldContain(c => c.Name.Common.Equals("Spain"));
            result.ShouldContain(c => c.Name.Common.Equals("Italy"));
            result.ShouldContain(c => c.Name.Common.Equals("Germany"));

            // wrong case
            result = RestCountriesService.GetCountriesByNameContains("kkkkk").ToList();
            result.ShouldBeEmpty();
        }

        [Fact]
        public void GetCountryByFullName_Should_Return_The_Right_Result()
        {
            // search using the common name
            var togo = RestCountriesService.GetCountryByFullName("Togo");
            togo.ShouldNotBeNull();
            togo.Name.Common.ShouldBe("Togo");

            // search using the official full name
            var france = RestCountriesService.GetCountryByFullName("république française");
            france.ShouldNotBeNull();
            france.Name.Common.ShouldBe("France");

            // Wrong name
            var nullResult = RestCountriesService.GetCountryByFullName("France1");
            nullResult.ShouldBeNull();
        }

        [Fact]
        public void GetCountryByCode_Should_Return_One_Country_Or_Null()
        {
            var result = RestCountriesService.GetCountryByCode("TGO");
            result.ShouldNotBeNull();
            result.Name.Common.ShouldBe("Togo");

            result = RestCountriesService.GetCountryByCode("us");
            result.ShouldNotBeNull();
            result.Name.Common.ShouldBe("United States");

            // Wrong case
            result = RestCountriesService.GetCountryByCode("yy");
            result.ShouldBeNull();
        }

        [Fact]
        public void GetCountriesByCurrency_Should_Return_Right_Result()
        {
            var result = RestCountriesService.GetCountriesByCurrency("EUR").ToList();
            result.ShouldNotBeEmpty();
            result.ShouldContain(c => c.Name.Common.Equals("France"));
            result.ShouldContain(c => c.Name.Common.Equals("Spain"));
            result.ShouldContain(c => c.Name.Common.Equals("Italy"));
            result.ShouldContain(c => c.Name.Common.Equals("Germany"));
            result.ShouldContain(c => c.Name.Common.Equals("Croatia"));

            // Wrong case
            result = RestCountriesService.GetCountriesByCurrency("kkkkk").ToList();
            result.ShouldBeEmpty();

            // v3.2.0
            // BA(Bosnia and Herzegovina) curency should be BAM
            var bosnia = RestCountriesService.GetCountriesByCurrency("BAM").ToList();
            bosnia.ShouldNotBeEmpty();
            bosnia.ShouldContain(c => c.Cca2.Equals("BA"));

            // Sudan currency is SDG
            var sudan = RestCountriesService.GetCountriesByCurrency("SDG").ToList();
            sudan.ShouldNotBeEmpty();
            sudan.ShouldContain(c => c.Cca2.Equals("SD"));
        }

        [Fact]
        public void GetCountriesByLanguage_Should_Return_Right_Result()
        {
            var result = RestCountriesService.GetCountriesByLanguage("french").ToList();
            result.ShouldNotBeEmpty();
            result.ShouldContain(c => c.Name.Common.Equals("France"));
            result.ShouldContain(c => c.Name.Common.Equals("Belgium"));
            result.ShouldContain(c => c.Name.Common.Equals("Benin"));
            result.ShouldContain(c => c.Name.Common.Equals("Switzerland"));
            result.ShouldContain(c => c.Name.Common.Equals("Canada"));

            // Wrong case
            result = RestCountriesService.GetCountriesByLanguage("kkkkk").ToList();
            result.ShouldBeEmpty();
        }

        [Fact]
        public void GetAllCountriesNames_Should_Return_Right_Result()
        {
            // Test with default parameters
            var result = RestCountriesService.GetAllCountriesNames().ToList();
            result.ShouldNotBeEmpty();
            result.ShouldContain("Afghanistan");
            result.ShouldContain("Zimbabwe");

            // Test using a translation language: French
            result = RestCountriesService.GetAllCountriesNames(TranslationLanguage.French).ToList();
            result.ShouldNotBeEmpty();
            result.ShouldContain("Bénin");
            result.ShouldContain("Corée du Sud");
            result.ShouldContain("Pologne");
            result.ShouldContain("République centrafricaine");
            result.ShouldContain("Congo (Rép. dém.)");
            result.ShouldContain("États-Unis");

            // Test using a German translation
            result = RestCountriesService.GetAllCountriesNames(TranslationLanguage.German).ToList();
            result.ShouldNotBeEmpty();
            result.ShouldContain("Frankreich");

            // Wrong case
            result = RestCountriesService.GetAllCountriesNames("unknow language").ToList();
            result.ShouldBeEmpty();
        }
    }
}