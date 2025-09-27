using Academia.Data;
using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.Services;
using Academia.Validaciones;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Context>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<JwtSettings>(
	builder.Configuration.GetSection("JwtSettings")
);

builder.Services.AddScoped<PlanRepository>();
builder.Services.AddScoped<EspecialidadRepository>();
builder.Services.AddScoped<IEntityService<EspecialidadDto>, EspecialidadService>();
builder.Services.AddScoped<IEntityService<PlanDto>, PlanService>();
builder.Services.AddScoped<IValidator<EspecialidadDto>, EspecialidadDtoValidator>();
builder.Services.AddScoped<IValidator<PlanDto>, PlanDtoValidator>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<Context>();
	await context.InitDatabase();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
