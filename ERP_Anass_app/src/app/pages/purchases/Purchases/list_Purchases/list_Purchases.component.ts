import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Purchase } from 'src/app/models/Purchase/Purchase';
import { PurchaseService } from 'src/app/Services/Purchase/Purchase.service';
import { erp_anass } from 'src/main';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';

import { StockMovementService } from 'src/app/Services/Inventory/StockMovement.service';
import { MoveToWarehouseDialogComponent } from 'src/app/components/move-to-warehouse-dialog/move-to-warehouse-dialog.component';
import { InvoicePreviewComponent } from 'src/app/components/invoice-preview/invoice-preview.component';

@Component({
  selector: 'app-list_Purchases',
  templateUrl: './list_Purchases.component.html',
  styleUrls: ['./list_Purchases.component.css'],
  standalone: false
})
export class List_PurchasesComponent implements OnInit {

  displayedColumns: string[] = [
    'purchaseRef',
    'purchaseDate',
    'totalAmount',
    'currencyName',
    'supplierName',
    'createdAt',
    'updatedAt',
    'paymentStatus',
    'paymentDate',
    'actions'
  ];
  dataSource = new MatTableDataSource();
  list: Purchase[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  idpurchase: Number = 0
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private _liveAnnouncer: LiveAnnouncer,
    private router: Router,
    private purchaseService: PurchaseService,
    private invoiceService: InvoiceService,
    private stockMovementService: StockMovementService,
    private route: ActivatedRoute,
    private dialog: MatDialog
  ) { }

  moveToWarehouse(purchaseId: number) {
    const dialogRef = this.dialog.open(MoveToWarehouseDialogComponent, {
      width: '400px',
      data: { purchaseId: purchaseId }
    });

    dialogRef.afterClosed().subscribe(warehouseId => {
      if (warehouseId) {
        this.stockMovementService.receivePurchase(purchaseId, warehouseId).subscribe({
          next: (success) => {
            if (success) {
              alert('Items moved to warehouse successfully!');
              this.loadPurchse(); // Reload to see status changes if any
            }
          },
          error: (err) => {
            console.error(err);
            alert('Failed to move items.');
          }
        });
      }
    });
  }

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadPurchse()
  }

  Delete(id: Number) {
    this.closeModelErp()
    this.idpurchase = id
  }

  DeletePurchase() {
    this.purchaseService.DeletePurchase(this.idpurchase).subscribe(
      reponse => {
        console.log(reponse);
        this.loadPurchse()
        this.closeModelErp()
      }
    )
  }

  exportInvoice(id: number) {
    this.loading = true;
    this.invoiceService.generateInvoiceFromPurchase(id).subscribe(invoice => {
      console.log(invoice);
      this.loading = false;
      this.dialog.open(InvoicePreviewComponent, {
        width: '1200px',
        maxWidth: '95vw',
        height: '90vh',
        data: { invoiceId: invoice.idInvoice }
      });
    }, error => {
      console.error('Invoice Generation Failed', error);
      this.loading = false;
      alert('Failed to generate invoice');
    });
  }

  edit(id: number) {
    this.router.navigate(['/purchases/add_Purchases', id]);
  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  formatRef(ref: string) {
    const result = ref.slice(0, 15).toString() + '...'
    return result
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
  loadPurchse() {
    this.purchaseService.GetPurchaseDetails().subscribe(data => {
      console.log('Purchase List API Response:', data); // Debugging
      this.list = data;
      this.dataSource.data = this.list;
      this.loading = false;
    })
  }
}
