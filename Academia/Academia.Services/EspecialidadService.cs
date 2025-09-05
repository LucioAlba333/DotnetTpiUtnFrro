using Academia.Data;
using Academia.Dtos;
using Academia.Models;
using Academia.Services.Interfaces;

namespace Academia.Services;

public class EspecialidadService: IEntityService<EspecialidadDto>
{
    public void New(EspecialidadDto dto)
    {
        dto.Id = EspecialidadData.GenerarId();
        Especialidad especialidad = new Especialidad(dto.Id, dto.Descripcion);
        EspecialidadData.Especialidades.Add(especialidad);
    }

    public bool Delete(int id)
    {
        Especialidad? especialidad =
            EspecialidadData.Especialidades.Find(x => x.Id == id);
        if (especialidad != null)
        {
            EspecialidadData.Especialidades.Remove(especialidad);
            return true;
        }
        return false;
    }

    public EspecialidadDto? Get(int id)
    {
        Especialidad? e = EspecialidadData.Especialidades.Find(x => x.Id == id);

        if (e != null)
        {
            return new EspecialidadDto { Id = e.Id, Descripcion = e.Descripcion };
        }

        return null;
    }

    public IEnumerable<EspecialidadDto> GetAll()
    {
     var especialidades = EspecialidadData.Especialidades.Select(e => new Especialidad(e)).ToList();
     return especialidades.Select(especialidad => new EspecialidadDto
     {
         Id = especialidad.Id, 
         Descripcion = especialidad.Descripcion
     });
    }

    public bool Update(EspecialidadDto dto)
    {
        Especialidad? e =
            EspecialidadData.Especialidades.Find(x => x.Id == dto.Id);
        if (e != null)
        {
            e.Descripcion = dto.Descripcion;
            return true;
        }
        return false;
    }
}