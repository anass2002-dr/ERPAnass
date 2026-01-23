import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { StockMovement, StockMovementType } from 'src/app/models/Inventory/StockMovement';
import { StockMovementService } from 'src/app/Services/Inventory/StockMovement.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-WarehousesMovement',
  templateUrl: './WarehousesMovement.component.html',
  styleUrls: ['./WarehousesMovement.component.css'],
  standalone: false
})
export class WarehousesMovementComponent implements OnInit, AfterViewInit {

  displayedColumns: string[] = [
    'idStockMovement',
    'articleID',
    'warehouseID',
    'quantity',
    'type',
    'movementDate',
    'actions'
  ];
  dataSource = new MatTableDataSource();
  list: StockMovement[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  idMovement: number = 0;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private _liveAnnouncer: LiveAnnouncer,
    private router: Router,
    private stockMovementService: StockMovementService,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadMovements();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  loadMovements() {
    this.stockMovementService.getStockMovements().subscribe(data => {
      this.list = data;
      this.dataSource.data = this.list;
      this.loading = false;
    }, error => {
      console.error("Error loading stock movements", error);
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
    this.idMovement = id;
    this.closeModelErp();
  }

  deleteMovement() {
    this.stockMovementService.deleteStockMovement(this.idMovement).subscribe(() => {
      this.list = this.list.filter(m => m.idStockMovement !== this.idMovement);
      this.dataSource.data = this.list;
      this.closeModelErp();
    }, error => {
      console.error("Error deleting movement", error);
      this.closeModelErp();
    });
  }

  edit(id: number) {
    this.router.navigate(['Inventory/Mouvement/edit', id]);
  }

  closeModelErp() {
    erp_anass.closeModelErp()
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }

  getTypeName(type: number): string {
    return StockMovementType[type];
  }
}

