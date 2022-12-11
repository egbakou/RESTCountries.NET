using BenchmarkDotNet.Attributes;
using RESTCountries.NET.Services;
using RESTCountries.NET.Models;

namespace RESTCountries.NET.Benchmark;

[MemoryDiagnoser]
[MediumRunJob]
public class RestCountriesServiceBenchmark
{

    [Benchmark]
    public List<Country> GetAllCountries() => RestCountriesService.GetAllCountries().ToList();
}