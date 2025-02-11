using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Service;
using Clean.Data;
using Clean.Data.Repositories;
using Clean.Core.Entities;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicyName", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//����� �� ������� �������
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

//���� �� ���� 2 ������
//Client
builder.Services.AddScoped<IService<Client>,ClientService>();
builder.Services.AddScoped<IEntityRepository<Client>,EntityRepository<Client>>();

//Order
builder.Services.AddScoped<IService<Order>, OrderService>();
builder.Services.AddScoped<IEntityRepository<Order>,EntityRepository<Order>>();

//����� �� ���� �������
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("MyPolicyName");

app.MapControllers();

app.Run();
