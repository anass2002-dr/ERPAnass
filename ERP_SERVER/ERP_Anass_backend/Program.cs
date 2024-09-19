using ERP_Anass_backend;
using ERP_Anass_backend.Repository.ArticleRepo;
using ERP_Anass_backend.Repository.FamilyRepo;
using ERP_Anass_backend.Repository.UserRepo;
using ERP_Anass_backend.Services.ArticleService;
using ERP_Anass_backend.Services.FamillyServices;
using ERP_Anass_backend.Services.UserService;
using Microsoft.EntityFrameworkCore;

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
}));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IRepoArticle, RepoArticle>();

builder.Services.AddScoped<IFamillyRepo, FamillyRepo>();
builder.Services.AddScoped<IFamillyService, FamillyService>();

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IUserService, UserService>();

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
