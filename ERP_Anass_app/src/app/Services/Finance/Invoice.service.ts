import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Invoice } from 'src/app/models/Finance/Invoice';

@Injectable({
    providedIn: 'root'
})
export class InvoiceService {
    private apiUrl = `${environment.ApiUrl}/Invoice`;

    constructor(private http: HttpClient) { }

    getInvoices(): Observable<Invoice[]> {
        return this.http.get<Invoice[]>(`${this.apiUrl}/GetInvoices`);
    }

    getInvoice(id: number): Observable<Invoice> {
        return this.http.get<Invoice>(`${this.apiUrl}/GetInvoiceById/${id}`);
    }

    createInvoice(invoice: Invoice): Observable<Invoice> {
        return this.http.post<Invoice>(`${this.apiUrl}/AddInvoice`, invoice);
    }

    updateInvoice(invoice: Invoice): Observable<Invoice> {
        return this.http.put<Invoice>(`${this.apiUrl}/UpdateInvoice/${invoice.idInvoice}`, invoice);
    }

    deleteInvoice(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/DeleteInvoice/${id}`);
    }
}
