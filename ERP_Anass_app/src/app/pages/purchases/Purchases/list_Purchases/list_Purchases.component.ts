import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Purchase } from 'src/app/models/Purchase/Purchase';
import { PurchaseService } from 'src/app/Services/Purchase/Purchase.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list_Purchases',
    templateUrl: './list_Purchases.component.html',
    styleUrls: ['./list_Purchases.component.css'],
    standalone: false
})
export class List_PurchasesComponent implements OnInit {

  displayedColumns: string[] = [
    'purchaseRef',
    'purchaseDate',
    'totalAmount',
    'currencyName',
    'supplierName',
    'createdAt',
    'updatedAt',
    'paymentStatus',
    'paymentDate',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Purchase[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private purchaseService: PurchaseService, private route: ActivatedRoute) { }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadPurchse()
  }

  deletePurchase(idPurchase: Number) {
    if (confirm(`Are you sure you want to delete this Purchase?`)) {
      this.purchaseService.DeletePurchase(idPurchase).subscribe(
        reponse => {
          console.log(reponse);
          this.loadPurchse()
        }
      )
    }

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
  loadPurchse() {
    this.purchaseService.GetPurchaseDetails().subscribe(data => {
      console.log(data);

      this.list = data;
      this.dataSource.data = this.list;
      this.loading = false;
    })
  }
}
