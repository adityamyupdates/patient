using EF6SQLite.BusinessLayer.Interface;
using EF6SQLite.BusinessLayer.Services;
using EF6SQLite.DataAccessLayer.Interface;
using EF6SQLite.DataAccessLayer.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//PatientDBService
builder.Services.AddScoped<IPatientDBService, PatientDBService>();
builder.Services.AddScoped<IPatientBusinessService, PatientBusinessService>();

//VisitDBService
builder.Services.AddScoped<IVisitDBService, VisitDBService>();
builder.Services.AddScoped<IVisitBusinessService, VisitBusinessService>();

builder.Services.AddDbContext<DataContext>(optins =>
optins.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors();

// Named Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOrigin",
        builder =>
        {
            builder.WithOrigins("https://localhost:7074", "https://localhost:7096")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// with a named pocili
app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
