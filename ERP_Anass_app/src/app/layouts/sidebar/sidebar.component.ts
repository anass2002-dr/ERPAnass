import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  sidebar_mouse_event() {
    const sidebar = document.getElementsByClassName('sidebar')
    if (sidebar[0].classList.contains('toggle-sidebar2')) {
      const elements = document.getElementsByClassName('toggle-sidebar-btn');
      if (elements.length > 0) {
        (elements[0] as HTMLElement).click();
      }
    }

  }
}
