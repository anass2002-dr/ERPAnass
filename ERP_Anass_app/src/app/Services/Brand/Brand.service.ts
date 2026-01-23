import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Brand } from '../../models/Brand/Brand';

@Injectable({
    providedIn: 'root'
})
export class BrandService {

    constructor(private http: HttpClient) { }

    private url: string = `${environment.ApiUrl}`;

    public createBrand(brand: Brand): Observable<Brand> {
        return this.http.post<Brand>(`${this.url}/Brand/AddBrand`, brand);
    }
    public getBrands(): Observable<Brand[]> {
        return this.http.get<Brand[]>(`${this.url}/Brand/GetBrands`);
    }
    public updateBrand(brand: Brand): Observable<Brand> {
        return this.http.put<Brand>(`${this.url}/Brand/UpdateBrand/${brand.brandID}`, brand);
    }
    public getBrandById(id: number): Observable<Brand> {
        return this.http.get<Brand>(`${this.url}/Brand/GetBrandById/${id}`);
    }
    public deleteBrand(id: number): Observable<void> {
        return this.http.delete<void>(`${this.url}/Brand/DeleteBrand/${id}`);
    }
}
