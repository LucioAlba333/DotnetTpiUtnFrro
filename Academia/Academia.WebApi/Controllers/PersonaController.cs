using Academia.Dtos;
using Academia.Services;
using Academia.WebApi.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;


[Route("api/[controller]")]
[TypeFilter(typeof(ExceptionManager))]
[ApiController]
public class PersonaController : ControllerBase
{
    private readonly PersonaService  _personaService;
    private readonly UsuarioService  _usuarioService;
    private readonly IValidator<PersonaDto> _personaDtoValidator;

    public PersonaController(
        PersonaService personaService,
        IValidator<PersonaDto> personaDtoValidator, UsuarioService usuarioService)
    {
        _personaService = personaService;
        _personaDtoValidator = personaDtoValidator;
        _usuarioService = usuarioService;
    }

    [Authorize(Policy = "personas.consulta")]
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
    [Authorize(Policy = "personas.consulta")]
    [HttpGet("alumnos")]
    public async Task<ActionResult<IEnumerable<PersonaDto>>> GetAllAlumnos()
    {
        var personas = await _personaService.GetAlumnos();
        return Ok(personas);
    }
    
    [Authorize(Policy = "personas.consulta")]
    [HttpGet("profesores")]
    public async Task<ActionResult<IEnumerable<PersonaDto>>> GetAllProfesores()
    {
        var personas = await _personaService.GetProfesores();
        return Ok(personas);
    }
    
    [Authorize(Policy = "personas.consulta")]
    [HttpGet(Name = "GetAllPersonas")]
    public async Task<ActionResult<IEnumerable<PersonaDto>>> GetAll()
    {
        var personas = await _personaService.GetAll();
        return Ok(personas);
    }
    
    [Authorize(Policy = "personas.alta")]
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

    [Authorize(Policy = "personas.modificacion")]
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

    [Authorize(Policy = "personas.baja")]
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
    [Authorize]
    [HttpGet("actual")]
    public async Task<ActionResult<PersonaDto>> GetPersonaActual()
    {
        var username = User.Identity?.Name;
        if (string.IsNullOrEmpty(username))
            return Unauthorized();

        var persona = await _usuarioService.GetPersonaByUsername(username);
        if (persona == null)
            return NotFound();
        
        return Ok(persona);
    }
    
}