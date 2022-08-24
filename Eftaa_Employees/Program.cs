using Bl.Interface;
using Bl.Repository;
using Dal.Database;
using Microsoft.EntityFrameworkCore;
using NewDataEmplyee.BL.Mapper;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("NewDataEmployeeConnection");
builder.Services.AddDbContext<ApplicationContext>(options =>
options.UseSqlServer(connectionString));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ILookupsValue, IlookupsValueRep>();
builder.Services.AddScoped<IEmpRegister, IEmpRegisterRep>();

builder.Services.AddScoped<ILookups, ILookupsRep>();

builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
