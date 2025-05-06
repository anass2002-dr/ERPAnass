import { LiveAnnouncer } from '@angular/cdk/a11y';
import { Component, OnInit, AfterViewInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { CommonModule } from '@angular/common';
import { FamilyService } from 'src/app/Services/Family/Family.service';
import { Familly } from 'src/app/models/Familly/Familly';
import { ActivatedRoute, Router } from '@angular/router';
import { erp_anass } from 'src/main';

@Component({
    selector: 'app-list-family',
    templateUrl: './list-family.component.html',
    styleUrls: ['./list-family.component.css'],
    standalone: false
})
export class ListFamilyComponent implements OnInit, AfterViewInit {
  displayedColumns: string[] = ['idFamilly', 'familyRef', 'familyName', 'familyDesc', 'actions'];
  dataSource = new MatTableDataSource();
  list: Familly[] = [];
  breadcrumbs: any[] = [];
  idDelete: number = 0
  idFamily: Number = 0
  loading: boolean = true;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(private _liveAnnouncer: LiveAnnouncer, private FamilyService: FamilyService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.breadcrumbs = erp_anass.title_header(this.route)

    this.FamilyService.GetDataFamily().subscribe(
      data => {
        console.log(data);
        this.list = data;
        this.dataSource.data = this.list;
        this.loading = false;
      },
      error => {
        console.error('Error fetching data', error);
        this.loading = false;
      }
    );
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  announceSortChange(sortState: Sort) {
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }


  
  Delete(id: Number) {
    this.idFamily = id
    this.closeModelErp()
  }
  
  edit(id: number) {
    this.router.navigate(['/Article/add-family/', id]);
  }
  closeModelErp() {
    erp_anass.closeModelErp()
  }
  formatRef(ref:string){
    const result= ref.slice(0,15).toString()+'...'
    
    return result
  }
  DeleteFamily() {

    this.FamilyService.deleteFamily(this.idFamily).subscribe(
      () => {
        this.list = this.list.filter(a => a.idFamilly !== this.idFamily);
        this.dataSource.data = this.list;
        this.closeModelErp()
        // console.log('Family deleted successfully');
      },
      error => {
        console.error('Error deleting Family', error);
      }
    );

  }
  formatBreadcrumb(breadcrumb: string): string {
    return erp_anass.formatBreadcrumb(breadcrumb)
  }
  formatBreadcrumbLink(breadcrumb: string, list: any[]): string {

    return erp_anass.formatBreadcrumbLink(breadcrumb, list)
  }
}

