using Academia.Dtos;
using Academia.Models;
using Academia.Services;
using Academia.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlanController : ControllerBase
	{
		private readonly IEntityService<PlanDto> _planService;
		private readonly IEntityService<EspecialidadDto> _especialidadService;

		public PlanController(IEntityService<PlanDto> p, IEntityService<EspecialidadDto> e)
		{
			_planService = p;
			_especialidadService = e;
		}
		[HttpGet("{id:int}")]
		public ActionResult<PlanDto> Get(int id)
		{
			var p = _planService.Get(id);
			if (p == null)
			{
				return NotFound();
			}
			/* actualizo la descripcion antes de la especialidad para reflejar cambios.
			 probablemente lo cambie al implementar el acceso a datos*/ 
			var e = _especialidadService.Get(p.EspecialidadId);
			if (e != null)
				p.DescripcionEspecialidad = e.Descripcion;
            else
            {
                p.DescripcionEspecialidad = "Sin Especialidad";
            }
            return Ok(p);

		}
		[HttpGet(Name = "GetAllPlanes")]
		public ActionResult<IEnumerable<PlanDto>> GetAll()
		{
			var planes =_planService.GetAll().ToList();
			/*Lo mismo que el anterior comentario*/
			foreach (var p in planes)
			{
				var especialidad = _especialidadService.Get(p.EspecialidadId);
				if (especialidad != null)
					p.DescripcionEspecialidad = especialidad.Descripcion;
				else
				{
					p.DescripcionEspecialidad = "Sin Especialidad";
				}
			}
			return Ok(planes);
			
		}
		[HttpPost]
		public ActionResult<PlanDto> Create(PlanDto plan)
		{
			var e = _especialidadService.Get(plan.EspecialidadId);
			if (e == null)
				return NotFound();
			plan.DescripcionEspecialidad = e.Descripcion;
			_planService.New(plan);
			return CreatedAtAction(nameof(Get), new { Id = plan.Id }, plan);
		}
		[HttpPut("{id:int}")]
		public ActionResult Update(int id, [FromBody] PlanDto plan)
		{
			if (id != plan.Id)
				return BadRequest();
			var especialidad = _especialidadService.Get(plan.EspecialidadId);
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
