using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.Services;
using Academia.Validaciones;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
