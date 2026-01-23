import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { BrandService } from 'src/app/Services/Brand/Brand.service';
import { Brand } from 'src/app/models/Brand/Brand';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-brand',
    templateUrl: './list-brand.component.html',
    styleUrls: ['./list-brand.component.css'],
    standalone: false
})
export class ListBrandComponent implements OnInit, AfterViewInit {
    displayedColumns: string[] = ['brandID', 'brandRef', 'brandName', 'familyName', 'actions'];
    dataSource = new MatTableDataSource();
    list: Brand[] = [];
    breadcrumbs: any[] = [];
    idDelete: number = 0;
    idBrand: number = 0;
    loading: boolean = true;
    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;

    constructor(private _liveAnnouncer: LiveAnnouncer, private brandService: BrandService, private router: Router, private route: ActivatedRoute) { }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route)

        this.brandService.getBrands().subscribe(
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
        this.idBrand = id
        this.closeModelErp()
    }

    edit(id: number) {
        this.router.navigate(['/Article/add-brand/', id]);
    }
    closeModelErp() {
        erp_anass.closeModelErp()
    }
    formatRef(ref: string) {
        if (!ref) return '';
        const result = ref.slice(0, 15).toString() + '...'
        return result
    }
    DeleteBrand() {
        this.brandService.deleteBrand(this.idBrand).subscribe(
            () => {
                this.list = this.list.filter(a => a.brandID !== this.idBrand);
                this.dataSource.data = this.list;
                this.closeModelErp()
            },
            error => {
                console.error('Error deleting Brand', error);
            }
        );
    }
    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb)
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list)
    }
}
