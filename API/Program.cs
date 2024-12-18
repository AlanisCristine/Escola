using Escola.Repository;
using Escola.Repository.Interfaces;
using Escola.Service;
using Escola.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
InicializadorBD.Inicializar();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

builder.Services.AddScoped<IAlunoService, AlunoService>();

var app = builder.Build();

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
