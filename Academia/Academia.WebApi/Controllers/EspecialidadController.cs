using Academia.Dtos;
using Academia.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
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
		public ActionResult<EspecialidadDto> Get(int id)
		{
			var e = _especialidadService.Get(id);
			if (e == null)
			{
				return NotFound();
			}
			return Ok(e);
		}
		[HttpGet(Name = "GetAllEspecialidades")]
		public ActionResult<IEnumerable<EspecialidadDto>> GetAll()
		{
			return _especialidadService.GetAll().ToList();
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
			_especialidadService.New(especialidad);
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
			bool up = _especialidadService.Update(especialidad);
			if (!up)
				return NotFound();
			return NoContent();

		}
		[HttpDelete("{id:int}")]
		public ActionResult Delete(int id)
		{
			bool del = _especialidadService.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();

		}
	}

}
