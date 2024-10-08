import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { data } from 'jquery';
import { Department } from 'src/app/models/Employee/Department';
import { Works } from 'src/app/models/Employee/Works';
import { City } from 'src/app/models/Info/City';
import { CityDetails } from 'src/app/models/Info/CityDetails';
import { Country } from 'src/app/models/Info/Country';
import { EmployeeService } from 'src/app/Services/Employee/Employee.service';
import { InfoServiceService } from 'src/app/Services/Info/InfoService.service';
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
  listCountry: Country[];
  listCity: City[];
  loading: boolean = false
  // Example departments, replace with actual data

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private EmployeeService: EmployeeService,
    private InfoService: InfoServiceService
  ) {
    this.FormInputs = this.fb.group({
      employeeID: ['0'],  // Auto-generated
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
      countryId: ['', Validators.required],
      startDate: ['', Validators.required],
      salary: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    // Set breadcrumbs and check if it's update mode
    this.loadDepartments()
    this.loadWorks();
    this.loadCountry();
    this.loadCity(0);
    this.loading = false
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
  changeSelect(DepartmentID: Number) {
    this.loading = true
    console.log(DepartmentID);
    this.EmployeeService.GetWorksDetailsByDepartment(DepartmentID).subscribe(
      data => {
        this.WorksList = data;

        this.loading = false
      },
      error => {
        console.error('Error fetching departments', error);
      }
    );
  }
  loadCountry() {
    this.loading = true

    this.InfoService.GetAllCountries().subscribe(
      data => {
        this.listCountry = data;
        this.loading = false
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );

  }
  loadCity(id: Number) {
    this.loading = true
    console.log(id);

    if (id != 0) {
      this.InfoService.GetCitysDetailsByCountry(id).subscribe(
        data => {
          this.listCity = data;
          this.loading = false
        },
        error => {
          console.error('Error fetching data', error);
          this.loading = false;
        }
      );
    }
    else {
      this.InfoService.GetCitysDetails().subscribe(
        data => {
          this.listCity = data;
          this.loading = false
        },
        error => {
          console.error('Error fetching data', error);
          this.loading = false;
        }
      );
    }
    console.log(this.listCity);


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
    newEmployee.createdAt = new Date();
    newEmployee.updatedAt = new Date();

    console.log(newEmployee);
    this.EmployeeService.AddEmployee(newEmployee).subscribe(
      data => {
        console.log(data);

      },
      error => {
        console.log('error there sending data : ' + error);

      }
    )
  }

  // Logic for updating an existing employee
  updateEmployee() {
    const updatedEmployee = this.FormInputs.value;
    updatedEmployee.updatedAt = new Date();  // Update the timestamp

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
