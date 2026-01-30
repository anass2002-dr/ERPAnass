import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { InvoiceService } from 'src/app/Services/Finance/Invoice.service';
import { Sale } from 'src/app/models/Sale/Sale'; // Assuming these IDs are needed or just loose linking
// Ideally we load customers/suppliers/articles to select
import { CustomerService } from 'src/app/Services/Customer/Customer.service';
import { SupplierService } from 'src/app/Services/Supplier/Supplier.service';
import { ProductService } from 'src/app/Services/Articles/product.service'; // Corrected path and class name
import { PurchaseService } from 'src/app/Services/Purchase/Purchase.service';

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
  purchases: any[] = [];
  isEditMode: boolean = false;
  invoiceId: number = 0;

  constructor(
    private fb: FormBuilder,

    private invoiceService: InvoiceService,
    private router: Router,
    private route: ActivatedRoute,
    private customerService: CustomerService,
    private supplierService: SupplierService,
    private articleService: ProductService,
    private purchaseService: PurchaseService
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

    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      if (id) {
        this.isEditMode = true;
        this.invoiceId = +id;
        this.loadInvoice(this.invoiceId);
      } else {
        this.addDetail(); // Add one empty row by default for create mode
      }
    });
  }

  loadInvoice(id: number) {
    this.invoiceService.getInvoice(id).subscribe(invoice => {
      // Patch top-level fields
      this.invoiceForm.patchValue({
        invoiceNumber: invoice.invoiceNumber,
        issueDate: invoice.issueDate ? new Date(invoice.issueDate).toISOString().split('T')[0] : null,
        dueDate: invoice.dueDate ? new Date(invoice.dueDate).toISOString().split('T')[0] : null,
        status: invoice.status,
        invoiceType: invoice.invoiceType,
        customerId: invoice.customerId,
        supplierId: invoice.supplierId
      });

      // Patch Details
      const detailsArray = this.invoiceForm.get('invoiceDetails') as FormArray;
      detailsArray.clear(); // Clear default empty row

      invoice.invoiceDetails.forEach((d: any) => {
        const detailGroup = this.fb.group({
          articleId: [d.articleId, Validators.required],
          quantity: [d.quantity, [Validators.required, Validators.min(1)]],
          price: [d.price, [Validators.required, Validators.min(0)]],
          taxRate: [d.taxRate, [Validators.required, Validators.min(0)]],
          total: [d.total]
        });

        // Re-attach listener for updates
        detailGroup.valueChanges.subscribe(val => {
          const total = (val.quantity * val.price) * (1 + val.taxRate / 100);
          detailGroup.patchValue({ total: total }, { emitEvent: false });
        });

        detailsArray.push(detailGroup);
      });
    });
  }

  loadData() {
    this.customerService.GetDataCustomer().subscribe(data => this.customers = data);
    this.supplierService.GetDataSupplier().subscribe(data => this.suppliers = data);
    this.articleService.GetDataArticle().subscribe(data => this.articles = data);
    this.purchaseService.GetPurchases().subscribe(data => this.purchases = data);
  }

  onPurchaseSelect(event: any) {
    let purchaseId: number = 0;
    if (typeof event === 'number') {
      purchaseId = event;
    } else if (event && event.idPurchase) {
      purchaseId = event.idPurchase;
    }

    if (!purchaseId) return;

    // Fetch Invoice Mapping Data (Pre-fill) without saving
    this.invoiceService.getInvoiceDataFromPurchase(purchaseId).subscribe(invoiceData => {
      if (invoiceData) {
        // Patch Header
        this.invoiceForm.patchValue({
          supplierId: invoiceData.supplierId,
          status: 'Draft',
          invoiceType: 'Purchase',
          invoiceNumber: invoiceData.invoiceNumber,
          // issueDate/dueDate: backend returns suggested dates (Now/Now+30)
          issueDate: invoiceData.issueDate ? new Date(invoiceData.issueDate).toISOString().split('T')[0] : null,
          dueDate: invoiceData.dueDate ? new Date(invoiceData.dueDate).toISOString().split('T')[0] : null,
        });

        // Patch Details
        const detailsArray = this.invoiceForm.get('invoiceDetails') as FormArray;
        detailsArray.clear();

        invoiceData.invoiceDetails.forEach((d: any) => {
          const detailGroup = this.fb.group({
            articleId: [d.articleId, Validators.required],
            quantity: [d.quantity, [Validators.required, Validators.min(1)]],
            price: [d.price, [Validators.required, Validators.min(0)]],
            taxRate: [d.taxRate || d.TaxRate || 0, [Validators.required, Validators.min(0)]],
            total: [d.total]
          });

          detailGroup.valueChanges.subscribe(val => {
            const total = (val.quantity * val.price) * (1 + val.taxRate / 100);
            detailGroup.patchValue({ total: total }, { emitEvent: false });
          });
          detailsArray.push(detailGroup);
        });
      }
    });
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
        idInvoice: this.isEditMode ? this.invoiceId : 0,
        totalAmount: totalAmount,
        taxAmount: totalTax
      };

      if (this.isEditMode) {
        this.invoiceService.updateInvoice(invoiceData).subscribe(() => {
          this.router.navigate(['/Finance/Invoice/Invoice-List']);
        });
      } else {
        this.invoiceService.createInvoice(invoiceData).subscribe(() => {
          this.router.navigate(['/Finance/Invoice/Invoice-List']);
        });
      }
    }
  }
}
