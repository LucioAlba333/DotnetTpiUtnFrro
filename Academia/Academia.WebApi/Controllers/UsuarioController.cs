using Academia.Dtos;
using Academia.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academia.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

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

        [HttpGet(Name = "GetAll Usuarios")]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        {
            var usuarios = await _usuarioService.GetAll();
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioCreateDto>> Create(UsuarioCreateDto usuarioCreateDto)
        {
            await _usuarioService.New(usuarioCreateDto);
            return Ok();
        }

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