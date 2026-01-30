
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { StockMovement } from '../../models/Inventory/StockMovement';

@Injectable({
    providedIn: 'root'
})
export class StockMovementService {

    private url: string = `${environment.ApiUrl}/StockMovement`;

    constructor(private http: HttpClient) { }

    public getStockMovements(): Observable<StockMovement[]> {
        return this.http.get<StockMovement[]>(`${this.url}/GetStockMovements`);
    }

    public getStockMovementById(id: number): Observable<StockMovement> {
        return this.http.get<StockMovement>(`${this.url}/GetStockMovementById/${id}`);
    }

    public createStockMovement(stockMovement: StockMovement): Observable<StockMovement> {
        return this.http.post<StockMovement>(`${this.url}/AddStockMovement`, stockMovement);
    }

    public updateStockMovement(stockMovement: StockMovement): Observable<StockMovement> {
        return this.http.put<StockMovement>(`${this.url}/UpdateStockMovement/${stockMovement.idStockMovement}`, stockMovement);
    }

    public deleteStockMovement(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeleteStockMovement/${id}`);
    }

    public receivePurchase(purchaseId: number, warehouseId: number): Observable<boolean> {
        return this.http.post<boolean>(`${this.url}/ReceivePurchase/${purchaseId}/${warehouseId}`, {});
    }
}
