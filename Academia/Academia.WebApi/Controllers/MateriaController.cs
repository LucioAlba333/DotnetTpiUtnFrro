using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;

[Route("api/[controller]")]
[TypeFilter(typeof(ExceptionManager))]
[ApiController]
public class MateriaController : ControllerBase
{
    private readonly IEntityService<MateriaDto> _materiaService;

    public MateriaController(IEntityService<MateriaDto> materiaService)
    {
        _materiaService = materiaService;
    }

    [Authorize(Policy = "materias.consulta")]
    [HttpGet("{id:int}")]
    public async Task<ActionResult<MateriaDto>> Get(int id)
    {
        var m = await _materiaService.Get(id);
        if (m == null)
        {
            return NotFound();
        }
        return Ok(m);
    }

    [Authorize(Policy = "materias.consulta")]
    [HttpGet(Name = "GetAllMaterias")]
    public async Task<ActionResult<IEnumerable<MateriaDto>>> GetAllMaterias()
    {
        var m = await _materiaService.GetAll();
        return Ok(m);
    }

    [Authorize(Policy = "materias.alta")]
    [HttpPost]
    public async Task<ActionResult<MateriaDto>> Create(MateriaDto materiaDto)
    {
        await _materiaService.New(materiaDto);
        return CreatedAtAction(nameof(Get), new { id = materiaDto.Id }, materiaDto);
    }

    [Authorize(Policy = "materias.modificacion")]
    [HttpPut("{id:int}")]
    public async Task<ActionResult> Update(int id, [FromBody] MateriaDto materiaDto)
    {
        if (id != materiaDto.Id)
        {
            return BadRequest();
        }
        bool up = await _materiaService.Update(materiaDto);
        if (!up)
        {
            return NotFound();
        }
        return Ok();
    }

    [Authorize(Policy = "materias.baja")]
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        bool del = await _materiaService.Delete(id);
        if (!del)
        {
            return NotFound();
        }
        return Ok();
    }
}