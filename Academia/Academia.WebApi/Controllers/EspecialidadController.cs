using Academia.Dtos;
using Academia.Models;
using Academia.Services;
using Academia.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EspecialidadController : ControllerBase
	{
		private readonly IEntityService<EspecialidadDto> _especialidadService;

		public EspecialidadController(IEntityService<EspecialidadDto> especialidadService)
		{
			_especialidadService = especialidadService;
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
		public ActionResult<EspecialidadDto> Create(EspecialidadDto e)
		{
			_especialidadService.New(e);
			return CreatedAtAction(nameof(Get), new { Id = e.Id }, e);
		}
		[HttpPut("{id:int}")]
		public ActionResult Update(int id, [FromBody] EspecialidadDto e)
		{
			if (id != e.Id)
				return BadRequest();
			bool up = _especialidadService.Update(e);
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
