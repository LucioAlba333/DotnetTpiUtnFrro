using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[TypeFilter(typeof(ExceptionManager))]
public class InscripcionController : ControllerBase
{
    private readonly IEntityService<InscripcionDto> _service;

    public InscripcionController(IEntityService<InscripcionDto> service)
    {
        _service = service;
    }

    [Authorize(Policy = "inscripciones.consulta")]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<InscripcionDto>> Get(int id)
    {
        var dto = await _service.Get(id);
        if (dto == null)
            return NotFound();
        return Ok(dto);
    }

    [Authorize(Policy = "inscripciones.consulta")]
    [HttpGet(Name = "GetAllInscripciones")]
    public async Task<ActionResult<IEnumerable<InscripcionDto>>> GetAll()
    {
        var dtos = await _service.GetAll();
        return Ok(dtos);
    }

    [Authorize(Policy = "inscripciones.alta")]
    [HttpPost]
    public async Task<ActionResult<InscripcionDto>> Create(InscripcionDto dto)
    {
        await _service.New(dto);
        return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
    }

    [Authorize(Policy = "inscripciones.modificacion")]
    [HttpPut("{id:int}")]
    public async Task<ActionResult<InscripcionDto>> Update(int id, [FromBody] InscripcionDto dto)
    {
        if (id != dto.Id)
            return BadRequest();

        bool updated = await _service.Update(dto);
        if (!updated)
            return NotFound();

        return NoContent();
    }

    [Authorize(Policy = "inscripciones.baja")]
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<InscripcionDto>> Delete(int id)
    {
        bool deleted = await _service.Delete(id);
        if (!deleted)
            return NotFound();
        return NoContent();
    }
}