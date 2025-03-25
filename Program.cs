using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql;
using PTirta.Data;
using PTirta.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PTirtaContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddIdentity<Users, IdentityRole>(Options =>
{
    Options.Password.RequireNonAlphanumeric = false;
    Options.Password.RequiredLength = 6;
    Options.Password.RequireLowercase = false;
    Options.Password.RequireUppercase = false;
    Options.User.RequireUniqueEmail = true;
    Options.SignIn.RequireConfirmedAccount = false;
    Options.SignIn.RequireConfirmedEmail = false;
    Options.SignIn.RequireConfirmedPhoneNumber = false;
})
    .AddEntityFrameworkStores<PTirtaContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Main/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
