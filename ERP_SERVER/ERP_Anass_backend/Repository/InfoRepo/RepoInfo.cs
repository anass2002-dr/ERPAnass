using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP_Anass_backend.Repository.InfoRepo
{
    public class RepoInfo : IRepoInfo
    {
        private readonly DbContextERP _context;

        public RepoInfo(DbContextERP context)
        {
            _context = context;
        }

        // -------------------- CITY METHODS --------------------

        public City AddCity(City city)
        {
            _context.City.Add(city);
            _context.SaveChanges();
            return city;
        }

        public City UpdateCity(int id, City city)
        {
            var existingCity = _context.City.FirstOrDefault(c => c.CityID == id);
            if (existingCity == null)
                return null;

            existingCity.CityName = city.CityName;
            existingCity.zipCode = city.zipCode != 0 ? city.zipCode : existingCity.zipCode;
            existingCity.CountryId = city.CountryId != 0 ? city.CountryId : existingCity.CountryId;

            _context.SaveChanges();
            return existingCity;
        }

        public bool DeleteCity(int id)
        {
            var city = _context.City.FirstOrDefault(c => c.CityID == id);
            if (city == null)
                return false;

            _context.City.Remove(city);
            _context.SaveChanges();
            return true;
        }

        public City GetCityById(int id)
        {
            return _context.City.Include(c => c.Country).FirstOrDefault(c => c.CityID == id);
        }

        public List<City> GetCitys()
        {
            return _context.City.Include(c => c.Country).ToList();
        }

        public List<dynamic> GetCitysDetails()
        {
            return _context.City.Include(c => c.Country)
                .Select(c => new
                {
                    c.CityID,
                    c.CityName,
                    c.zipCode,
                    Country = c.Country.CountryName,
                    c.CountryId
                }).ToList<dynamic>();
        }

        public List<dynamic> GetCitysDetailsByCountry(int id)
        {
            return _context.City.Where(c => c.CountryId == id)
                .Include(c => c.Country)

                .Select(c => new
                {
                    c.CityID,
                    c.CityName,
                    c.zipCode,
                    Country = c.Country.CountryName,
                    c.CountryId
                }).ToList<dynamic>();
        }

        // -------------------- COUNTRY METHODS --------------------

        public Country AddCountry(Country country)
        {
            _context.Country.Add(country);
            _context.SaveChanges();
            return country;
        }

        public Country UpdateCountry(int id, Country country)
        {
            var existingCountry = _context.Country.FirstOrDefault(c => c.CountryId == id);
            if (existingCountry == null)
                return null;

            existingCountry.CountryName = country.CountryName;

            _context.SaveChanges();
            return existingCountry;
        }

        public bool DeleteCountry(int id)
        {
            var country = _context.Country.FirstOrDefault(c => c.CountryId == id);
            if (country == null)
                return false;

            _context.Country.Remove(country);
            _context.SaveChanges();
            return true;
        }

        public Country GetCountryById(int id)
        {
            return _context.Country.Include(c => c.City).FirstOrDefault(c => c.CountryId == id);
        }

        public List<Country> GetCountrys()
        {
            return _context.Country.Include(c => c.City).ToList();
        }

        public List<dynamic> GetCountrysDetails()
        {
            return _context.Country.Include(c => c.City)
                .Select(c => new
                {
                    c.CountryId,
                    c.CountryName,
                    Cities = c.City.Select(city => city.CityName).ToList()
                }).ToList<dynamic>();
        }

        public Currency GetCurrencyById(int id)
        {
            return _context.Currency.Where(e => e.IdCurrency == id && e.IsAcitve).FirstOrDefault();
        }



        public List<Currency> GetCurrencys()
        {

            return _context.Currency.Where(e => e.IsAcitve).ToList();
        }

        public Currency AddCurrency(Currency Currency)
        {
            _context.Currency.Add(Currency);
            _context.SaveChanges();
            return Currency;
        }

        public Currency UpdateCurrency(int id, Currency Currency)
        {
            var existingCurrency = GetCurrencyById(id);
            if (existingCurrency != null)
            {
                existingCurrency.CurrencyName = Currency.CurrencyName;
                _context.SaveChanges();
            }
            return Currency;
        }

        public bool DeleteCurrency(int id)
        {
            try
            {
                var existingCurrency = GetCurrencyById(id);
                if (existingCurrency != null)
                {
                    existingCurrency.IsAcitve = false;
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
