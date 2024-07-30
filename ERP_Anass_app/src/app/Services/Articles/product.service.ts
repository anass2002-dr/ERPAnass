import { Injectable } from '@angular/core';
import { Article } from '../../models/Article/Article';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ArticleDTO } from '../../models/Article/ArticleDTO';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  private url: string = `${environment.ApiUrl}`;


  public GetDataArticle(): Observable<Article[]> {
    return this.http.get<Article[]>(`${this.url}/Article/GetArticles`);
  }
  public createArticle(article: Article): Observable<Article> {
    return this.http.post<Article>(`${this.url}/Article/AddArticle`, article);
  }
  public deleteArticle(id: number): Observable<void> {
    return this.http.delete<void>(`${this.url}/Article/DeleteArticle/${id}`);
  }
  public updateArticle(article: Article): Observable<Article> {
    return this.http.put<Article>(`${this.url}/Article/UpdateArticle/${article.idArticle}`, article);
  }
  public getArticleById(id: number): Observable<Article> {
    return this.http.get<Article>(`${this.url}/Article//GetArticleById/${id}`);
  }
}
