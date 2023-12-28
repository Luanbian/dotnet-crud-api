using ProductManagement.API.Src.Data.Protocols;
using ProductManagement.API.Src.Data.Usecases;
using ProductManagement.API.Src.Domain.Entities;
using ProductManagement.API.Src.Infra.EntityFramework;
using ProductManagement.API.Src.Infra.Repositories;
using ProductManagement.API.Src.Infra.Repositories.Protocols;
using ProductManagement.API.Src.Presentation.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// usecases
builder.Services.AddScoped<ICreateProductProtocol, CreateProduct>();
builder.Services.AddScoped<IListAllProductProtocol, ListAllProduct>();
builder.Services.AddScoped<IUpdateProductProtocol, UpdateProduct>();

// db
builder.Services.AddScoped<AppDbContext>();

//repositories
builder.Services.AddScoped<ICreateRepository<Product>, EFCreateProduct>();
builder.Services.AddScoped<IFindRepository<Product>, EFFindProduct>();
builder.Services.AddScoped<IUpdateRepository<UpdateControllerProps>, EFUpdateProduct>();

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
