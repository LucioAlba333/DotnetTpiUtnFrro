using Academia.Data.Interfaces;
using Academia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlanController : ControllerBase
	{
		private readonly ICrud<Plan> _planData;
		private readonly ICrud<Especialidad> _especialiadData;

		public PlanController(ICrud<Plan> p, ICrud<Especialidad> e)
		{
			_planData = p;
			_especialiadData = e;
		}
		[HttpGet("{id}")]
		public ActionResult<Plan> Get(int id)
		{
			var p = _planData.Get(id);
			if (p == null)
			{
				return NotFound();
			}
			return Ok(p);

		}
		[HttpGet(Name = "GetAllPlanes")]
		public ActionResult<IEnumerable<Plan>> GetAll()
		{
			return _planData.GetAll().ToList();
		}
		[HttpPost]
		public ActionResult<Plan> Create(Plan plan)
		{
			var e = _especialiadData.Get(plan.IdEspecialidad);
			if (e == null)
				return NotFound();
			_planData.New(plan);
			return CreatedAtAction(nameof(Get), new { Id = plan.Id }, plan);
		}
		[HttpPut("{id}")]
		public ActionResult Update(int id, [FromBody] Plan plan)
		{
			if (id != plan.Id)
				return BadRequest();
			var especialidad = _especialiadData.Get(plan.IdEspecialidad);
			if (especialidad == null)
				return NotFound();
			bool up = _planData.Update(plan);
			if (!up)
				return NotFound();
			return NoContent();
		}
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			bool del = _planData.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();
		}

	}
}
