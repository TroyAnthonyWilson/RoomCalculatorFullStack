using Microsoft.EntityFrameworkCore;
using RoomCalculatorAPI.DbModel;
using RoomCalculatorAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<RoomCalculatorDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlServerConnStr"));
});

//add cores
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
    {
        policy.WithOrigins("http://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddScoped<IRoomCalculatorService, RoomCalculatorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
