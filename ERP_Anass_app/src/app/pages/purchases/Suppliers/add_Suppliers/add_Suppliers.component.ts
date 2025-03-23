import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import { Supplier } from 'src/app/models/Supplier/Supplier';
import { SupplierService } from 'src/app/Services/Supplier/Supplier.service';
import { Country } from 'src/app/models/Info/Country';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { City } from 'src/app/models/Info/City';

@Component({
  selector: 'app-add_Suppliers',
  templateUrl: './add_Suppliers.component.html',
  styleUrls: ['./add_Suppliers.component.css']
})
export class Add_SuppliersComponent implements OnInit {

  @Input() Supllier?: Supplier;
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
  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private SupplierService: SupplierService,
    private info: InfoServiceService
  ) {
    this.FormInputs = this.fb.group({
      idSupplier: [0],
      supplierRef: ['', Validators.required],
      supplierName: ['', Validators.required],
      contactPerson: [''],
      phone: [''],
      email: [''],
      address: [''],
      countryId: [''],
      cityID: [''],
      identityNumber: ['', Validators.required],
      IsAcitve: [true]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.loadCity(0);
    this.loadCountry()
    this.route.paramMap.subscribe(params => {
      this.id = parseInt(params.get('id')) || 0;
      console.log(this.id);

      if (this.id != 0) {
        this.loading = true
        this.isUpdateMode = true;
        this.SupplierService.GetSupplierById(this.id).subscribe(supplier => {
          this.Supllier = supplier;
          console.log(this.Supllier);
          this.FormInputs.patchValue(this.Supllier);
        });
        this.loading = false
      }
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
    console.log(id);
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
    console.log(this.listCity);


  }
  checkIdentity(identity: string) {
    if (!identity) return; // Prevent API call if input is empty

    // Optional: Add a small delay (e.g., 500ms) to prevent unnecessary API calls

    this.SupplierService.SupplierByIdentity(identity).subscribe(
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
    this.ref = 'SUP' + result + '' + random1
    this.FormInputs.get('supplierRef')?.setValue(this.ref);
    console.log(result);
  }
  onSubmit(): void {
    if (this.FormInputs.valid && !this.identityExists) {
      const Supplier: Supplier = { ...this.Supllier, ...this.FormInputs.value };

      if (this.isUpdateMode) {
        console.log(Supplier);

        this.SupplierService.UpdateSupplier(Supplier, this.id).subscribe(response => {

          console.log('Supplier updated successfully', response);
          this.router.navigate(['Suppliers/list-Suppliers']); // Navigate back to the article list
        }, error => {
          console.error('Error updating Supplier', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        console.log(Supplier);
        this.SupplierService.AddSupplier(Supplier).subscribe(response => {
          this.router.navigate(['Suppliers/list-Suppliers']); // Navigate back to the article list

          console.log('Supplier created successfully', response);
          // this.router.navigate(['Suppliers/list-Suppliers']); // Navigate back to the article list
        }, error => {
          console.error('Error creating Supplier', error);
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
