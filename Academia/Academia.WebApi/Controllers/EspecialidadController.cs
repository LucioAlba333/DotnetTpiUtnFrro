using Academia.Models;
using Academia.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EspecialidadController : ControllerBase
	{
		private readonly ICrud<Especialidad> _especialidadService;

		public EspecialidadController(ICrud<Especialidad> especialidadService)
		{
			_especialidadService = especialidadService;
		}

		[HttpGet("{id:int}")]
		public ActionResult<Especialidad> Get(int id)
		{
			var e = _especialidadService.Get(id);
			if (e == null)
			{
				return NotFound();
			}
			return Ok(e);
		}
		[HttpGet(Name = "GetAllEspecialidades")]
		public ActionResult<IEnumerable<Especialidad>> GetAll()
		{
			return _especialidadService.GetAll().ToList();
		}
		[HttpPost]
		public ActionResult<Especialidad> Create(Especialidad e)
		{
			_especialidadService.New(e);
			return CreatedAtAction(nameof(Get), new { Id = e.Id }, e);
		}
		[HttpPut("{id:int}")]
		public ActionResult Update(int id, [FromBody] Especialidad e)
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
