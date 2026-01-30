import { Component, OnInit } from '@angular/core';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';
import { Invoice } from 'src/app/models/Finance/Invoice';
import { MatDialog } from '@angular/material/dialog';
import { InvoicePreviewComponent } from 'src/app/components/invoice-preview/invoice-preview.component';

@Component({
  selector: 'app-invoice-list',
  templateUrl: './invoice-list.component.html',
  styleUrls: ['./invoice-list.component.css'],
  standalone: false
})
export class InvoiceListComponent implements OnInit {
  invoices: Invoice[] = [];

  constructor(
    private invoiceService: InvoiceService,
    private dialog: MatDialog
  ) { }

  ngOnInit(): void {
    this.loadInvoices();
  }

  loadInvoices() {
    this.invoiceService.getInvoices().subscribe(data => {
      this.invoices = data;
    });
  }

  deleteInvoice(id: number) {
    if (confirm("Are you sure you want to delete this invoice?")) {
      this.invoiceService.deleteInvoice(id).subscribe(() => {
        this.loadInvoices();
      });
    }
  }

  previewInvoice(id: number) {
    this.dialog.open(InvoicePreviewComponent, {
      width: '1200px',
      maxWidth: '95vw',
      height: '90vh',
      data: { invoiceId: id }
    });
  }
}
