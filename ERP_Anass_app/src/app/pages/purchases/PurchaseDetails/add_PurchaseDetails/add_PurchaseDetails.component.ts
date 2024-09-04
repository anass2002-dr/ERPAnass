import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-add_PurchaseDetails',
  templateUrl: './add_PurchaseDetails.component.html',
  styleUrls: ['./add_PurchaseDetails.component.css']
})
export class Add_PurchaseDetailsComponent implements OnInit {

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
      purchaseRef: ['', Validators.required],
      Product: ['', Validators.required],
      Quantity: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      UnitPrice: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      Discount: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],
      TotalPrice: ['', Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')],
      TaxAmount: ['', Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')],

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
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }

}
