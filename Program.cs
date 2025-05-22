using Microsoft.EntityFrameworkCore;
using Proyecto.Components;
using Proyecto.Data;
using Proyecto.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<BDDirectorioDBContext>(
    options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("BDDirectorioDBContext")));

builder.Services.AddScoped<IRepositorioAlumnas, RepositorioAlumnas>();
builder.Services.AddScoped<IRepositorioClases, RepositorioClases>();
builder.Services.AddScoped<IRepositorioComentarios, RepositorioComentarios>();

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
