using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class PersonaService : IEntityService<PersonaDto>
{
    private readonly PersonaRepository  _personaRepository;
    private readonly PlanRepository _planRepository;

    public PersonaService(PersonaRepository personaRepository, PlanRepository planRepository)
    {
        _personaRepository = personaRepository;
        _planRepository = planRepository;
    }

    public async Task New(PersonaDto dto)
    {
        try
        {
            if (await _personaRepository.EmailExists(dto.Email))
            {
                throw new ArgumentException("ya hay una persona con ese Email");
            }

            Plan? plan = null;
            if (dto.IdPlan is int idPlan)
            {
                plan = await _planRepository.Get(idPlan);
            }

            var legajo = await _personaRepository.GenerarLegajo();
            Persona persona = new Persona(
                id: dto.Id,
                nombre: dto.Nombre,
                apellido: dto.Apellido,
                direccion: dto.Direccion,
                telefono: dto.Telefono,
                email: dto.Email,
                legajo: legajo,
                fechaNacimiento: dto.FechaNacimiento,
                tipoPersona: dto.TipoPersona,
                plan: plan);
            await _personaRepository.Add(persona);

        }
        catch (ArgumentException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al crear persona", e);
        }
    }

    public async Task<bool> Delete(int id)
    {
        try
        {
            return await _personaRepository.Delete(id);

        }
        catch (Exception e)
        {
            throw new ApplicationException("error al eliminar persona", e);
        }
    }

    public async Task<PersonaDto?> Get(int id)
    {
        try
        {
            Persona? persona = await _personaRepository.Get(id);
            if (persona == null)
                return null;
            return new PersonaDto
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Direccion = persona.Direccion,
                Telefono = persona.Telefono,
                Email = persona.Email,
                Legajo = persona.Legajo,
                FechaNacimiento = persona.FechaNacimiento,
                TipoPersona = persona.TipoPersona.ToString(),
                IdPlan = persona.IdPlan,
                DescripcionPlan = persona.Plan?.Descripcion,
            };

        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener las persona", e);
        }
    }

    public async Task<IEnumerable<PersonaDto>> GetAll()
    {
        try
        {
            var personas = await _personaRepository.GetAll();
            return personas.Select(p => new PersonaDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Direccion = p.Direccion,
                Telefono = p.Telefono,
                Email = p.Email,
                Legajo = p.Legajo,
                FechaNacimiento = p.FechaNacimiento,
                TipoPersona = p.TipoPersona.ToString(),
                IdPlan = p.IdPlan,
                DescripcionPlan = p.Plan?.Descripcion,
            });


        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener las personas", e);
        }
    }

    public async Task<IEnumerable<PersonaDto>> GetAlumnos()
    {
        try
        {
            var personas = await _personaRepository.GetAlumnos();
            return personas.Select(p => new PersonaDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Direccion = p.Direccion,
                Telefono = p.Telefono,
                Email = p.Email,
                Legajo = p.Legajo,
                FechaNacimiento = p.FechaNacimiento,
                TipoPersona = p.TipoPersona.ToString(),
                IdPlan = p.IdPlan,
                DescripcionPlan = p.Plan?.Descripcion,
            });


        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener las personas", e);
        }
    }
    public async Task<IEnumerable<PersonaDto>> GetProfesores()
    {
        try
        {
            var personas = await _personaRepository.GetProfesores();
            return personas.Select(p => new PersonaDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Direccion = p.Direccion,
                Telefono = p.Telefono,
                Email = p.Email,
                Legajo = p.Legajo,
                FechaNacimiento = p.FechaNacimiento,
                TipoPersona = p.TipoPersona.ToString(),
                IdPlan = p.IdPlan,
                DescripcionPlan = p.Plan?.Descripcion,
            });


        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener las personas", e);
        }
    }
    public async Task<bool> Update(PersonaDto dto)
    {
        try
        {
            if (await _personaRepository.EmailExists(dto.Email, dto.Id))
                throw new ApplicationException("ya hay una persona con ese Email");
            Plan? plan = null;
            if (dto.IdPlan is int idPlan)
                plan = await _planRepository.Get(idPlan);
            Persona persona = new Persona(
                id:  dto.Id,
                nombre:  dto.Nombre,
                apellido:  dto.Apellido,
                direccion:  dto.Direccion,
                telefono:  dto.Telefono,
                email:  dto.Email,
                legajo:  dto.Legajo,
                fechaNacimiento:  dto.FechaNacimiento,
                tipoPersona:  dto.TipoPersona,
                plan: plan);
            return await _personaRepository.Update(persona);
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al editar persona", e);
        }
    }
}