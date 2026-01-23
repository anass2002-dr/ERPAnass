
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { BillOfMaterials } from 'src/app/models/Inventory/BillOfMaterials';
import { BillOfMaterialsService } from 'src/app/Services/Inventory/BillOfMaterials.service';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-bom',
    templateUrl: './add-bom.component.html',
    styleUrls: ['./add-bom.component.css'],
    standalone: false
})
export class AddBOMComponent implements OnInit {
    @Input() bom?: BillOfMaterials;
    bomForm: FormGroup;
    showAlert: boolean = false;
    isUpdateMode: boolean = false;
    id: string = "";
    breadcrumbs: any[] = [];
    articles: any[] = [];

    constructor(
        private fb: FormBuilder,
        private route: ActivatedRoute,
        private router: Router,
        private bomService: BillOfMaterialsService,
        private productService: ProductService
    ) {
        this.bomForm = this.fb.group({
            parentArticleId: [null, Validators.required],
            childArticleId: [null, Validators.required],
            quantityNeeded: [0, [Validators.required, Validators.min(0.01)]]
        });
    }

    ngOnInit(): void {
        this.breadcrumbs = erp_anass.title_header(this.route);

        this.productService.GetDataArticle().subscribe(data => this.articles = data);

        this.route.paramMap.subscribe(params => {
            this.id = params.get('id') || "";
            if (this.id) {
                this.isUpdateMode = true;
                this.bomService.getBOMById(parseInt(this.id)).subscribe(bom => {
                    this.bom = bom;
                    this.bomForm.patchValue(bom);
                });
            }
        });
    }

    onSubmit() {
        if (this.bomForm.valid) {
            const bom: BillOfMaterials = { ...this.bom, ...this.bomForm.value };

            if (this.isUpdateMode) {
                this.bomService.updateBOM(bom).subscribe(response => {
                    console.log('BOM updated successfully', response);
                    this.router.navigate(['Inventory/BOM/list-bom']);
                }, error => {
                    console.error('Error updating BOM', error);
                    this.showAlert = true;
                });
            } else {
                this.bomService.createBOM(bom).subscribe(response => {
                    console.log('BOM created successfully', response);
                    this.router.navigate(['Inventory/BOM/list-bom']);
                }, error => {
                    console.error('Error creating BOM', error);
                    this.showAlert = true;
                });
            }
        } else {
            console.log('Form not valid');
            this.showAlert = true;
        }
    }

    onReset() {
        this.bomForm.reset();
        this.showAlert = false;
    }

    formatBreadcrumb(breadcrumb: string): string {
        return erp_anass.formatBreadcrumb(breadcrumb);
    }
    formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
        return erp_anass.formatBreadcrumbLink(breadcrumb, list);
    }
}
