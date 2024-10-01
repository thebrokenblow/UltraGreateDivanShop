using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UltraGreateDivanShop.Database;
using UltraGreateDivanShop.Web.Repositories;
using UltraGreateDivanShop.Web.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("UltraGreateDivanShopContext");

builder.Services.AddDbContext<DivanShopContext>(options =>
    options.UseSqlServer(connection));
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IRepositoryCart, RepositoryCart>();

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
