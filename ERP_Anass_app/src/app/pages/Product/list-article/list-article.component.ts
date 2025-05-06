import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-article',
    templateUrl: './list-article.component.html',
    styleUrls: ['./list-article.component.css'],
    standalone: false
})
export class ListArticleComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['articleRef', 'articleName', 'familyName', 'stockQuantity', 'purchasePrice', 'sellingPrice', 'actions'];
  dataSource = new MatTableDataSource();
  list: Article[] = [];
  idArticle:Number=0
  loading: boolean = true;
  breadcrumbs: any[] = [];

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private productService: ProductService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.productService.GetDataArticle().subscribe(
      data => {
        console.log(data);
        this.list = data;
        this.dataSource.data = this.list;
        this.loading = false;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
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

  Delete(id: Number) {
    this.idArticle = id
    this.closeModelErp()
  }
  
  edit(id: number) {
    this.router.navigate(['/Article/add-article/', id]);
  }

  updateArticle(article: Article) {
    // Navigate to the update article component with the article ID
    this.router.navigate(['/add-article/:id', article.idArticle]);
  }

  deleteArticle() {
      this.productService.deleteArticle(this.idArticle).subscribe(
        () => {
          this.list = this.list.filter(a => a.idArticle !== this.idArticle);
          this.dataSource.data = this.list;
          console.log('Article deleted successfully');
          this.closeModelErp()
        },
        error => {
          console.error('Error deleting article', error);
          this.closeModelErp()
        }
      );
  }
  
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
