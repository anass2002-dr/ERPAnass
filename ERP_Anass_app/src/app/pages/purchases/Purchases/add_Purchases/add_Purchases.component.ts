import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
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
import { combineLatest } from 'rxjs';

@Component({
    selector: 'app-add_Purchases',
    templateUrl: './add_Purchases.component.html',
    styleUrls: ['./add_Purchases.component.css'],
    standalone: false
})
export class Add_PurchasesComponent implements OnInit {
  displayedColumns: string[] = ['articleRef', 'articleName', 'familyName', 'stockQuantity', 'ADD'];
  ColumnsPurchaseDetails: string[] = ['articleName', 'quality', 'quantity', 'totalPrice', 'update', 'delete'];

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
  Suppliers: Supplier[] = [];
  Currencies: Currency[] = [];
  list: Article[] = [];
  listSupplier: Supplier[] = [];
  loading: boolean = true;
  SetDisable: boolean = true;
  isUpdateModeDetails: boolean = false;
  idPurchaseDetails: number = 0;
  lasteStock: number = 0;
  discountAmount: number = 0
  totalPayment: number = 0
  discountPercentage: number = 0
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
    private productService: ProductService
  ) {
    // Initialize the Purchase form
    this.FormInputs = this.fb.group({
      idPurchase: [0, Validators.required],
      purchaseRef: ['', Validators.required],
      totalAmount: [0, [Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      TotalPayment: [0, [Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      idCurrency: ['', Validators.required],
      paymentStatus: ['', Validators.required],
      paymentDate: ['', Validators.required],
      purchaseDate: ['', Validators.required],
      remarks: [''],
      idSupplier: [0, Validators.required],
      isActive: [true],

      // Additional Fields
      purchaseStatus: ['Pending', Validators.required], // Default value set to 'Pending'
      expectedDeliveryDate: [null],
      shippingAddress: [null],
      purchaseType: ['Raw Material', Validators.required], // Default value set to 'Raw Material'
      discountAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      discountPercentage: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      taxRate: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      totalTaxAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      exchangeRate: [1, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      approvedBy: [null],
      approvalDate: [null],
      paymentTerms: [''],
      purchaseChannel: ['Offline']
    });

    // Initialize the Purchase Details form
    this.FormInputsDetails = this.fb.group({
      idPurchaseDetails: [0, Validators.required],
      idArticle: [0, Validators.required],
      articleName: ['', Validators.required],
      articleRef: ['', Validators.required],
      unitPrice: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      quantity: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      totalPrice: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      taxAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      quality: ['New', Validators.required], // Default value set to 'New'
      isActive: [true],
      idPurchase: [this.idPurchase, Validators.required],

      // Additional Fields
      lineItemStatus: ['Pending', Validators.required], // Default value set to 'Pending'
      unitOfMeasure: ['Pieces', Validators.required], // Default value set to 'Pieces'
      lineDiscountAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      lineDiscountPercentage: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      batchNumber: [''],
      expiryDate: [''],
      serialNumber: [''],
      warehouseLocation: [''],
      receivedQuantity: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      rejectedQuantity: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      lineTaxRate: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);

    this.loading = true;
    this.route.paramMap.subscribe(params => {
      this.idPurchase = parseInt(params.get('id') || '0');
      if (this.idPurchase) {
        this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
        this.isUpdateMode = true;
        this.purchaseService.GetPurchaseById(this.idPurchase).subscribe(data => {
          this.purchase = data;
          this.FormInputs.patchValue(data);
          this.SetDisable = !this.SetDisable;
        });
      }
    });

    this.loadSupplier();
    this.CurrencyService.GetAllCurrencys().subscribe(data => {
      this.Currencies = data;
    });
    this.loadArticle();
    this.loadPurchaseDetails(this.idPurchase);


    this.setupValueChangeListeners();

    this.setupValueChangeListenersLine();

    this.loading = false;
  }

  private setupValueChangeListeners() {
    combineLatest([
      this.FormInputs.get('totalAmount')!.valueChanges,
      this.FormInputs.get('discountAmount')!.valueChanges,
      this.FormInputs.get('discountPercentage')!.valueChanges,
      this.FormInputs.get('taxRate')!.valueChanges,
    ]).subscribe(() => {
      this.calculateDiscount();
      this.calculateTotalTaxAmount();
      this.calculateTotalPayment();
    });
  }

  private setupValueChangeListenersLine() {
    combineLatest([
      this.FormInputsDetails.get('quantity')!.valueChanges,
      this.FormInputsDetails.get('unitPrice')!.valueChanges,
      this.FormInputsDetails.get('lineDiscountAmount')!.valueChanges,
      this.FormInputsDetails.get('lineDiscountPercentage')!.valueChanges,
      this.FormInputsDetails.get('lineTaxRate')!.valueChanges,
    ]).subscribe(() => {
      this.calculateDiscountLine();
      this.calculateTotalTaxLine();
      this.calculateTotalPriceLine();
    });
  }

  private calculateDiscountLine() {
    const totalAmount = this.getValueLine('unitPrice');
    let discountAmount = this.getValueLine('lineDiscountAmount');
    let discountPercentage = this.getValueLine('lineDiscountPercentage');

    if (discountAmount) {
      discountPercentage = (discountAmount / totalAmount) * 100;
      this.FormInputsDetails.get('lineDiscountPercentage')?.setValue(discountPercentage.toFixed(2), { emitEvent: false });
    } else if (discountPercentage) {
      discountAmount = (totalAmount * discountPercentage) / 100;
      this.FormInputsDetails.get('lineDiscountAmount')?.setValue(discountAmount.toFixed(2), { emitEvent: false });
    }
  }
  private calculateTotalTaxLine() {
    const totalAmount = this.getValueLine('unitPrice');
    const taxRate = this.getValueLine('lineTaxRate');
    const totalTaxAmount = (totalAmount * taxRate) / 100;

    this.FormInputsDetails.get('taxAmount')?.setValue(totalTaxAmount.toFixed(2), { emitEvent: false });
  }
  private calculateTotalPriceLine() {
    const quantity = this.getValueLine('quantity');
    const totalAmount = this.getValueLine('unitPrice');
    const totalTaxAmount = this.getValueLine('taxAmount');
    const discountAmount = this.getValueLine('lineDiscountAmount');

    const result = (totalAmount * quantity) - discountAmount + totalTaxAmount;
    console.log(result);

    this.FormInputsDetails.get('totalPrice')?.setValue(result.toFixed(2), { emitEvent: false });
  }
  private calculateTotalTaxAmount() {
    const totalAmount = this.getValue('totalAmount');
    const taxRate = this.getValue('taxRate');
    const totalTaxAmount = (totalAmount * taxRate) / 100;

    this.FormInputs.get('totalTaxAmount')?.setValue(totalTaxAmount.toFixed(2), { emitEvent: false });
  }

  private calculateTotalPayment() {
    const totalAmount = this.getValue('totalAmount');
    const totalTaxAmount = this.getValue('totalTaxAmount');
    const discountAmount = this.getValue('discountAmount');

    this.totalPayment = totalAmount - discountAmount + totalTaxAmount;
    this.FormInputs.get('TotalPayment')?.setValue(this.totalPayment.toFixed(2), { emitEvent: false });
  }

  private calculateDiscount() {
    const totalAmount = this.getValue('totalAmount');
    let discountAmount = this.getValue('discountAmount');
    let discountPercentage = this.getValue('discountPercentage');

    if (discountAmount) {
      discountPercentage = (discountAmount / totalAmount) * 100;
      this.FormInputs.get('discountPercentage')?.setValue(discountPercentage.toFixed(2), { emitEvent: false });
    } else if (discountPercentage) {
      discountAmount = (totalAmount * discountPercentage) / 100;
      this.FormInputs.get('discountAmount')?.setValue(discountAmount.toFixed(2), { emitEvent: false });
    }
  }
  private getValue(field: string): number {
    return parseFloat(this.FormInputs.get(field)?.value) || 0;
  }

  private getValueLine(field: string): number {

    return parseFloat(this.FormInputsDetails.get(field)?.value) || 0;
  }

  loadSupplier(): void {
    this.loading = true;
    this.supplierService.GetDataSupplier().subscribe(
      data => {
        this.listSupplier = data.map(supplier => ({
          idSupplier: supplier.idSupplier,
          supplierName: `${supplier.supplierName} - ${supplier.identityNumber}`,
          identityNumber: supplier.identityNumber
        }));
        this.loading = false;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;

  }

  deletePurchaseDetails(idPurchaseDetails: number): void {
    if (confirm(`Are you sure you want to delete the Purchase Details?`)) {
      this.purchaseService.DeletePurchaseDetails(idPurchaseDetails).subscribe(
        response => {
          this.loadPurchaseDetails(this.idPurchase);
          this.loadArticle();
        }
      );
    }
  }

  updatePurchaseDetails(idPurchaseDetails: number): void {
    this.loading = true;
    this.purchaseService.GetPurchaseDetailsById(idPurchaseDetails).subscribe(
      data => {
        this.loading = false;
        this.FormInputsDetails.patchValue(data);
        const pr = this.List_purchaseDetails.find(e => e.idPurchaseDetails === idPurchaseDetails);
        if (pr) {
          this.article = pr.article;
          this.FormInputsDetails.get('articleName')?.setValue(pr.article.articleName);
          this.FormInputsDetails.get('articleRef')?.setValue(pr.article.articleRef);
          this.isUpdateModeDetails = true;
          this.idPurchaseDetails = idPurchaseDetails;
          this.lasteStock = pr.quantity;
        }
      }
    );
  }

  applyFilter(event: Event): void {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  announceSortChange(sortState: Sort): void {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  announceSortChange2(sortState: Sort): void {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  AddArticle(id: number): void {
    if (!this.checkArticle(id)) {
      this.loading = true;
      this.productService.getArticleById(id).subscribe(
        data => {
          this.article = data;
          this.FormInputsDetails.get('articleRef')?.setValue(this.article.articleRef);
          this.FormInputsDetails.get('idArticle')?.setValue(this.article.idArticle);
          this.FormInputsDetails.get('articleName')?.setValue(this.article.articleName);
          this.loading = false;
        }
      );
    }
  }

  reset(): void {
    this.FormInputsDetails.reset();
    this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
    this.FormInputsDetails.get('idPurchaseDetails')?.setValue(0);
    this.FormInputsDetails.get('isActive')?.setValue(true);
    this.isUpdateModeDetails = false;
  }

  onSubmit(): void {
    if (this.FormInputs.valid) {
      const purchase: Purchase = { ...this.purchase, ...this.FormInputs.value };
      console.log(purchase);

      if (!this.isUpdateMode) {
        this.purchaseService.AddPurchase(purchase).subscribe(
          response => {
            this.idPurchase = response.idPurchase;
            this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
            this.SetDisable = false;
            this.isUpdateMode = true;

            this.showAlertSuccess = true;
            setTimeout(() => {
              this.showAlertSuccess = false;
            }, 1000);
          },
          error => {
            console.error('Error updating Purchase', error);
            this.showAlert = true;
          }
        );
      } else {
        this.purchaseService.UpdatePurchase(purchase, this.idPurchase).subscribe(
          response => {
            this.idPurchase = response.idPurchase;

            this.showAlertSuccess = true;
            setTimeout(() => {
              this.showAlertSuccess = false;
            }, 3000);
          },
          error => {
            console.error('Error updating Purchase', error);
            this.showAlert = true;
          }
        );
      }
    } else {
      this.showAlert = true;
    }
  }

  onSubmitDetails(): void {
    const purchaseDetails: PurchaseDetails = { ...this.purchaseDetails, ...this.FormInputsDetails.value };

    if (this.FormInputsDetails.valid) {
      if (!this.isUpdateModeDetails) {
        if (!this.checkArticle(parseInt(purchaseDetails.idArticle.toString()))) {
          this.purchaseService.AddPurchaseDetails(purchaseDetails).subscribe(
            response => {
              if (this.article) {
                this.article.stockQuantity += parseInt(purchaseDetails.quantity.toString());
                this.productService.UpdateStock(this.article).subscribe(
                  response => {
                    this.loadArticle();
                  }
                );
              }
              this.reset();
              this.loadPurchaseDetails(this.idPurchase);
            },
            error => {
              console.error('Error updating Purchase Details', error);
              this.showAlert = true;
            }
          );
        }
      } else {
        this.purchaseService.UpdatePurchaseDetails(purchaseDetails, this.idPurchaseDetails).subscribe(
          response => {
            if (this.article) {
              const qt = purchaseDetails.quantity;
              const op = qt - this.lasteStock;
              this.article.stockQuantity += op;
              this.isUpdateModeDetails = false;
              this.productService.UpdateStock(this.article).subscribe(
                response => {
                  this.loadArticle();
                  this.lasteStock = 0;
                }
              );
            }
            this.loadPurchaseDetails(this.idPurchase);
            this.FormInputsDetails.reset();
            this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
            this.FormInputsDetails.get('idPurchaseDetails')?.setValue(0);
            this.FormInputsDetails.get('isActive')?.setValue(true);
          },
          error => {
            console.error('Error updating Purchase Details', error);
            this.showAlert = true;
          }
        );
      }
    } else {
      this.showAlert = true;
    }
  }

  generateRef(): void {
    const dt = new Date();

    const year = dt.getFullYear();
    const month = (dt.getMonth() + 1).toString().padStart(2, '0');
    const day = dt.getDate().toString().padStart(2, '0');
    const hours = dt.getHours().toString().padStart(2, '0');
    const minutes = dt.getMinutes().toString().padStart(2, '0');
    const seconds = dt.getSeconds().toString().padStart(2, '0');

    const result = `${year}${month}${day}${hours}${minutes}${seconds}`;

    const random1 = Math.floor(Math.random() * (99 - 10)) + 10;
    const random2 = Math.floor(Math.random() * (999 - 100)) + 100;
    this.ref = 'PR-' + random1 + '-' + result + '-' + random2;
    this.FormInputs.get('purchaseRef')?.setValue(this.ref);
  }

  loadArticle(): void {
    this.productService.GetDataArticle().subscribe(
      data => {
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

  loadPurchaseDetails(id: number): void {
    this.purchaseService.GetPurchaseDetailsByPurchase(id).subscribe(
      data => {
        this.List_purchaseDetails = data;
        this.dataSourcePurchase.data = data;
      }
    );
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }

  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }

  checkArticle(id: number): boolean {
    const exist = this.List_purchaseDetails.some(element => element.article.idArticle === id);
    if (exist) {
      alert("This article already exists in the list of details.");
    }
    return exist;
  }
}
