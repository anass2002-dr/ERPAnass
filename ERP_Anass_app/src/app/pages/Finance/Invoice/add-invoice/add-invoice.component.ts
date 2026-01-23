import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';
import { Sale } from 'src/app/models/Sale/Sale'; // Assuming these IDs are needed or just loose linking
// Ideally we load customers/suppliers/articles to select
import { CustomerService } from 'src/app/Services/Customer/Customer.service';
import { SupplierService } from 'src/app/Services/Supplier/Supplier.service';
import { ProductService } from 'src/app/Services/Articles/product.service'; // Corrected path and class name

@Component({
  selector: 'app-add-invoice',
  templateUrl: './add-invoice.component.html',
  styleUrls: ['./add-invoice.component.css'],
  standalone: false
})
export class AddInvoiceComponent implements OnInit {
  invoiceForm: FormGroup;
  invoiceTypes = ['Sale', 'Purchase'];
  customers: any[] = [];
  suppliers: any[] = [];
  articles: any[] = [];

  constructor(
    private fb: FormBuilder,
    private invoiceService: InvoiceService,
    private router: Router,
    private customerService: CustomerService,
    private supplierService: SupplierService,
    private articleService: ProductService
  ) {
    this.invoiceForm = this.fb.group({
      invoiceNumber: ['', Validators.required],
      issueDate: [new Date(), Validators.required],
      dueDate: [new Date(), Validators.required],
      status: ['Draft', Validators.required],
      invoiceType: ['Sale', Validators.required],
      customerId: [null],
      supplierId: [null],
      invoiceDetails: this.fb.array([])
    });
  }

  ngOnInit(): void {
    this.loadData();
    this.addDetail(); // Add one empty row by default
  }

  loadData() {
    this.customerService.GetDataCustomer().subscribe(data => this.customers = data);
    this.supplierService.GetDataSupplier().subscribe(data => this.suppliers = data);
    this.articleService.GetDataArticle().subscribe(data => this.articles = data);
  }

  get invoiceDetails(): FormArray {
    return this.invoiceForm.get('invoiceDetails') as FormArray;
  }

  addDetail() {
    const detail = this.fb.group({
      articleId: [null, Validators.required],
      quantity: [1, [Validators.required, Validators.min(1)]],
      price: [0, [Validators.required, Validators.min(0)]],
      taxRate: [0, [Validators.required, Validators.min(0)]],
      total: [0]
    });

    // Auto-calculate total when inputs change
    detail.valueChanges.subscribe(val => {
      const total = (val.quantity * val.price) * (1 + val.taxRate / 100);
      detail.patchValue({ total: total }, { emitEvent: false });
    });

    this.invoiceDetails.push(detail);
  }

  removeDetail(index: number) {
    this.invoiceDetails.removeAt(index);
  }

  onArticleSelect(index: number, articleId: number) {
    const article = this.articles.find(a => a.idArticle === articleId);
    if (article) {
      const detail = this.invoiceDetails.at(index);
      detail.patchValue({
        price: article.sellingPrice || 0, // Fallback
        taxRate: article.taxRate || 0
      });
    }
  }

  onSubmit() {
    if (this.invoiceForm.valid) {
      const formVal = this.invoiceForm.value;
      // Calculate totals
      let totalAmount = 0;
      let totalTax = 0;

      formVal.invoiceDetails.forEach((d: any) => {
        totalAmount += d.total;
        totalTax += (d.quantity * d.price) * (d.taxRate / 100);
      });

      const invoiceData = {
        ...formVal,
        totalAmount: totalAmount,
        taxAmount: totalTax
      };

      this.invoiceService.createInvoice(invoiceData).subscribe(() => {
        this.router.navigate(['/Finance/Invoice/Invoice-List']);
      });
    }
  }
}
