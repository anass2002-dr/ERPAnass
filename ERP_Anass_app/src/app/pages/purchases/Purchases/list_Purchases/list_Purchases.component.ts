import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { each } from 'jquery';
import { filter } from 'rxjs';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-list_Purchases',
  templateUrl: './list_Purchases.component.html',
  styleUrls: ['./list_Purchases.component.css']
})
export class List_PurchasesComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }


}
