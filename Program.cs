using GEfrontEnd.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GEfrontEnd.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<GEfrontEndContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("GEfrontEndContext") ?? throw new InvalidOperationException("Connection string 'GEfrontEndContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register HttpClient for making HTTP requests
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5042") });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
