global using Microsoft.Playwright;
global using System.Globalization;
global using System.Text.Encodings.Web;
global using Microsoft.EntityFrameworkCore;
global using HtmlAgilityPack;
global using RoboDeApostas.Utils;
global using RoboDeApostas.Database;
global using RoboDeApostas.Models;
global using RoboDeApostas.Models.CasasDeAposta;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazored.Toast;

if (!Directory.Exists("./Logs"))
    Directory.CreateDirectory("./Logs");

if (!Directory.Exists("./Resultados"))
    Directory.CreateDirectory("./Resultados");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddBlazoredToast();
builder.Services.AddScoped<Bet365>();
builder.Services.AddScoped<Betano>();
builder.Services.AddScoped<Sportsbet_IO>();
builder.Services.AddScoped<SportingBet>();
builder.Services.AddScoped<Betfair>();
builder.Services.AddScoped<Betway>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DatabaseContext>();
    context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
await new Betano().SalvarEmJsonAsync();
await new SportingBet().SalvarEmJsonAsync();
await new Betway().SalvarEmJsonAsync();
//RoboDeApostas.InicializadorDeValores.Liga();
//RoboDeApostas.InicializadorDeValores.Betano();
//RoboDeApostas.InicializadorDeValores.SportingBet();
//RoboDeApostas.InicializadorDeValores.Betway();
RoboDeApostas.InicializadorDeValores.Bet365();
RoboDeApostas.InicializadorDeValores.SportsBetIo();
RoboDeApostas.InicializadorDeValores.Betfair();
app.Run();