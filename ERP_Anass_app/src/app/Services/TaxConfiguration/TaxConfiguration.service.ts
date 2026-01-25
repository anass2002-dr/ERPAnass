import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { TaxConfiguration } from 'src/app/models/TaxConfiguration/TaxConfiguration';

@Injectable({
    providedIn: 'root'
})
export class TaxConfigurationService {

    private url: string = `${environment.ApiUrl}/TaxConfiguration`;

    constructor(private http: HttpClient) { }

    public GetTaxConfigurations(): Observable<TaxConfiguration[]> {
        return this.http.get<TaxConfiguration[]>(`${this.url}/GetTaxConfigurations`);
    }

    public GetTaxConfigurationById(id: number): Observable<TaxConfiguration> {
        return this.http.get<TaxConfiguration>(`${this.url}/GetTaxConfigurationById/${id}`);
    }

    public AddTaxConfiguration(tax: TaxConfiguration): Observable<TaxConfiguration> {
        return this.http.post<TaxConfiguration>(`${this.url}/AddTaxConfiguration`, tax);
    }

    public UpdateTaxConfiguration(tax: TaxConfiguration, id: number): Observable<TaxConfiguration> {
        return this.http.post<TaxConfiguration>(`${this.url}/UpdateTaxConfiguration/${id}`, tax);
    }

    public DeleteTaxConfiguration(id: number): Observable<boolean> {
        return this.http.delete<boolean>(`${this.url}/DeleteTaxConfiguration/${id}`);
    }
}
