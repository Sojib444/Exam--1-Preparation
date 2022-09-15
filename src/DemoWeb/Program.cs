using Autofac;
using Autofac.Extensions.DependencyInjection;
using DemoWeb;

using DemoWebLibrary;
using DemoWebLibrary.ApplicationDbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var assembly = Assembly.GetExecutingAssembly().FullName;

builder.Services.AddDbContext<StudentDbContext>(option =>
                 option.UseSqlServer(connectionString,
                 e => e.MigrationsAssembly(assembly)));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseSqlServer(connectionString, m => m.MigrationsAssembly(assembly)));
builder.Services.AddControllersWithViews();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
      .AddEntityFrameworkStores<StudentDbContext>();
builder.Services.AddControllersWithViews();
//Autofac Configure 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => {
    containerBuilder.RegisterModule(new LibraryModule(connectionString, assembly));
    containerBuilder.RegisterModule(new DemowebModule());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
