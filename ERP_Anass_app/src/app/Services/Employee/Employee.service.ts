import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Works } from 'src/app/models/Employee/Works';
import { Department } from 'src/app/models/Employee/Department';
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public GetWorksDetails(): Observable<Works[]> {
    return this.http.get<Works[]>(`${this.url}/Employee/GetWorksDetails`);
  }
  public GetWorksDetailsByDepartment(DepartmentID: Number): Observable<Works[]> {
    return this.http.get<Works[]>(`${this.url}/Employee/GetWorksDetailsByDepartment/${DepartmentID}`);
  }
  public GetWorks(): Observable<Works[]> {
    return this.http.get<Works[]>(`${this.url}/Employee/GetWorks`);
  }
  public AddWorks(Works: Works): Observable<Works> {
    return this.http.post<Works>(`${this.url}/Employee/AddWorks`, Works);
  }
  public DeleteWorks(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Employee/DeleteWorks/${id}`);
  }
  public UpdateWorks(Works: Works, WorksID: Number): Observable<Works> {
    return this.http.put<Works>(`${this.url}/Employee/UpdateWorks/${WorksID}`, Works);
  }
  public GetWorksById(id: Number): Observable<Works> {
    return this.http.get<Works>(`${this.url}/Employee/GetWorksById/${id}`);
  }


  public GetDepartments(): Observable<Department[]> {
    return this.http.get<Department[]>(`${this.url}/Employee/GetDepartments`);
  }
  public AddDepartment(Department: Department): Observable<Department> {
    return this.http.post<Department>(`${this.url}/Employee/AddDepartment`, Department);
  }
  public DeleteDepartment(id: Number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Employee/DeleteDepartment/${id}`);
  }
  public UpdateDepartment(Department: Department, DepartmentID: Number): Observable<Department> {
    return this.http.put<Department>(`${this.url}/Employee/UpdateDepartment/${DepartmentID}`, Department);
  }
  public GetDepartmentById(id: Number): Observable<Department> {
    return this.http.get<Department>(`${this.url}/Employee/GetDepartmentById/${id}`);
  }
}
