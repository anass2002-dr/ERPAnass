import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { each } from 'jquery';
import { Modules } from 'src/app/models/User/Modules';
import { User } from 'src/app/models/User/User';
import { UserPer } from 'src/app/models/User/UsersPermission';
import { UserServiceService } from 'src/app/Services/Users/UserService.service';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-add-permissions',
    templateUrl: './add-permissions.component.html',
    styleUrls: ['./add-permissions.component.css'],
    standalone: false
})
export class AddPermissionsComponent implements OnInit {

  @Input() userInput?: User;
  userPer?: UserPer;
  FormInputs: FormGroup;
  isUpdateMode: boolean = false;
  id: string = "";
  showAlert: boolean = false;
  showAlertSuccess: boolean = false;
  breadcrumbs: string[] = [];
  loading: boolean = false;
  listUser: User[];
  listModule: Modules[];
  disabledUser: boolean = true
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
      userId: [{ value: '', disabled: this.isUpdateMode }, Validators.required],
      idModule: ['', Validators.required],

      add: [false],
      edit: [false],
      delete: [false],
    });
  }

  ngOnInit(): void {
    this.loadUsers();

    // Set breadcrumbs and check if it's update mode
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.loading = true;
        this.isUpdateMode = true;

        // Update form control 'userId' to be disabled if in update mode
        this.userService.getPermissionById(this.id).subscribe(userPer => {
          this.userPer = userPer;
          this.FormInputs.patchValue(userPer);
          this.loading = false;

          // Disable the userId field if we're in update mode
          this.FormInputs.get('userId')?.disable();
        });

      } else {
        this.loading = false;

        this.isUpdateMode = false;
      }
    });

    this.breadcrumbs = erp_anass.title_header(this.route);
  }

  onSubmit() {
    if (this.FormInputs.invalid) {
      this.showAlert = true;

      return;
    }
    const Permission: UserPer = this.FormInputs.getRawValue();
    if (this.isUpdateMode) {
      console.log(Permission);
      this.userService.updatePermission(Permission, this.id).subscribe(response => {

        console.log('Permission updated successfully', response);

        this.showAlertSuccess = true;
        setTimeout(() => {
          this.router.navigate(['../Users-Management/Permission']);
        }, 1000);
      }, error => {
        alert('this user are already have permssion for this module');

        this.showAlert = true; // Show the alert if there was an error
      });
    } else {
      console.log(Permission);
      this.userService.createPermission(Permission).subscribe(response => {

        console.log('Permission created successfully', response);

        this.showAlertSuccess = true
        setTimeout(() => {
          this.router.navigate(['../Users-Management/Permission']);
        }, 1000);
        // Navigate back to the user list
      }, error => {
        alert('this user are already have permssion for this module');
        this.showAlert = true; // Show the alert if there was an error
      });
    }
  }
  loadUsers() {
    this.loading = true;
    this.userService.GetDataUser().subscribe(
      data => {
        this.listUser = data;
        console.log(this.listUser);
      },
      error => {
        console.error('Error fetching data', error);
      }
    );
    this.userService.GetDataModule().subscribe(
      data => {
        this.listModule = data;
        this.loading = false;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }

    );

  }
  formatBreadcrumb(breadcrumb: string): string {


    return breadcrumb.replace('-', ' ');
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }

}
