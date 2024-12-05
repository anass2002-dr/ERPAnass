import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild, inject } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';

import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
import { Currency } from 'src/app/models/Info/Currency';
@Component({
  selector: 'app-list-currency',
  templateUrl: './list-currency.component.html',
  styleUrls: ['./list-currency.component.css']
})
export class ListCurrencyComponent implements OnInit {
  displayedColumns: string[] = [
    'idCurrency',
    'currencyName',
    'update',
    'delete'
  ];
  dataSource = new MatTableDataSource();
  list: Currency[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  FormInputs: FormGroup;
  UpdateMode: boolean = false;
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  currency: Currency;
  id: Number = 0;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private InfoService: InfoServiceService, private route: ActivatedRoute) {
    this.FormInputs = this.fb.group({
      idCurrency: [0],
      currencyName: ['', Validators.required],
      isAcitve: [true]
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
    this.loadcurrency()
    this.breadcrumbs = erp_anass.title_header(this.route)
  }
  loadcurrency() {

    this.InfoService.GetAllCurrencys().subscribe(
      data => {
        console.log(data)
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
  add_currency() {

    if (this.FormInputs.valid) {
      const currency: Currency = this.FormInputs.getRawValue();
      console.log(currency)
      if (this.UpdateMode) {
        this.InfoService.UpdateCurrency(currency, this.id).subscribe(response => {
          this.dataSource.data = this.list;

          this.loadcurrency()
          this.closeModelErp()
          this.showAlertSuccess = true;
          this.UpdateMode = false
          this.id = 0
        }, error => {

          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        console.log(currency);
        this.InfoService.AddCurrency(currency).subscribe(response => {
          this.loadcurrency()
          this.closeModelErp()

          this.showAlertSuccess = true
          // Navigate back to the user list
        }, error => {
          alert('this Currency are already have permssion for this module');
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
  SetUpdateMode(id: Number, CurrencyName: string) {
    this.UpdateMode = true
    this.FormInputs.patchValue({ IdCurrency: id, CurrencyName: CurrencyName })
    this.id = id
    erp_anass.closeModelErp()
  }
  closeModelErp() {
    this.UpdateMode = false
    erp_anass.closeModelErp()
  }
  open() {

    this.FormInputs.patchValue({ IdCurrency: 0, CurrencyName: "" })
    erp_anass.closeModelErp()
  }
  setDelete(id: Number) {
    this.id = id
  }
  Delete() {
    this.InfoService.DeleteCurrency(this.id).subscribe(

      (repons: any) => {
        console.log(repons);

        this.list = this.list.filter(a => a.IdCurrency !== this.id);
        this.dataSource.data = this.list;
        this.loadcurrency()
        this.closeModel()
      },
      error => {
        this.closeModel()
        setTimeout(() => {

          alert("Can't delete this currency because there are models linked with this currency")
          alert("If you want to delete this currency, you should to delete all models linked with this currency")
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
