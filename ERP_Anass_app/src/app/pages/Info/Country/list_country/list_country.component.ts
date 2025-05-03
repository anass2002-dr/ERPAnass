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
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { Country } from 'src/app/models/Info/Country';
@Component({
    selector: 'app-list_country',
    templateUrl: './list_country.component.html',
    styleUrls: ['./list_country.component.css'],
    standalone: false
})

export class List_countryComponent implements OnInit {

  displayedColumns: string[] = [
    'countryId',
    'countryName',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Country[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  FormInputs: FormGroup;
  UpdateMode: boolean = false;
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  country: Country;
  id: Number = 0;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private InfoService: InfoServiceService, private route: ActivatedRoute) {
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
    this.loadCountry()
    this.breadcrumbs = erp_anass.title_header(this.route)
  }
  loadCountry() {

    this.InfoService.GetAllCountries().subscribe(
      data => {
        this.list = data;
        this.dataSource.data = this.list;
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
        this.loading = false;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );

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
  add_country() {
    console.log("submited");

    if (this.FormInputs.valid) {
      const country: Country = this.FormInputs.getRawValue();
      if (this.UpdateMode) {
        this.InfoService.UpdateCountry(country, this.id).subscribe(response => {
          this.dataSource.data = this.list;

          this.loadCountry()
          this.closeModelErp()
          this.showAlertSuccess = true;
          this.UpdateMode = false
          this.id = 0
        }, error => {

          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        console.log(country);
        this.InfoService.AddCountry(country).subscribe(response => {
          this.loadCountry()
          this.closeModelErp()

          this.showAlertSuccess = true
          // Navigate back to the user list
        }, error => {
          alert('this user are already have permssion for this module');
          this.showAlert = true; // Show the alert if there was an error
        });
      }
      setTimeout(() => {
        this.showAlertSuccess = false
      }, 1000);
      console.log(this.FormInputs.value);
    } else {
      console.log('Form not valid');
      this.showAlert = true;
    }
  }
  SetUpdateMode(id: Number, countryName: string) {
    this.UpdateMode = true
    this.FormInputs.patchValue({ countryId: id, countryName: countryName })
    this.id = id
    erp_anass.closeModelErp()
  }
  closeModelErp() {
    this.UpdateMode = false
    erp_anass.closeModelErp()
  }
  open() {

    this.FormInputs.patchValue({ countryID: 0, countryName: "" })
    erp_anass.closeModelErp()
  }
  setDelete(id: Number) {
    this.id = id
  }
  Delete() {
    this.InfoService.DeleteCountry(this.id).subscribe(

      (repons: any) => {
        console.log(repons);

        this.list = this.list.filter(a => a.countryId !== this.id);
        this.dataSource.data = this.list;
        this.loadCountry()
        this.closeModel()
      },
      error => {
        this.closeModel()
        setTimeout(() => {

          alert("Can't delete this Country because there are models linked with this country")
          alert("If you want to delete this Country, you should to delete all models linked with this country")
        }, 1000);
      }

    );
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
  closeModel() {
    erp_anass.closeModeleDelete();
  }
}
