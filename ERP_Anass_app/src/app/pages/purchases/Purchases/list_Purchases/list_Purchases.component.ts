import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Purchase } from 'src/app/models/Purchase/Purchase';
import { PurchaseService } from 'src/app/Services/Purchase/Purchase.service';
import { erp_anass } from 'src/main';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';

// PDFMake Imports
import * as pdfMake from "pdfmake/build/pdfmake";
import * as pdfFonts from "pdfmake/build/vfs_fonts";

// Fix for pdfMake vfs assignment
(pdfMake as any).vfs = (pdfFonts as any).pdfMake ? (pdfFonts as any).pdfMake.vfs : (pdfFonts as any).vfs;
if (!(pdfMake as any).vfs && (window as any).pdfMake) {
  (pdfMake as any).vfs = (window as any).pdfMake.vfs;
}

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
    private route: ActivatedRoute
  ) { }

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
      this.generatePdfClientSide(invoice);
      this.loading = false;
    }, error => {
      console.error('Invoice Generation Failed', error);
      this.loading = false;
      alert('Failed to generate invoice');
    });
  }

  generatePdfClientSide(invoice: any) {
    console.log(invoice);

    const documentDefinition: any = {
      content: [
        { text: `Invoice #${invoice.invoiceNumber}`, style: 'header' },
        { text: `Date: ${new Date(invoice.issueDate).toLocaleDateString()}` },
        { text: `Due Date: ${new Date(invoice.dueDate).toLocaleDateString()}` },
        { text: `Type: ${invoice.invoiceType}`, margin: [0, 0, 0, 10] },

        {
          table: {
            headerRows: 1,
            widths: ['*', 'auto', 'auto', 'auto'],
            body: [
              [
                { text: 'Item', style: 'tableHeader' },
                { text: 'Qty', style: 'tableHeader' },
                { text: 'Price', style: 'tableHeader' },
                { text: 'Total', style: 'tableHeader' }
              ],
              ...invoice.invoiceDetails.map((item: any) => [
                `${item.articleId}`,
                item.quantity,
                { text: item.price.toFixed(2), alignment: 'right' },
                { text: item.total.toFixed(2), alignment: 'right' }
              ])
            ]
          }
        },
        { text: `Total: ${invoice.totalAmount.toFixed(2)}`, style: 'total', margin: [0, 20, 0, 0], alignment: 'right' }
      ],
      styles: {
        header: { fontSize: 22, bold: true, margin: [0, 0, 0, 10] },
        tableHeader: { bold: true, fontSize: 13, color: 'black' },
        total: { fontSize: 16, bold: true }
      }
    };

    pdfMake.createPdf(documentDefinition).open();
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
