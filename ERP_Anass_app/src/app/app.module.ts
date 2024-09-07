import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './layouts/header/header.component';
import { FooterComponent } from './layouts/footer/footer.component';
import { SidebarComponent } from './layouts/sidebar/sidebar.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { AlertsComponent } from './components/alerts/alerts.component';
import { AccordionComponent } from './components/accordion/accordion.component';
import { BadgesComponent } from './components/badges/badges.component';
import { BreadcrumbsComponent } from './components/breadcrumbs/breadcrumbs.component';
import { ButtonsComponent } from './components/buttons/buttons.component';
import { CardsComponent } from './components/cards/cards.component';
import { CarouselComponent } from './components/carousel/carousel.component';
import { ListGroupComponent } from './components/list-group/list-group.component';
import { ModalComponent } from './components/modal/modal.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { PaginationComponent } from './components/pagination/pagination.component';
import { ProgressComponent } from './components/progress/progress.component';
import { SpinnersComponent } from './components/spinners/spinners.component';
import { TooltipsComponent } from './components/tooltips/tooltips.component';
import { FormsElementsComponent } from './components/forms-elements/forms-elements.component';
import { FormsLayoutsComponent } from './components/forms-layouts/forms-layouts.component';
import { FormsEditorsComponent } from './components/forms-editors/forms-editors.component';
import { TablesGeneralComponent } from './components/tables-general/tables-general.component';
import { TablesDataComponent } from './components/tables-data/tables-data.component';
import { ChartsChartjsComponent } from './components/charts-chartjs/charts-chartjs.component';
import { ChartsApexchartsComponent } from './components/charts-apexcharts/charts-apexcharts.component';
import { IconsBootstrapComponent } from './components/icons-bootstrap/icons-bootstrap.component';
import { IconsRemixComponent } from './components/icons-remix/icons-remix.component';
import { IconsBoxiconsComponent } from './components/icons-boxicons/icons-boxicons.component';
import { UsersProfileComponent } from './pages/users-profile/users-profile.component';
import { PagesFaqComponent } from './pages/pages-faq/pages-faq.component';
import { PagesContactComponent } from './pages/pages-contact/pages-contact.component';
import { PagesRegisterComponent } from './pages/pages-register/pages-register.component';
import { PagesError404Component } from './pages/pages-error404/pages-error404.component';
import { PagesBlankComponent } from './pages/pages-blank/pages-blank.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { MatTableModule } from '@angular/material/table'
import { MatPaginatorModule } from '@angular/material/paginator';
import { AddFamilyComponent } from './pages/Product/add-family/add-family.component';
import { ListFamilyComponent } from './pages/Product/list-family/list-family.component';
import { AddArticleComponent } from './pages/Product/add-article/add-article.component';
import { ListArticleComponent } from './pages/Product/list-article/list-article.component';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort, Sort } from '@angular/material/sort';
import { MatSortModule } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { MatSpinner } from '@angular/material/progress-spinner';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { List_PurchasesComponent } from './pages/purchases/Purchases/list_Purchases/list_Purchases.component';
import { List_PurchaseDetailsComponent } from './pages/purchases/PurchaseDetails/list_PurchaseDetails/list_PurchaseDetails.component';
import { List_SuppliersComponent } from './pages/purchases/Suppliers/list_Suppliers/list_Suppliers.component';
import { Add_PurchasesComponent } from './pages/purchases/Purchases/add_Purchases/add_Purchases.component';
import { Add_PurchaseDetailsComponent } from './pages/purchases/PurchaseDetails/add_PurchaseDetails/add_PurchaseDetails.component';
import { Add_SuppliersComponent } from './pages/purchases/Suppliers/add_Suppliers/add_Suppliers.component';
import { MatGridListModule } from '@angular/material/grid-list';
import { ListSalesComponent } from './pages/Sales/list-sales/list-sales/list-sales.component';
import { Add_salesComponent } from './pages/Sales/list-sales/add_sales/add_sales.component';
import { List_customersComponent } from './pages/Sales/Customers/list_customers/list_customers.component';
import { Add_customerComponent } from './pages/Sales/Customers/add_customer/add_customer.component';
import { List_countryComponent } from './pages/Info/Country/list_country/list_country.component';
import { List_cityComponent } from './pages/Info/City/list_city/list_city.component';
import { List_WarehousesComponent } from './pages/Info/Warehouses/list_Warehouses/list_Warehouses.component';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogActions, MatDialogClose, MatDialogContent, MatDialogTitle } from '@angular/material/dialog';
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    SidebarComponent,
    DashboardComponent,
    AlertsComponent,
    AccordionComponent,
    BadgesComponent,
    BreadcrumbsComponent,
    ButtonsComponent,
    CardsComponent,
    CarouselComponent,
    ListGroupComponent,
    ModalComponent,
    TabsComponent,
    PaginationComponent,
    ProgressComponent,
    SpinnersComponent,
    TooltipsComponent,
    FormsElementsComponent,
    FormsLayoutsComponent,
    FormsEditorsComponent,
    TablesGeneralComponent,
    TablesDataComponent,
    ChartsChartjsComponent,
    ChartsApexchartsComponent,
    IconsBootstrapComponent,
    IconsRemixComponent,
    IconsBoxiconsComponent,
    UsersProfileComponent,
    PagesFaqComponent,
    PagesContactComponent,
    PagesError404Component,
    PagesBlankComponent,
    AddFamilyComponent,
    AddArticleComponent,
    ListArticleComponent,
    ListFamilyComponent,
    List_PurchasesComponent,
    List_PurchaseDetailsComponent,
    List_SuppliersComponent,
    Add_PurchasesComponent,
    Add_PurchaseDetailsComponent,
    Add_SuppliersComponent,
    ListSalesComponent,
    Add_salesComponent,
    List_customersComponent,
    Add_customerComponent,
    List_countryComponent,
    List_cityComponent,
    List_WarehousesComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatSliderModule,
    MatTableModule,
    MatPaginatorModule,
    RouterModule,
    CommonModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatFormFieldModule,
    MatInputModule,
    HttpClientModule,
    MatProgressSpinnerModule,
    MatGridListModule,
    MatButtonModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
