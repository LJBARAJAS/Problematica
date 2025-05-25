using Microsoft.EntityFrameworkCore;
using Problematica.Components;
using Problematica.Components.Data;
using Problematica.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();
builder.Services.AddDbContext<CatalogoBDContex>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepositorioEmpleados, RepositorioEmpleados>();
builder.Services.AddScoped<IRepositorioEmpresa, RepositorioEmpresa>();
builder.Services.AddScoped<IRepositorioPuesto, RepositorioPuesto>();
builder.Services.AddDbContext<CatalogoBDContex>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
