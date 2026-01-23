import { Component, OnInit } from '@angular/core';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';
import { Invoice } from 'src/app/models/Finance/Invoice';

@Component({
  selector: 'app-invoice-list',
  templateUrl: './invoice-list.component.html',
  styleUrls: ['./invoice-list.component.css'],
  standalone: false
})
export class InvoiceListComponent implements OnInit {
  invoices: Invoice[] = [];

  constructor(private invoiceService: InvoiceService) { }

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
}
