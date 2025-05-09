import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import { Customer } from 'src/app/models/Customer/Customer';
import { SaleService } from 'src/app/Services/Sale/Sale.service';
import { CustomerService } from 'src/app/Services/Customer/Customer.service';
import { Currency } from 'src/app/models/Info/Currency';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { Sale } from 'src/app/models/Sale/Sale';
import { MatTableDataSource } from '@angular/material/table';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatSort, Sort } from '@angular/material/sort';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { SaleDetails } from 'src/app/models/Sale/SaleDetails';
import { MatPaginator } from '@angular/material/paginator';
import { combineLatest } from 'rxjs';
@Component({
    selector: 'app-add_sales',
    templateUrl: './add_sales.component.html',
    styleUrls: ['./add_sales.component.css'],
    standalone: false
})
export class Add_salesComponent implements OnInit {

 displayedColumns: string[] = ['articleRef', 'articleName', 'familyName', 'stockQuantity', 'ADD'];
   ColumnssaleDetails: string[] = ['articleName', 'quality', 'quantity', 'totalPrice', 'update', 'delete'];
 
   article?: Article;
   articleStock: number = 0;
   FormInputs: FormGroup;
   FormInputsDetails: FormGroup;
   showAlert: boolean = false;
   showAlertSuccess: boolean = false;
   sale: Sale;
   saleDetails: SaleDetails;
   List_saleDetails: SaleDetails[];
   dataSource = new MatTableDataSource();
   dataSourcesale = new MatTableDataSource();
   isUpdateMode: boolean = false;
   idsale: number = 0;
   breadcrumbs: any[] = [];
   ref: string = "";
   Customers: Customer[] = [];
   Currencies: Currency[] = [];
   list: Article[] = [];
   listCustomer: Customer[] = [];
   loading: boolean = true;
   SetDisable: boolean = true;
   isUpdateModeDetails: boolean = false;
   idsaleDetails: number = 0;
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
     private saleService: SaleService,
     private CustomerService: CustomerService,
     private CurrencyService: InfoServiceService,
     private productService: ProductService
   ) {
     // Initialize the sale form
     this.FormInputs = this.fb.group({
       idsale: [0, Validators.required],
       saleRef: ['', Validators.required],
       totalAmount: [0, [Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
       TotalPayment: [0, [Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
       idCurrency: ['', Validators.required],
       paymentStatus: ['', Validators.required],
       paymentDate: ['', Validators.required],
       saleDate: ['', Validators.required],
       remarks: [''],
       idCustomer: [0, Validators.required],
       isActive: [true],
 
       // Additional Fields
       saleStatus: ['Pending', Validators.required], // Default value set to 'Pending'
       expectedDeliveryDate: [null],
       shippingAddress: [null],
       saleType: ['Raw Material', Validators.required], // Default value set to 'Raw Material'
       discountAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
       discountPercentage: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
       taxRate: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
       totalTaxAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
       exchangeRate: [1, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
       approvedBy: [null],
       approvalDate: [null],
       paymentTerms: [''],
       saleChannel: ['Offline']
     });
 
     // Initialize the sale Details form
     this.FormInputsDetails = this.fb.group({
       idsaleDetails: [0, Validators.required],
       idArticle: [0, Validators.required],
       articleName: ['', Validators.required],
       articleRef: ['', Validators.required],
       unitPrice: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
       quantity: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
       totalPrice: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
       taxAmount: [0, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
       quality: ['New', Validators.required], // Default value set to 'New'
       isActive: [true],
       idsale: [this.idsale, Validators.required],
 
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
       this.idsale = parseInt(params.get('id') || '0');
       if (this.idsale) {
         this.FormInputsDetails.get('idsale')?.setValue(this.idsale);
         this.isUpdateMode = true;
         this.saleService.GetSaleById(this.idsale).subscribe(data => {
           this.sale = data;
           this.FormInputs.patchValue(data);
           this.SetDisable = !this.SetDisable;
         });
       }
     });
 
     this.loadCustomer();
     this.CurrencyService.GetAllCurrencys().subscribe(data => {
       this.Currencies = data;
     });
     this.loadArticle();
     this.loadsaleDetails(this.idsale);
 
 
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
 
   loadCustomer(): void {
     this.loading = true;
     this.CustomerService.GetDataCustomer().subscribe(
       data => {
         this.listCustomer = data.map(Customer => ({
           idCustomer: Customer.idCustomer,
           CustomerName: `${Customer.customerName} - ${Customer.identityNumber}`,
           identityNumber: Customer.identityNumber
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
 
   deleteSaleDetails(idsaleDetails: number): void {
     if (confirm(`Are you sure you want to delete the sale Details?`)) {
       this.saleService.DeleteSaleDetails(idsaleDetails).subscribe(
         response => {
           this.loadsaleDetails(this.idsale);
           this.loadArticle();
         }
       );
     }
   }
 
   updateSaleDetails(idsaleDetails: number): void {
     this.loading = true;
     this.saleService.GetSaleDetailsById(idsaleDetails).subscribe(
       data => {
         this.loading = false;
         this.FormInputsDetails.patchValue(data);
         const pr = this.List_saleDetails.find(e => e.idSaleDetails === idsaleDetails);
         if (pr) {
           this.article = pr.article;
           this.FormInputsDetails.get('articleName')?.setValue(pr.article.articleName);
           this.FormInputsDetails.get('articleRef')?.setValue(pr.article.articleRef);
           this.isUpdateModeDetails = true;
           this.idsaleDetails = idsaleDetails;
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
     this.FormInputsDetails.get('idsale')?.setValue(this.idsale);
     this.FormInputsDetails.get('idsaleDetails')?.setValue(0);
     this.FormInputsDetails.get('isActive')?.setValue(true);
     this.isUpdateModeDetails = false;
   }
 
   onSubmit(): void {
     if (this.FormInputs.valid) {
       const sale: Sale = { ...this.sale, ...this.FormInputs.value };
       console.log(sale);
 
       if (!this.isUpdateMode) {
         this.saleService.AddSale(sale).subscribe(
           response => {
             this.idsale = response.idSale;
             this.FormInputsDetails.get('idsale')?.setValue(this.idsale);
             this.SetDisable = false;
             this.isUpdateMode = true;
 
             this.showAlertSuccess = true;
             setTimeout(() => {
               this.showAlertSuccess = false;
             }, 1000);
           },
           error => {
             console.error('Error updating sale', error);
             this.showAlert = true;
           }
         );
       } else {
         this.saleService.UpdateSale(sale, this.idsale).subscribe(
           response => {
             this.idsale = response.idSale;
 
             this.showAlertSuccess = true;
             setTimeout(() => {
               this.showAlertSuccess = false;
             }, 3000);
           },
           error => {
             console.error('Error updating sale', error);
             this.showAlert = true;
           }
         );
       }
     } else {
       this.showAlert = true;
     }
   }
 
   onSubmitDetails(): void {
     const saleDetails: SaleDetails = { ...this.saleDetails, ...this.FormInputsDetails.value };
 
     if (this.FormInputsDetails.valid) {
       if (!this.isUpdateModeDetails) {
         if (!this.checkArticle(parseInt(saleDetails.idArticle.toString()))) {
           this.saleService.AddSaleDetails(saleDetails).subscribe(
             response => {
               if (this.article) {
                 this.article.stockQuantity += parseInt(saleDetails.quantity.toString());
                 this.productService.UpdateStock(this.article).subscribe(
                   response => {
                     this.loadArticle();
                   }
                 );
               }
               this.reset();
               this.loadsaleDetails(this.idsale);
             },
             error => {
               console.error('Error updating sale Details', error);
               this.showAlert = true;
             }
           );
         }
       } else {
         this.saleService.UpdateSaleDetails(saleDetails, this.idsaleDetails).subscribe(
           response => {
             if (this.article) {
               const qt = saleDetails.quantity;
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
             this.loadsaleDetails(this.idsale);
             this.FormInputsDetails.reset();
             this.FormInputsDetails.get('idsale')?.setValue(this.idsale);
             this.FormInputsDetails.get('idsaleDetails')?.setValue(0);
             this.FormInputsDetails.get('isActive')?.setValue(true);
           },
           error => {
             console.error('Error updating sale Details', error);
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
     this.ref = 'PR' + random1.toString() + result.toString() 
     this.FormInputs.get('saleRef')?.setValue(this.ref);
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
 
   loadsaleDetails(id: number): void {
     this.saleService.GetSaleDetailsBySale(id).subscribe(
       data => {
         this.List_saleDetails = data;
         this.dataSourcesale.data = data;
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
     const exist = this.List_saleDetails.some(element => element.article.idArticle === id);
     if (exist) {
       alert("This article already exists in the list of details.");
     }
     return exist;
   }
}
