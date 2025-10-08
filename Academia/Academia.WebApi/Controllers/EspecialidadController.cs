using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Academia.WebApi.Controllers
{
	[Authorize]
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
		[HttpGet(Name = "GetAllEspecialidades")]
		public async Task<ActionResult<IEnumerable<EspecialidadDto>>> GetAll()
		{
			var e= await _especialidadService.GetAll();
			return Ok(e);
		}
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
