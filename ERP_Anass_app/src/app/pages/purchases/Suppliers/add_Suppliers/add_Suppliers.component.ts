import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import { Supplier } from 'src/app/models/Supplier/Supplier';
import { SupplierService } from 'src/app/Services/Supplier/Supplier.service';
import { Country } from 'src/app/models/Info/Country';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';

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
  isUpdateMode: boolean = false;
  id: number = 0;
  breadcrumbs: any[] = [];

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
      countryId: ['']
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.info.GetAllCountries().subscribe(data => {
      this.listCountry = data;
    });
    this.route.paramMap.subscribe(params => {
      this.id = parseInt(params.get('id')) || 0;
      console.log(this.id);

      if (this.id != 0) {
        this.isUpdateMode = true;
        this.SupplierService.GetSupplierById(this.id).subscribe(supplier => {
          this.Supllier = supplier;
          console.log(this.Supllier);
          this.FormInputs.patchValue(this.Supllier);
        });
      }
    });

  }

  onSubmit(): void {
    if (this.FormInputs.valid) {
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

          console.log('Supplier created successfully', response);
          this.router.navigate(['Suppliers/list-Suppliers']); // Navigate back to the article list
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
