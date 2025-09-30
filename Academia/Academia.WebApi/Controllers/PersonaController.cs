using Academia.Dtos;
using Academia.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class PersonaController : ControllerBase
{
    private readonly IEntityService<PersonaDto>  _personaService;
    private readonly IValidator<PersonaDto> _personaDtoValidator;

    public PersonaController(
        IEntityService<PersonaDto> personaService,
        IValidator<PersonaDto> personaDtoValidator)
    {
        _personaService = personaService;
        _personaDtoValidator = personaDtoValidator;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<PersonaDto>> Get(int id)
    {
        var p =  await _personaService.Get(id);
        if (p == null)
        {
            return NotFound();
        }
        return Ok(p);
    }

    [HttpGet(Name = "GetAllPersonas")]
    public async Task<ActionResult<IEnumerable<PersonaDto>>> GetAll()
    {
        var personas = await _personaService.GetAll();
        return Ok(personas);
    }

    [HttpPost]
    public async Task<ActionResult<PersonaDto>> Create(PersonaDto p)
    {
        var result = await _personaDtoValidator.ValidateAsync(p);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(e => new {e.PropertyName, e.ErrorMessage});
            return BadRequest(errors);
        }

        await _personaService.New(p);
        return CreatedAtAction(nameof(Get), new { id = p.Id }, p);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<PersonaDto>> Update(int id, [FromBody] PersonaDto p)
    {
        var result = await _personaDtoValidator.ValidateAsync(p);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(e => new {e.PropertyName, e.ErrorMessage});
            return BadRequest(errors);
        }
        if (id != p.Id)
            return BadRequest();
        bool up =  await _personaService.Update(p);
        if (!up)
            return NotFound();
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        bool del = await _personaService.Delete(id);
        if(!del)
        {
            return NotFound();
        }
        return NoContent();
    }
    
    
}