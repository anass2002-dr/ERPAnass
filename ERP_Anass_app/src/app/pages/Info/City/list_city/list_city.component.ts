import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Article } from 'src/app/models/Article/Article';
import { City } from 'src/app/models/Info/City';
import { Country } from 'src/app/models/Info/Country';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { erp_anass } from 'src/main';
@Component({
    selector: 'app-list_city',
    templateUrl: './list_city.component.html',
    styleUrls: ['./list_city.component.css'],
    standalone: false
})
export class List_cityComponent implements OnInit {

  displayedColumns: string[] = [
    'cityID',
    'cityName',
    'country',
    'zipCode',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: City[] = [];
  listCountry: Country[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  FormInputs: FormGroup;
  UpdateMode: boolean = false;
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  city: City;
  id: Number = 0;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private InfoService: InfoServiceService, private route: ActivatedRoute) {
    this.FormInputs = this.fb.group({
      cityName: ['', Validators.required],
      countryId: ['', Validators.required],
      zipCode: [''],

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
    this.loadcity()
    this.loadCountry()
    this.breadcrumbs = erp_anass.title_header(this.route)
  }
  loadcity() {
    this.InfoService.GetCitysDetails().subscribe(
      data => {
        console.log(data);

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
  add_city() {
    console.log("submited");

    if (this.FormInputs.valid) {
      const city: City = this.FormInputs.getRawValue();
      if (this.UpdateMode) {
        console.log(city);
        this.InfoService.UpdateCity(city, this.id).subscribe(response => {
          this.dataSource.data = this.list;

          this.loadcity()
          this.closeModelErp()
          this.showAlertSuccess = true;
          this.UpdateMode = false
          this.id = 0
        }, error => {

          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        console.log(city);
        this.InfoService.AddCity(city).subscribe(response => {
          this.loadcity()
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
  SetUpdateMode(id: Number, cityName: string, countryId: Number, zipCode: Number) {
    this.UpdateMode = true
    this.FormInputs.patchValue({ cityId: id, cityName: cityName, countryId: countryId, zipCode: zipCode })
    this.id = id
    erp_anass.closeModelErp()
  }
  closeModelErp() {
    this.UpdateMode = false
    erp_anass.closeModelErp()
  }
  loadCountry() {

    this.InfoService.GetAllCountries().subscribe(
      data => {
        this.listCountry = data;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );

  }
  open() {

    this.FormInputs.reset()
    erp_anass.closeModelErp()
  }
  setDelete(id: Number) {
    this.id = id

    erp_anass.closeModeleDelete();
  }
  Delete() {
    this.InfoService.DeleteCity(this.id).subscribe(
      (repons: any) => {
        console.log(repons);

        this.list = this.list.filter(a => a.CityID !== this.id);
        this.dataSource.data = this.list;
        this.loadcity()
        this.closeModel()
      },
      error => {
        this.closeModel()
        setTimeout(() => {

          alert("Can't delete this city because there are models linked with this city")
          alert("If you want to delete this city, you should to delete all models linked with this city")
        }, 1000);
      }
    );
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
  closeModel() {
    this.id = 0
    erp_anass.closeModeleDelete();
  }
}
