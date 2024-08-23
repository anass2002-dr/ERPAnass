import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-add_PurchaseDetails',
  templateUrl: './add_PurchaseDetails.component.html',
  styleUrls: ['./add_PurchaseDetails.component.css']
})
export class Add_PurchaseDetailsComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }

}
