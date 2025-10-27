using System.Text;
using Academia.Data;
using Academia.Dtos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Academia.Services.Interfaces;
using Academia.Services;
using Academia.Validaciones;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
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
var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options =>
	{
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuer = true,
			ValidIssuer = jwtSettings.Issuer,
			ValidateAudience = true,
			ValidAudience = jwtSettings.Audience,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
			ClockSkew = TimeSpan.Zero
		};
	});

builder.Services.AddAuthorization(options =>
{
	options.FallbackPolicy = new AuthorizationPolicyBuilder()
		.RequireAuthenticatedUser()
		.Build();


	var modulos = new[] { "especialidades", "planes", "usuarios", "personas", "materias", "comisiones", "cursos", "docentescursos", "inscripciones" };
	var acciones = new[] { "consulta", "alta", "modificacion", "baja" };

	foreach (var modulo in modulos)
	{
		foreach (var accion in acciones)
		{
			var claimName = $"{modulo}.{accion}";
			options.AddPolicy(claimName, policy =>
				policy.RequireClaim("permission", claimName));
		}
	}
});
builder.Services.AddScoped<PasswordEncrypter>();
builder.Services.AddScoped<PlanRepository>();
builder.Services.AddScoped<MateriaRepository>();
builder.Services.AddScoped<EspecialidadRepository>();
builder.Services.AddScoped<PersonaRepository>();
builder.Services.AddScoped<UsuarioRepository>();
builder.Services.AddScoped<ModuloUsuarioRepository>();
builder.Services.AddScoped<ComisionRepository>();
builder.Services.AddScoped<CursoRepository>();
builder.Services.AddScoped<DocenteCursosRepository>();
builder.Services.AddScoped<InscripcionRepository>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<PersonaService>();
builder.Services.AddScoped<IEntityService<EspecialidadDto>, EspecialidadService>();
builder.Services.AddScoped<IEntityService<PlanDto>, PlanService>();
builder.Services.AddScoped<IEntityService<MateriaDto>, MateriaService>();
builder.Services.AddScoped<IEntityService<ComisionDto>, ComisionService>();
builder.Services.AddScoped<IEntityService<CursoDto>, CursoService>();
builder.Services.AddScoped<IEntityService<DocenteCursosDto>, DocenteCursosService>();
builder.Services.AddScoped<IEntityService<InscripcionDto>, InscripcionService>();
builder.Services.AddScoped<IValidator<EspecialidadDto>, EspecialidadDtoValidator>();
builder.Services.AddScoped<IValidator<PlanDto>, PlanDtoValidator>();
builder.Services.AddScoped<IValidator<ComisionDto>, ComisionDtoValidator>();
builder.Services.AddScoped<IValidator<CursoDto>, CursoDtoValidator>();
builder.Services.AddScoped<IValidator<PersonaDto>, PersonaDtoValidator>();
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

 using (var scope = app.Services.CreateScope())
{
	var usuarioService = scope.ServiceProvider.GetRequiredService<UsuarioService>();
	await usuarioService.SeedAdminUser();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
