using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.InfoRepo
{
    public interface IRepoInfo
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
        List<City> GetCitys();
        City AddCity(City City);
        City UpdateCity(int id, City City);
        Boolean DeleteCity(int id);

    }
}
