import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Supplier } from 'src/app/models/Supplier/Supplier';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetSupplierDetails(): Observable<Supplier[]> {
    return this.http.get<Supplier[]>(`${this.url}/Supplier/GetSupplierDetails`);
  }
  public GetDataSupplier(): Observable<Supplier[]> {
    return this.http.get<Supplier[]>(`${this.url}/Supplier/GetSuppliers`);
  }
  public AddSupplier(Supplier: Supplier): Observable<Supplier> {
    return this.http.post<Supplier>(`${this.url}/Supplier/AddSupplier`, Supplier);
  }
  public DeleteSupplier(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Supplier/DeleteSupplier/${id}`);
  }
  public UpdateSupplier(Supplier: Supplier, SupplierID: Number): Observable<Supplier> {
    return this.http.put<Supplier>(`${this.url}/Supplier/UpdateSupplier/${SupplierID}`, Supplier);
  }
  public GetSupplierById(id: Number): Observable<Supplier> {
    return this.http.get<Supplier>(`${this.url}/Supplier/GetSupplierById/${id}`);
  }

}
