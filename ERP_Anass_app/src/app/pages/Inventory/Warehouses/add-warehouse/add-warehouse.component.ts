
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Warehouse } from 'src/app/models/Inventory/Warehouse';
import { WarehouseService } from 'src/app/Services/Inventory/Warehouse.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-warehouse',
    templateUrl: './add-warehouse.component.html',
    styleUrls: ['./add-warehouse.component.css'],
    standalone: false
})
export class AddWarehouseComponent implements OnInit {
    @Input() warehouse?: Warehouse;
    warehouseForm: FormGroup;
    showAlert: boolean = false;
    isUpdateMode: boolean = false;
    id: string = "";
    breadcrumbs: any[] = [];

    constructor(private fb: FormBuilder, private route: ActivatedRoute, private router: Router, private warehouseService: WarehouseService) {
        this.warehouseForm = this.fb.group({
            name: ['', Validators.required],
            location: ['', Validators.required],
            isAcitve: [true]
        });
    }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        this.route.paramMap.subscribe(params => {
            this.id = params.get('id') || "";
            if (this.id) {
                this.isUpdateMode = true;
                this.warehouseService.getWarehouseById(parseInt(this.id)).subscribe(warehouse => {
                    this.warehouse = warehouse;
                    this.warehouseForm.patchValue(warehouse);
                });
            }
        });
    }

    onSubmit() {
        if (this.warehouseForm.valid) {
            const warehouse: Warehouse = { ...this.warehouse, ...this.warehouseForm.value };

            if (this.isUpdateMode) {
                this.warehouseService.updateWarehouse(warehouse).subscribe(response => {
                    console.log('Warehouse updated successfully', response);
                    this.router.navigate(['Inventory/Warehouses/list_warehouses']);
                }, error => {
                    console.error('Error updating warehouse', error);
                    this.showAlert = true;
                });
            } else {
                this.warehouseService.createWarehouse(warehouse).subscribe(response => {
                    console.log('Warehouse created successfully', response);
                    this.router.navigate(['Inventory/Warehouses/list_warehouses']);
                }, error => {
                    console.error('Error creating warehouse', error);
                    this.showAlert = true;
                });
            }
        } else {
            console.log('Form not valid');
            this.showAlert = true;
        }
    }

    onReset() {
        this.warehouseForm.reset();
        this.showAlert = false;
    }

    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb);
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list);
    }
}
