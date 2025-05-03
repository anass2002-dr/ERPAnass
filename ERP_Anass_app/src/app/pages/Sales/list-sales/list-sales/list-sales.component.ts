import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { TranslationService } from 'src/app/Services/translation.service';
import { erp_anass } from 'src/main';
@Component({
    selector: 'app-list-sales',
    templateUrl: './list-sales.component.html',
    styleUrls: ['./list-sales.component.css'],
    standalone: false
})
export class ListSalesComponent implements OnInit {

  displayedColumns: string[] = [
    'Saleref',
    'SaleDate',
    'Customer',
    'TotalAmount',
    'Currency',
    'PaymentStatus',
    'PaymentDate',
    'SalesRep',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Article[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private translationService: TranslationService, private _liveAnnouncer: LiveAnnouncer, private router: Router, private productService: ProductService, private route: ActivatedRoute) { }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }
  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.
    this.translationService.translatePage();
    console.log(window.localStorage.getItem('lang'));

  }
  delete() {
    console.log();

  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
