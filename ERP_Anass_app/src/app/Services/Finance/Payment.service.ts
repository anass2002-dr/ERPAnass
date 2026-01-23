
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Payment } from '../../models/Finance/Payment';

@Injectable({
    providedIn: 'root'
})
export class PaymentService {

    private url: string = `${environment.ApiUrl}/Payment`;

    constructor(private http: HttpClient) { }

    public getPayments(): Observable<Payment[]> {
        return this.http.get<Payment[]>(`${this.url}/GetPayments`);
    }

    public getPaymentById(id: number): Observable<Payment> {
        return this.http.get<Payment>(`${this.url}/GetPaymentById/${id}`);
    }

    public createPayment(payment: Payment): Observable<Payment> {
        return this.http.post<Payment>(`${this.url}/AddPayment`, payment);
    }

    public updatePayment(payment: Payment): Observable<Payment> {
        return this.http.put<Payment>(`${this.url}/UpdatePayment/${payment.idPayment}`, payment);
    }

    public deletePayment(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeletePayment/${id}`);
    }
}
