using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.InfoService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : Controller
    {
        private readonly IServiceInfo _serviceInfo;

        public InfoController(IServiceInfo serviceInfo)
        {
            _serviceInfo = serviceInfo;
        }

        // -------------------- CITY METHODS --------------------

        [HttpGet("GetAllCity")]
        public ActionResult<List<City>> GetAllCity()
        {
            var City = _serviceInfo.GetCitys();
            return Ok(City);
        }
        [HttpGet("GetCitysDetails")]
        public ActionResult<List<City>> GetCitysDetails()
        {
            var City = _serviceInfo.GetCitysDetails();
            return Ok(City);
        }
        [HttpGet("GetCitysDetailsByCountry/{id}")]
        public ActionResult<List<City>> GetCitysDetailsByCountry(int id)
        {
            var City = _serviceInfo.GetCitysDetailsByCountry(id);
            return Ok(City);
        }
        [HttpGet("GetCityById/{id}")]
        public ActionResult<City> GetCityById(int id)
        {
            var city = _serviceInfo.GetCityById(id);
            if (city == null)
                return NotFound();

            return Ok(city);
        }

        [HttpPost("AddCity")]
        public ActionResult<City> AddCity([FromBody] City city)
        {
            var addedCity = _serviceInfo.AddCity(city);
            return CreatedAtAction(nameof(GetCityById), new { id = addedCity.CityID }, addedCity);
        }

        [HttpPut("UpdateCity/{id}")]
        public ActionResult<City> UpdateCity(int id, [FromBody] City city)
        {
            var updatedCity = _serviceInfo.UpdateCity(id, city);
            if (updatedCity == null)
                return NotFound();

            return Ok(updatedCity);
        }

        [HttpDelete("DeleteCity/{id}")]
        public ActionResult DeleteCity(int id)
        {
            var result = _serviceInfo.DeleteCity(id);
            if (!result)
                return NotFound();

            return NoContent();
        }

        // -------------------- COUNTRY METHODS --------------------

        [HttpGet("GetAllCountries")]
        public ActionResult<List<Country>> GetAllCountries()
        {
            var Country = _serviceInfo.GetCountrys();
            return Ok(Country);
        }

        [HttpGet("GetCountryById/{id}")]
        public ActionResult<Country> GetCountryById(int id)
        {
            var country = _serviceInfo.GetCountryById(id);
            if (country == null)
                return NotFound();

            return Ok(country);
        }

        [HttpPost("AddCountry")]
        public ActionResult<Country> AddCountry([FromBody] Country country)
        {
            var addedCountry = _serviceInfo.AddCountry(country);
            return CreatedAtAction(nameof(GetCountryById), new { id = addedCountry.CountryId }, addedCountry);
        }

        [HttpPut("UpdateCountry/{id}")]
        public ActionResult<Country> UpdateCountry(int id, [FromBody] Country country)
        {
            var updatedCountry = _serviceInfo.UpdateCountry(id, country);
            if (updatedCountry == null)
                return NotFound();

            return Ok(updatedCountry);
        }

        [HttpDelete("DeleteCountry/{id}")]
        public ActionResult DeleteCountry(int id)
        {
            var result = _serviceInfo.DeleteCountry(id);
            if (!result)
                return NotFound();

            return NoContent();
        }

        // -------------------- Currency METHODS --------------------

        [HttpGet("GetAllCurrency")]
        public ActionResult<List<Currency>> GetAllCurrency()
        {
            var Currency = _serviceInfo.GetCurrencys();
            return Ok(Currency);
        }
        [HttpGet("GetCurrencyById/{id}")]
        public ActionResult<Currency> GetCurrencyById(int id)
        {
            var city = _serviceInfo.GetCurrencyById(id);
            if (city == null)
                return NotFound();

            return Ok(city);
        }

        [HttpPost("AddCurrency")]
        public ActionResult<Currency> AddCurrency([FromBody] Currency currency)
        {
            var addedCurrency = _serviceInfo.AddCurrency(currency);
            return CreatedAtAction(nameof(GetCurrencyById), new { id = addedCurrency.IdCurrency }, addedCurrency);
        }

        [HttpPut("UpdateCurrency/{id}")]
        public ActionResult<Currency> UpdateCurrency(int id, [FromBody] Currency currency)
        {
            var updatedCurrency = _serviceInfo.UpdateCurrency(id, currency);
            if (updatedCurrency == null)
                return NotFound();

            return Ok(updatedCurrency);
        }

        [HttpDelete("DeleteCurrency/{id}")]
        public ActionResult DeleteCurrency(int id)
        {
            var result = _serviceInfo.DeleteCurrency(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
