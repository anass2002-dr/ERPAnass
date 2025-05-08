import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { Customer } from 'src/app/models/Customer/Customer';
import { CustomerService } from 'src/app/Services/Customer/Customer.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-List_Customers',
    templateUrl: './List_Customers.component.html',
    styleUrls: ['./List_Customers.component.css'],
    standalone: false
})
export class List_CustomersComponent implements OnInit {

  displayedColumns: string[] = [
    'customerRef',
    'customerName',
    'identityNumber',
    'Phone',
    'Email',
    'actions'
  ];
  dataSource = new MatTableDataSource();
  list: Customer[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  CustomerID: number;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private CustomerService: CustomerService, private route: ActivatedRoute) { }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadCustomer()

  }
  Delete(id: number) {
    this.closeModelErp()
    this.CustomerID = id

  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  
  edit(id: number) {
    this.router.navigate(['/Customers/edit-Customers', id]);
  }
  DeleteCustomer() {
    this.CustomerService.DeleteCustomer(this.CustomerID).subscribe(

      (repons: any) => {
        console.log(repons);

        this.list = this.list.filter(a => a.idCustomer !== this.CustomerID);
        this.dataSource.data = this.list;
        this.loadCustomer()
        this.closeModelErp()
      },
      error => {
        this.closeModelErp()
        setTimeout(() => {

          alert("Can't delete this Customer because there are models linked with Customer")
          alert("If you want to delete this Customer, you should to delete all models linked with Customer")
        }, 1000);
      }

    );
  }
  formatRef(ref:string){
    const result= ref.slice(0,15).toString()+'...'
    
    return result
  }
  loadCustomer() {
    this.CustomerService.GetCustomerDetails().subscribe(
      data => {
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
