# <img src="art/icon.png" alt="Icon" width="50" />RESTCountries.NET 

This is a .NET wrapper library around the API provided by REST Countries https://restcountries.eu (Get information about countries via a RESTful API).

## Setup

- Available on NuGet: https://www.nuget.org/packages/RESTCountries.NET/ [![NuGet](https://img.shields.io/nuget/v/RESTCountries.NET.svg?label=NuGet)](https://www.nuget.org/packages/RESTCountries.NET/)
- Install into your .NET project.

## Usage

Add namespace `RESTCountries.Services` and call `RESTCountriesAPI` class to access to all methods:

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