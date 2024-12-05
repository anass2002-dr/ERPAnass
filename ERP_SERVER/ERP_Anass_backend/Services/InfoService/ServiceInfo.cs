using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.InfoRepo;
using System;
using System.Collections.Generic;

namespace ERP_Anass_backend.Services.InfoService
{
    public class ServiceInfo : IServiceInfo
    {
        private readonly IRepoInfo _repo;

        public ServiceInfo(IRepoInfo repo)
        {
            _repo = repo;
        }

        // -------------------- CITY METHODS --------------------

        public City AddCity(City city)
        {
            return _repo.AddCity(city);
        }

        public City UpdateCity(int id, City city)
        {
            return _repo.UpdateCity(id, city);
        }

        public bool DeleteCity(int id)
        {
            return _repo.DeleteCity(id);
        }

        public City GetCityById(int id)
        {
            return _repo.GetCityById(id);
        }

        public List<City> GetCitys()
        {
            return _repo.GetCitys();
        }

        public List<dynamic> GetCitysDetails()
        {
            return _repo.GetCitysDetails();
        }

        public List<dynamic> GetCitysDetailsByCountry(int id)
        {
            return _repo.GetCitysDetailsByCountry(id);
        }
        // -------------------- COUNTRY METHODS --------------------

        public Country AddCountry(Country country)
        {
            return _repo.AddCountry(country);
        }

        public Country UpdateCountry(int id, Country country)
        {
            return _repo.UpdateCountry(id, country);
        }

        public bool DeleteCountry(int id)
        {
            return _repo.DeleteCountry(id);
        }

        public Country GetCountryById(int id)
        {
            return _repo.GetCountryById(id);
        }

        public List<Country> GetCountrys()
        {
            return _repo.GetCountrys();
        }

        public List<dynamic> GetCountrysDetails()
        {
            return _repo.GetCountrysDetails();
        }

        public Currency GetCurrencyById(int id)
        {
            return _repo.GetCurrencyById(id);
        }

        public List<Currency> GetCurrencys()
        {
            return _repo.GetCurrencys();
        }

        public Currency AddCurrency(Currency Currency)
        {
            return _repo.AddCurrency(Currency);
        }

        public Currency UpdateCurrency(int id, Currency Currency)
        {
            return _repo.UpdateCurrency(id, Currency);
        }

        public bool DeleteCurrency(int id)
        {
            return _repo.DeleteCurrency(id);
        }
    }
}
