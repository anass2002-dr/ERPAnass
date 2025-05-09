import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Sale } from 'src/app/models/Sale/Sale';
import { SaleService } from 'src/app/Services/Sale/Sale.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-sales',
    templateUrl: './list-sales.component.html',
    styleUrls: ['./list-sales.component.css'],
    standalone: false
})
export class ListSalesComponent implements OnInit {
displayedColumns: string[] = [
    'saleRef',
    'saleDate',
    'totalAmount',
    'currencyName',
    'customerName',
    'createdAt',
    'updatedAt',
    'paymentStatus',
    'paymentDate',
    'actions'
  ];
  dataSource = new MatTableDataSource();
  list: Sale[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  idsale:Number=0
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private saleService: SaleService, private route: ActivatedRoute) { }
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

  Delete(id: Number) {
    
    this.closeModelErp()
    this.idsale = id


  }
  DeleteSale(){
      this.saleService.DeleteSale(this.idsale).subscribe(
        reponse => {
          console.log(reponse);
          this.loadPurchse()
          this.closeModelErp()
        }
      )
  }
  
  edit(id: number) {
    this.router.navigate(['/sales/add_sales', id]);
  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  formatRef(ref:string){
    const result= ref.slice(0,15).toString()+'...'
    return result
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
    this.saleService.GetSaleDetails().subscribe(data => {
      this.list = data;
      this.dataSource.data = this.list;
      this.loading = false;
    })
  }
}
