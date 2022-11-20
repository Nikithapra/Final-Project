using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectMVC.Areas.Identity.Data;
using ProjectMVC.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ProjectMVCContextConnection") ?? throw new InvalidOperationException("Connection string 'ProjectMVCContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();


//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHNqVVhlXlpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF9iSH9Xdk1gWX9fcXRdRg==;Mgo+DSMBPh8sVXJ0S0V+XE9BdFRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS3xSd0RnWXddcHRUR2JZUQ==;Mgo+DSMBMAY9C3t2VVhjQlFac11JXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRd0RiXX9Wc3RVR2FZVUQ=");
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.Run();
