using BLL.Services;
using BLL.Services.interfaces;
using COMMON.Models;
using DAL.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/*builder.Services.AddDbContext<WebApplication1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication1Context") ?? throw new InvalidOperationException("Connection string 'WebApplication1Context' not found.")));
*/builder.Services.AddTransient<IHomeServices,HomeServices>();
builder.Services.AddTransient<IEmployeeServices, EmployeeServices>();
builder.Services.AddTransient<IProjectServices, ProjectServices>();
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
