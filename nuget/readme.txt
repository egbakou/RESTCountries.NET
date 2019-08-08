RESTCountries.NET 

Find the latest at: https://github.com/egbakou/RESTCountries.NET


## Note

Add namespace "RESTCountries.Services" and call "RESTCountriesAPI" class to access to all methods.

Each method return an object of type "Country"(https://github.com/egbakou/RESTCountries.NET/blob/master/src/RESTCountries.NET/Models/Country.cs)
or a List of Country. You can apply filters on the returned value to retrieve what you need. 

Example:

- Just get the name and capital city of all countries.
- Get country name in French language or Spanish language.


## Usage

- Get all countries.
List<Country> countries = await RESTCountriesAPI.GetAllCountriesAsync();

## Go to https://github.com/egbakou/RESTCountries.NET for more information.

