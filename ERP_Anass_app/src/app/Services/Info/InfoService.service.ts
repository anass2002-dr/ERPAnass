import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { City } from 'src/app/models/Info/City';
import { Country } from 'src/app/models/Info/Country';
import { Currency } from 'src/app/models/Info/Currency';
@Injectable({
  providedIn: 'root'
})
export class InfoServiceService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetCitysDetails(): Observable<City[]> {
    return this.http.get<City[]>(`${this.url}/Info/GetCitysDetails`);
  }
  public GetCitysDetailsByCountry(id: Number): Observable<City[]> {
    return this.http.get<City[]>(`${this.url}/Info/GetCitysDetailsByCountry/${id}`);
  }
  public GetDataCity(): Observable<City[]> {
    return this.http.get<City[]>(`${this.url}/Info/GetAllCity`);
  }
  public AddCity(City: City): Observable<City> {
    return this.http.post<City>(`${this.url}/Info/AddCity`, City);
  }
  public DeleteCity(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Info/DeleteCity/${id}`);
  }
  public UpdateCity(City: City, CityID: Number): Observable<City> {
    return this.http.put<City>(`${this.url}/Info/UpdateCity/${CityID}`, City);
  }
  public GetCityById(id: Number): Observable<City> {
    return this.http.get<City>(`${this.url}/Info/GetCityById/${id}`);
  }


  public GetAllCountries(): Observable<Country[]> {
    return this.http.get<Country[]>(`${this.url}/Info/GetAllCountries`);
  }
  public AddCountry(Country: Country): Observable<Country> {
    return this.http.post<Country>(`${this.url}/Info/AddCountry`, Country);
  }
  public DeleteCountry(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Info/DeleteCountry/${id}`);
  }
  public UpdateCountry(Country: Country, CountryID: Number): Observable<Country> {
    return this.http.put<Country>(`${this.url}/Info/UpdateCountry/${CountryID}`, Country);
  }
  public GetCountryById(id: Number): Observable<Country> {
    return this.http.get<Country>(`${this.url}/Info/GetCountryById/${id}`);
  }


  public GetAllCurrencys(): Observable<Currency[]> {
    return this.http.get<Currency[]>(`${this.url}/Info/GetAllCurrency`);
  }
  public AddCurrency(Currency: Currency): Observable<Currency> {
    return this.http.post<Currency>(`${this.url}/Info/AddCurrency`, Currency);
  }
  public DeleteCurrency(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Info/DeleteCurrency/${id}`);
  }
  public UpdateCurrency(Currency: Currency, CurrencyID: Number): Observable<Currency> {
    return this.http.put<Currency>(`${this.url}/Info/UpdateCurrency/${CurrencyID}`, Currency);
  }
  public GetCurrencyById(id: Number): Observable<Currency> {
    return this.http.get<Currency>(`${this.url}/Info/GetCurrencyById/${id}`);
  }


}
