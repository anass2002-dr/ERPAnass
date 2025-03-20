import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Familly } from 'src/app/models/Familly/Familly';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { erp_anass } from 'src/main';
@Component({
  selector: 'app-add-family',
  templateUrl: './add-family.component.html',
  styleUrls: ['./add-family.component.css']
})
export class AddFamilyComponent implements OnInit {
  @Input() familly?: Familly;
  familyForm: FormGroup;
  showAlert: boolean = false;
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: any[] = [];
  ref: string = "";
  constructor(private fb: FormBuilder, private route: ActivatedRoute, private router: Router, private famillyService: FamilyService) {
    this.familyForm = this.fb.group({
      familyRef: ['', Validators.required],
      familyName: ['', Validators.required],
      familyDesc: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;
        this.famillyService.GetFamillyById(parseInt(this.id)).subscribe(familly => {
          this.familly = familly;
          console.log(this.familly);
          this.familyForm.patchValue(familly);
        });
      }
    });
  }

  onSubmit() {
    // if (this.familyForm.valid) {

    //   const family: Familly = { ...this.familly, ...this.familyForm.value }
    //   console.log('Form Submitted!', this.familyForm.value);
    //   this.showAlert = false; // Hide the alert if the form is valid
    // } else {
    //   console.log('Form not valid');
    //   this.showAlert = true; // Show the alert if the form is not valid
    // }

    if (this.familyForm.valid) {

      const family: Familly = { ...this.familly, ...this.familyForm.value }
      console.log('vv');

      if (this.isUpdateMode) {

        this.famillyService.UpdateFamilly(family).subscribe(response => {

          console.log('family updated successfully', response);
          this.router.navigate(['Article/list-family']); // Navigate back to the article list
        }, error => {
          console.error('Error updating family', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        this.famillyService.createFamily(family).subscribe(response => {

          console.log('Family created successfully', response);
          this.router.navigate(['Article/list-family']); // Navigate back to the article list
        }, error => {
          console.error('Error creating Family', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      }
    } else {
      console.log('Form not valid');
      this.showAlert = true; // Show the alert if the form is not valid
    }
  }
  generateRef() {
    const dt = new Date();

    const year = dt.getFullYear();
    const month = (dt.getMonth() + 1).toString().padStart(2, '0');
    const day = dt.getDate().toString().padStart(2, '0');
    const hours = dt.getHours().toString().padStart(2, '0');
    const minutes = dt.getMinutes().toString().padStart(2, '0');
    const seconds = dt.getSeconds().toString().padStart(2, '0');

    // Concatenate the parts
    const result = `${year}${month}${day}${hours}${minutes}${seconds}`;

    // Assign to `this.ref`
    let random1 = Math.floor(Math.random() * (99 - 10)) + 10;
    let random2 = Math.floor(Math.random() * (999 - 100)) + 100;
    this.ref = 'FM' + result + '' + random1
    this.familyForm.get('familyRef')?.setValue(this.ref);
    console.log(result);
  }
  onReset() {
    this.familyForm.reset();
    this.showAlert = false; // Hide the alert on form reset
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
