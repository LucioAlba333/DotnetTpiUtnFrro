using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Academia.WebApi.Controllers
{
	
	[Route("api/[controller]")]
	[TypeFilter(typeof(ExceptionManager))]
	[ApiController]
	public class EspecialidadController : ControllerBase
	{
		private readonly IEntityService<EspecialidadDto> _especialidadService;
		private readonly IValidator<EspecialidadDto> _especialidadDtoValidator;

		public EspecialidadController(
			IEntityService<EspecialidadDto> especialidadService, 
			IValidator<EspecialidadDto> especialidadDtoValidator)
		{
			_especialidadService = especialidadService;
			_especialidadDtoValidator = especialidadDtoValidator;
		}

		[Authorize(Policy = "especialidades.consulta")]
		[HttpGet("{id:int}")]
		public async Task<ActionResult<EspecialidadDto>> Get(int id)
		{
			var e = await _especialidadService.Get(id);
			if (e == null)
			{
				return NotFound();
			}
			return Ok(e);
		}
		[Authorize(Policy = "especialidades.consulta")]
		[HttpGet(Name = "GetAllEspecialidades")]
		public async Task<ActionResult<IEnumerable<EspecialidadDto>>> GetAll()
		{
			var e= await _especialidadService.GetAll();
			return Ok(e);
		}
		[Authorize(Policy = "especialidades.alta")]
		[HttpPost]
		public async Task<ActionResult<EspecialidadDto>> Create(EspecialidadDto especialidad)
		{
			var result = await _especialidadDtoValidator.ValidateAsync(especialidad);
			if (!result.IsValid)
			{
				var errors = result.Errors
					.Select(e => new {e.PropertyName, e.ErrorMessage} );
				return BadRequest(errors);
			}
			await _especialidadService.New(especialidad);
			return CreatedAtAction(nameof(Get), new { especialidad.Id }, especialidad);
		}
		[Authorize(Policy = "especialidades.modificacion")]
		[HttpPut("{id:int}")]
		public async Task<ActionResult> Update(int id, [FromBody] EspecialidadDto especialidad)
		{
			var result = await _especialidadDtoValidator.ValidateAsync(especialidad);
			if (!result.IsValid)
			{
				var errors = result.Errors
					.Select(e => new {e.PropertyName, e.ErrorMessage});
				return BadRequest(errors);
			}
			if (id != especialidad.Id)
				return BadRequest();
			bool up = await _especialidadService.Update(especialidad);
			if (!up)
				return NotFound();
			return NoContent();

		}
		[Authorize(Policy = "especialidades.baja")]
		[HttpDelete("{id:int}")]
		public async Task<ActionResult> Delete(int id)
		{
			bool del = await _especialidadService.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();

		}
	}

}
