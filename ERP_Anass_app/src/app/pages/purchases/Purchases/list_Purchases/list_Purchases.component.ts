import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { each } from 'jquery';
import { filter } from 'rxjs';

@Component({
  selector: 'app-list_Purchases',
  templateUrl: './list_Purchases.component.html',
  styleUrls: ['./list_Purchases.component.css']
})
export class List_PurchasesComponent implements OnInit {

  breadcrumbs: any[] = [];
  lg_title: number = 0
  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.route.data.forEach(x => {
      this.breadcrumbs.push(x);
      console.log(x['breadcrumb'])
      this.lg_title = x['breadcrumb'].length
      console.log(this.breadcrumbs);

    }
    );

    // this.breadcrumbs = buildBreadcrumb(this.route);
    // console.log(this.route);
    // for (var x of this.route.snapshot.url) {
    //   console.log(x.path);

    // }

  }


}
const buildBreadcrumb = function (route: ActivatedRoute): any[] {
  const children: ActivatedRoute[] = route.children;
  console.log(children)
  var breadcrumbs: any[] = []
  var url = "";
  breadcrumbs.push('Home')
  for (var x of route.snapshot.url) {
    breadcrumbs.push(x.path)

  }

  return breadcrumbs;
}
