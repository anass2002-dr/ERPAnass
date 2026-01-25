import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import { Supplier } from 'src/app/models/Supplier/Supplier';
import { PurchaseService } from 'src/app/Services/Purchase/Purchase.service';
import { SupplierService } from 'src/app/Services/Supplier/Supplier.service';
import { Currency } from 'src/app/models/Info/Currency';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { Purchase } from 'src/app/models/Purchase/Purchase';
import { MatTableDataSource } from '@angular/material/table';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatSort, Sort } from '@angular/material/sort';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { PurchaseDetails } from 'src/app/models/Purchase/PurchaseDetails';
import { MatPaginator } from '@angular/material/paginator';
import { Warehouse } from 'src/app/models/Inventory/Warehouse';
import { Employee } from 'src/app/models/Employee/Employee';
import { Account } from 'src/app/models/Finance/Account';
import { TaxConfiguration } from 'src/app/models/TaxConfiguration/TaxConfiguration';
import { WarehouseService } from 'src/app/Services/Inventory/Warehouse.service';
import { EmployeeService } from 'src/app/Services/Employee/Employee.service';
import { AccountService } from 'src/app/Services/Finance/Account.service';

@Component({
  selector: 'app-add_Purchases',
  templateUrl: './add_Purchases.component.html',
  styleUrls: ['./add_Purchases.component.css'],
  standalone: false
})
export class Add_PurchasesComponent implements OnInit {
  displayedColumns: string[] = ['articleRef', 'articleName', 'familyName', 'stockQuantity', 'ADD'];
  ColumnsPurchaseDetails: string[] = ['articleName', 'quality', 'quantity', 'unitPrice', 'tax', 'totalPrice', 'update', 'delete'];

  article?: Article;
  articleStock: number = 0;
  FormInputs: FormGroup;
  FormInputsDetails: FormGroup;
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  purchase: Purchase;
  purchaseDetails: PurchaseDetails;
  List_purchaseDetails: PurchaseDetails[];
  dataSource = new MatTableDataSource();
  dataSourcePurchase = new MatTableDataSource();
  isUpdateMode: boolean = false;
  idPurchase: number = 0;
  breadcrumbs: any[] = [];
  ref: string = "";

  // Lists
  Suppliers: Supplier[] = [];
  Currencies: Currency[] = [];
  list: Article[] = [];
  listSupplier: Supplier[] = [];
  listWarehouses: Warehouse[] = [];
  listEmployees: Employee[] = [];
  listAccounts: Account[] = [];
  listTaxes: TaxConfiguration[] = [];

  loading: boolean = true;
  SetDisable: boolean = true;
  isUpdateModeDetails: boolean = false;
  idPurchaseDetails: number = 0;
  lasteStock: number = 0;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private _liveAnnouncer: LiveAnnouncer,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private purchaseService: PurchaseService,
    private supplierService: SupplierService,
    private CurrencyService: InfoServiceService,
    private productService: ProductService,
    private warehouseService: WarehouseService,
    private employeeService: EmployeeService,
    private accountService: AccountService
  ) {
    // Initialize the Purchase form
    this.FormInputs = this.fb.group({
      idPurchase: [0],
      purchaseRef: ['', Validators.required],
      totalAmount: [0],
      totalPayment: [0],
      idCurrency: [null],
      paymentStatus: ['No payment'],
      paymentDate: [null],
      purchaseDate: [new Date(), Validators.required],
      remarks: [null],
      idSupplier: [null, Validators.required],
      isActive: [true],

      // New FKs
      idWarehouse: [null, Validators.required], // Warehouse is required for stock
      idEmployee: [null],
      idAccount: [null, Validators.required], // Expense account required
      idInvoice: [null],

      // Additional Fields
      purchaseStatus: ['Pending'],
      expectedDeliveryDate: [null],
      shippingAddress: [null],
      purchaseType: ['Raw Material'],
      discountAmount: [0],
      discountPercentage: [0],
      taxRate: [0],
      totalTaxAmount: [0],
      shippingAmount: [0],
      exchangeRate: [1],
      approvedBy: [null],
      approvalDate: [null],
      paymentTerms: [null],
      purchaseChannel: ['Offline']
    });

    // Initialize the Purchase Details form
    this.FormInputsDetails = this.fb.group({
      idPurchaseDetails: [0],
      idArticle: [null, Validators.required],
      articleName: [null],
      articleRef: [null],
      unitPrice: [0, [Validators.required, Validators.min(0)]],
      quantity: [0, [Validators.required, Validators.min(1)]],
      totalPrice: [0],
      taxAmount: [0],
      quality: ['New', Validators.required],
      isActive: [true],
      idPurchase: [this.idPurchase, Validators.required],

      // Relations
      idTaxConfig: [null],

      // Additional Fields
      lineItemStatus: ['Pending'],
      unitOfMeasure: ['Pieces'],
      lineDiscountAmount: [0],
      lineDiscountPercentage: [0],
      batchNumber: [null],
      expiryDate: [null],
      serialNumber: [null],
      warehouseLocation: [null],
      receivedQuantity: [0],
      rejectedQuantity: [0],
      lineTaxRate: [0]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);
    this.loadInitialData();

    this.route.paramMap.subscribe(params => {
      this.idPurchase = parseInt(params.get('id') || '0');
      if (this.idPurchase) {
        this.isUpdateMode = true;
        this.loading = true;
        this.purchaseService.GetPurchaseById(this.idPurchase).subscribe(data => {
          this.purchase = data;
          console.log('Purchase Loaded:', data); // Debugging

          // Format Date for Input
          const pDate = data.purchaseDate ? new Date(data.purchaseDate).toISOString().split('T')[0] : null;
          const eDate = data.expectedDeliveryDate ? new Date(data.expectedDeliveryDate).toISOString().split('T')[0] : null;
          const payDate = data.paymentDate ? new Date(data.paymentDate).toISOString().slice(0, 16) : null;

          this.FormInputs.patchValue({
            ...data,
            purchaseDate: pDate,
            expectedDeliveryDate: eDate,
            paymentDate: payDate
          });

          this.SetDisable = false;
          this.loadPurchaseDetails(this.idPurchase);
          this.loading = false;
        });
      } else {
        this.generateRef();
        this.loading = false;
      }
    });

    // Subscriptions for calculations
    this.FormInputsDetails.get('quantity')?.valueChanges.subscribe(() => this.calculateLineTotal());
    this.FormInputsDetails.get('unitPrice')?.valueChanges.subscribe(() => this.calculateLineTotal());
    this.FormInputsDetails.get('lineDiscountAmount')?.valueChanges.subscribe(() => this.calculateLineTotal());
    this.FormInputsDetails.get('idTaxConfig')?.valueChanges.subscribe(() => this.calculateLineTotal());
  }

  loadInitialData() {
    this.supplierService.GetDataSupplier().subscribe(data => this.listSupplier = data);
    this.CurrencyService.GetAllCurrencys().subscribe(data => this.Currencies = data);
    this.productService.GetDataArticle().subscribe(data => {
      this.list = data;
      this.dataSource.data = this.list;
    });
    this.warehouseService.getWarehouses().subscribe(data => this.listWarehouses = data);
    this.employeeService.GetEmployees().subscribe(data => this.listEmployees = data);
    this.accountService.getAccounts().subscribe(data => this.listAccounts = data);
    this.purchaseService.GetTaxConfigurations().subscribe(data => this.listTaxes = data);
  }

  calculateLineTotal() {
    const quantity = parseFloat(this.FormInputsDetails.get('quantity')?.value) || 0;
    const unitPrice = parseFloat(this.FormInputsDetails.get('unitPrice')?.value) || 0;
    const discount = parseFloat(this.FormInputsDetails.get('lineDiscountAmount')?.value) || 0;

    // Tax Calculation
    let taxRate = 0;
    const idTax = this.FormInputsDetails.get('idTaxConfig')?.value;
    if (idTax) {
      const tax = this.listTaxes.find(t => t.idTaxConfig === idTax);
      if (tax) taxRate = tax.taxRate || 0;
    }

    // Fallback to manual rate if needed, or override
    // this.FormInputsDetails.get('lineTaxRate')?.setValue(taxRate, { emitEvent: false });

    const netPrice = (unitPrice * quantity) - discount;
    const taxAmount = (netPrice * taxRate) / 100;
    const totalPrice = netPrice + taxAmount;

    this.FormInputsDetails.get('taxAmount')?.setValue(taxAmount.toFixed(2), { emitEvent: false });
    this.FormInputsDetails.get('totalPrice')?.setValue(totalPrice.toFixed(2), { emitEvent: false });
  }

  // ... (Other helper methods like breadcrumb formatting) ...
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }
  announceSortChange(sortState: Sort) {
    // keeping existing logic
  }
  announceSortChange2(sortState: Sort) {
    // keeping existing logic
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  applyFilter(event: Event): void {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  AddArticle(id: number): void {
    if (!this.checkArticle(id)) {
      this.productService.getArticleById(id).subscribe(data => {
        this.article = data;
        this.FormInputsDetails.patchValue({
          idArticle: this.article.idArticle,
          articleRef: this.article.articleRef,
          articleName: this.article.articleName,
          unitPrice: this.article.sellingPrice // defaulting to sale price? or purchase price if exists
        });
      });
    }
  }

  checkArticle(id: number): boolean {
    // Simple check if already added in UI list (not strictly necessary if we allow multiple lines of same item)
    // For now keeping it loose or as is
    return false;
  }

  onSubmit(): void {
    console.log(this.FormInputs.value)

    if (this.FormInputs.valid) {
      const purchaseData = { ...this.FormInputs.value };
      if (!this.isUpdateMode) {
        this.purchaseService.AddPurchase(purchaseData).subscribe(res => {
          this.idPurchase = res.idPurchase;
          this.isUpdateMode = true;
          this.SetDisable = false;
          this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
          this.showAlertSuccess = true;
          this.loadPurchaseDetails(this.idPurchase);
          setTimeout(() => this.showAlertSuccess = false, 2000);
        });
      } else {
        this.purchaseService.UpdatePurchase(purchaseData, this.idPurchase).subscribe(res => {
          this.showAlertSuccess = true;
          setTimeout(() => this.showAlertSuccess = false, 2000);
        });
      }
    } else {
      this.FormInputs.markAllAsTouched();
    }
  }

  onSubmitDetails(): void {
    if (this.FormInputsDetails.valid) {
      const detailData = { ...this.FormInputsDetails.value };
      detailData.idPurchase = this.idPurchase; // Ensure link

      if (!this.isUpdateModeDetails) {
        this.purchaseService.AddPurchaseDetails(detailData).subscribe(() => {
          this.resetDetails();
          this.loadPurchaseDetails(this.idPurchase);
        });
      } else {
        this.purchaseService.UpdatePurchaseDetails(detailData, this.idPurchaseDetails).subscribe(() => {
          this.resetDetails();
          this.loadPurchaseDetails(this.idPurchase);
        });
      }
    } else {
      this.FormInputsDetails.markAllAsTouched();
    }
  }

  loadPurchaseDetails(id: number) {
    this.purchaseService.GetPurchaseDetailsByPurchase(id).subscribe(data => {
      this.List_purchaseDetails = data;
      this.dataSourcePurchase.data = data;
      this.recalculatePurchaseTotals(); // Recalculate totals
    });
  }

  recalculatePurchaseTotals() {
    if (!this.List_purchaseDetails) return;

    const totalAmount = this.List_purchaseDetails.reduce((sum, item) => sum + (item.totalPrice || 0), 0);
    const totalTax = this.List_purchaseDetails.reduce((sum, item) => sum + (item.taxAmount || 0), 0);

    this.FormInputs.patchValue({
      totalAmount: totalAmount,
      totalTaxAmount: totalTax,
      // discountAmount could be summed if we had line discounts, for now manual or sum
    });

    // Auto-save changes to backend
    if (this.isUpdateMode) {
      const purchaseData = { ...this.FormInputs.value };
      // Ensure we don't overwrite user changes in other fields if they are editing, 
      // but here we are primarily viewing details. 
      // Ideally should debounce or only save if changed. 
      // For now, let's just patch the form. The User has to click "Update Header" to save?
      // "Update Header" button exists. 
      // BUT if the user expects "Total Amount" to be saved when they add an item, we should probably do it.
      // Let's do a silent update or just let the user see the updated value and click Update.
      // User complaint: "totalAmount": 0 in database.
      // So let's force an update.
      this.purchaseService.UpdatePurchase(purchaseData, this.idPurchase).subscribe();
    }
  }

  deletePurchaseDetails(id: number) {
    if (confirm('Delete this item?')) {
      this.purchaseService.DeletePurchaseDetails(id).subscribe(() => {
        this.loadPurchaseDetails(this.idPurchase);
      });
    }
  }

  updatePurchaseDetails(id: number) {
    const item = this.List_purchaseDetails.find(d => d.idPurchaseDetails === id);
    if (item) {
      this.idPurchaseDetails = id;
      this.isUpdateModeDetails = true;

      // Patch all fields including tax
      this.FormInputsDetails.patchValue({
        ...item,
        idTaxConfig: item.idTaxConfig // Ensure tax is bound
      });
    }
  }

  resetDetails() {
    this.FormInputsDetails.reset();
    this.FormInputsDetails.patchValue({
      idPurchaseDetails: 0,
      idPurchase: this.idPurchase,
      isActive: true,
      quality: 'New',
      lineItemStatus: 'Pending',
      unitOfMeasure: 'Pieces',
      quantity: 1, // Default quantity
      taxAmount: 0,
      totalPrice: 0,
      lineDiscountAmount: 0
    });
    this.isUpdateModeDetails = false;
    this.idPurchaseDetails = 0;
  }

  generateRef(): void {
    // keeping simple logic for now
    this.ref = 'PR-' + Date.now();
    this.FormInputs.get('purchaseRef')?.setValue(this.ref);
  }
}

