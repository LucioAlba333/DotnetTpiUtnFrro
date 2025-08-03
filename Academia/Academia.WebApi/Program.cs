using Academia.Data;
using Academia.Data.Interfaces;
using Academia.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICrud<Especialidad>, EspecialidadData>();
builder.Services.AddSingleton<ICrud<Plan>, PlanData>();
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
