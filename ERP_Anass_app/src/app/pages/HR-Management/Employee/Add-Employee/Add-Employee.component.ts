import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
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
  departmentList: { id: number, name: string }[] = [
    { id: 1, name: 'HR' },
    { id: 2, name: 'Engineering' },
    { id: 3, name: 'Marketing' },
  ];  // Example departments, replace with actual data

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.FormInputs = this.fb.group({
      EmployeeID: [''],
      FirstName: ['', Validators.required],
      LastName: ['', Validators.required],
      DateOfBirth: ['', Validators.required],
      Email: ['', [Validators.required, Validators.email]],
      Phone: ['', [Validators.required, Validators.pattern('^[0-9-+() ]+$')]],
      Address: [''],
      JobTitle: [''],
      DepartmentID: ['', Validators.required],
      StartDate: [''],
      Salary: [''],
      CreatedAt: ['', Validators.required],
      UpdatedAt: ['', Validators.required],
    });
  }

  ngOnInit(): void {
    // Set breadcrumbs and check if it's update mode
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;
        // Logic to populate the form with existing employee data based on ID
      }
    });

    // Update breadcrumbs
    this.breadcrumbs = this.router.url.split('/');
  }

  onSubmit() {
    if (this.FormInputs.invalid) {
      this.showAlert = true;
      return;
    }

    if (this.isUpdateMode) {
      // Logic for updating an employee
    } else {
      // Logic for creating a new employee
    }
  }

  formatBreadcrumb(breadcrumb: string): string {
    return breadcrumb.replace('-', ' ');
  } nInit() {
  }

}
