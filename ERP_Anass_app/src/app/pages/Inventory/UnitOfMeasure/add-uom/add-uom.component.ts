
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { UnitOfMeasure } from 'src/app/models/Inventory/UnitOfMeasure';
import { UnitOfMeasureService } from 'src/app/Services/Inventory/UnitOfMeasure.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-uom',
    templateUrl: './add-uom.component.html',
    styleUrls: ['./add-uom.component.css'],
    standalone: false
})
export class AddUOMComponent implements OnInit {
    @Input() uom?: UnitOfMeasure;
    uomForm: FormGroup;
    showAlert: boolean = false;
    isUpdateMode: boolean = false;
    id: string = "";
    breadcrumbs: any[] = [];

    constructor(
        private fb: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private uomService: UnitOfMeasureService
    ) {
        this.uomForm = this.fb.group({
            abbreviation: ['', Validators.required],
            uomName: ['', Validators.required],
            multiplier: [1, [Validators.required, Validators.min(0.0001)]],
            isAcitve: [true]
        });
    }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        this.route.paramMap.subscribe(params => {
            this.id = params.get('id') || "";
            if (this.id) {
                this.isUpdateMode = true;
                this.uomService.getUOMById(parseInt(this.id)).subscribe(uom => {
                    this.uom = uom;
                    this.uomForm.patchValue(uom);
                });
            }
        });
    }

    onSubmit() {
        if (this.uomForm.valid) {
            const uom: UnitOfMeasure = { ...this.uom, ...this.uomForm.value };

            if (this.isUpdateMode) {
                this.uomService.updateUOM(uom).subscribe(response => {
                    console.log('UOM updated successfully', response);
                    this.router.navigate(['Inventory/UOM/list-uom']);
                }, error => {
                    console.error('Error updating UOM', error);
                    this.showAlert = true;
                });
            } else {
                this.uomService.createUOM(uom).subscribe(response => {
                    console.log('UOM created successfully', response);
                    this.router.navigate(['Inventory/UOM/list-uom']);
                }, error => {
                    console.error('Error creating UOM', error);
                    this.showAlert = true;
                });
            }
        } else {
            console.log('Form not valid');
            this.showAlert = true;
        }
    }

    onReset() {
        this.uomForm.reset();
        this.showAlert = false;
    }

    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb);
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list);
    }
}
