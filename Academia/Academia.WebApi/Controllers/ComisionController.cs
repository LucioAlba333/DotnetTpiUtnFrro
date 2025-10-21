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
}