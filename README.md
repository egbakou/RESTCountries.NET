# <img src="art/icon.png" alt="Icon" width="50" />RESTCountries.NET 

This is a .NET wrapper library around the API provided by REST Countries https://restcountries.eu (Get information about countries via a RESTful API).

## Setup

- Available on NuGet: https://www.nuget.org/packages/RESTCountries.NET/ [![NuGet](https://img.shields.io/nuget/v/RESTCountries.NET.svg?label=NuGet)](https://www.nuget.org/packages/RESTCountries.NET/)
- Install into your .NET project.

## Note

Add `namespace` `RESTCountries.Services` and call `RESTCountriesAPI` class to access to all methods.

Each method return an object of type [`Country`](https://github.com/egbakou/RESTCountries.NET/blob/master/src/RESTCountries.NET/Models/Country.cs) or a `List`. You can apply filter on the return value to retrieve what you need. 

Example:

- Just get the name and capital of all countries.
- Get country name in French language or Spanish language.
- ...

Default language for country name is English But you can also get the name in other language such as: `de`(German language),  `es`(Spanish language), `fr`(French language),  `ja`(Japanese language), `it`(Italian language), `br`(Breton language), `pt`(Portuguese language), `nl`(Dutch language), `hr`(Croatian language), `fa`(Persian language).

## Usage

- Get all countries

```csharp
// Get all countries
List<Country> countries = await RESTCountriesAPI.GetAllCountriesAsync();
```

## Created by: Kodjo Laurent Egbakou

- LinkedIn: [Kodjo Laurent Egbakou](https://www.linkedin.com/in/laurentegbakou/)
- Twitter: [@lioncoding](https://twitter.com/lioncoding)

## License

The MIT License (MIT) see [License file](https://github.com/egbakou/App.User.LocationInfo/blob/master/LICENSE)

## Contribution

Feel free to create issues and PRs 😃