using BenchmarkDotNet.Running;
using RESTCountries.NET.Benchmark;

// CountryData.Standard is not optimized during build,
// So to avoid benchmark errors, we need to disable the OptimizationValidator
/*var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddValidator(JitOptimizationsValidator.DontFailOnError)
    .AddLogger(ConsoleLogger.Default)
    .AddColumnProvider(DefaultColumnProviders.Instance);*/

BenchmarkRunner.Run<RestCountriesServiceBenchmark>();