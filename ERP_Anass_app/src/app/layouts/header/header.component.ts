import { Component, OnInit, Inject, ChangeDetectorRef } from '@angular/core';
import { DOCUMENT } from '@angular/common'
import { ittone } from 'src/main';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  public dossiers: Record<string, any>[] = []
  public user: Record<string, any> | undefined
  constructor(@Inject(DOCUMENT) private document: Document, private route: ActivatedRoute, private router: Router) { }
  ngOnInit(): void {
    // this.route.params.subscribe(params => {
    //   var user = ittone.getSession()
    //   this.dossiers = [];
    //   ittone.getData("SDossiers/GetDossiers", { idGroup: user?.['idGroup'] })
    //     .then((data) => {
    //       this.dossiers = data
    //       ittone.idDossier = data[0].idDossier
    //     })
    //     .catch(error => ittone.error('Error fetching data:' + error));
    // });
  }
  sidebarToggle() {
    this.document.body.classList.toggle('toggle-sidebar');
  }
  onSelected(value: string): void {
    ittone.idDossier = value;
    this.route.params.subscribe();
  }
}
