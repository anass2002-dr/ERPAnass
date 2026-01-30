
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { UnitOfMeasure } from 'src/app/models/Inventory/UnitOfMeasure';
import { UnitOfMeasureService } from 'src/app/Services/Inventory/UnitOfMeasure.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-uom',
    templateUrl: './list-uom.component.html',
    styleUrls: ['./list-uom.component.css'],
    standalone: false
})
export class ListUOMComponent implements OnInit, AfterViewInit {
    displayedColumns: string[] = ['idUom', 'abbreviation', 'uomName', 'multiplier', 'isAcitve', 'actions'];
    dataSource = new MatTableDataSource();
    list: UnitOfMeasure[] = [];
    idUom: number = 0;
    loading: boolean = true;
    breadcrumbs: any[] = [];

    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;

    constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private uomService: UnitOfMeasureService, private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);
        this.loadUOMs();
    }

    loadUOMs() {
        this.uomService.getUOMs().subscribe(data => {
            this.list = data;
            this.dataSource.data = this.list;
            this.loading = false;
        }, error => {
            console.error('Error loading UOMs', error);
            this.loading = false;
        });
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
        this.idUom = id;
        this.closeModelErp();
    }

    edit(id: number) {
        this.router.navigate(['/Inventory/UOM/add-uom/', id]);
    }

    deleteUOM() {
        this.uomService.deleteUOM(this.idUom).subscribe(
            () => {
                this.list = this.list.filter(u => u.idUom !== this.idUom);
                this.dataSource.data = this.list;
                this.closeModelErp();
            },
            error => {
                console.error('Error deleting UOM', error);
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
}
