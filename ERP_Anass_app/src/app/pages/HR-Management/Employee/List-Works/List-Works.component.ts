import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Router, ActivatedRoute } from '@angular/router';
import { Works } from 'src/app/models/Employee/Works';
import { Department } from 'src/app/models/Employee/Department';
import { EmployeeService } from 'src/app/Services/Employee/Employee.service';
import { erp_anass } from 'src/main';


@Component({
    selector: 'app-List-Works',
    templateUrl: './List-Works.component.html',
    styleUrls: ['./List-Works.component.css'],
    standalone: false
})
export class ListWorksComponent implements OnInit {
  displayedColumns: string[] = ['WorkstID', 'WorksName', 'DepartmentName', 'update', 'delete'];
  dataSource = new MatTableDataSource();
  list: Works[] = [];
  listDepartment: Department[] = [];
  loading: boolean = true;
  breadcrumbs: any[] = [];
  FormInputs: FormGroup;
  UpdateMode: boolean = false;
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  work: Works;
  id: Number = 0;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private liveAnnouncer: LiveAnnouncer, private fb: FormBuilder, private router: Router, private EmployeeService: EmployeeService, private route: ActivatedRoute) {
    this.FormInputs = this.fb.group({
      worksName: ['', Validators.required],
      departmentID: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);
    this.loadWorks();
    this.loadDepartments();
  }

  loadWorks() {
    this.EmployeeService.GetWorksDetails().subscribe(
      data => {
        this.list = data;
        console.log(data);

        this.dataSource.data = this.list;
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
        this.loading = false;
      },
      error => {
        console.error('Error fetching works', error);
        this.loading = false;
      }
    );
  }

  loadDepartments() {
    this.EmployeeService.GetDepartments().subscribe(
      data => {
        this.listDepartment = data;
        console.log(data);

      },
      error => {
        console.error('Error fetching departments', error);
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

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this.liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this.liveAnnouncer.announce('Sorting cleared');
    }
  }

  open() {
    this.FormInputs.reset();
    this.UpdateMode = false;
    erp_anass.closeModelErp()
  }

  setUpdateMode(WorkstID: number, WorksName: string, DepartmentID: number) {
    this.FormInputs.patchValue({
      WorksName: WorksName,
      DepartmentID: DepartmentID
    });
    this.id = WorkstID;
    this.UpdateMode = true;
    erp_anass.closeModelErp()
  }

  addOrUpdate() {
    if (this.FormInputs.invalid) {
      this.showAlert = true;
      return;
    }

    const work: Works = {
      workstID: this.UpdateMode ? this.id : 0,
      worksName: this.FormInputs.value.worksName,
      departmentID: this.FormInputs.value.departmentID
    };

    if (this.UpdateMode) {
      this.EmployeeService.UpdateWorks(work, work.workstID).subscribe(
        () => {
          this.loadWorks();
          this.closeModelErp();
          this.showAlertSuccess = true;
        },
        error => {
          console.error('Error updating work', error);
          this.showAlert = true;
        }
      );
    } else {
      this.EmployeeService.AddWorks(work).subscribe(
        () => {
          this.loadWorks();
          this.closeModelErp();
          this.showAlertSuccess = true;
        },
        error => {
          console.error('Error adding work', error);
          this.showAlert = true;
        }
      );
    }
  }

  setDelete(WorkstID: number) {
    this.id = WorkstID
    erp_anass.closeModeleDelete();
  }
  Delete() {
    this.EmployeeService.DeleteWorks(this.id).subscribe(
      () => {
        this.loadWorks();
        this.closeModel()
      },
      error => {
        this.closeModel()
        setTimeout(() => {

          alert("Can't delete this Works because there are models linked with this Works")
          alert("If you want to delete this Works, you should to delete all models linked with this Works")
        }, 1000);
      }
    );
  }
  closeModel() {
    this.id = 0
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
