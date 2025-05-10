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
import { PagesError404Component } from './pages/pages-error404/pages-error404.component';
import { PagesBlankComponent } from './pages/pages-blank/pages-blank.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { MatTable, MatTableModule } from '@angular/material/table'
import { MatTab, MatTabGroup} from '@angular/material/tabs'
import { MatDividerModule  } from '@angular/material/divider'
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatMenuModule } from '@angular/material/menu';  
import { AddFamilyComponent } from './pages/Product/add-family/add-family.component';
import { ListFamilyComponent } from './pages/Product/list-family/list-family.component';
import { AddArticleComponent } from './pages/Product/add-article/add-article.component';
import { ListArticleComponent } from './pages/Product/list-article/list-article.component';
import { MatSortModule } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { CommonModule } from '@angular/common';
import { provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
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
import { List_CustomersComponent } from './pages/Sales/Customers/list_customers/List_Customers.component';
import { Add_CustomerComponent } from './pages/Sales/Customers/add_customer/Add_Customer.component';
import { List_countryComponent } from './pages/Info/Country/list_country/list_country.component';
import { List_cityComponent } from './pages/Info/City/list_city/list_city.component';
import { List_WarehousesComponent } from './pages/Inventory/Warehouses/list_Warehouses/list_Warehouses.component';
import { MatButtonModule } from '@angular/material/button';
import { WarehousesMovementComponent } from './pages/Inventory/Mouvement/WarehousesMovement/WarehousesMovement.component';
import { AddMouvementComponent } from './pages/Inventory/Mouvement/AddMouvement/AddMouvement.component';
import { AddEmployeeComponent } from './pages/HR-Management/Employee/Add-Employee/Add-Employee.component';
import { ListDepartementComponent } from './pages/HR-Management/Employee/List-Departement/List-Departement.component';
import { ListEmployeeComponent } from './pages/HR-Management/Employee/List-Employee/List-Employee.component';
import { ProfileEmployeeComponent } from './pages/HR-Management/Employee/Profile-Employee/Profile-Employee.component';
import { AddLeaveComponent } from './pages/HR-Management/Leave-management/Add-Leave/Add-Leave.component';
import { ListLeaveComponent } from './pages/HR-Management/Leave-management/List-Leave/List-Leave.component';
import { LeaveReportComponent } from './pages/HR-Management/Leave-management/Leave-Report/Leave-Report.component';
import { AddPayrollComponent } from './pages/HR-Management/Payroll-management/Add-Payroll/Add-Payroll.component';
import { ListPayrollComponent } from './pages/HR-Management/Payroll-management/List-Payroll/List-Payroll.component';
import { AddPerformanceReviewComponent } from './pages/HR-Management/Performance-management/Add-PerformanceReview/Add-PerformanceReview.component';
import { Goal_ObjectivesComponent } from './pages/HR-Management/Performance-management/Goal_Objectives/Goal_Objectives.component';
import { PerformanceReviewListComponent } from './pages/HR-Management/Performance-management/PerformanceReview-List/PerformanceReview-List.component';
import { Add_ApplicantComponent } from './pages/HR-Management/Recruitment/Add_Applicant/Add_Applicant.component';
import { List_ApplicantComponent } from './pages/HR-Management/Recruitment/List_Applicant/List_Applicant.component';
import { List_Job_PostingComponent } from './pages/HR-Management/Recruitment/List_Job_Posting/List_Job_Posting.component';
import { Add_Job_PostingComponent } from './pages/HR-Management/Recruitment/Add_Job_Posting/Add_Job_Posting.component';
import { Add_TrainingComponent } from './pages/HR-Management/Training-Development/Add_Training/Add_Training.component';
import { List_Training_ProgramsComponent } from './pages/HR-Management/Training-Development/List_Training_Programs/List_Training_Programs.component';
import { HRDashboardComponent } from './pages/HR-Management/HR-Dashboard/HR-Dashboard.component';
import { ListAttendanceComponent } from './pages/HR-Management/Attendance-management/List-Attendance/List-Attendance.component';
import { AddAttendanceComponent } from './pages/HR-Management/Attendance-management/add-Attendance/add-Attendance.component';
import { ReportAttendanceComponent } from './pages/HR-Management/Attendance-management/Report-Attendance/Report-Attendance.component';
import { ListEmployeeDetailsComponent } from './pages/HR-Management/Employee/List-EmployeeDetails/List-EmployeeDetails.component';
import { ListUsersComponent } from './pages/Users-Management/list-users/list-users.component';
import { UsersDashboardComponent } from './pages/Users-Management/users-dashboard/users-dashboard.component';
import { AddUsersComponent } from './pages/Users-Management/add-users/add-users.component';
import { UsersPermissionsComponent } from './pages/Users-Management/users-permissions/users-permissions.component';
import { AddPermissionsComponent } from './pages/Users-Management/add-permissions/add-permissions.component';
import { UserDashboardComponent } from './pages/Users-Management/user-dashboard/user-dashboard.component';
import { ListWorksComponent } from './pages/HR-Management/Employee/List-Works/List-Works.component';
import { NgSelectModule } from '@ng-select/ng-select';
import { SupplierService } from './Services/Supplier/Supplier.service';
import { ListCurrencyComponent } from './pages/Info/Currency/list-currency/list-currency.component';
@NgModule({ declarations: [
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
        List_CustomersComponent,
        Add_CustomerComponent,
        List_countryComponent,
        List_cityComponent,
        List_WarehousesComponent,
        WarehousesMovementComponent,
        AddMouvementComponent,
        AddEmployeeComponent,
        ListDepartementComponent,
        ListEmployeeComponent,
        ProfileEmployeeComponent,
        AddLeaveComponent,
        ListLeaveComponent,
        LeaveReportComponent,
        AddPayrollComponent,
        ListPayrollComponent,
        AddPerformanceReviewComponent,
        Goal_ObjectivesComponent,
        PerformanceReviewListComponent,
        Add_ApplicantComponent,
        Add_Job_PostingComponent,
        List_ApplicantComponent,
        List_Job_PostingComponent,
        Add_TrainingComponent,
        List_Training_ProgramsComponent,
        HRDashboardComponent,
        ListAttendanceComponent,
        AddAttendanceComponent,
        ReportAttendanceComponent,
        ListEmployeeDetailsComponent,
        ListUsersComponent,
        UsersDashboardComponent,
        AddUsersComponent,
        UsersPermissionsComponent,
        AddPermissionsComponent,
        UserDashboardComponent,
        ListWorksComponent,
        ListDepartementComponent,
        ListCurrencyComponent
    ],
    bootstrap: [AppComponent] // This is correct
    , imports: [BrowserModule,
        AppRoutingModule,
        ReactiveFormsModule,
        BrowserAnimationsModule,
        MatSliderModule,
        MatTableModule,
        MatPaginatorModule,
        RouterModule,
        CommonModule,
        MatSortModule,
        MatFormFieldModule,
        MatInputModule,
        MatProgressSpinnerModule,
        MatGridListModule,
        MatButtonModule,
        MatTab,MatTabGroup,
        FormsModule,
        MatMenuModule,
        MatButtonModule,
        MatIconModule ,
        MatDividerModule ,
        NgSelectModule], providers: [provideHttpClient(withInterceptorsFromDi())] })
export class AppModule { }
