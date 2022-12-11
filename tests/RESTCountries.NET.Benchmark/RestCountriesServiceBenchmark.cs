using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using CountryData.Standard;
using RESTCountries.NET.Services;
using Country = RESTCountries.NET.Models.Country;
using CountryDataCountry = CountryData.Standard.Country;

namespace RESTCountries.NET.Benchmark;

[MemoryDiagnoser]
[MediumRunJob]
[Config(typeof(Config))]
public class RestCountriesServiceBenchmark
{
    private class Config : ManualConfig
    {
        public Config()
        {
            AddJob(Job.MediumRun);
            AddColumn(new TagColumn("Nuget", name =>
                name.StartsWith("GetAll") ? "RESTCountries.NET 3.0.0" : "CountryData.Standard 1.3.0"));
        }
    }
    
    [Benchmark]
    [Arguments("RESTCountries.NET")]
    public List<Country> GetAllCountries() => RestCountriesService.GetAllCountries().ToList();

    [Benchmark]
    [Arguments("CountryData.Standard")]
    public List<CountryDataCountry> GetCountryData()
    {
        var helper = new CountryHelper();
        return helper.GetCountryData().ToList();
    }
}