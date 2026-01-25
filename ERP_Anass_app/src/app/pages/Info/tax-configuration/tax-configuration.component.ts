import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { TaxConfiguration } from 'src/app/models/TaxConfiguration/TaxConfiguration';
import { TaxConfigurationService } from 'src/app/Services/TaxConfiguration/TaxConfiguration.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-tax-configuration',
  standalone: false,
  templateUrl: './tax-configuration.component.html',
  styleUrl: './tax-configuration.component.css'
})
export class TaxConfigurationComponent implements OnInit {

  displayedColumns: string[] = ['taxName', 'taxRate', 'description', 'actions'];
  dataSource = new MatTableDataSource<TaxConfiguration>();

  form: FormGroup;
  isUpdateMode: boolean = false;
  selectedId: number = 0;
  showAlertSuccess: boolean = false;

  // Modal visibility
  showModal: boolean = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private taxService: TaxConfigurationService,
    private fb: FormBuilder,
    private _liveAnnouncer: LiveAnnouncer
  ) {
    this.form = this.fb.group({
      taxName: ['', Validators.required],
      taxRate: [0, [Validators.required, Validators.min(0)]],
      description: [''],
      isActive: [true]
    });
  }

  ngOnInit(): void {
    this.loadTaxes();
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  loadTaxes() {
    this.taxService.GetTaxConfigurations().subscribe(data => {
      this.dataSource.data = data;
    });
  }

  openModal(tax?: TaxConfiguration) {
    this.showModal = true;
    const modal = document.getElementById('taxModal');
    if (modal) modal.classList.remove('d-none');

    if (tax) {
      this.isUpdateMode = true;
      this.selectedId = tax.idTaxConfig;
      this.form.patchValue(tax);
    } else {
      this.isUpdateMode = false;
      this.selectedId = 0;
      this.form.reset({ isActive: true, taxRate: 0 });
    }
  }

  closeModal() {
    this.showModal = false;
    const modal = document.getElementById('taxModal');
    if (modal) modal.classList.add('d-none');
  }

  onSubmit() {
    if (this.form.invalid) return;

    const taxData: TaxConfiguration = { ...this.form.value, idTaxConfig: this.selectedId };

    if (this.isUpdateMode) {
      this.taxService.UpdateTaxConfiguration(taxData, this.selectedId).subscribe(() => {
        this.loadTaxes();
        this.closeModal();
        this.showSuccess();
      });
    } else {
      this.taxService.AddTaxConfiguration(taxData).subscribe(() => {
        this.loadTaxes();
        this.closeModal();
        this.showSuccess();
      });
    }
  }

  deleteTax(id: number) {
    if (confirm('Are you sure you want to delete this tax?')) {
      this.taxService.DeleteTaxConfiguration(id).subscribe(() => {
        this.loadTaxes();
      });
    }
  }

  showSuccess() {
    this.showAlertSuccess = true;
    setTimeout(() => this.showAlertSuccess = false, 3000);
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }
}
