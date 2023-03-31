using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SSP.Controllers;
using SSP.EIRSModel;
using SSP.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string? conn = builder.Configuration.GetConnectionString("EirsContext");
builder.Services.AddDbContext<EirsContext>(opt => opt.UseSqlServer(conn));
string? conn2 = builder.Configuration.GetConnectionString("PayeContext");
builder.Services.AddDbContext<EirsContext>(opt => opt.UseSqlServer(conn2));
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(180000);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
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

app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=SignIn}/{id?}"
    );
app.Run();
