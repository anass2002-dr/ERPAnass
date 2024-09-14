import { Component, ElementRef, NgModule } from '@angular/core';
import { Router } from '@angular/router';
import * as arb from 'src/assets/js/Translate/ar.json'
import { TranslationService } from './Services/translation.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  ar: any = arb

  title = 'admindashboard';
  constructor(private elementRef: ElementRef, public _router: Router, private translationService: TranslationService) { }

  ngOnInit() {
    var s = document.createElement("script");
    s.type = "text/javascript";
    s.src = "../assets/js/main.js";
    this.elementRef.nativeElement.appendChild(s);
    this.translationService.translatePage();
  }
  hide() {

  }
}
