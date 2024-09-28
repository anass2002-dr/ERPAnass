import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Department } from 'src/app/models/Employee/Department';
import { Works } from 'src/app/models/Employee/Works';
import { EmployeeService } from 'src/app/Services/Employee/Employee.service';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-Add-Employee',
  templateUrl: './Add-Employee.component.html',
  styleUrls: ['./Add-Employee.component.css']
})
export class AddEmployeeComponent implements OnInit {
  FormInputs: FormGroup;
  showAlert: boolean = false;
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: string[] = [];
  departmentList: Department[];
  WorksList: Works[];
  // Example departments, replace with actual data

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private EmployeeService: EmployeeService
  ) {
    this.FormInputs = this.fb.group({
      employeeID: [''],  // Auto-generated
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      dateOfBirth: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      phone: ['', [Validators.required, Validators.pattern('^[0-9-+() ]+$')]],
      address: [''],
      jobTitle: ['', Validators.required],
      departmentID: ['', Validators.required],
      worksID: ['', Validators.required],
      cityID: ['', Validators.required],
      countryID: ['', Validators.required],
      startDate: ['', Validators.required],
      salary: ['', Validators.required],
      createdAt: [''],  // Auto-handled on the backend
      updatedAt: [''],  // Auto-handled on the backend
    });
  }

  ngOnInit(): void {
    // Set breadcrumbs and check if it's update mode
    this.loadDepartments()
    this.loadWorks();
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;
        // Logic to populate the form with existing employee data based on ID
        this.loadEmployeeData(this.id);
      }
    });

    this.breadcrumbs = erp_anass.title_header(this.route);
  }
  loadDepartments() {
    this.EmployeeService.GetDepartments().subscribe(
      data => {
        this.departmentList = data;
        console.log(data);

      },
      error => {
        console.error('Error fetching departments', error);
      }
    );
  }
  loadWorks() {
    this.EmployeeService.GetWorks().subscribe(
      data => {
        this.WorksList = data;
        console.log(data);

      },
      error => {
        console.error('Error fetching departments', error);
      }
    );
  }
  // Load existing employee data in case of update
  loadEmployeeData(employeeId: string) {
    // Logic to fetch the employee data using employeeId
    // Example:
    // this.employeeService.getEmployeeById(employeeId).subscribe(employee => {
    //   this.FormInputs.patchValue(employee);
    // });
  }

  onSubmit() {
    if (this.FormInputs.invalid) {
      this.showAlert = true;
      return;
    }

    if (this.isUpdateMode) {
      this.updateEmployee();
    } else {
      this.createEmployee();
    }
  }

  // Logic for creating a new employee
  createEmployee() {
    const newEmployee = this.FormInputs.value;
    newEmployee.CreatedAt = new Date();
    newEmployee.UpdatedAt = new Date();

    // Call the backend service to save the new employee
    // Example:
    // this.employeeService.createEmployee(newEmployee).subscribe(() => {
    //   this.router.navigate(['/employees']);
    // });
  }

  // Logic for updating an existing employee
  updateEmployee() {
    const updatedEmployee = this.FormInputs.value;
    updatedEmployee.UpdatedAt = new Date();  // Update the timestamp

    // Call the backend service to update the employee
    // Example:
    // this.employeeService.updateEmployee(this.id, updatedEmployee).subscribe(() => {
    //   this.router.navigate(['/employees']);
    // });
  }

  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }

  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {
    return erp_anass.formatBreadcrumbLink(breadcrumb, list);
  }
}
