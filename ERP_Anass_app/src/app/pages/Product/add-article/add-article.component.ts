import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-add-article',
  templateUrl: './add-article.component.html',
  styleUrls: ['./add-article.component.css']
})
export class AddArticleComponent implements OnInit {
  @Input() article?: Article;
  articleForm: FormGroup;
  showAlert: boolean = false;
  listFamilly?: Familly[];
  isUpdateMode: boolean = false;
  id: string = "";
  breadcrumbs: any[] = [];
  ref: string = "";
  constructor(
    private fb: FormBuilder,
    private productService: ProductService,
    private FamillyService: FamilyService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.articleForm = this.fb.group({
      articleRef: ['', Validators.required], // Alphanumeric, 3-10 characters
      articleName: ['', Validators.required],
      familyID: ['', Validators.required],
      descriptionArticle: [''],
      purchasePrice: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]], // Decimal number
      sellingPrice: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],  // Decimal number
      stockQuantity: [0]  // Decimal number
    });
  }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)
    this.FamillyService.GetDataFamily().subscribe(data => {
      this.listFamilly = data;
    });
    this.route.paramMap.subscribe(params => {
      this.id = params.get('id') || "";
      if (this.id) {
        this.isUpdateMode = true;
        this.productService.getArticleById(parseInt(this.id)).subscribe(article => {
          this.article = article;
          console.log(this.article);
          this.articleForm.patchValue(article);
        });
      }
    });

  }

  onSubmit(): void {
    console.log(this.articleForm);

    if (this.articleForm.valid) {
      const article: Article = { ...this.article, ...this.articleForm.value };

      if (this.isUpdateMode) {
        console.log(article);

        this.productService.updateArticle(article).subscribe(response => {

          console.log('Article updated successfully', response);
          this.router.navigate(['Article/list-article']); // Navigate back to the article list
        }, error => {
          console.error('Error updating article', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        console.log(article);
        this.productService.createArticle(article).subscribe(response => {

          console.log('Article created successfully', response);
          this.router.navigate(['Article/list-article']); // Navigate back to the article list
        }, error => {
          console.error('Error creating article', error);
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
    this.ref = 'AR-' + random1 + '-' + result + '-' + random2;
    this.articleForm.get('articleRef').setValue(this.ref);
    console.log(result);
  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}
