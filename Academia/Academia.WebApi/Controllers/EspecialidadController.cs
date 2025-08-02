using Academia.Data.Interfaces;
using Academia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
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
		[HttpGet(Name = "GetAll")]
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
			_especialidadData.Update(e);
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
