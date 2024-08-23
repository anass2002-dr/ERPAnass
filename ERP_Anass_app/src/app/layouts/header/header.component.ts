import { Component, OnInit, Inject, ChangeDetectorRef } from '@angular/core';
import { DOCUMENT } from '@angular/common'
import { erp_anass } from 'src/main';
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
    // this.document.body.classList.toggle('toggle-sidebar');
    this.document.querySelectorAll('.nav-item span').forEach((e) => {
      e.classList.toggle('toggle-sidebar_text')
    })
    this.document.querySelectorAll('.nav-item ul').forEach((e) => {
      if (e.classList.contains('show'))
        e.classList.remove('show')
    })

    this.document.querySelectorAll('.bi-chevron-down').forEach((e) => {
      e.classList.toggle('toggle-sidebar_text')
    })
    this.document.querySelector('.sidebar')?.classList.toggle('toggle-sidebar2')

    this.document.querySelector('.prf')?.classList.toggle('d-md-block')
    this.document.querySelector('.prf')?.classList.toggle('d-none')
    this.document.querySelector('.main')?.classList.toggle('main_toggele')

  }
  onSelected(value: string): void {
    erp_anass.idDossier = value;
    this.route.params.subscribe();
  }
}
