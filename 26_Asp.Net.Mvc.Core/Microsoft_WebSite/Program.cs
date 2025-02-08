using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.InFrustracture.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Microsoft_WebSite;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddSession();
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<Microsoft_Website_Context>();
        builder.Services.AddServices();
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
        {
            option.LoginPath = "/Admin/Auth/SignIn";
            option.AccessDeniedPath = "/Admin/Auth/AccessDenied";
        });
       
        var app = builder.Build();

        app.UseStatusCodePagesWithReExecute("/Error/ErrorPages/{0}");
        app.UseSession();
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
        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name : "areas",
            pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
        );
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        
       

        app.Run();
    }
}