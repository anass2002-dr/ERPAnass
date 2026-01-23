import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Brand } from 'src/app/models/Brand/Brand';
import { BrandService } from 'src/app/Services/Brand/Brand.service';
import { erp_anass } from 'src/main';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { Familly } from 'src/app/models/Familly/Familly';

@Component({
    selector: 'app-add-brand',
    templateUrl: './add-brand.component.html',
    styleUrls: ['./add-brand.component.css'],
    standalone: false
})
export class AddBrandComponent implements OnInit {
    @Input() brand?: Brand;
    brandForm: FormGroup;
    showAlert: boolean = false;
    isUpdateMode: boolean = false;
    listFamilly?: Familly[];
    id: string = "";
    breadcrumbs: any[] = [];
    ref: string = "";

    constructor(private fb: FormBuilder, private route: ActivatedRoute, private router: Router, private brandService: BrandService, private familyService: FamilyService) {
        this.brandForm = this.fb.group({
            brandRef: ['', Validators.required],
            brandName: ['', Validators.required],
            idFamilly: [null], // Initialize as null
            isAcitve: [true] // Match backend typo and default to true
        });
    }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route)
        this.familyService.GetDataFamily().subscribe(data => {
            this.listFamilly = data;
        });

        this.route.paramMap.subscribe(params => {
            this.id = params.get('id') || "";
            if (this.id) {
                this.isUpdateMode = true;
                this.brandService.getBrandById(parseInt(this.id)).subscribe(brand => {
                    this.brand = brand;
                    this.brandForm.patchValue(brand);
                });
            }
        });
    }

    onSubmit() {
        if (this.brandForm.valid) {

            const formValue = this.brandForm.value;
            // ensure idFamilly is null if empty string
            if (formValue.idFamilly === "") {
                formValue.idFamilly = null;
            }

            const brand: Brand = { ...this.brand, ...formValue };

            if (this.isUpdateMode) {
                this.brandService.updateBrand(brand).subscribe(response => {
                    console.log('Brand updated successfully', response);
                    this.router.navigate(['Article/list-brand']);
                }, error => {
                    console.error('Error updating brand', error);
                    this.showAlert = true;
                });
            } else {
                this.brandService.createBrand(brand).subscribe(response => {
                    console.log('Brand created successfully', response);
                    this.router.navigate(['Article/list-brand']);
                }, error => {
                    console.error('Error creating Brand', error);
                    this.showAlert = true;
                });
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
        const result = `${year}${month}${day}${hours}${minutes}${seconds}`;
        let random1 = Math.floor(Math.random() * (99 - 10)) + 10;
        this.ref = 'BR' + result + '' + random1
        this.brandForm.get('brandRef')?.setValue(this.ref);
    }
    onReset() {
        this.brandForm.reset();
        this.showAlert = false;
    }
    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb)
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list)
    }
}
