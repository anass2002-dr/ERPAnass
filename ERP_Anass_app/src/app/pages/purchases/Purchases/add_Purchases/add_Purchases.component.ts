import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-add_Purchases',
  templateUrl: './add_Purchases.component.html',
  styleUrls: ['./add_Purchases.component.css']
})
export class Add_PurchasesComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }

}
