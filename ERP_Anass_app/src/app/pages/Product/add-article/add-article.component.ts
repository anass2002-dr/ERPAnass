import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Article } from 'src/app/models/Article/Article';
import { Familly } from 'src/app/models/Familly/Familly';
import { ProductService } from 'src/app/Services/Articles/product.service';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { ActivatedRoute, Router } from '@angular/router';

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

  constructor(
    private fb: FormBuilder,
    private productService: ProductService,
    private FamillyService: FamilyService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.articleForm = this.fb.group({
      ArticleRef: ['', [Validators.required, Validators.pattern('^[A-Za-z0-9]{3,10}$')]], // Alphanumeric, 3-10 characters
      ArticleName: ['', Validators.required],
      FamilyID: ['', Validators.required],
      DescriptionArticle: ['', Validators.required],
      PurchasePrice: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]], // Decimal number
      SellingPrice: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]],  // Decimal number
      StockQuantity: ['', [Validators.required, Validators.pattern('^[0-9]*\\.?[0-9]+$')]]  // Decimal number
    });
  }

  ngOnInit(): void {
    this.FamillyService.GetDataFamily().subscribe(data => {
      this.listFamilly = data;
    });

    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.isUpdateMode = true;
      this.productService.getArticleById(+id).subscribe(article => {
        this.article = article;
        this.articleForm.patchValue(article);
      });
    }
  }

  onSubmit(): void {
    if (this.articleForm.valid) {
      const article: Article = { ...this.article, ...this.articleForm.value };

      if (this.isUpdateMode) {
        this.productService.updateArticle(article).subscribe(response => {
          console.log('Article updated successfully', response);
          this.router.navigate(['/articles']); // Navigate back to the article list
        }, error => {
          console.error('Error updating article', error);
          this.showAlert = true; // Show the alert if there was an error
        });
      } else {
        this.productService.createArticle(article).subscribe(response => {
          console.log('Article created successfully', response);
          this.router.navigate(['/articles']); // Navigate back to the article list
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
}
