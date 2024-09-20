import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { AlertsComponent } from './components/alerts/alerts.component';
import { AccordionComponent } from './components/accordion/accordion.component';
import { BadgesComponent } from './components/badges/badges.component';
import { BreadcrumbsComponent } from './components/breadcrumbs/breadcrumbs.component';
import { ButtonsComponent } from './components/buttons/buttons.component';
import { CardsComponent } from './components/cards/cards.component';
import { CarouselComponent } from './components/carousel/carousel.component';
import { ChartsApexchartsComponent } from './components/charts-apexcharts/charts-apexcharts.component';
import { ChartsChartjsComponent } from './components/charts-chartjs/charts-chartjs.component';
import { FormsEditorsComponent } from './components/forms-editors/forms-editors.component';
import { FormsElementsComponent } from './components/forms-elements/forms-elements.component';
import { FormsLayoutsComponent } from './components/forms-layouts/forms-layouts.component';
import { IconsBootstrapComponent } from './components/icons-bootstrap/icons-bootstrap.component';
import { IconsBoxiconsComponent } from './components/icons-boxicons/icons-boxicons.component';
import { IconsRemixComponent } from './components/icons-remix/icons-remix.component';
import { ListGroupComponent } from './components/list-group/list-group.component';
import { ModalComponent } from './components/modal/modal.component';
import { PaginationComponent } from './components/pagination/pagination.component';
import { ProgressComponent } from './components/progress/progress.component';
import { SpinnersComponent } from './components/spinners/spinners.component';
import { TablesDataComponent } from './components/tables-data/tables-data.component';
import { TablesGeneralComponent } from './components/tables-general/tables-general.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { TooltipsComponent } from './components/tooltips/tooltips.component';
import { PagesBlankComponent } from './pages/pages-blank/pages-blank.component';
import { PagesContactComponent } from './pages/pages-contact/pages-contact.component';
import { PagesError404Component } from './pages/pages-error404/pages-error404.component';
import { PagesFaqComponent } from './pages/pages-faq/pages-faq.component';
import { UsersProfileComponent } from './pages/users-profile/users-profile.component';
import { PagesInfoDepotComponent } from './pages/pages-info/Depot/pages-info-depot.component';
import { PagesInfoTresoreriesComponent } from './pages/pages-info/Tresoreries/pages-info-tresoreries.component';
import { AddFamilyComponent } from './pages/Product/add-family/add-family.component';
import { ListFamilyComponent } from './pages/Product/list-family/list-family.component';
import { AddArticleComponent } from './pages/Product/add-article/add-article.component';
import { ListArticleComponent } from './pages/Product/list-article/list-article.component';
import { List_SuppliersComponent } from './pages/purchases/Suppliers/list_Suppliers/list_Suppliers.component';
import { Add_SuppliersComponent } from './pages/purchases/Suppliers/add_Suppliers/add_Suppliers.component';
import { Add_PurchasesComponent } from './pages/purchases/Purchases/add_Purchases/add_Purchases.component';
import { List_PurchasesComponent } from './pages/purchases/Purchases/list_Purchases/list_Purchases.component';
import { Add_PurchaseDetailsComponent } from './pages/purchases/PurchaseDetails/add_PurchaseDetails/add_PurchaseDetails.component';
import { List_PurchaseDetailsComponent } from './pages/purchases/PurchaseDetails/list_PurchaseDetails/list_PurchaseDetails.component';
import { ListSalesComponent } from './pages/Sales/list-sales/list-sales/list-sales.component';
import { Add_salesComponent } from './pages/Sales/list-sales/add_sales/add_sales.component';
import { List_customersComponent } from './pages/Sales/Customers/list_customers/list_customers.component';
import { Add_customerComponent } from './pages/Sales/Customers/add_customer/add_customer.component';
import { List_cityComponent } from './pages/Info/City/list_city/list_city.component';
import { List_countryComponent } from './pages/Info/Country/list_country/list_country.component';
import { List_WarehousesComponent } from './pages/Inventory/Warehouses/list_Warehouses/list_Warehouses.component';
import { WarehousesMovementComponent } from './pages/Inventory/Mouvement/WarehousesMovement/WarehousesMovement.component';
import { AddMouvementComponent } from './pages/Inventory/Mouvement/AddMouvement/AddMouvement.component';
import { AddEmployeeComponent } from './pages/HR-Management/Employee/Add-Employee/Add-Employee.component';
import { ListEmployeeComponent } from './pages/HR-Management/Employee/List-Employee/List-Employee.component';
import { HRDashboardComponent } from './pages/HR-Management/HR-Dashboard/HR-Dashboard.component';
import { ProfileEmployeeComponent } from './pages/HR-Management/Employee/Profile-Employee/Profile-Employee.component';
import { ListDepartementComponent } from './pages/HR-Management/Employee/List-Departement/List-Departement.component';
import { ListLeaveComponent } from './pages/HR-Management/Leave-management/List-Leave/List-Leave.component';
import { AddLeaveComponent } from './pages/HR-Management/Leave-management/Add-Leave/Add-Leave.component';
import { LeaveReportComponent } from './pages/HR-Management/Leave-management/Leave-Report/Leave-Report.component';
import { ListPayrollComponent } from './pages/HR-Management/Payroll-management/List-Payroll/List-Payroll.component';
import { AddPayrollComponent } from './pages/HR-Management/Payroll-management/Add-Payroll/Add-Payroll.component';
import { PerformanceReviewListComponent } from './pages/HR-Management/Performance-management/PerformanceReview-List/PerformanceReview-List.component';
import { AddPerformanceReviewComponent } from './pages/HR-Management/Performance-management/Add-PerformanceReview/Add-PerformanceReview.component';
import { Goal_ObjectivesComponent } from './pages/HR-Management/Performance-management/Goal_Objectives/Goal_Objectives.component';
import { List_ApplicantComponent } from './pages/HR-Management/Recruitment/List_Applicant/List_Applicant.component';
import { Add_ApplicantComponent } from './pages/HR-Management/Recruitment/Add_Applicant/Add_Applicant.component';
import { List_Job_PostingComponent } from './pages/HR-Management/Recruitment/List_Job_Posting/List_Job_Posting.component';
import { Add_Job_PostingComponent } from './pages/HR-Management/Recruitment/Add_Job_Posting/Add_Job_Posting.component';
import { List_Training_ProgramsComponent } from './pages/HR-Management/Training-Development/List_Training_Programs/List_Training_Programs.component';
import { Add_TrainingComponent } from './pages/HR-Management/Training-Development/Add_Training/Add_Training.component';
import { ListAttendanceComponent } from './pages/HR-Management/Attendance-management/List-Attendance/List-Attendance.component';
import { AddAttendanceComponent } from './pages/HR-Management/Attendance-management/add-Attendance/add-Attendance.component';
import { ReportAttendanceComponent } from './pages/HR-Management/Attendance-management/Report-Attendance/Report-Attendance.component';
import { ListEmployeeDetailsComponent } from './pages/HR-Management/Employee/List-EmployeeDetails/List-EmployeeDetails.component';
import { UsersDashboardComponent } from './pages/Users-Management/users-dashboard/users-dashboard.component';
import { ListUsersComponent } from './pages/Users-Management/list-users/list-users.component';
import { AddUsersComponent } from './pages/Users-Management/add-users/add-users.component';
import { UsersPermissionsComponent } from './pages/Users-Management/users-permissions/users-permissions.component';

const routes: Routes = [
  { path: '', component: DashboardComponent },
  { path: 'Home', component: DashboardComponent },
  { path: 'Product', component: ListArticleComponent },

  { path: 'Article/add-family', component: AddFamilyComponent },
  { path: 'Article/list-family', component: ListFamilyComponent },
  { path: 'Article/add-family/:id', component: AddFamilyComponent },
  { path: 'Article/add-article', component: AddArticleComponent },
  { path: 'Article/add-article/:id', component: AddArticleComponent },
  { path: 'Article/list-article', component: ListArticleComponent },

  { path: 'Suppliers', component: List_SuppliersComponent },
  { path: 'Suppliers/add-Suppliers', component: Add_SuppliersComponent },
  { path: 'add-Suppliers', component: Add_SuppliersComponent },
  { path: 'edit-Suppliers/:id', component: Add_SuppliersComponent },
  { path: 'Suppliers/list-Suppliers', component: List_SuppliersComponent },

  { path: 'purchases/add_Purchases', component: Add_PurchasesComponent },
  { path: 'add_Purchases', component: Add_PurchasesComponent },
  { path: 'edit-Purchases/:id', component: Add_PurchasesComponent },
  { path: 'purchases', component: List_PurchasesComponent },
  { path: 'purchases/list-Purchases', component: List_PurchasesComponent },

  { path: 'PurchaseDetails', component: List_PurchaseDetailsComponent },
  { path: 'PurchaseDetails/add_PurchaseDetails', component: Add_PurchaseDetailsComponent },
  { path: 'add_PurchaseDetails', component: Add_PurchaseDetailsComponent },
  { path: 'edit_PurchaseDetails/:id', component: Add_PurchaseDetailsComponent },
  { path: 'PurchaseDetails/list-PurchaseDetails', component: List_PurchaseDetailsComponent },

  { path: 'sales', component: ListSalesComponent },
  { path: 'sales/add_sales', component: Add_salesComponent },
  { path: 'add_sales', component: Add_salesComponent },
  { path: 'edit_sales/:id', component: Add_salesComponent },
  { path: 'sales/list-sales', component: ListSalesComponent },

  { path: 'customers', component: List_customersComponent },
  { path: 'customers/add_customers', component: Add_customerComponent },
  { path: 'add_customers', component: Add_customerComponent },
  { path: 'edit_customers/:id', component: Add_customerComponent },
  { path: 'customers/list_customers', component: List_customersComponent },



  { path: 'Info/City', component: List_cityComponent },
  { path: 'Info/City/list_city', component: List_cityComponent },

  { path: 'Info/Country', component: List_countryComponent },
  { path: 'Info/Country/list_country', component: List_countryComponent },


  { path: 'Inventory/Warehouses', component: List_WarehousesComponent },
  { path: 'Inventory/Warehouses/list_warehouses', component: List_WarehousesComponent },
  { path: 'Inventory/Mouvement/WarehousesMovement', component: WarehousesMovementComponent },
  { path: 'Inventory/Mouvement', component: WarehousesMovementComponent },

  { path: 'Mouvement', component: WarehousesMovementComponent },
  { path: 'Inventory/Mouvement/AddMouvement', component: AddMouvementComponent },
  { path: 'Inventory/AddMouvement', component: AddMouvementComponent },
  { path: 'AddMouvement', component: AddMouvementComponent },

  { path: 'HR-Management', component: HRDashboardComponent },
  { path: 'HR-Management/Employee', component: HRDashboardComponent },
  { path: 'HR-Management/Employee/AddEmployee', component: AddEmployeeComponent },
  { path: 'HR-Management/Employee/ListEmployee', component: ListEmployeeComponent },
  { path: 'HR-Management/Employee/ListEmployeeDetails', component: ListEmployeeDetailsComponent },
  { path: 'HR-Management/Employee/Profile/:id', component: ProfileEmployeeComponent },

  // Department Management
  { path: 'HR-Management/Employee/Department', component: ListDepartementComponent },

  // Leave Management
  { path: 'HR-Management/Leave', component: HRDashboardComponent },
  { path: 'HR-Management/Leave/List', component: ListLeaveComponent },
  { path: 'HR-Management/Leave/AddLeave', component: AddLeaveComponent },
  { path: 'HR-Management/Leave/LeaveReport', component: LeaveReportComponent },

  // Payroll Management
  { path: 'HR-Management/Payroll', component: HRDashboardComponent },
  { path: 'HR-Management/Payroll/List', component: ListPayrollComponent },
  { path: 'HR-Management/Payroll/AddPayroll', component: AddPayrollComponent },

  // Performance Review Management
  { path: 'HR-Management/PerformanceReview', component: HRDashboardComponent },
  { path: 'HR-Management/PerformanceReview/List', component: PerformanceReviewListComponent },
  { path: 'HR-Management/PerformanceReview/AddReview', component: AddPerformanceReviewComponent },
  { path: 'HR-Management/PerformanceReview/Goals', component: Goal_ObjectivesComponent },

  // Recruitment Management
  { path: 'HR-Management/Recruitment', component: HRDashboardComponent },
  { path: 'HR-Management/Recruitment/Applicants', component: List_ApplicantComponent },
  { path: 'HR-Management/Recruitment/AddApplicant', component: Add_ApplicantComponent },
  { path: 'HR-Management/Recruitment/JobPostings', component: List_Job_PostingComponent },
  { path: 'HR-Management/Recruitment/AddJobPosting', component: Add_Job_PostingComponent },

  // Training Programs Management
  { path: 'HR-Management/Training', component: HRDashboardComponent },
  { path: 'HR-Management/Training/List', component: List_Training_ProgramsComponent },
  { path: 'HR-Management/Training/AddTraining', component: Add_TrainingComponent },

  // Attendance Management
  { path: 'HR-Management/Attendance', component: HRDashboardComponent },
  { path: 'HR-Management/Attendance/List', component: ListAttendanceComponent },
  { path: 'HR-Management/Attendance/AddAttendance', component: AddAttendanceComponent },
  { path: 'HR-Management/Attendance/Report', component: ReportAttendanceComponent },

  // Users Management
  { path: 'Users-Management/users-dashboard', component: UsersDashboardComponent },
  { path: 'Users-Management/List-Users', component: ListUsersComponent },
  { path: 'Users-Management/Add-Users', component: AddUsersComponent },
  { path: 'Users-Management/Update-Users/:id', component: AddUsersComponent },

  { path: 'Users-Management/Permission', component: UsersPermissionsComponent },


  { path: 'pages-blank', component: PagesBlankComponent },
  { path: 'home', component: DashboardComponent },
  { path: 'alerts', component: AlertsComponent },
  { path: 'accordion', component: AccordionComponent },
  { path: 'badges', component: BadgesComponent },
  { path: 'breadcrumbs', component: BreadcrumbsComponent },
  { path: 'buttons', component: ButtonsComponent },
  { path: 'cards', component: CardsComponent },
  { path: 'carousel', component: CarouselComponent },
  { path: 'charts-apexcharts', component: ChartsApexchartsComponent },
  { path: 'charts-chartjs', component: ChartsChartjsComponent },
  { path: 'form-editors', component: FormsEditorsComponent },
  { path: 'form-elements', component: FormsElementsComponent },
  { path: 'form-layouts', component: FormsLayoutsComponent },
  { path: 'icons-bootstrap', component: IconsBootstrapComponent },
  { path: 'icons-boxicons', component: IconsBoxiconsComponent },
  { path: 'icons-remix', component: IconsRemixComponent },
  { path: 'list-group', component: ListGroupComponent },
  { path: 'modal', component: ModalComponent },
  { path: 'pagination', component: PaginationComponent },
  { path: 'progress', component: ProgressComponent },
  { path: 'spinners', component: SpinnersComponent },
  { path: 'tables-data', component: TablesDataComponent },
  { path: 'tables-general', component: TablesGeneralComponent },
  { path: 'tabs', component: TabsComponent },
  { path: 'tooltips', component: TooltipsComponent },
  { path: 'pages-contact', component: PagesContactComponent },
  { path: 'pages-error404', component: PagesError404Component },
  { path: 'pages-faq', component: PagesFaqComponent },
  { path: 'user-profile', component: UsersProfileComponent },
  { path: 'pages-info-depot', component: PagesInfoDepotComponent },
  { path: 'pages-info-tresoreries', component: PagesInfoTresoreriesComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
