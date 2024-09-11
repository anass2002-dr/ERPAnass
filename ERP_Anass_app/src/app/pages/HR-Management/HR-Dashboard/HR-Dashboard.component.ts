import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';
import * as menuData from './menu.json';
@Component({
  selector: 'app-HR-Dashboard',
  templateUrl: './HR-Dashboard.component.html',
  styleUrls: ['./HR-Dashboard.component.css']
})
export class HRDashboardComponent implements OnInit {

  breadcrumbs: any[] = [];
  constructor(private route: ActivatedRoute) { }
  data: any = menuData
  RouterName: string = ""
  menu: any
  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route);
    this.RouterName = this.breadcrumbs[this.breadcrumbs.length - 1]
    this.menu = this.data['dt'][0][this.RouterName]

  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb);
  }

}
