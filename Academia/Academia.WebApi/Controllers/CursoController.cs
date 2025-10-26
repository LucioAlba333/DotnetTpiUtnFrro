using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[TypeFilter(typeof(ExceptionManager))]
public class CursoController : ControllerBase
{
    private readonly IEntityService<CursoDto> _cursoService;
    private readonly IValidator<CursoDto> _cursoValidator;

    public CursoController(
        IEntityService<CursoDto> cursoService,
        IValidator<CursoDto> cursoValidator)
    {
        _cursoService = cursoService;
        _cursoValidator = cursoValidator;
    }

    [Authorize(Policy = "cursos.consulta")]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<CursoDto>> Get(int id)
    {
        var cursoDto = await _cursoService.Get(id);
        if (cursoDto == null)
            return NotFound();
        return Ok(cursoDto);
    }

    [Authorize(Policy = "cursos.consulta")]
    [HttpGet(Name = "GetAllCursos")]
    public async Task<ActionResult<IEnumerable<CursoDto>>> GetAll()
    {
        var cursoDtos = await _cursoService.GetAll();
        return Ok(cursoDtos);
    }

    [Authorize(Policy = "cursos.alta")]
    [HttpPost]
    public async Task<ActionResult<CursoDto>> Create(CursoDto cursoDto)
    {
        var result = await _cursoValidator.ValidateAsync(cursoDto);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(e => new { e.PropertyName, e.ErrorMessage });
            return BadRequest(errors);
        }

        await _cursoService.New(cursoDto);
        return CreatedAtAction(nameof(Get), new { id = cursoDto.Id }, cursoDto);
    }

    [Authorize(Policy = "cursos.modificacion")]
    [HttpPut("{id:int}")]
    public async Task<ActionResult<CursoDto>> Update(int id, [FromBody] CursoDto cursoDto)
    {
        var result = await _cursoValidator.ValidateAsync(cursoDto);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(e => new { e.PropertyName, e.ErrorMessage });
            return BadRequest(errors);
        }

        if (id != cursoDto.Id)
        {
            return BadRequest();
        }

        bool updated = await _cursoService.Update(cursoDto);
        if (!updated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [Authorize(Policy = "cursos.baja")]
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<CursoDto>> Delete(int id)
    {
        bool deleted = await _cursoService.Delete(id);
        if (!deleted)
            return NotFound();
        return NoContent();
    }
}
