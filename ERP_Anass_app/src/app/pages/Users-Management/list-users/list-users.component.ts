import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router, ActivatedRoute } from '@angular/router';
import { User } from 'src/app/models/User/User';
import { UserServiceService } from 'src/app/Services/Users/UserService.service';
// import { UserService } from 'src/app/Services/User/user.service'; // Uncomment this when service is created
import { erp_anass } from 'src/main';
@Component({
  selector: 'app-list-users',
  templateUrl: './list-users.component.html',
  styleUrls: ['./list-users.component.css']
})
export class ListUsersComponent implements OnInit {
  displayedColumns: string[] = [
    'firstName',
    'lastName',
    'email',
    'role',
    'status',
    'createdAt',
    'updatedAt',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource<any>();
  breadcrumbs: any[] = [];
  loading: boolean = true;
  selectedRow: any = null;
  list: User[] = [];
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
    this.loadUsers();
    // this.userService.GetDataUser().subscribe(
    //   data => {
    //     console.log(data);
    //     this.list = data;
    //     this.dataSource.data = this.list;
    //     this.loading = false;
    //   },
    //   error => {
    //     console.error('Error fetching data', error);
    //     this.loading = false;
    //   }
    // );
  }

  loadUsers() {
    this.userService.GetDataUser().subscribe(
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
    // this.userService.getUsers().subscribe((users) => {
    //   this.dataSource.data = users;
    //   this.dataSource.paginator = this.paginator;
    //   this.dataSource.sort = this.sort;
    //   this.loading = false;
    // });
  }

  deleteUser(userID: string) {
    console.log('Deleting user with ID:', userID);
    // Add actual delete logic here
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
