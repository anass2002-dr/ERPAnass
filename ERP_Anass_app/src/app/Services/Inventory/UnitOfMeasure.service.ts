
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UnitOfMeasure } from '../../models/Inventory/UnitOfMeasure';

@Injectable({
    providedIn: 'root'
})
export class UnitOfMeasureService {

    private url: string = `${environment.ApiUrl}/UnitOfMeasure`;

    constructor(private http: HttpClient) { }

    public getUOMs(): Observable<UnitOfMeasure[]> {
        return this.http.get<UnitOfMeasure[]>(`${this.url}/GetUnitOfMeasures`);
    }

    public getUOMById(id: number): Observable<UnitOfMeasure> {
        return this.http.get<UnitOfMeasure>(`${this.url}/GetUnitOfMeasureById/${id}`);
    }

    public createUOM(uom: UnitOfMeasure): Observable<UnitOfMeasure> {
        return this.http.post<UnitOfMeasure>(`${this.url}/AddUnitOfMeasure`, uom);
    }

    public updateUOM(uom: UnitOfMeasure): Observable<UnitOfMeasure> {
        return this.http.put<UnitOfMeasure>(`${this.url}/UpdateUnitOfMeasure/${uom.idUom}`, uom);
    }

    public deleteUOM(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeleteUnitOfMeasure/${id}`);
    }
}
