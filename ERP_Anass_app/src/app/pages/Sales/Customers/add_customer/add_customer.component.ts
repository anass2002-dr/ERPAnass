import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
@Component({
  selector: 'app-add_customer',
  templateUrl: './add_customer.component.html',
  styleUrls: ['./add_customer.component.css']
})
export class Add_customerComponent implements OnInit {

  @Input() article?: Article;
  FormInputs: FormGroup;
  showAlert: boolean = false;
  listFamilly?: Familly[];
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: any[] = [];

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.FormInputs = this.fb.group({
      CustomerID: ['', [Validators.required, Validators.pattern('^[0-9]+$')]],  // Assuming the CustomerID is an integer
      CustomerName: ['', [Validators.required, Validators.maxLength(100)]],
      ContactPerson: ['', [Validators.maxLength(100)]],
      Phone: ['', [Validators.pattern('^[0-9-+() ]+$'), Validators.maxLength(20)]],  // Regex pattern to match phone numbers
      Email: ['', [Validators.email, Validators.maxLength(100)]],
      Address: ['', [Validators.maxLength(255)]],
      Country: ['', [Validators.maxLength(50)]],
      CreatedAt: ['', Validators.required],  // Assuming CreatedAt is set automatically, it may be non-editable
      UpdatedAt: ['', Validators.required],  // Same for UpdatedAt
    });

  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;

      }
    });

  }

  onSubmit(): void {
    if (this.FormInputs.valid) {
      console.log(this.FormInputs);


    } else {
      console.log('Form not valid');
      this.showAlert = true; // Show the alert if the form is not valid
    }
  }

}
