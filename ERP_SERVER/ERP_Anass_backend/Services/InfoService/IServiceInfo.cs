using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.InfoService
{
    public interface IServiceInfo
    {
        //Country
        Country GetCountryById(int id);
        List<dynamic> GetCountrysDetails();
        List<Country> GetCountrys();
        Country AddCountry(Country Country);
        Country UpdateCountry(int id, Country Country);
        Boolean DeleteCountry(int id);

        //City
        City GetCityById(int id);
        List<dynamic> GetCitysDetails();
        List<dynamic> GetCitysDetailsByCountry(int id);
        List<City> GetCitys();
        City AddCity(City City);
        City UpdateCity(int id, City City);
        Boolean DeleteCity(int id);

        //Currency
        Currency GetCurrencyById(int id);
        List<Currency> GetCurrencys();
        Currency AddCurrency(Currency Currency);
        Currency UpdateCurrency(int id, Currency Currency);
        Boolean DeleteCurrency(int id);

    }
}
