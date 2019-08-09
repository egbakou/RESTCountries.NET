# <img src="art/icon.png" alt="Icon" width="60" />RESTCountries.NET 

This is a .NET wrapper library around the API provided by REST Countries https://restcountries.eu (Get information about countries via a RESTful API).

## Setup

- Available on NuGet: https://www.nuget.org/packages/RESTCountries.NET/ [![NuGet](https://img.shields.io/nuget/v/RESTCountries.NET.svg?label=NuGet)](https://www.nuget.org/packages/RESTCountries.NET/)
- Install into your .NET project(.NET Standard, .NET Core, Xamarin, etc).

## Note

Add `namespace` `RESTCountries.Services` and call `RESTCountriesAPI` class to access to all methods.

Each method return an object of type [`Country`](https://github.com/egbakou/RESTCountries.NET/blob/master/src/RESTCountries.NET/Models/Country.cs) or a `List` of [`Country`](https://github.com/egbakou/RESTCountries.NET/blob/master/src/RESTCountries.NET/Models/Country.cs). You can apply filters on the returned value to retrieve what you need. 

Example:

- Just get the name and capital city of all countries.
- Get country name in French language or Spanish language.

Default language for country name is English, but you can also get the name in other languages such as: `de`(German language),  `es`(Spanish language), `fr`(French language),  `ja`(Japanese language), `it`(Italian language), `br`(Breton language), `pt`(Portuguese language), `nl`(Dutch language), `hr`(Croatian language) and `fa`(Persian language).

## Usage

- Get all countries.

```csharp
// Get all countries
List<Country> countries = await RESTCountriesAPI.GetAllCountriesAsync();
```

- Search by country name. It can be the native name or partial name.

```csharp
// Search by country name
List<Country> result = await RESTCountriesAPI.GetCountriesByNameContainsAsync(string name);
```

If partial name, this method could return a list of countries. Else a List of one element.

- Search by country full name.

```csharp
// Search by country full name
Country result = await RESTCountriesAPI.GetCountryByFullNameAsync(string fullName);
```

-  Search by ISO 3166-1 2-letter or 3-letter country code.

```csharp
// Search by list of ISO 3166-1 2-letter or 3-letter country codes
Country result = await RESTCountriesAPI.GetCountryByCodeAsync(string countryCode);
```

-  Search by list of ISO 3166-1 2-letter or 3-letter country codes.

```csharp
// Search by list of ISO 3166-1 2-letter or 3-letter country codes
List<Country> result = await RESTCountriesAPI.GetCountriesByCodesAsync(params string[] codes);
```

- Search by ISO 4217 currency code.

```csharp
// Search by ISO 4217 currency code
List<Country> result = await RESTCountriesAPI.GetCountriesByCurrencyCodeAsync(string currencyCode);
```

- Search by ISO 639-1 language code.

```csharp
// Search by ISO 639-1 language code
List<Country> result = await RESTCountriesAPI.GetCountriesByLanguageCodeAsync(string languageCode);
```

-  Search by capital city.

```csharp
// Search by capital city
var result = await RESTCountriesAPI.GetCountryByCapitalCityAsync(string capitalCity);
```

You can use `var` instead of explicit types. I use explicit types to show you the return type of each method.

- Search by calling code.

```csharp
// Search by calling code
List<Country> result = await RESTCountriesAPI.GetCountriesByCallingCodeAsync(string callingCode);
```

-  Search by continent: Africa, Americas, Asia, Europe, Oceania.

```csharp
//  Search by continent: Africa, Americas, Asia, Europe, Oceania
List<Country> result = await RESTCountriesAPI.GetCountriesByContinentAsync(string continent);
```

- Search by regional bloc: EU, EFTA, CARICOM, AU, USAN, EEU, AL, ASEAN , CAIS, CEFTA , NAFTA , SAARC.

```csharp
//  Search by regional bloc
List<Country> result = await RESTCountriesAPI.GetCountriesByRegionalBlocAsync(string regionalBloc);
```

EU (European Union), EFTA (European Free Trade Association), CARICOM (Caribbean Community), PA (Pacific Alliance), AU (African Union), USAN (Union of South American Nations), EEU (Eurasian Economic Union), AL (Arab League), ASEAN (Association of Southeast Asian Nations), CAIS (Central American Integration System), CEFTA (Central European Free Trade Agreement), NAFTA (North American Free Trade Agreement), SAARC (South Asian Association for Regional Cooperation).

## Country class

```csharp
public class Country
{	
    // Gets or sets the Name
    public string Name { get; set; }
  
    // Gets or sets the Top Level Domain
    public IList<string> TopLevelDomain { get; set; }
  
    // Gets or sets the Alpha2 Code
    public string Alpha2Code { get; set; }
  
    // Gets or sets the Alpha3 Code
    public string Alpha3Code { get; set; }
  
    // Gets or sets the Calling Codes
    public IList<string> CallingCodes { get; set; }
  
    // Gets or sets the Capital City
    public string Capital { get; set; }
  
    // Gets or sets the Alt Spellings
    public IList<string> AltSpellings { get; set; }    
   
    // Gets or sets the Region
    public string Region { get; set; }
  
    // Gets or sets the Subregion
    public string Subregion { get; set; }
   
    // Gets or sets the Population
    public int Population { get; set; }
  
    // Gets or sets the Latlng(Latitude and Longitude)
    public IList<double> Latlng { get; set; }
   
    // Gets or sets the Demonym
    public string Demonym { get; set; }
   
    // Gets or sets the Area
    public double? Area { get; set; }
  
    // Gets or sets the Gini
    public double? Gini { get; set; }
   
    // Gets or sets the Timezones
    public IList<string> Timezones { get; set; }

    // Gets or sets the Borders
    public IList<string> Borders { get; set; }

    // Gets or sets the Native Name
    public string NativeName { get; set; }

    // Gets or sets the Numeric Code
    public string NumericCode { get; set; }

    // Gets or sets the Currencies
    public IList<Currency> Currencies { get; set; }

    // Gets or sets the Languages
    public IList<Language> Languages { get; set; }

    // Gets or sets the Translations
    public Translations Translations { get; set; }

    // Gets or sets the Flag
    public string Flag { get; set; }

    // Gets or sets the Regional Blocs
    public IList<RegionalBloc> RegionalBlocs { get; set; }

    // Gets or sets the Cioc(International Olympic Committee Code)
    public string Cioc { get; set; }
}
```



## Created by: Kodjo Laurent Egbakou

- LinkedIn: [Kodjo Laurent Egbakou](https://www.linkedin.com/in/laurentegbakou/)
- Twitter: [@lioncoding](https://twitter.com/lioncoding)

## License

The MIT License (MIT) see [License file](https://github.com/egbakou/RESTCountries.NET/blob/master/LICENSE)

## Contribution

Feel free to create issues and PRs 😃