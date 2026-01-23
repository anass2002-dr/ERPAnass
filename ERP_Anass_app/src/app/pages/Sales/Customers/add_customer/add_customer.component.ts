import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import { Customer } from 'src/app/models/Customer/Customer';
import { CustomerService } from 'src/app/Services/Customer/Customer.service';
import { Country } from 'src/app/models/Info/Country';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { City } from 'src/app/models/Info/City';
import { AccountService } from 'src/app/Services/Finance/Account.service';
import { Account } from 'src/app/models/Finance/Account';

@Component({
  selector: 'app-add_Customer',
  templateUrl: './Add_Customer.component.html',
  styleUrls: ['./Add_Customer.component.css'],
  standalone: false
})
export class Add_CustomerComponent implements OnInit {

  @Input() Supllier?: Customer;
  FormInputs: FormGroup;
  showAlert: boolean = false;
  listCountry?: Country[];
  listCity?: City[];
  isUpdateMode: boolean = false;
  id: number = 0;
  breadcrumbs: any[] = [];
  typingTimeout: any;
  ref: string = "";
  identityExists: boolean = false;
  loading: boolean = false;
  controlAccounts: Account[] = [];

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private CustomerService: CustomerService,
    private info: InfoServiceService,
    private accountService: AccountService
  ) {
    this.FormInputs = this.fb.group({
      idCustomer: [0],
      customerRef: ['', Validators.required],
      customerName: ['', Validators.required],
      contactPerson: [''],
      phone: [''],
      email: [''],
      address: [''],
      countryId: [''],
      cityID: [''],
      identityNumber: ['', Validators.required],
      IsAcitve: [true],
      idControlAccount: [null, Validators.required]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadCity(0);
    this.loadCountry();
    this.loadAccounts();

    this.route.paramMap.subscribe(params => {
      this.id = parseInt(params.get('id')) || 0;

      if (this.id != 0) {
        this.loading = true
        this.isUpdateMode = true;
        this.CustomerService.GetCustomerById(this.id).subscribe(Customer => {
          this.Supllier = Customer;
          this.FormInputs.patchValue(this.Supllier);
        });
        this.loading = false
      }
    });

  }

  loadAccounts() {
    this.accountService.getAccounts().subscribe(accounts => {
      // Filter accounts based on type (1 = Asset, appropriate for Customer Control Account / Receivable)
      this.controlAccounts = accounts.filter(a => a.type === 1);
    });
  }

  loadCountry() {
    this.loading = true

    this.info.GetAllCountries().subscribe(
      data => {
        this.listCountry = data;
        this.loading = false
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );

  }
  loadCity(id: Number) {
    this.loading = true
    this.listCity = []
    if (id != 0) {
      this.info.GetCitysDetailsByCountry(id).subscribe(
        data => {
          this.listCity = data;
          this.loading = false
        },
        error => {
          console.error('Error fetching data', error);
          this.loading = false;
        }
      );
    }
    else {
      this.info.GetCitysDetails().subscribe(
        data => {
          this.listCity = data;
          this.loading = false
        },
        error => {
          console.error('Error fetching data', error);
          this.loading = false;
        }
      );
    }


  }
  checkIdentity(identity: string) {
    if (!identity) return; // Prevent API call if input is empty

    // Optional: Add a small delay (e.g., 500ms) to prevent unnecessary API calls

    this.CustomerService.CustomerByIdentity(identity).subscribe(
      response => {
        this.identityExists = !!response; // Set to true if identity exists
      }

    );
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
    this.ref = 'CUS' + result + '' + random1
    this.FormInputs.get('customerRef')?.setValue(this.ref);
  }
  onSubmit(): void {
    if (this.FormInputs.valid && !this.identityExists) {

      const Customer: Customer = { ...this.Supllier, ...this.FormInputs.value };

      // console.log(Customer);

      if (this.isUpdateMode) {

        this.CustomerService.UpdateCustomer(Customer, this.id).subscribe(response => {

          console.log('Customer updated successfully', response);
          this.router.navigate(['Customers/list-Customers']); // Navigate back to the article list
        }, error => {
          console.error('Error updating Customer', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      } else {

        this.CustomerService.AddCustomer(Customer).subscribe(response => {
          this.router.navigate(['Customers/list-Customers']); // Navigate back to the article list

          console.log('Customer created successfully', response);
          // this.router.navigate(['Customers/list-Customers']); // Navigate back to the article list
        }, error => {
          console.error('Error creating Customer', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      }
    } else {
      console.log('Form not valid');
      this.showAlert = true; // Show the alert if the form is not valid
    }
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
