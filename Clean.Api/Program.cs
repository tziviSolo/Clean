using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Service;
using Clean.Data;
using Clean.Data.Repositories;
using Clean.Core.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicyName", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//ניהול כל הישויות בפרויקט
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

//עבור כל ישות 2 הזרקות
//Client
builder.Services.AddScoped<IClientService,ClientService>();
builder.Services.AddScoped<IEntityRepository<Client>,EntityRepository<Client>>();

//Order
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IEntityRepository<Order>,EntityRepository<Order>>();

//הזרקה של הדטה לפרויקט
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
