import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { each } from 'jquery';
import { filter } from 'rxjs';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-list_PurchaseDetails',
  templateUrl: './list_PurchaseDetails.component.html',
  styleUrls: ['./list_PurchaseDetails.component.css']
})
export class List_PurchaseDetailsComponent implements OnInit {

  displayedColumns: string[] = [
    'purchaseRef',
    'Product',
    'Quantity',
    'UnitPrice',
    'Discount',
    'TotalPrice',
    'TaxAmount',
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

}
