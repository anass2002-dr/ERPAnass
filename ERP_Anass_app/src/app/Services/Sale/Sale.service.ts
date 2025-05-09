import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { SaleDetails } from 'src/app/models/Sale/SaleDetails';
import { Sale } from 'src/app/models/Sale/Sale';
@Injectable({
  providedIn: 'root'
})
export class SaleService {


  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetSaleById(id: Number): Observable<Sale> {
    console.log(id);

    return this.http.get<Sale>(`${this.url}/Sale/GetSaleById/${id}`);
  }
  public checkRef(reff: string): Observable<Sale> {
    return this.http.get<Sale>(`${this.url}/Sale/checkRef/${reff}`);
  }
  public GetSaleDetails(): Observable<Sale[]> {
    return this.http.get<Sale[]>(`${this.url}/Sale/GetSaleDetails`);
  }
  public GetSales(): Observable<Sale[]> {
    return this.http.get<Sale[]>(`${this.url}/Sale/GetSales`);
  }
  public AddSale(Sale: Sale): Observable<Sale> {
    return this.http.post<Sale>(`${this.url}/Sale/AddSale`, Sale);
  }
  public UpdateSale(Sale: Sale, SaleID: Number): Observable<Sale> {
    return this.http.post<Sale>(`${this.url}/Sale/UpdateSale/${SaleID}`, Sale);
  }
  public DeleteSale(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Sale/DeleteSale/${id}`);
  }


  public GetSaleDetailsById(id: Number): Observable<SaleDetails> {
    return this.http.get<SaleDetails>(`${this.url}/SaleDetails/GetSaleDetailsById/${id}`);
  }
  public DataSaleDetails(): Observable<SaleDetails[]> {
    return this.http.get<SaleDetails[]>(`${this.url}/SaleDetails/GetSaleDetails`);
  }
  public GetSaleDetailsBySale(id: Number): Observable<SaleDetails[]> {
    return this.http.get<SaleDetails[]>(`${this.url}/SaleDetails/GetSaleDetailsBySale/${id}`);
  }
  public AddSaleDetails(SaleDetails: SaleDetails): Observable<SaleDetails> {
    return this.http.post<SaleDetails>(`${this.url}/SaleDetails/AddSaleDetails`, SaleDetails);
  }
  public UpdateSaleDetails(SaleDetails: SaleDetails, SaleDetailsID: Number): Observable<SaleDetails> {
    return this.http.post<SaleDetails>(`${this.url}/SaleDetails/UpdateSaleDetails/${SaleDetailsID}`, SaleDetails);
  }
  public DeleteSaleDetails(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/SaleDetails/DeleteSaleDetails/${id}`);
  }

}
