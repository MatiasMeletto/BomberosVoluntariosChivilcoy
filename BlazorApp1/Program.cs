using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Data;

var builder = WebApplication.CreateBuilder(args);

var conexionString = "server=db4free.net:3306;user=eest1chivilcoy;password=eest1-1910;database=bomberosindu";
var serverVersion = ServerVersion.AutoDetect(conexionString);

builder.Services.AddDbContextFactory<BomberosDbContext>(
    dbContextOptions => dbContextOptions
    .UseMySql(conexionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging()
    .EnableDetailedErrors()
    );

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();




var app = builder.Build();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
