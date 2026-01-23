
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BillOfMaterials } from '../../models/Inventory/BillOfMaterials';

@Injectable({
    providedIn: 'root'
})
export class BillOfMaterialsService {

    private url: string = `${environment.ApiUrl}/BillOfMaterials`;

    constructor(private http: HttpClient) { }

    public getBOMs(): Observable<BillOfMaterials[]> {
        return this.http.get<BillOfMaterials[]>(`${this.url}/GetBOMs`);
    }

    public getBOMById(id: number): Observable<BillOfMaterials> {
        return this.http.get<BillOfMaterials>(`${this.url}/GetBOMById/${id}`);
    }

    public createBOM(bom: BillOfMaterials): Observable<BillOfMaterials> {
        return this.http.post<BillOfMaterials>(`${this.url}/AddBOM`, bom);
    }

    public updateBOM(bom: BillOfMaterials): Observable<BillOfMaterials> {
        return this.http.put<BillOfMaterials>(`${this.url}/UpdateBOM/${bom.idBOM}`, bom);
    }

    public deleteBOM(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/DeleteBOM/${id}`);
    }
}
