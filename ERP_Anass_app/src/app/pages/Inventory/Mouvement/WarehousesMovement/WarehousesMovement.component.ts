import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';
@Component({
  selector: 'app-WarehousesMovement',
  templateUrl: './WarehousesMovement.component.html',
  styleUrls: ['./WarehousesMovement.component.css']
})
export class WarehousesMovementComponent implements OnInit {

  displayedColumns: string[] = [
    'WarehouseMouvementID',
    'FromWarehouse',
    'ToWarehouse',
    'Quantity',
    'MovementDate',
    'MovementType',
    'Reason',
    'HandledBy',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Article[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];

  showAlert: boolean = false;
  FormInputs: FormGroup;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private productService: ProductService, private route: ActivatedRoute) {
    this.FormInputs = this.fb.group({
      WarehouseName: ['', Validators.required],
      Location: ['', Validators.required],
      Capacity: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      CurrentStock: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]]
    });
  }

  announceSortChange(sortState: Sort) {

    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
  }

  deleteCustomer() {
    console.log();

  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  onSubmit(): void {
    if (this.FormInputs.valid) {
      console.log(this.FormInputs);
    } else {
      console.log('Form not valid');
      this.showAlert = true;
    }
  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }

}
