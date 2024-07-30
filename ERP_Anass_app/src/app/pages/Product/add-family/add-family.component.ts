import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
@Component({
  selector: 'app-add-family',
  templateUrl: './add-family.component.html',
  styleUrls: ['./add-family.component.css']
})
export class AddFamilyComponent implements OnInit {

  familyForm: FormGroup;
  showAlert: boolean = false;

  constructor(private fb: FormBuilder) {
    this.familyForm = this.fb.group({
      familyRef: ['', Validators.required],
      familyName: ['', Validators.required],
      familyDesc: ['', Validators.required]
    });
  }

  ngOnInit(): void { }

  onSubmit() {
    if (this.familyForm.valid) {
      console.log('Form Submitted!', this.familyForm.value);
      this.showAlert = false; // Hide the alert if the form is valid
    } else {
      console.log('Form not valid');
      this.showAlert = true; // Show the alert if the form is not valid
    }
  }

  onReset() {
    this.familyForm.reset();
    this.showAlert = false; // Hide the alert on form reset
  }

}
