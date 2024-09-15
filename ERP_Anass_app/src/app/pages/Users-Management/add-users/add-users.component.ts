import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-add-users',
  templateUrl: './add-users.component.html',
  styleUrls: ['./add-users.component.css']
})
export class AddUsersComponent implements OnInit {

  FormInputs: FormGroup;
  showAlert: boolean = false;
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: string[] = [];
  roleList: { id: number, name: string }[] = [
    { id: 1, name: 'Admin' },
    { id: 2, name: 'User' },
    { id: 3, name: 'Manager' },
  ];

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.FormInputs = this.fb.group({
      UserID: [''],
      FirstName: ['', Validators.required],
      LastName: ['', Validators.required],
      Email: ['', [Validators.required, Validators.email]],
      Password: ['', Validators.required],
      RoleID: ['', Validators.required],
      Status: ['', Validators.required],
      CreatedAt: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    // Set breadcrumbs and check if it's update mode
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;
        // Logic to populate the form with existing user data based on ID
      }
    });

    // Logic for setting breadcrumbs, can be customized
    this.breadcrumbs = this.setBreadcrumbs(this.route);
  }

  onSubmit() {
    if (this.FormInputs.invalid) {
      this.showAlert = true;

      return;
    }

    if (this.isUpdateMode) {
      // Logic for updating a user
    } else {
      // Logic for creating a new user
    }
  }

  setBreadcrumbs(route: ActivatedRoute): string[] {
    // Define breadcrumb logic here
    return ['Users', this.isUpdateMode ? 'Update User' : 'Add User'];
  }

}
