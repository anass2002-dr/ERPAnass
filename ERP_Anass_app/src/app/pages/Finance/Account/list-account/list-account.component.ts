
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { Account, AccountType } from 'src/app/models/Finance/Account';
import { AccountService } from 'src/app/Services/Finance/Account.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-account',
    templateUrl: './list-account.component.html',
    styleUrls: ['./list-account.component.css'],
    standalone: false
})
export class ListAccountComponent implements OnInit, AfterViewInit {
    displayedColumns: string[] = ['accountCode', 'accountName', 'type', 'isAcitve', 'actions'];
    dataSource = new MatTableDataSource();
    list: Account[] = [];
    idAccount: number = 0;
    loading: boolean = true;
    breadcrumbs: any[] = [];
    accountTypes = AccountType; // For Enum display

    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;

    constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private accountService: AccountService, private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        this.accountService.getAccounts().subscribe(
            data => {
                this.list = data;
                this.dataSource.data = this.list;
                this.loading = false;
            },
            error => {
                console.error('Error fetching accounts', error);
                this.loading = false;
            }
        );
    }

    ngAfterViewInit() {
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
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

    Delete(id: number) {
        this.idAccount = id;
        this.closeModelErp();
        // We reuse the same model logic, assuming 'model_erp' ID exists in HTML
    }

    edit(id: number) {
        this.router.navigate(['/Finance/add-account/', id]);
    }

    deleteAccount() {
        this.accountService.deleteAccount(this.idAccount).subscribe(
            () => {
                this.list = this.list.filter(a => a.idAccount !== this.idAccount);
                this.dataSource.data = this.list;
                console.log('Account deleted successfully');
                this.closeModelErp();
            },
            error => {
                console.error('Error deleting account', error);
                this.closeModelErp();
            }
        );
    }

    closeModelErp() {
        erp_anass.closeModelErp();
    }

    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb);
    }

    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list);
    }

    getAccountTypeName(type: number): string {
        return AccountType[type];
    }
}
