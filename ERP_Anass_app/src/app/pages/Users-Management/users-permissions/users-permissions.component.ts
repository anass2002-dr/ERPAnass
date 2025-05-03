import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router, ActivatedRoute } from '@angular/router';
import { User } from 'src/app/models/User/User';
import { UserPerDetail } from 'src/app/models/User/UsersPermissionDetails';
import { UserServiceService } from 'src/app/Services/Users/UserService.service';
// import { UserService } from 'src/app/Services/User/user.service'; // Uncomment this when service is created
import { erp_anass } from 'src/main';
@Component({
    selector: 'app-users-permissions',
    templateUrl: './users-permissions.component.html',
    styleUrls: ['./users-permissions.component.css'],
    standalone: false
})
export class UsersPermissionsComponent implements OnInit {
  displayedColumns: string[] = [
    'firstName',
    'moduleName',
    'add',
    'edit',
    'delete',
    'update',
    'remove'
  ];
  dataSource = new MatTableDataSource<any>();
  breadcrumbs: any[] = [];
  loading: boolean = true;
  selectedRow: any = null;
  list: UserPerDetail[] = [];
  idPermission: number;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private _liveAnnouncer: LiveAnnouncer,
    private router: Router,
    private route: ActivatedRoute,
    private userService: UserServiceService // Uncomment when service is available
  ) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);
    this.loadPermission();

  }

  loadPermission() {
    this.userService.GetDataPermissionDetails().subscribe(
      data => {
        console.log(data);

        this.list = data;
        this.dataSource.data = this.list;
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
        this.loading = false;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );

  }

  deletePermission(idPermission: number) {
    this.closeModelErp()
    this.idPermission = idPermission
    // Add actual delete logic here
  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  Delete() {
    this.userService.deletePermission(this.idPermission).subscribe(

      (repons: any) => {
        console.log(repons);

        this.list = this.list.filter(a => a.idPermission !== this.idPermission);
        this.dataSource.data = this.list;
        this.loadPermission()
        this.closeModelErp()
      },
      error => {
        this.closeModelErp()
        setTimeout(() => {

          alert("Can't delete this permission because there are models linked with permission")
          alert("If you want to delete this permission, you should to delete all models linked with permission")
        }, 1000);
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
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }
  rowSelect(row: any) {
    this.selectedRow = row;
    console.log('Selected row:', row);

  }
}
