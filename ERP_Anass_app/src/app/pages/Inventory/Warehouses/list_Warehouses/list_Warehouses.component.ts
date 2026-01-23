import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { Warehouse } from 'src/app/models/Inventory/Warehouse';
import { WarehouseService } from 'src/app/Services/Inventory/Warehouse.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-list_Warehouses',
  templateUrl: './list_Warehouses.component.html',
  styleUrls: ['./list_Warehouses.component.css'],
  standalone: false
})
export class List_WarehousesComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = [
    'idWarehouse',
    'name',
    'location',
    'isAcitve',
    'actions'
  ];
  dataSource = new MatTableDataSource();
  list: Warehouse[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  idWarehouse: number = 0;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private _liveAnnouncer: LiveAnnouncer,
    private router: Router,
    private warehouseService: WarehouseService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadWarehouses();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  loadWarehouses() {
    this.warehouseService.getWarehouses().subscribe(data => {
      this.list = data;
      this.dataSource.data = this.list;
      this.loading = false;
    }, error => {
      console.error("Error loading warehouses", error);
      this.loading = false;
    });
  }

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  Delete(id: number) {
    this.idWarehouse = id;
    this.closeModelErp();
  }

  deleteWarehouse() {
    this.warehouseService.deleteWarehouse(this.idWarehouse).subscribe(() => {
      this.list = this.list.filter(w => w.idWarehouse !== this.idWarehouse);
      this.dataSource.data = this.list;
      this.closeModelErp();
    }, error => {
      console.error("Error deleting warehouse", error);
      this.closeModelErp();
    });
  }

  edit(id: number) {
    // route to add/edit component
    // Assuming route will be Inventory/Warehouses/edit/:id or similar
    this.router.navigate(['Inventory/Warehouses/edit', id]);
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }

  closeModelErp() {
    erp_anass.closeModelErp()
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
