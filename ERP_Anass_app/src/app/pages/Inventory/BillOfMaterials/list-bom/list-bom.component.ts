
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { ActivatedRoute, Router } from '@angular/router';
import { BillOfMaterials } from 'src/app/models/Inventory/BillOfMaterials';
import { BillOfMaterialsService } from 'src/app/Services/Inventory/BillOfMaterials.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-bom',
    templateUrl: './list-bom.component.html',
    styleUrls: ['./list-bom.component.css'],
    standalone: false
})
export class ListBOMComponent implements OnInit, AfterViewInit {
    displayedColumns: string[] = ['idBOM', 'parentArticle', 'childArticle', 'quantityNeeded', 'actions'];
    dataSource = new MatTableDataSource();
    list: BillOfMaterials[] = [];
    idBOM: number = 0;
    loading: boolean = true;
    breadcrumbs: any[] = [];

    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;

    constructor(private _liveAnnouncer: LiveAnnouncer, private router: Router, private bomService: BillOfMaterialsService, private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);
        this.loadBOMs();
    }

    loadBOMs() {
        this.bomService.getBOMs().subscribe(data => {
            this.list = data;
            this.dataSource.data = this.list;
            this.loading = false;
        }, error => {
            console.error('Error loading BOMs', error);
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
        this.idBOM = id;
        this.closeModelErp();
    }

    edit(id: number) {
        this.router.navigate(['/Inventory/BOM/add-bom/', id]);
    }

    deleteBOM() {
        this.bomService.deleteBOM(this.idBOM).subscribe(
            () => {
                this.list = this.list.filter(b => b.idBOM !== this.idBOM);
                this.dataSource.data = this.list;
                this.closeModelErp();
            },
            error => {
                console.error('Error deleting BOM', error);
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
