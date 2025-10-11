using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class UsuarioService 
{
    private readonly PasswordEncrypter _passwordEncrypter;
    private readonly UsuarioRepository  _usuarioRepository;
    private readonly PersonaRepository  _personaRepository;
    private readonly ModuloUsuarioRepository _moduloUsuarioRepository;

    public UsuarioService(
        PasswordEncrypter passwordEncrypter,
        UsuarioRepository usuarioRepository,
        PersonaRepository personaRepository,
        ModuloUsuarioRepository moduloUsuarioRepository)
    {
        _passwordEncrypter = passwordEncrypter;
        _usuarioRepository = usuarioRepository;
        _personaRepository = personaRepository;
        _moduloUsuarioRepository = moduloUsuarioRepository;
    }

    public async Task New(UsuarioCreateDto usuarioCreateDto)
    {
        try
        {
            Persona? persona = await _personaRepository.Get(usuarioCreateDto.PersonaId);

            if (persona != null)
            {
                string passwordHash = _passwordEncrypter.Hash(usuarioCreateDto.Clave);
                Usuario usuario = new Usuario(0,persona,usuarioCreateDto.NombreUsuario,passwordHash);
                await _usuarioRepository.Add(usuario);
                await _moduloUsuarioRepository.Add(usuario);
            }
                

        }
        catch (Exception e)
        {
            throw new ArgumentException("error al crear usuario",e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _usuarioRepository.Delete(id);
        }
        catch (Exception e)
        {
            
            throw new ArgumentException("error al eliminar usuario", e);
        }
    }

    public async Task<UsuarioDto?> Get(int id)
    {
        try
        {
            Usuario? usuario = await _usuarioRepository.Get(id);
            if (usuario == null)
                return null;
            return new UsuarioDto
            {
                Id = usuario.Id,
                NombreUsuario = usuario.NombreUsuario,
                Email = usuario.Persona.Email,
            };

        }
        catch (Exception e)
        {
            throw new ArgumentException("error al obtener el usuario", e);
        }
    }

    public async Task<IEnumerable<UsuarioDto>> GetAll()
    {
        try
        {
            var usuarios = await _usuarioRepository.GetAll();
            return usuarios.Select(u => new UsuarioDto
            {
                Id = u.Id,
                NombreUsuario = u.NombreUsuario,
                Email = u.Persona.Email,
            });

        }
        catch (Exception e)
        { 
            throw new ArgumentException("error al obtener los usuarios", e);
        }
    }

    public async Task<bool> Update(UsuarioUpdateDto dto)
    {
        try
        {
            Persona? persona = await _personaRepository.Get(dto.PersonaId);
            Usuario? usuario = await _usuarioRepository.Get(dto.Id);
            if (usuario == null)
            {
                return false;
            }

            if (persona!=null)
            {
                usuario.SetPersona(persona);
            }

            if (!string.IsNullOrWhiteSpace(dto.Clave))
            {
                string passwordHash = _passwordEncrypter.Hash(dto.Clave);
                usuario.SetClave(passwordHash);
            }
            usuario.SetNombreUsuario(dto.NombreUsuario);
            return await _usuarioRepository.Update(usuario);
        }
        catch (Exception e)
        {
           throw new ArgumentException("error al actualizar usuario", e);
        }
    }
    public async Task SeedAdminUser()
    {
        
        const string adminUsername = "admin";
        const string adminPassword = "admin123";

        var usuarios = await _usuarioRepository.GetAll();
        if (usuarios.Any(u => u.NombreUsuario == adminUsername))
            return;

        var persona = await _personaRepository.Get(1);

        if (persona != null)
        {
            string passwordHash = _passwordEncrypter.Hash(adminPassword);
            Usuario usuario = new Usuario(0, persona, adminUsername, passwordHash);
            await _usuarioRepository.Add(usuario);
            await _moduloUsuarioRepository.Add(usuario);
        }
    }

}