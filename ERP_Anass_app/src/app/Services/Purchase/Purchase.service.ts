import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Purchase } from 'src/app/models/Purchase/Purchase';
import { PurchaseDetails } from 'src/app/models/Purchase/PurchaseDetails';
@Injectable({
  providedIn: 'root'
})
export class PurchaseService {


  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetPurchaseById(id: Number): Observable<Purchase> {
    return this.http.get<Purchase>(`${this.url}/Purchase/GetPurchaseById/${id}`);
  }
  public checkRef(reff: string): Observable<Purchase> {
    return this.http.get<Purchase>(`${this.url}/Purchase/checkRef/${reff}`);
  }
  public GetPurchaseDetails(): Observable<Purchase[]> {
    return this.http.get<Purchase[]>(`${this.url}/Purchase/GetPurchaseDetails`);
  }
  public GetPurchases(): Observable<Purchase[]> {
    return this.http.get<Purchase[]>(`${this.url}/Purchase/GetPurchases`);
  }
  public AddPurchase(Purchase: Purchase): Observable<Purchase> {
    return this.http.post<Purchase>(`${this.url}/Purchase/AddPurchase`, Purchase);
  }
  public UpdatePurchase(Purchase: Purchase, PurchaseID: Number): Observable<Purchase> {
    return this.http.post<Purchase>(`${this.url}/Purchase/UpdatePurchase/${PurchaseID}`, Purchase);
  }
  public DeletePurchase(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Purchase/DeletePurchase/${id}`);
  }


  public GetPurchaseDetailsById(id: Number): Observable<PurchaseDetails> {
    return this.http.get<PurchaseDetails>(`${this.url}/PurchaseDetails/GetPurchaseDetailsById/${id}`);
  }
  public DataPurchaseDetails(): Observable<PurchaseDetails[]> {
    return this.http.get<PurchaseDetails[]>(`${this.url}/PurchaseDetails/GetPurchaseDetails`);
  }
  public GetPurchaseDetailsByPurchase(id: Number): Observable<PurchaseDetails[]> {
    return this.http.get<PurchaseDetails[]>(`${this.url}/PurchaseDetails/GetPurchaseDetailsByPurchase/${id}`);
  }
  public AddPurchaseDetails(PurchaseDetails: PurchaseDetails): Observable<PurchaseDetails> {
    return this.http.post<PurchaseDetails>(`${this.url}/PurchaseDetails/AddPurchaseDetails`, PurchaseDetails);
  }
  public UpdatePurchaseDetails(PurchaseDetails: PurchaseDetails, PurchaseDetailsID: Number): Observable<PurchaseDetails> {
    return this.http.post<PurchaseDetails>(`${this.url}/PurchaseDetails/UpdatePurchaseDetails/${PurchaseDetailsID}`, PurchaseDetails);
  }
  public DeletePurchaseDetails(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/PurchaseDetails/DeletePurchaseDetails/${id}`);
  }

}
