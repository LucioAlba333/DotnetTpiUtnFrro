using Academia.Data;
using Academia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EspecialidadController : ControllerBase
	{
		[HttpGet("{id}")]
		public ActionResult<Especialidad> Get(int id)
		{
			var e = EspecialidadData.Get(id);
			if (e == null)
			{
				return NotFound();
			}
			return Ok(e);
		}
		[HttpGet(Name = "GetAll")]
		public ActionResult<IEnumerable<Especialidad>> GetAll()
		{
			return EspecialidadData.GetAll().ToList();
		}
		[HttpPost]
		public ActionResult<Especialidad> Create(Especialidad e)
		{
			EspecialidadData.New(e);
			return CreatedAtAction(nameof(Get), new { Id = e.Id }, e);
		}
		[HttpPut("{id}")]
		public ActionResult Update(int id, [FromBody] Especialidad e)
		{
			if (id != e.Id)
				return BadRequest();
			EspecialidadData.Update(e);
			return NoContent();

		}
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			bool del = EspecialidadData.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();

		}
	}

}
