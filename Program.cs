using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Data.Usecases;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories;
using ProductManagement.API.Src.Infra.Repositories.Protocols;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// services
builder.Services.AddScoped<ICreateProductProtocol, CreateProduct>();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<ICreateRepository<Product>, EFCreateProduct>();

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
