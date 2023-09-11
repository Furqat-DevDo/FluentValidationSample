using FluentValidation;
using FluentValidationExample.Data;
using FluentValidationExample.Models;
using FluentValidationExample.Validations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDb>(options =>
{
    options.UseSqlite("Data Source = app.db");
});

builder.Services.AddScoped<IValidator<AdrressModel>, AdrressValidator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();