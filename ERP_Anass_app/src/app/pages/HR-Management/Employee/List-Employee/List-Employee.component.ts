import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router, ActivatedRoute } from '@angular/router';
import { each } from 'jquery';
import { Article } from 'src/app/models/Article/Article';
import { erp_anass } from 'src/main'; // Assuming this handles breadcrumb logic

@Component({
  selector: 'app-List-Employee',
  templateUrl: './List-Employee.component.html',
  styleUrls: ['./List-Employee.component.css']
})
export class ListEmployeeComponent implements OnInit {

  displayedColumns: string[] = [
    'employeeID',
    'employeeName',
    'phone',
    'email',
    'department',
    'createdAt',
    'updatedAt',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource<Article>();
  loading: boolean = true;
  breadcrumbs: any[] = [];

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private _liveAnnouncer: LiveAnnouncer,
    private router: Router,
    // private employeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);
    this.loadEmployees();
  }

  loadEmployees() {
    // this.employeeService.getEmployees().subscribe((employees) => {
    //   this.dataSource.data = employees;
    //   this.dataSource.paginator = this.paginator;
    //   this.dataSource.sort = this.sort;
    //   this.loading = false;
    // });
  }

  deleteEmployee(employeeID: string) {
    // Logic for deleting an employee
    console.log('Deleting employee with ID:', employeeID);
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

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
