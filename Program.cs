using Microsoft.EntityFrameworkCore;
using MyFilmRanking.Models.ModelContext;
using MyFilmRanking.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

var adminRole = new Role("admin");
var admin = new User("user1@gmail.com", "pass121", adminRole);

var builder = WebApplication.CreateBuilder();

builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<FilmContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-R4H57RQ; Database=FilmDB; Trusted_Connection=True; TrustServerCertificate=True;");
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.Name = "Cookie";
        options.LoginPath = "/Account/Login";
    });

builder.Services.AddAuthorization();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Main}/{id?}"
);

app.Run();