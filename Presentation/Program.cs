using Business.Manager;
using Business.Services;
using Data.Context;
using Data.DAL.Customer;
using Data.Repositories.Db1Repository;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ILazerAppointmentService, LazerAppointmentManager>();
builder.Services.AddScoped<ILazerAppointmentDAL, LazerAppointmentRepository>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<ICustomerDAL, CustomerRepository>();
builder.Services.AddScoped<IMasterService, MasterManager>();
builder.Services.AddScoped<IMasterDAL, MasterRepository>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
	options.Password.RequireUppercase = false;
	options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuöğıəşçvwxyzABCDEFGHIJŞÖĞIƏKLMNOPÇQRSTUVWXYZ0123456789.";



}).AddEntityFrameworkStores<AppDbContext>();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
		  name: "TestSalon",
		  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
		);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
