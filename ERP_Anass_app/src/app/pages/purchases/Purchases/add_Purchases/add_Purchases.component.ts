import { Component, Input, OnInit } from '@angular/core';
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

@Component({
  selector: 'app-add_Purchases',
  templateUrl: './add_Purchases.component.html',
  styleUrls: ['./add_Purchases.component.css']
})
export class Add_PurchasesComponent implements OnInit {

  @Input() article?: Article;
  FormInputs: FormGroup;
  showAlert: boolean = false;
  purchase: Purchase;
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: any[] = [];
  ref: string = "";
  Suppliers: Supplier[] = []
  Currencies: Currency[] = []
  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private purchaseService: PurchaseService,
    private supplierService: SupplierService,
    private CurrencyService: InfoServiceService
  ) {

    // IsAcitve?: boolean,
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



  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;

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
  }

  onSubmit(): void {
    // console.log(this.FormInputs);
    // console.log(new Date().toLocaleDateString('en-US'));

    if (this.FormInputs.valid) {
      const purchase: Purchase = { ...this.purchase, ...this.FormInputs.value };
      console.log(purchase);

      this.purchaseService.AddPurchase(purchase).subscribe(response => {

        console.log('Purchase add with successfully', response);
        this.router.navigate(['purchases/list-Purchases']); // Navigate back to the article list
      }, error => {
        console.error('Error updating Purchase', error);
        this.showAlert = true; // Show the alert if there was an error
      }
      )
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

    // Assign to `this.ref`
    this.ref = result;
    this.FormInputs.get('purchaseRef')?.setValue(this.ref);
    console.log(result);
  }
  OnsubmitDetails() {

  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
