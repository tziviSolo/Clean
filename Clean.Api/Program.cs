using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Data;
using Clean.Data.Repositories;
using Clean.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicyName", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//עבור כל ישות בפרויקט צריך 2 הזרקות
builder.Services.AddScoped<IClientService,ClientService>();
builder.Services.AddScoped<IClientRepository,ClientRepository>();

//הזרקה של הדטה לפרויקט
builder.Services.AddSingleton<DataContext>();

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
