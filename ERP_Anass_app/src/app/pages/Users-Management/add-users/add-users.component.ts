import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from 'src/app/models/User/User';
import { UserServiceService } from 'src/app/Services/Users/UserService.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-users',
    templateUrl: './add-users.component.html',
    styleUrls: ['./add-users.component.css'],
    standalone: false
})
export class AddUsersComponent implements OnInit {
  @Input() userInput?: User;
  user?: User;
  FormInputs: FormGroup;
  isUpdateMode: boolean = false;
  id: string = "";
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  breadcrumbs: string[] = [];
  loading: boolean = false;
  roleList: { name: string }[] = [
    { name: 'Admin' },
    { name: 'User' },
    { name: 'Manager' },
  ];

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private userService: UserServiceService
  ) {
    this.FormInputs = this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.pattern(/(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*#?&^_-]).{8,}/)]],
      role: ['', Validators.required],
      status: ['', Validators.required],
      createdAt: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    // Set breadcrumbs and check if it's update mode
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.loading = true
        this.isUpdateMode = true;
        this.userService.getUserById(this.id).subscribe(user => {
          this.user = user;
          console.log(this.user);
          this.FormInputs.patchValue(user);
          this.loading = false
        });
        console.log(this.id);

        // Logic to populate the form with existing user data based on ID
      }
    });


    this.breadcrumbs = erp_anass.title_header(this.route);

  }

  onSubmit() {
    if (this.FormInputs.invalid) {
      this.showAlert = true;

      return;
    }
    const user: User = this.FormInputs.value;
    if (this.isUpdateMode) {
      console.log(user);


      this.userService.updateUser(user, this.id).subscribe(response => {

        console.log('user updated successfully', response);

        this.showAlertSuccess = true;
        setTimeout(() => {
          this.router.navigate(['../Users-Management/List-Users']);
        }, 1000);
      }, error => {
        console.error('Error updating user', error);
        this.showAlert = true; // Show the alert if there was an error
      });
    } else {
      console.log(user);
      this.userService.createUser(user).subscribe(response => {

        console.log('user created successfully', response);

        this.showAlertSuccess = true
        setTimeout(() => {
          this.router.navigate(['../Users-Management/List-Users']);
        }, 1000);
        // Navigate back to the user list
      }, error => {
        console.error('Error creating user', error);
        this.showAlert = true; // Show the alert if there was an error
      });
    }
  }

  formatBreadcrumb(breadcrumb: string): string {
    console.log(breadcrumb);

    return breadcrumb.replace('-', ' ');
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }

}
