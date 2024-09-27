import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { ActivatedRoute, Router } from '@angular/router';
import { Department } from 'src/app/models/Employee/Department';
import { EmployeeService } from 'src/app/Services/Employee/Employee.service';
import { erp_anass } from 'src/main';
@Component({
  selector: 'app-List-Departement',
  templateUrl: './List-Departement.component.html',
  styleUrls: ['./List-Departement.component.css']
})
export class ListDepartementComponent implements OnInit {
  displayedColumns: string[] = ['departmentID', 'departmentName', 'update', 'delete'];
  dataSource = new MatTableDataSource<Department>();
  loading = true;
  breadcrumbs: any[] = [];
  FormInputs: FormGroup;
  UpdateMode = false;
  showAlert = false;
  showAlertSuccess = false;
  departmentID: Number = 0;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private departmentService: EmployeeService, private route: ActivatedRoute) {
    this.FormInputs = this.fb.group({
      departmentID: [0],
      departmentName: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);
    this.getAllDepartments();
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }
  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this.liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this.liveAnnouncer.announce('Sorting cleared');
    }
  }
  getAllDepartments() {
    this.departmentService.GetDepartments().subscribe((res: Department[]) => {
      this.dataSource.data = res;
      this.loading = false;
    });
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  setUpdateMode(department: Department) {
    this.UpdateMode = true;
    this.departmentID = department.departmentID;
    this.FormInputs.patchValue(department);
    erp_anass.closeModelErp()
  }
  open() {
    this.FormInputs.reset();
    this.UpdateMode = false;
    erp_anass.closeModelErp()
  }
  submitForm() {
    if (this.UpdateMode) {
      this.updateDepartment();
    } else {
      this.addDepartment();
    }
  }

  addDepartment() {
    if (this.FormInputs.valid) {
      this.FormInputs.value.departmentID = 0

      this.departmentService.AddDepartment(this.FormInputs.value).subscribe({
        next: () => {
          this.getAllDepartments();
          erp_anass.closeModelErp()

          this.showAlertSuccess = true;
        }
      });
    }
  }

  updateDepartment() {
    if (this.FormInputs.valid) {
      this.departmentService.UpdateDepartment(this.FormInputs.value, this.departmentID).subscribe({
        next: () => {
          this.getAllDepartments();
          erp_anass.closeModelErp()

          this.showAlertSuccess = true;
        }
      });
    }
  }

  deleteDepartment(departmentID: number) {
    if (confirm('Are you sure you want to delete this department?')) {
      this.departmentService.DeleteDepartment(departmentID).subscribe({
        next: () => {
          this.getAllDepartments();
        }
      });
    }
  }



  setDelete(departmentID: number) {
    this.departmentID = departmentID
    erp_anass.closeModeleDelete();
  }
  Delete() {
    this.departmentService.DeleteDepartment(this.departmentID).subscribe(
      () => {
        this.getAllDepartments();
        this.closeModel()

        this.showAlertSuccess = true;
      },
      error => {
        this.closeModel()

        this.showAlert = true;
        setTimeout(() => {

          alert("Can't delete this Departement because there are models linked with this Departement")
          alert("If you want to delete this Departement, you should to delete all models linked with this Departement")
        }, 1000);
      }
    );
  }
  closeModel() {
    this.departmentID = 0
    erp_anass.closeModeleDelete();
  }
  closeModelErp() {
    erp_anass.closeModelErp()
    this.showAlert = false;
    this.showAlertSuccess = false;
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }

  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }
}
