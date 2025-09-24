using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class EspecialidadService: IEntityService<EspecialidadDto>
{
    private readonly EspecialidadRepository _repository;

    public EspecialidadService(EspecialidadRepository repository)
    {
        _repository = repository;
    }
   
    public async Task New(EspecialidadDto dto)
    {
        try
        {
            if (await _repository.EspecialidadExists(dto.Descripcion))
            {
                throw new ArgumentException($"ya existe una especialidad con descripcion '{dto.Descripcion}'.");
            }
            Especialidad especialidad = new Especialidad(dto.Id, dto.Descripcion);
            await _repository.Add(especialidad);
        }
        catch (Exception e)
        {
            throw new ApplicationException("error al crear la especialidad", e);
        }
    }

    public async Task<bool> Delete(int id)
    {

        try
        {
            return await _repository.Delete(id);
        }
        catch (Exception e)
        {
            throw new ApplicationException($"error al eliminar la especialidad con id: {id}", e);
        }
    }

    public async Task<EspecialidadDto?> Get(int id)
    {
        try
        {
            Especialidad? especialidad = await _repository.Get(id);
            if (especialidad == null)
                return null;
            return new EspecialidadDto
            {
                Id = especialidad.Id,
                Descripcion = especialidad.Descripcion
            };
        }
        catch (Exception e)
        {
            throw new ApplicationException($"error al obtener la especialidad con id: {id}", e);
        }
    }

    public async Task<IEnumerable<EspecialidadDto>> GetAll()
    {
        try
        {
            var especialidades = await _repository.GetAll();
            return especialidades.Select(e => new EspecialidadDto
            {
                Id = e.Id,
                Descripcion = e.Descripcion
            }).ToList();

        }
        catch (Exception e)
        {
            throw new ApplicationException("error al obtener todas las especialidades", e);
        }
    }

    public async Task<bool> Update(EspecialidadDto dto)
    {
        try
        {
            if (await _repository.EspecialidadExists(dto.Descripcion, dto.Id))
            {
                throw new ArgumentException($"Ya existe otra especialidad con descripcion '{dto.Descripcion}'.");
            }
            Especialidad especialidad = new Especialidad(dto.Id, dto.Descripcion);
            return await _repository.Update(especialidad);

        }
        catch (Exception e)
        {
            throw new ApplicationException("error al editar la especialidad", e);
        }
    }
}