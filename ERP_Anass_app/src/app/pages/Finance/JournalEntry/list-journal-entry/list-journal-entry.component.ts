
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { JournalEntry, JournalEntryStatus } from 'src/app/models/Finance/JournalEntry';
import { JournalEntryService } from 'src/app/Services/Finance/JournalEntry.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-journal-entry',
    templateUrl: './list-journal-entry.component.html',
    styleUrls: ['./list-journal-entry.component.css'],
    standalone: false
})
export class ListJournalEntryComponent implements OnInit, AfterViewInit {
    displayedColumns: string[] = ['idJournalEntry', 'entryDate', 'description', 'totalDebit', 'totalCredit', 'status', 'actions'];
    dataSource = new MatTableDataSource();
    list: JournalEntry[] = [];
    idEntry: number = 0;
    loading: boolean = true;
    breadcrumbs: any[] = [];
    entryStatus = JournalEntryStatus;

    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;

    constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private journalEntryService: JournalEntryService, private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        this.journalEntryService.getJournalEntries().subscribe(
            data => {
                this.list = data;
                this.dataSource.data = this.list;
                this.loading = false;
            },
            error => {
                console.error('Error fetching journal entries', error);
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
        this.idEntry = id;
        this.closeModelErp();
    }

    edit(id: number) {
        this.router.navigate(['/Finance/add-journal-entry/', id]);
    }

    deleteJournalEntry() {
        this.journalEntryService.deleteJournalEntry(this.idEntry).subscribe(
            () => {
                this.list = this.list.filter(a => a.idJournalEntry !== this.idEntry);
                this.dataSource.data = this.list;
                console.log('Journal Entry deleted successfully');
                this.closeModelErp();
            },
            error => {
                console.error('Error deleting journal entry', error);
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

    getStatusName(status: number): string {
        return JournalEntryStatus[status];
    }
}
