import { Injectable } from '@angular/core';
import { User } from '../../models/User/User';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { UserPer } from 'src/app/models/User/UsersPermission';
import { UserPerDetail } from 'src/app/models/User/UsersPermissionDetails';
@Injectable({
  providedIn: 'root'
})
export class UserServiceService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;


  public GetDataUser(): Observable<User[]> {
    return this.http.get<User[]>(`${this.url}/User/GetAllUsers`);
  }
  public createUser(User: User): Observable<User> {
    return this.http.post<User>(`${this.url}/User/AddUser`, User);
  }
  public deleteUser(id: string): Observable<void> {
    return this.http.delete<void>(`${this.url}/User/DeleteUser/${id}`);
  }
  public updateUser(User: User, userID: string): Observable<User> {
    return this.http.put<User>(`${this.url}/User/UpdateUser/${userID}`, User);
  }
  public getUserById(id: string): Observable<User> {
    return this.http.get<User>(`${this.url}/User/GetUserById/${id}`);
  }


  //permission

  public GetDataPermissionDetails(): Observable<UserPerDetail[]> {
    return this.http.get<UserPerDetail[]>(`${this.url}/User/permissions/GetPermissionsDetails`);
  }
  public GetDataUserPermission(): Observable<UserPer[]> {
    return this.http.get<UserPer[]>(`${this.url}/User/permissions/GetAllPermissions`);
  }
  public createPermissionPermission(Permission: UserPer): Observable<UserPer> {
    return this.http.post<UserPer>(`${this.url}/User/permissions/AddPermission`, Permission);
  }
  public deletePermissionPermission(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/User/permissions/Deletepermissions/${id}`);
  }
  public updatePermissionPermission(Permission: UserPer, PermissionID: string): Observable<UserPer> {
    return this.http.put<UserPer>(`${this.url}/User/permissions/Updatepermissions/${PermissionID}`, Permission);
  }
  public getPermissionById(id: string): Observable<UserPer> {
    return this.http.get<UserPer>(`${this.url}/User/permissions/GetPermissionById/${id}`);
  }

}
