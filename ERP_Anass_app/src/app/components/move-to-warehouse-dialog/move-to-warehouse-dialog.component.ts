import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { WarehouseService } from 'src/app/Services/Inventory/Warehouse.service';
import { Warehouse } from 'src/app/models/Inventory/Warehouse';

@Component({
  selector: 'app-move-to-warehouse-dialog',
  template: `
    <h2 mat-dialog-title>Move Items to Warehouse</h2>
    <mat-dialog-content>
      <p>Select the destination warehouse for this purchase.</p>
      
      <div class="form-group mt-3">
        <label>Warehouse</label>
        <ng-select [items]="warehouses" 
                   bindLabel="name" 
                   bindValue="idWarehouse" 
                   [(ngModel)]="selectedWarehouseId"
                   placeholder="Select Warehouse">
        </ng-select>
      </div>
    </mat-dialog-content>
    <mat-dialog-actions align="end">
      <button mat-button (click)="onCancel()">Cancel</button>
      <button mat-raised-button color="primary" 
              [disabled]="!selectedWarehouseId" 
              (click)="onConfirm()">
        Confirm Move
      </button>
    </mat-dialog-actions>
  `,
  styles: [`
    ng-select { width: 100%; }
  `],
  standalone: false
})
export class MoveToWarehouseDialogComponent implements OnInit {
  warehouses: Warehouse[] = [];
  selectedWarehouseId: number | null = null;

  constructor(
    private dialogRef: MatDialogRef<MoveToWarehouseDialogComponent>,
    private warehouseService: WarehouseService,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }

  ngOnInit() {
    this.warehouseService.getWarehouses().subscribe(data => {
      this.warehouses = data;
    });
  }

  onCancel() {
    this.dialogRef.close(null);
  }

  onConfirm() {
    this.dialogRef.close(this.selectedWarehouseId);
  }
}
