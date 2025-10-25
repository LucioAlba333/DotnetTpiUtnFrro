using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[TypeFilter(typeof(ExceptionManager))]
public class DocenteCursosController : ControllerBase
{
    private readonly IEntityService<DocenteCursosDto> _service;

    public DocenteCursosController(IEntityService<DocenteCursosDto> service)
    {
        _service = service;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<DocenteCursosDto>> Get(int id)
    {
        var dto = await _service.Get(id);
        if (dto == null)
            return NotFound();
        return Ok(dto);
    }

    [HttpGet(Name = "GetAllDocenteCursos")]
    public async Task<ActionResult<IEnumerable<DocenteCursosDto>>> GetAll()
    {
        var dtos = await _service.GetAll();
        return Ok(dtos);
    }

    [HttpPost]
    public async Task<ActionResult<DocenteCursosDto>> Create(DocenteCursosDto dto)
    {
        await _service.New(dto);
        return CreatedAtAction(nameof(Get), new { id = dto.Id }, dto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<DocenteCursosDto>> Update(int id, [FromBody] DocenteCursosDto dto)
    {
        if (id != dto.Id)
            return BadRequest();

        bool updated = await _service.Update(dto);
        if (!updated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<DocenteCursosDto>> Delete(int id)
    {
        bool deleted = await _service.Delete(id);
        if (!deleted)
            return NotFound();
        return NoContent();
    }
}