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

@Component({
  selector: 'app-add_Purchases',
  templateUrl: './add_Purchases.component.html',
  styleUrls: ['./add_Purchases.component.css']
})

export class Add_PurchasesComponent implements OnInit {
  displayedColumns: string[] = ['articleRef', 'articleName', 'familyName', 'stockQuantity', 'ADD'];
  ColumnsPurchaseDetails: string[] = ['articleName', 'quality', 'quantity', 'totalPrice', 'update', 'delete'];

  article?: Article;
  articleStock: number = 0
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
  idPurchase: Number = 0;
  breadcrumbs: any[] = [];
  ref: string = "";
  Suppliers: Supplier[] = []
  Currencies: Currency[] = []
  list: Article[] = []
  loading: boolean = true
  SetDisable: boolean = true
  isUpdateModeDetails: boolean = false
  idPurchaseDetails: Number = 0
  lasteStock: number = 0
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  constructor(private _liveAnnouncer: LiveAnnouncer,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private purchaseService: PurchaseService,
    private supplierService: SupplierService,
    private CurrencyService: InfoServiceService,
    private productService: ProductService
  ) {


    this.FormInputs = this.fb.group({
      idPurchase: [0, Validators.required],
      purchaseRef: ['', Validators.required],
      totalAmount: [0, [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      idCurrency: ['', Validators.required],
      paymentStatus: ['', Validators.required],
      paymentDate: ['', Validators.required],
      purchaseDate: ['', Validators.required],
      remarks: [''],
      idSupplier: [0, Validators.required],
      isAcitve: [true]
    });


    this.FormInputsDetails = this.fb.group({
      idPurchaseDetails: [0, Validators.required],
      idArticle: [0, Validators.required],
      articleName: ['', Validators.required],
      articleRef: ['', Validators.required],
      quantity: [0, Validators.required],
      totalPrice: [0, Validators.required],
      taxAmount: [0, Validators.required],
      quality: ['New', Validators.required], // Default value set to 'New'
      isActive: [true, Validators.required],
      idPurchase: [this.idPurchase, Validators.required],
    });



  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.loading = true
    this.route.paramMap.subscribe(params => {
      this.idPurchase = parseInt(params.get('id')) || 0;
      if (this.idPurchase) {

        this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
        this.isUpdateMode = true;
        this.purchaseService.GetPurchaseById(this.idPurchase).subscribe(data => {
          this.purchase = data;
          this.FormInputs.patchValue(data);
          this.SetDisable = !this.SetDisable
        });
      }
    });
    this.supplierService.GetSupplierDetails().subscribe(
      data => {
        console.log(data);

        this.Suppliers = data
      }
    )
    this.CurrencyService.GetAllCurrencys().subscribe(
      data => {
        this.Currencies = data
      }
    )
    this.loadArticle()
    this.loadPurchaseDetails(this.idPurchase);
    this.loading = false
  }
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  deletePurchaseDetails(idPurchaseDetails: Number) {

  }
  updatePurchaseDetails(idPurchaseDetails: Number) {
    this.loading = true
    this.purchaseService.GetPurchaseDetailsById(idPurchaseDetails).subscribe(
      data => {
        this.loading = false
        this.FormInputsDetails.patchValue(data);
        var pr = this.List_purchaseDetails.find(e => e.idPurchaseDetails == idPurchaseDetails)
        this.article = pr.article
        this.FormInputsDetails.get('articleName')?.setValue(pr.article.articleName);
        this.FormInputsDetails.get('articleRef')?.setValue(pr.article.articleRef);
        this.isUpdateModeDetails = true
        this.idPurchaseDetails = idPurchaseDetails
        this.lasteStock = pr.quantity
      }
    )
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

  announceSortChange2(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  AddArticle(id: Number) {
    this.loading = true
    this.productService.getArticleById(id).subscribe(
      data => {
        this.article = data
        console.log(this.article);
        this.FormInputsDetails.get('articleRef')?.setValue(this.article.articleRef);
        this.FormInputsDetails.get('idArticle')?.setValue(this.article.idArticle);
        this.FormInputsDetails.get('articleName')?.setValue(this.article.articleName);
        this.loading = false;

      }
    )
  }
  onSubmit(): void {

    if (this.FormInputs.valid) {
      const purchase: Purchase = { ...this.purchase, ...this.FormInputs.value };
      console.log(purchase);

      if (!this.isUpdateMode) {
        this.purchaseService.AddPurchase(purchase).subscribe(response => {

          console.log('Purchase add with successfully', response);
          this.idPurchase = response.idPurchase
          this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
          this.SetDisable = false
          this.isUpdateMode = true

          this.showAlertSuccess = true;
          setTimeout(() => {
            this.showAlertSuccess = false
          }, 1000);
        }, error => {
          console.error('Error updating Purchase', error);
          this.showAlert = true; // Show the alert if there was an error
        }
        )
      }
      else {
        this.purchaseService.UpdatePurchase(purchase, this.idPurchase).subscribe(response => {

          console.log('Purchase update with successfully', response);
          this.idPurchase = response.idPurchase

          this.showAlertSuccess = true;
          setTimeout(() => {
            this.showAlertSuccess = false
          }, 3000);
        }, error => {
          console.error('Error updating Purchase', error);
          this.showAlert = true; // Show the alert if there was an error
        }
        )
      }
    } else {
      console.log('Form not valid');
      this.showAlert = true;
    }
  }
  onSubmitDetails() {
    const purchaseDetails: PurchaseDetails = { ...this.purchaseDetails, ...this.FormInputsDetails.value };
    console.log(purchaseDetails);


    if (this.FormInputsDetails.valid) {

      if (!this.isUpdateModeDetails) {
        this.purchaseService.AddPurchaseDetails(purchaseDetails).subscribe(response => {

          console.log('Purchase add with successfully', response);
          this.article.stockQuantity += parseInt(purchaseDetails.quantity.toString());

          this.productService.UpdateStock(this.article).subscribe(
            reponse => {
              console.log(reponse)
              this.loadArticle()
            }
          )
        }, error => {
          console.error('Error updating Purchase Details', error);
          this.showAlert = true; // Show the alert if there was an error
        }
        )
      }
      else {
        console.log(purchaseDetails);
        this.purchaseService.UpdatePurchaseDetails(purchaseDetails, this.idPurchaseDetails).subscribe(response => {

          console.log('Purchase add with successfully', response);
          var qt = purchaseDetails.quantity
          console.log(qt)
          var op = qt - this.lasteStock
          this.article.stockQuantity += op
          this.isUpdateModeDetails = false
          this.productService.UpdateStock(this.article).subscribe(
            reponse => {
              this.loadArticle()
              this.lasteStock = 0
            }
          )
          this.loadPurchaseDetails(this.idPurchase)
          this.FormInputsDetails.reset()
          this.FormInputsDetails.get('idPurchase')?.setValue(this.idPurchase);
          this.FormInputsDetails.get('idPurchaseDetails')?.setValue(0);
          this.FormInputsDetails.get('isActive')?.setValue(true);
        }, error => {
          console.error('Error updating Purchase Details', error);
          this.showAlert = true; // Show the alert if there was an error
        }
        )
      }

    } else {
      console.log('Form not valid');
      this.showAlert = true;
    }
  }
  generateRef() {
    const dt = new Date();

    const year = dt.getFullYear();
    const month = (dt.getMonth() + 1).toString().padStart(2, '0');
    const day = dt.getDate().toString().padStart(2, '0');
    const hours = dt.getHours().toString().padStart(2, '0');
    const minutes = dt.getMinutes().toString().padStart(2, '0');
    const seconds = dt.getSeconds().toString().padStart(2, '0');

    // Concatenate the parts
    const result = `${year}${month}${day}${hours}${minutes}${seconds}`;

    let random1 = Math.floor(Math.random() * (99 - 10)) + 10;
    let random2 = Math.floor(Math.random() * (999 - 100)) + 100;
    this.ref = 'PR-' + random1 + '-' + result + '-' + random2;
    this.FormInputs.get('purchaseRef')?.setValue(this.ref);
    console.log(result);
  }
  loadArticle() {

    this.productService.GetDataArticle().subscribe(
      data => {
        console.log(data);
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
  loadPurchaseDetails(id: Number) {
    this.purchaseService.GetPurchaseDetailsByPurchase(id).subscribe(
      data => {
        this.List_purchaseDetails = data
        console.log(this.List_purchaseDetails)
        this.dataSourcePurchase.data = data;
      }
    )
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
