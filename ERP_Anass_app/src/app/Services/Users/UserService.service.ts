import { Injectable } from '@angular/core';
import { User } from '../../models/User/User';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
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
  public updateUser(User: User): Observable<User> {
    return this.http.put<User>(`${this.url}/User/UpdateUser/${User.UserID}`, User);
  }
  public getUserById(id: string): Observable<User> {
    return this.http.get<User>(`${this.url}/User/GetUserById/${id}`);
  }

}
