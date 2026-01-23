
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Warehouse } from '../../models/Inventory/Warehouse';

@Injectable({
    providedIn: 'root'
})
export class WarehouseService {

    private url: string = `${environment.ApiUrl}/Warehouse`;

    constructor(private http: HttpClient) { }

    public getWarehouses(): Observable<Warehouse[]> {
        return this.http.get<Warehouse[]>(`${this.url}/GetWarehouses`);
    }

    public getWarehouseById(id: number): Observable<Warehouse> {
        return this.http.get<Warehouse>(`${this.url}/GetWarehouseById/${id}`);
    }

    public createWarehouse(warehouse: Warehouse): Observable<Warehouse> {
        return this.http.post<Warehouse>(`${this.url}/AddWarehouse`, warehouse);
    }

    public updateWarehouse(warehouse: Warehouse): Observable<Warehouse> {
        return this.http.put<Warehouse>(`${this.url}/UpdateWarehouse/${warehouse.idWarehouse}`, warehouse);
    }

    public deleteWarehouse(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeleteWarehouse/${id}`);
    }
}
