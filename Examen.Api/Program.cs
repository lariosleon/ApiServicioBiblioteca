using Examen.Application.Implement;
using Examen.Application.Interface;
using Examen.Domain.Implement;
using Examen.Domain.Interface;
using Examen.Infrastructure.Implement;
using Examen.Infrastructure.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CARGOS
builder.Services.AddTransient<ICargosInf, CargosInf>();
builder.Services.AddTransient<ICargosDom, CargosDom>();
builder.Services.AddTransient<ICargosApp, CargosApp>();
//EMPLEADOS
builder.Services.AddTransient<IEmpleadosInf, EmpleadosInf>();
builder.Services.AddTransient<IEmpleadosDom, EmpleadosDom>();
builder.Services.AddTransient<IEmpleadoApp, EmpleadoApp>();
//ESTUDIANTES
builder.Services.AddTransient<IEstudiantesInf, EstudiantesInf>();
builder.Services.AddTransient<IEstudiantesDom, EstudiantesDom>();
builder.Services.AddTransient<IEstudiantesApp, EstudiantesApp>();
//LIBROS
builder.Services.AddTransient<ILibrosInf, LibrosInf>();
builder.Services.AddTransient<ILibrosDom, LibrosDom>();
builder.Services.AddTransient<ILibrosApp, LibrosApp>();

//PRESTAMOS
builder.Services.AddTransient<IPrestamosInf, PrestamosInf>();
builder.Services.AddTransient<IPrestamosDom, PrestamosDom>();
builder.Services.AddTransient<IPrestamosApp, PrestamosApp>();


var app = builder.Build();

//builder.Services.AddSignalR();
//builder.Services.AddTransient<IClienteInf, ClienteInf>();
//builder.Services.AddTransient<IClienteDom, ClienteDom>();
//builder.Services.AddTransient<IClienteApp, ClienteApp>();
//builder.Services.AddScoped<IClienteInf, ClienteInf>();
//builder.Services.AddScoped<IClienteDom, ClienteDom>();
//builder.Services.AddScoped<IClienteApp, ClienteApp>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
