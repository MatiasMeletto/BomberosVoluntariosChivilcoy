using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
void ConfigureServices(IServiceCollection servicios)
{
    var conexionString = "server=localhost;user=root;password=1234;database=ef";
    var serverVersion = ServerVersion.AutoDetect(conexionString);

    servicios.AddDbContext<>(
        dbContextOptions => dbContextOptions
        .UseMySql(conexionString, serverVersion)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors()
        );
}

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
