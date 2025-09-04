using Academia.Models;
using Academia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlanController : ControllerBase
	{
		private readonly PlanService _planService;
		private readonly EspecialidadService _especialidadService;

		public PlanController(PlanService p, EspecialidadService e)
		{
			_planService = p;
			_especialidadService = e;
		}
		[HttpGet("{id:int}")]
		public ActionResult<Plan> Get(int id)
		{
			var p = _planService.Get(id);
			if (p == null)
			{
				return NotFound();
			}
			/* actualizo la descripcion antes de la especialidad para reflejar cambios.
			 probablemente lo cambie al implementar el acceso a datos*/ 
			var e = _especialidadService.Get(p.IdEspecialidad);
			if (e != null)
				p.EspecialidadDescripcion = e.Descripcion;
            else
            {
                p.EspecialidadDescripcion = "Sin Especialidad";
            }
            return Ok(p);

		}
		[HttpGet(Name = "GetAllPlanes")]
		public ActionResult<IEnumerable<Plan>> GetAll()
		{
			var planes =_planService.GetAll().ToList();
			/*Lo mismo que el anterior comentario*/
			foreach (var p in planes)
			{
				var especialidad = _especialidadService.Get(p.IdEspecialidad);
				if (especialidad != null)
					p.EspecialidadDescripcion = especialidad.Descripcion;
				else
				{
					p.EspecialidadDescripcion = "Sin Especialidad";
				}
			}
			return Ok(planes);
			
		}
		[HttpPost]
		public ActionResult<Plan> Create(Plan plan)
		{
			var e = _especialidadService.Get(plan.IdEspecialidad);
			if (e == null)
				return NotFound();
			_planService.New(plan);
			return CreatedAtAction(nameof(Get), new { Id = plan.Id }, plan);
		}
		[HttpPut("{id:int}")]
		public ActionResult Update(int id, [FromBody] Plan plan)
		{
			if (id != plan.Id)
				return BadRequest();
			var especialidad = _especialidadService.Get(plan.IdEspecialidad);
			if (especialidad == null)
				return NotFound();
			bool up = _planService.Update(plan);
			if (!up)
				return NotFound();
			return NoContent();
		}
		[HttpDelete("{id:int}")]
		public ActionResult Delete(int id)
		{
			bool del = _planService.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();
		}

	}
}
