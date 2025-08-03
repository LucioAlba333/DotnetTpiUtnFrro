using Academia.Data.Interfaces;
using Academia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EspecialidadController : ControllerBase
	{
		private readonly ICrud<Especialidad> _especialidadData;

		public EspecialidadController(ICrud<Especialidad> especialidadData)
		{
			_especialidadData = especialidadData;
		}

		[HttpGet("{id}")]
		public ActionResult<Especialidad> Get(int id)
		{
			var e = _especialidadData.Get(id);
			if (e == null)
			{
				return NotFound();
			}
			return Ok(e);
		}
		[HttpGet(Name = "GetAllEspecialidades")]
		public ActionResult<IEnumerable<Especialidad>> GetAll()
		{
			return _especialidadData.GetAll().ToList();
		}
		[HttpPost]
		public ActionResult<Especialidad> Create(Especialidad e)
		{
			_especialidadData.New(e);
			return CreatedAtAction(nameof(Get), new { Id = e.Id }, e);
		}
		[HttpPut("{id}")]
		public ActionResult Update(int id, [FromBody] Especialidad e)
		{
			if (id != e.Id)
				return BadRequest();
			bool up = _especialidadData.Update(e);
			if (!up)
				return NotFound();
			return NoContent();

		}
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			bool del = _especialidadData.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();

		}
	}

}
