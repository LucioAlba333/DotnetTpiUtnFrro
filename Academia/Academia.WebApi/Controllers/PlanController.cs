using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[TypeFilter(typeof(ExceptionManager))]
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
		public async Task<ActionResult<PlanDto>> Get(int id)
		{
			var p = await _planService.Get(id);
			if (p == null)
			{
				return NotFound();
			}
            return Ok(p);

		}
		[HttpGet(Name = "GetAllPlanes")]
		public async Task<ActionResult<IEnumerable<PlanDto>>> GetAll()
		{
			var planes = await _planService.GetAll();
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
			await _planService.New(plan);
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
			var especialidad = await _especialidadService.Get(plan.EspecialidadId);
			if (especialidad == null)
				return NotFound();
			bool up = await _planService.Update(plan);
			if (!up)
				return NotFound();
			return NoContent();
		}
		[HttpDelete("{id:int}")]
		public async Task<ActionResult> Delete(int id)
		{
			bool del = await _planService.Delete(id);
			if (!del)
				return NotFound();
			return NoContent();
		}

	}
}
