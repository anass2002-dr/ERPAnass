
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StockMovement, StockMovementType, StockMovementDetail } from 'src/app/models/Inventory/StockMovement';
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

  // Temporary holder for item being added
  currentItem: any = {
    articleID: null,
    quantity: 1
  };

  // List of items to be saved
  movementDetails: StockMovementDetail[] = [];

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
      warehouseID: [null, Validators.required],
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
          this.movementForm.patchValue({
            warehouseID: mv.warehouseID,
            type: mv.type,
            movementDate: mv.movementDate
          });
          // Load details
          if (mv.stockMovementDetails) {
            this.movementDetails = mv.stockMovementDetails;
          }
        });
      }
    });
  }

  addItem() {
    if (this.currentItem.articleID && this.currentItem.quantity > 0) {
      const article = this.articles.find(a => a.idArticle === this.currentItem.articleID);

      const detail: StockMovementDetail = {
        articleID: this.currentItem.articleID,
        quantity: this.currentItem.quantity,
        article: article // For display purpose
      };

      this.movementDetails.push(detail);

      // Reset current item
      this.currentItem = { articleID: null, quantity: 1 };
    }
  }

  removeItem(index: number) {
    this.movementDetails.splice(index, 1);
  }

  onSubmit() {
    if (this.movementForm.valid && this.movementDetails.length > 0) {
      const formValue = this.movementForm.value;
      const movementPayload: StockMovement = {
        warehouseID: formValue.warehouseID,
        type: Number(formValue.type),
        movementDate: formValue.movementDate,
        stockMovementDetails: this.movementDetails
      };

      // Add ID if update mode
      if (this.isUpdateMode && this.movement) {
        movementPayload.idStockMovement = this.movement.idStockMovement;
      }

      if (this.isUpdateMode) {
        this.stockMovementService.updateStockMovement(movementPayload).subscribe(response => {
          this.router.navigate(['Inventory/Mouvement/WarehousesMovement']);
        }, error => {
          console.error('Error updating movement', error);
          this.showAlert = true;
        });
      } else {
        this.stockMovementService.createStockMovement(movementPayload).subscribe(response => {
          this.router.navigate(['Inventory/Mouvement/WarehousesMovement']);
        }, error => {
          console.error('Error creating movement', error);
          this.showAlert = true;
        });
      }
    } else {
      console.log('Form invalid or no items');
      this.showAlert = true;
    }
  }

  onReset() {
    this.movementForm.reset();
    this.movementDetails = [];
    this.showAlert = false;
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }
}
