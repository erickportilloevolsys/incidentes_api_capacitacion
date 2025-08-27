using Infraestructura;
using Infraestructura.Persistence;
using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Servicios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddScoped<ITipoIncidenteService, TipoIncidenteService>();
builder.Services.AddScoped<IPrioridadService, PrioridadService>();
builder.Services.AddScoped<IImpactoService, ImpactoService>();
builder.Services.AddScoped<IIncidenteService, IncidenteService>();

builder.Services.AddScoped<ITipoIncidenteRepository, TipoIncidenteRepository>();
builder.Services.AddScoped<IPrioridadRepository, PrioridadRepository>();
builder.Services.AddScoped<IImpactoRepository, ImpactoRepository>();
builder.Services.AddScoped<IIncidenteRepository, IncidenteRepository>();

builder.Services.AddSqlServer<AppDbContext>(builder.Configuration.GetConnectionString("DefaultConnection"));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
