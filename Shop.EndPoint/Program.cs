using Microsoft.EntityFrameworkCore;
using Shop.InfraData.Context;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
 void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    #region context
    services.AddDbContext<ShopDbContext>(option =>
    {
        option.UseSqlServer(connectionString);
    }
    #endregion
}

// Add services to the container.
builder.Services.AddControllersWithViews();

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
