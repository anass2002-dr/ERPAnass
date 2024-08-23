import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-list_PurchaseDetails',
  templateUrl: './list_PurchaseDetails.component.html',
  styleUrls: ['./list_PurchaseDetails.component.css']
})
export class List_PurchaseDetailsComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }

}
