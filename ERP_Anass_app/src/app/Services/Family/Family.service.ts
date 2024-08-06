import { Injectable } from '@angular/core';
import { Article } from '../../models/Article/Article';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ArticleDTO } from '../../models/Article/ArticleDTO';
import { Familly } from 'src/app/models/Familly/Familly';
@Injectable({
  providedIn: 'root'
})
export class FamilyService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;

  public createFamily(familly: Familly): Observable<Familly> {
    return this.http.post<Familly>(`${this.url}/Familly/AddFamilly`, familly);
  }
  public GetDataFamily(): Observable<Familly[]> {
    return this.http.get<Familly[]>(`${this.url}/Familly/GetFamillys`);
  }
  public UpdateFamilly(familly: Familly): Observable<Familly> {
    return this.http.put<Familly>(`${this.url}/Article/UpdateFamilly/${familly.idFamilly}`, familly);
  }
  public GetFamillyById(id: number): Observable<Familly> {
    return this.http.get<Familly>(`${this.url}/Familly/GetFamillyById/${id}`);
  }
  public deleteFamily(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Article/DeleteFamilly/${id}`);
  }
  // public createArticle(article: ArticleDTO): Observable<ArticleDTO> {
  //   return this.http.post<ArticleDTO>(`${this.url}/Article/AddArticle`, article);
  // }
}
