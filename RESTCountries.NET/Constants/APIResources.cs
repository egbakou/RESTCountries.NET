namespace RESTCountries.Constants
{
    /// <summary>
    /// RESTCountries Endpoints class.
    /// Below are described the REST endpoints available that you can use to search for countries.
    /// </summary>
    public static class APIResources
    {
        public static string RESTCOUNTRIES_BASE_URI = "https://restcountries.eu/rest/v2/";
        public static string ALL_COUNTRY_SIFFIX_URI = "all/";
        public static string COUNTRY_BY_NAME_SIFFIX_URI = "name/";
        public static string COUNTRY_BY_FULLNAME_SUFFIX_URI = "?fullText=true";
        public static string COUNTRY_BY_CODE_SIFFIX_URI = "alpha/";
        public static string COUNTRY_BY_LISTOFCODES_SIFFIX_URI = "alpha?codes=";
        public static string COUNTRY_BY_CURRENCYCODE = "currency/";
        public static string COUNTRY_BY_LANGUAGECODE = "lang/";
        public static string COUNTRY_BY_CAPITALCITY = "capital/";
        public static string COUNTRY_BY_CALLINGCODE = "callingcode/";
        public static string COUNTRY_BY_CONTINENT = "region/";
        public static string COUNTRY_BY_REGIONALBLOC = "regionalbloc/";





    }
}
