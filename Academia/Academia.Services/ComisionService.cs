using Academia.Data;
using Academia.Dtos;
using Academia.Models;

namespace Academia.Services;

public class ComisionService
{
    private readonly ComisionRepository _comisionRepository;
    private readonly PlanRepository _planRepository;


    public ComisionService(ComisionRepository comisionRepository, PlanRepository planRepository)
    {
        _comisionRepository = comisionRepository;
        _planRepository = planRepository;
    }

    public async Task New(ComisionDto comisionDto)
    {
        try
        {
            Plan? plan = await _planRepository.Get(comisionDto.IdPlan);
            if (plan != null) 
            {
                Comision comision = new Comision(comisionDto.Id,
                    comisionDto.Descripcion,
                    comisionDto.AnioEspecialidad,
                    plan);
                await _comisionRepository.Add(comision);
            }
            
        }
        catch (Exception e)
        {
            throw new Exception("error al crear la comision", e);
        }
    }

}

