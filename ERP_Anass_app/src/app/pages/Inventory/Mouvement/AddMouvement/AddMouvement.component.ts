import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import { MatTableDataSource } from '@angular/material/table';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Sort } from '@angular/material/sort';
@Component({
  selector: 'app-AddMouvement',
  templateUrl: './AddMouvement.component.html',
  styleUrls: ['./AddMouvement.component.css']
})
export class AddMouvementComponent implements OnInit {
  displayedColumns: string[] = ['idArticle', 'articleName', 'familyName', 'stockQuantity', 'purchasePrice', 'sellingPrice'];
  displayedColumnsDetails: string[] = ['MovementDetailID', 'Product', 'Quantity', 'CreatedAt', 'UpdatedAt', 'update', 'delete'];

  dataSource = new MatTableDataSource();
  dataSource_details = new MatTableDataSource();

  @Input() article?: Article;
  FormInputMouvement: FormGroup;
  FormMouvementDetails: FormGroup;
  showAlert: boolean = false;
  listFamilly?: Familly[];
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: any[] = [];

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private _liveAnnouncer: LiveAnnouncer
  ) {
    // 'FromWarehouse',
    // 'ToWarehouse',
    // 'Quantity',
    // 'MovementDate',
    // 'MovementType',
    // 'Reason',
    // 'HandledBy',
    this.FormInputMouvement = this.fb.group({
      MouvementRef: ['', Validators.required],
      FromWarehouse: ['', Validators.required],
      ToWarehouse: ['', Validators.required],
      Quantity: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      MovementDate: ['', Validators.required],
      MovementType: ['', Validators.required],
      Reason: ['', Validators.required],
      HandledBy: ['', Validators.required]
    });
    this.FormMouvementDetails = this.fb.group({
      Product: ['', Validators.required],
      Quantity: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]]
    })
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;

      }
    });

  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
  applyFilter_details(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource_details.filter = filterValue.trim().toLowerCase();

    if (this.dataSource_details.paginator) {
      this.dataSource_details.paginator.firstPage();
    }
  }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
  onSubmit(): void {
    if (this.FormInputMouvement.valid) {
      console.log(this.FormInputMouvement);


    } else {
      console.log('Form not valid');
      this.showAlert = true; // Show the alert if the form is not valid
    }
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }

}
