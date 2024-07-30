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


  public GetDataFamily(): Observable<Familly[]> {
    return this.http.get<Familly[]>(`${this.url}/Familly/GetFamillys`);
  }
  public createArticle(article: ArticleDTO): Observable<ArticleDTO> {
    return this.http.post<ArticleDTO>(`${this.url}/Article/AddArticle`, article);
  }
}
