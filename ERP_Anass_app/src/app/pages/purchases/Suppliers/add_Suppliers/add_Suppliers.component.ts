import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
  selector: 'app-add_Suppliers',
  templateUrl: './add_Suppliers.component.html',
  styleUrls: ['./add_Suppliers.component.css']
})
export class Add_SuppliersComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

  }

}
