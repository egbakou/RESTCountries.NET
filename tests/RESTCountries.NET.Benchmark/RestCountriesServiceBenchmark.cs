using BenchmarkDotNet.Attributes;
using RESTCountries.NET.Models;
using RESTCountries.NET.Services;

namespace RESTCountries.NET.Benchmark;

[MemoryDiagnoser]
[MediumRunJob]
public class RestCountriesServiceBenchmark
{
    [Benchmark]
    public List<Country> GetAllCountries() => RestCountriesService.GetAllCountries().ToList();
}