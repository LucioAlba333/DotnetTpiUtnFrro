using Academia.Dtos;
using Academia.Services;
using Academia.WebApi.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [Authorize(Policy = "usuarios.consulta")]
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UsuarioDto>> Get(int id)
        {
            var usuario = await _usuarioService.Get(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [Authorize(Policy = "usuarios.consulta")]
        [HttpGet(Name = "GetAll Usuarios")]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        {
            var usuarios = await _usuarioService.GetAll();
            return Ok(usuarios);
        }

        [Authorize(Policy = "usuarios.alta")]
        [HttpPost]
        public async Task<ActionResult<UsuarioCreateDto>> Create(UsuarioCreateDto usuarioCreateDto)
        {
            await _usuarioService.New(usuarioCreateDto);
            return Ok();
        }

        [AllowAnonymous]
        [HttpPut("{id:int}")]
        public async Task<ActionResult<UsuarioUpdateDto>> Update(int id, [FromBody] UsuarioUpdateDto usuarioUpdateDto)
        {
            if(id != usuarioUpdateDto.Id)
            {
                return BadRequest();
            }
            bool up = await _usuarioService.Update(usuarioUpdateDto);
            if (!up)
            {
                return NotFound();
            }
            return NoContent();
        }

        [Authorize(Policy = "usuarios.baja")]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            bool del = await _usuarioService.Delete(id);
            if (!del)
            {
                return NotFound();
            }
            return NoContent();
            
        }
    }
    
}