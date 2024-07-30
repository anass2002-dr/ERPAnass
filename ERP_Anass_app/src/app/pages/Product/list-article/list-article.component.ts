import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';

@Component({
  selector: 'app-list-article',
  templateUrl: './list-article.component.html',
  styleUrls: ['./list-article.component.css'],
})
export class ListArticleComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['position', 'name', 'familyName', 'stockQuantity', 'purchasePrice', 'sellingPrice', 'update', 'delete'];
  dataSource = new MatTableDataSource();
  list: Article[] = [];
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private productService: ProductService) { }

  ngOnInit(): void {
    this.productService.GetDataArticle().subscribe(
      data => {
        console.log(data);
        this.list = data;
        this.dataSource.data = this.list;
      },
      error => {
        console.error('Error fetching data', error);
      }
    );
  }

  onLinkClick(event: Event) {
    console.log('router clicked');
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  updateArticle(article: Article) {
    // Navigate to the update article component with the article ID
    this.router.navigate(['/add-article', article.idArticle]);
  }

  deleteArticle(article: Article) {
    if (confirm(`Are you sure you want to delete the article: ${article.articleName}?`)) {
      this.productService.deleteArticle(article.idArticle).subscribe(
        () => {
          this.list = this.list.filter(a => a.idArticle !== article.idArticle);
          this.dataSource.data = this.list;
          console.log('Article deleted successfully');
        },
        error => {
          console.error('Error deleting article', error);
        }
      );
    }
  }
}
