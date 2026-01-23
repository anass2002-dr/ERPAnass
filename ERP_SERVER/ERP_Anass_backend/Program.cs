using ERP_Anass_backend;
using ERP_Anass_backend.Repository.ArticleRepo;
using ERP_Anass_backend.Repository.CustomerRepo;
using ERP_Anass_backend.Repository.EmployeeRepo;
using ERP_Anass_backend.Repository.FamilyRepo;
using ERP_Anass_backend.Repository.InfoRepo;
using ERP_Anass_backend.Repository.PurchaseRepo;
using ERP_Anass_backend.Repository.SupplierRepo;
using ERP_Anass_backend.Repository.UserRepo;
using ERP_Anass_backend.Services.ArticleService;
using ERP_Anass_backend.Services.EmployeeService;
using ERP_Anass_backend.Services.FamillyServices;
using ERP_Anass_backend.Services.InfoService;
using ERP_Anass_backend.Services.PurchaseService;
using ERP_Anass_backend.Services.SupplierService;
using ERP_Anass_backend.Services.CustomerService;
using ERP_Anass_backend.Services.UserService;
using Microsoft.EntityFrameworkCore;
using ERP_Anass_backend.Repository.SaleRepo;
using ERP_Anass_backend.Services.SaleService;
using ERP_Anass_backend.Repository.BrandRepo;
using ERP_Anass_backend.Services.BrandService;
using ERP_Anass_backend.Repository.WarehouseRepo;
using ERP_Anass_backend.Services.WarehouseService;
using ERP_Anass_backend.Repository.StockMovementRepo;
using ERP_Anass_backend.Services.StockMovementService;
using ERP_Anass_backend.Repository.AccountRepo;
using ERP_Anass_backend.Services.AccountService;
using ERP_Anass_backend.Repository.PaymentRepo;
using ERP_Anass_backend.Services.PaymentService;
using ERP_Anass_backend.Repository.TenantRepo;
using ERP_Anass_backend.Services.TenantService;
using ERP_Anass_backend.Repository.ModuleLicenseRepo;
using ERP_Anass_backend.Services.ModuleLicenseService;
using ERP_Anass_backend.Repository.AppConfigurationRepo;
using ERP_Anass_backend.Services.AppConfigurationService;
using ERP_Anass_backend.Repository.UnitOfMeasureRepo;
using ERP_Anass_backend.Services.UnitOfMeasureService;
using ERP_Anass_backend.Repository.BillOfMaterialsRepo;
using ERP_Anass_backend.Services.BillOfMaterialsService;
using ERP_Anass_backend.Repository.JournalEntryRepo;
using ERP_Anass_backend.Services.JournalEntryService;
using ERP_Anass_backend.Repository.InvoiceRepo;
using ERP_Anass_backend.Services.InvoiceService;
using ERP_Anass_backend.Repository.BankAccountRepo;
using ERP_Anass_backend.Services.BankAccountService;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Retrieve the connection string from configuration
var connectionString = configuration.GetConnectionString("defaultConnection");

// Add Database service and specify the migrations assembly
builder.Services.AddDbContext<DbContextERP>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
    b => b.MigrationsAssembly("ERP_Anass_backend")));

// Add services to the container.
var Myplociy = "Mypolicy";
builder.Services.AddCors(options => options.AddPolicy(name: Myplociy, policy =>
{
    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
    policy.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IRepoArticle, RepoArticle>();

builder.Services.AddScoped<IFamillyRepo, FamillyRepo>();
builder.Services.AddScoped<IFamillyService, FamillyService>();

builder.Services.AddScoped<IBrandRepo, BrandRepo>();
builder.Services.AddScoped<IBrandService, BrandService>();

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IServiceInfo, ServiceInfo>();
builder.Services.AddScoped<IRepoInfo, RepoInfo>();

builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();

builder.Services.AddScoped<ISupplierRepo, SupplierRepo>();
builder.Services.AddScoped<ISupplierService, SupplierService>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();

builder.Services.AddScoped<IPurchaseRepo, PurchaseRepo>();
builder.Services.AddScoped<IPurchaseDetailsRepo, PurchaseDetailsRepo>();

builder.Services.AddScoped<ISaleRepo, SaleRepo>();
builder.Services.AddScoped<ISaleDetailsRepo, SaleDetailsRepo>();

builder.Services.AddScoped<IPurchaseService, PurchaseService>();
builder.Services.AddScoped<IPurchaseDetailsService, PurchaseDetailsService>();

builder.Services.AddScoped<ISaleService, SaleService>();
builder.Services.AddScoped<ISaleDetailsService, SaleDetailsService>();

builder.Services.AddScoped<IRepoWarehouse, RepoWarehouse>();
builder.Services.AddScoped<IServiceWarehouse, WarehouseService>();

builder.Services.AddScoped<IRepoStockMovement, RepoStockMovement>();
builder.Services.AddScoped<IServiceStockMovement, StockMovementService>();

builder.Services.AddScoped<IRepoAccount, RepoAccount>();
builder.Services.AddScoped<IServiceAccount, AccountService>();

builder.Services.AddScoped<IRepoPayment, RepoPayment>();
builder.Services.AddScoped<IServicePayment, PaymentService>();

builder.Services.AddScoped<IRepoTenant, RepoTenant>();
// Register TenantService as both IServiceTenant AND ITenantProvider if needed, 
// OR register them separately. Since TenantService implements both, we can do:
builder.Services.AddScoped<TenantService>();
builder.Services.AddScoped<IServiceTenant>(provider => provider.GetRequiredService<TenantService>());
builder.Services.AddScoped<ITenantProvider>(provider => provider.GetRequiredService<TenantService>());

builder.Services.AddScoped<IRepoModuleLicense, RepoModuleLicense>();
builder.Services.AddScoped<IServiceModuleLicense, ModuleLicenseService>();

builder.Services.AddScoped<IRepoAppConfiguration, RepoAppConfiguration>();
builder.Services.AddScoped<IServiceAppConfiguration, AppConfigurationService>();

builder.Services.AddScoped<IRepoUnitOfMeasure, RepoUnitOfMeasure>();
builder.Services.AddScoped<IServiceUnitOfMeasure, UnitOfMeasureService>();

builder.Services.AddScoped<IRepoBillOfMaterials, RepoBillOfMaterials>();
builder.Services.AddScoped<IServiceBillOfMaterials, BillOfMaterialsService>();

builder.Services.AddScoped<IRepoJournalEntry, RepoJournalEntry>();
builder.Services.AddScoped<IServiceJournalEntry, JournalEntryService>();

builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();

builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();
builder.Services.AddScoped<IBankAccountService, BankAccountService>();

var app = builder.Build();
app.UseCors(Myplociy); // Use CORS before any other middleware

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();