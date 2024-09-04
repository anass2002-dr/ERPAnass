import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';
@Component({
  selector: 'app-list_city',
  templateUrl: './list_city.component.html',
  styleUrls: ['./list_city.component.css']
})
export class List_cityComponent implements OnInit {

  displayedColumns: string[] = [
    'CityId',
    'CityName',
    'CountryName',
    'zipCode',
    'createdAt',
    'updatedAt',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Article[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private productService: ProductService, private route: ActivatedRoute) { }
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

  deleteCustomer() {
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

}
