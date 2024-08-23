import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-list_Suppliers',
  templateUrl: './list_Suppliers.component.html',
  styleUrls: ['./list_Suppliers.component.css']
})
export class List_SuppliersComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }

}
