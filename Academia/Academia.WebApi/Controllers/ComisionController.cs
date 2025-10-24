using Academia.Dtos;
using Academia.Services.Interfaces;
using Academia.WebApi.Filters;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
[TypeFilter(typeof(ExceptionManager))]
public class ComisionController : ControllerBase
{
    private readonly IEntityService<ComisionDto> _comisionService;
    private readonly IValidator<ComisionDto> _comisionValidator;

    public ComisionController(
        IEntityService<ComisionDto> comisionService,
        IValidator<ComisionDto> comisionValidator)
    {
        _comisionService = comisionService;
        _comisionValidator = comisionValidator;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ComisionDto>> Get(int id)
    {
        var comisionDto = await _comisionService.Get(id);
        if (comisionDto == null)
            return NotFound();
        return Ok(comisionDto);
    }

    [HttpGet(Name = "GetAllComisiones")]
    public async Task<ActionResult<IEnumerable<ComisionDto>>> GetAll()
    {
        var comisionDtos = await _comisionService.GetAll();
        return Ok(comisionDtos);
    }

    [HttpPost]
    public async Task<ActionResult<ComisionDto>> Create(ComisionDto comisionDto)
    {
        var result =  await _comisionValidator.ValidateAsync(comisionDto);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(e => new {e.PropertyName, e.ErrorMessage} );
            return BadRequest(errors);
        }
        await _comisionService.New(comisionDto);
        return CreatedAtAction(nameof(Get), new { id = comisionDto.Id }, comisionDto);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ComisionDto>> Update(int id, [FromBody] ComisionDto comisionDto)
    {
        var result = await _comisionValidator.ValidateAsync(comisionDto);
        if (!result.IsValid)
        {
            var errors = result.Errors
                .Select(e => new {e.PropertyName, e.ErrorMessage});
            return BadRequest(errors);
        }

        if (id != comisionDto.Id)
        {
            return BadRequest();
        }

        bool up = await _comisionService.Update(comisionDto);
        if (!up)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ComisionDto>> Delete(int id)
    {
        bool del = await _comisionService.Delete(id);
        if (!del)
            return NotFound();
        return NoContent();
    }
}