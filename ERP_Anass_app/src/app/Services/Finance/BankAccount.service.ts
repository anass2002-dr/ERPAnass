import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BankAccount } from 'src/app/models/Finance/BankAccount';

@Injectable({
    providedIn: 'root'
})
export class BankAccountService {
    private apiUrl = `${environment.ApiUrl}/BankAccount`;

    constructor(private http: HttpClient) { }

    getBankAccounts(): Observable<BankAccount[]> {
        return this.http.get<BankAccount[]>(`${this.apiUrl}/GetBankAccounts`);
    }

    getBankAccount(id: number): Observable<BankAccount> {
        return this.http.get<BankAccount>(`${this.apiUrl}/GetBankAccountById/${id}`);
    }

    createBankAccount(bankAccount: BankAccount): Observable<BankAccount> {
        return this.http.post<BankAccount>(`${this.apiUrl}/AddBankAccount`, bankAccount);
    }

    updateBankAccount(bankAccount: BankAccount): Observable<BankAccount> {
        return this.http.put<BankAccount>(`${this.apiUrl}/UpdateBankAccount/${bankAccount.idBankAccount}`, bankAccount);
    }

    deleteBankAccount(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/DeleteBankAccount/${id}`);
    }
}
