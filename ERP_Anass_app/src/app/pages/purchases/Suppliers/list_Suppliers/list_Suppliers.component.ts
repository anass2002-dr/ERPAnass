import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { Supplier } from 'src/app/models/Supplier/Supplier';
import { SupplierService } from 'src/app/Services/Supplier/Supplier.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-list_Suppliers',
  templateUrl: './list_Suppliers.component.html',
  styleUrls: ['./list_Suppliers.component.css']
})
export class List_SuppliersComponent implements OnInit {

  displayedColumns: string[] = [
    'SupplierRef',
    'SupplierName',
    'ContactPerson',
    'Phone',
    'Email',
    'Address',
    'Country',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Supplier[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  SupplierID: number;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private SupplierService: SupplierService, private route: ActivatedRoute) { }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadSupplier()

  }
  deleteUser(SupplierID: number) {
    this.closeModelErp()
    this.SupplierID = SupplierID

  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  Delete() {
    this.SupplierService.DeleteSupplier(this.SupplierID).subscribe(

      (repons: any) => {
        console.log(repons);

        this.list = this.list.filter(a => a.idSupplier !== this.SupplierID);
        this.dataSource.data = this.list;
        this.loadSupplier()
        this.closeModelErp()
      },
      error => {
        this.closeModelErp()
        setTimeout(() => {

          alert("Can't delete this Supplier because there are models linked with Supplier")
          alert("If you want to delete this Supplier, you should to delete all models linked with Supplier")
        }, 1000);
      }

    );
  }
  loadSupplier() {
    this.SupplierService.GetSupplierDetails().subscribe(
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
