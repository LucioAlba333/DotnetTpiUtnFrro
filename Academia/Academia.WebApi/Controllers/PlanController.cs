using Academia.Dtos;
using Academia.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlanController : ControllerBase
	{
		private readonly IEntityService<PlanDto> _planService;
		private readonly IEntityService<EspecialidadDto> _especialidadService;
		private readonly IValidator<PlanDto> _planDtoValidator;

		public PlanController(IEntityService<PlanDto> p, 
			IEntityService<EspecialidadDto> e, 
			IValidator<PlanDto> planDtoValidator)
		{
			_planService = p;
			_especialidadService = e;
			_planDtoValidator = planDtoValidator;
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
		public async Task<ActionResult<PlanDto>> Create(PlanDto plan)
		{
			
			var result = await _planDtoValidator.ValidateAsync(plan);
			if (!result.IsValid)
			{
				var errors = result.Errors
					.Select(e => new {e.PropertyName, e.ErrorMessage});
				return BadRequest(errors);
			}
			var e = _especialidadService.Get(plan.EspecialidadId);
			if (e == null)
				return NotFound("el plan no tiene una especialidad valida");
			plan.DescripcionEspecialidad = e.Descripcion;
			_planService.New(plan);
			return CreatedAtAction(nameof(Get), new { plan.Id }, plan);
		}
		[HttpPut("{id:int}")]
		public async Task<ActionResult> Update(int id, [FromBody] PlanDto plan)
		{
			var result = await _planDtoValidator.ValidateAsync(plan);
			if (!result.IsValid)
			{
				var errors = result.Errors
					.Select(e => new {e.PropertyName, e.ErrorMessage});
				return BadRequest(errors);
			}
			if (id != plan.Id)
				return BadRequest();
			if (ModelState.IsValid == false)
				return BadRequest(ModelState);
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
