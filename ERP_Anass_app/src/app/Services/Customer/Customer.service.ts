import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from 'src/app/models/Customer/Customer';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetCustomerDetails(): Observable<Customer[]> {
    return this.http.get<Customer[]>(`${this.url}/Customer/GetCustomerDetails`);
  }
  public GetDataCustomer(): Observable<Customer[]> {
    return this.http.get<Customer[]>(`${this.url}/Customer/GetCustomers`);
  }
  public AddCustomer(Customer: Customer): Observable<Customer> {
    return this.http.post<Customer>(`${this.url}/Customer/AddCustomer`, Customer);
  }
  public DeleteCustomer(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Customer/DeleteCustomer/${id}`);
  }
  public UpdateCustomer(Customer: Customer, CustomerID: Number): Observable<Customer> {
    return this.http.put<Customer>(`${this.url}/Customer/UpdateCustomer/${CustomerID}`, Customer);
  }
  public GetCustomerById(id: Number): Observable<Customer> {
    return this.http.get<Customer>(`${this.url}/Customer/GetCustomerById/${id}`);
  }
  public CustomerByIdentity(identity: string): Observable<Customer> {
    return this.http.get<Customer>(`${this.url}/Customer/CustomerByIdentity/${identity}`);
  }

}
