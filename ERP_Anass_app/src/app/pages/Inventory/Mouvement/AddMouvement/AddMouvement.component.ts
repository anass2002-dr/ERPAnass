
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StockMovement, StockMovementType } from 'src/app/models/Inventory/StockMovement';
import { StockMovementService } from 'src/app/Services/Inventory/StockMovement.service';
import { WarehouseService } from 'src/app/Services/Inventory/Warehouse.service';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-AddMouvement',
  templateUrl: './AddMouvement.component.html',
  styleUrls: ['./AddMouvement.component.css'],
  standalone: false
})
export class AddMouvementComponent implements OnInit {
  @Input() movement?: StockMovement;
  movementForm: FormGroup;
  showAlert: boolean = false;
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: any[] = [];

  warehouses: any[] = [];
  articles: any[] = [];

  // Convert Enum to Array
  movementTypes = Object.keys(StockMovementType)
    .filter(key => !isNaN(Number(key)))
    .map(key => ({ id: Number(key), name: StockMovementType[Number(key)] }));

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private stockMovementService: StockMovementService,
    private warehouseService: WarehouseService,
    private productService: ProductService
  ) {
    this.movementForm = this.fb.group({
      articleID: [null, Validators.required],
      warehouseID: [null, Validators.required],
      quantity: [0, [Validators.required, Validators.min(1)]],
      type: [null, Validators.required],
      movementDate: [new Date(), Validators.required]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);

    // Load dependencies
    this.warehouseService.getWarehouses().subscribe(data => this.warehouses = data);
    this.productService.GetDataArticle().subscribe(data => this.articles = data);

    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;
        this.stockMovementService.getStockMovementById(parseInt(this.id)).subscribe(mv => {
          this.movement = mv;
          this.movementForm.patchValue(mv);
        });
      }
    });
  }

  onSubmit() {
    if (this.movementForm.valid) {
      const formValue = this.movementForm.value;
      formValue.type = Number(formValue.type); // Ensure number

      const movement: StockMovement = { ...this.movement, ...formValue };

      if (this.isUpdateMode) {
        this.stockMovementService.updateStockMovement(movement).subscribe(response => {
          console.log('Movement updated', response);
          this.router.navigate(['Inventory/Mouvement/WarehousesMovement']);
        }, error => {
          console.error('Error updating movement', error);
          this.showAlert = true;
        });
      } else {
        this.stockMovementService.createStockMovement(movement).subscribe(response => {
          console.log('Movement created', response);
          this.router.navigate(['Inventory/Mouvement/WarehousesMovement']);
        }, error => {
          console.error('Error creating movement', error);
          this.showAlert = true;
        });
      }
    } else {
      console.log('Form invalid');
      this.showAlert = true;
    }
  }

  onReset() {
    this.movementForm.reset();
    this.showAlert = false;
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }
}
