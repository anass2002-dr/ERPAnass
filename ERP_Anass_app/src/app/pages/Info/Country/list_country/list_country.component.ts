import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild, inject } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { erp_anass } from 'src/main';
import { MatButtonModule } from '@angular/material/button';
import {
  MAT_DIALOG_DATA,
  MatDialog,
  MatDialogActions,
  MatDialogClose,
  MatDialogContent,
  MatDialogRef,
  MatDialogTitle,
} from '@angular/material/dialog';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-list_country',
  templateUrl: './list_country.component.html',
  styleUrls: ['./list_country.component.css']
})

export class List_countryComponent implements OnInit {

  displayedColumns: string[] = [
    'CountryId',
    'CountryName',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Article[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  FormInputs: FormGroup;

  showAlert: boolean = false;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private productService: ProductService, private route: ActivatedRoute) {
    this.FormInputs = this.fb.group({
      countryName: ['', Validators.required]
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
  // openDialog(): void {
  //   const dialogRef = this.dialog.open(DialogOverviewExampleDialog, {
  //     data: { name: this.name(), animal: this.animal() },
  //   });

  //   dialogRef.afterClosed().subscribe(result => {
  //     console.log('The dialog was closed');
  //     if (result !== undefined) {
  //       this.animal.set(result);
  //     }
  //   });
  // }
}
