import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Purchase } from 'src/app/models/Purchase/Purchase';
import { Country } from 'src/app/models/Info/Country';
import { Currency } from 'src/app/models/Info/Currency';
import { PurchaseDetails } from 'src/app/models/Purchase/PurchaseDetails';
@Injectable({
  providedIn: 'root'
})
export class PurchaseService {


  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetPurchaseById(id: Number): Observable<Purchase> {
    return this.http.get<Purchase>(`${this.url}/Info/GetPurchaseById/${id}`);
  }
  public GetPurchaseDetails(): Observable<Purchase[]> {
    return this.http.get<Purchase[]>(`${this.url}/Info/GetPurchaseDetails`);
  }
  public GetPurchases(): Observable<Purchase[]> {
    return this.http.get<Purchase[]>(`${this.url}/Info/GetPurchases`);
  }
  public AddPurchase(Purchase: Purchase): Observable<Purchase> {
    return this.http.post<Purchase>(`${this.url}/Info/AddPurchase`, Purchase);
  }
  public UpdatePurchase(Purchase: Purchase, PurchaseID: Number): Observable<Purchase> {
    return this.http.put<Purchase>(`${this.url}/Info/UpdatePurchase/${PurchaseID}`, Purchase);
  }
  public DeletePurchase(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Info/DeletePurchase/${id}`);
  }


  public GetPurchaseDetailsById(id: Number): Observable<PurchaseDetails> {
    return this.http.get<PurchaseDetails>(`${this.url}/Info/GetPurchaseDetailsById/${id}`);
  }
  public DataPurchaseDetails(): Observable<PurchaseDetails[]> {
    return this.http.get<PurchaseDetails[]>(`${this.url}/Info/GetPurchaseDetails`);
  }
  public AddPurchaseDetails(PurchaseDetails: PurchaseDetails): Observable<PurchaseDetails> {
    return this.http.post<PurchaseDetails>(`${this.url}/Info/AddPurchaseDetails`, PurchaseDetails);
  }
  public UpdatePurchaseDetails(PurchaseDetails: PurchaseDetails, PurchaseDetailsID: Number): Observable<PurchaseDetails> {
    return this.http.put<PurchaseDetails>(`${this.url}/Info/UpdatePurchaseDetails/${PurchaseDetailsID}`, PurchaseDetails);
  }
  public DeletePurchaseDetails(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Info/DeletePurchaseDetails/${id}`);
  }

}
