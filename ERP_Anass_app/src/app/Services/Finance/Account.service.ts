
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Account } from '../../models/Finance/Account';

@Injectable({
    providedIn: 'root'
})
export class AccountService {

    private url: string = `${environment.ApiUrl}/Account`;

    constructor(private http: HttpClient) { }

    public getAccounts(): Observable<Account[]> {
        return this.http.get<Account[]>(`${this.url}/GetAccounts`);
    }

    public getAccountById(id: number): Observable<Account> {
        return this.http.get<Account>(`${this.url}/GetAccountById/${id}`);
    }

    public createAccount(account: Account): Observable<Account> {
        return this.http.post<Account>(`${this.url}/AddAccount`, account);
    }

    public updateAccount(account: Account): Observable<Account> {
        return this.http.put<Account>(`${this.url}/UpdateAccount/${account.idAccount}`, account);
    }

    public deleteAccount(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeleteAccount/${id}`);
    }
}
