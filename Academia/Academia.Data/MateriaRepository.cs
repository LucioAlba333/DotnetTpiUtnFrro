using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class MateriaRepository
{
    private readonly Context _context;

    public MateriaRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(Materia materia)
    {
        _context.Materias.Add(materia);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var materia = await _context.Materias.FindAsync(id);
        if (materia == null)
        {
            return false;
        }
        _context.Materias.Remove(materia);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Materia?> Get(int id)
    {
        return await _context.Materias
            .Include(m => m.Plan)
            .FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<IEnumerable<Materia>> GetAll()
    {
        return await _context.Materias
            .Include(m => m.Plan)
            .ToListAsync();
    }

    public async Task<bool> Update(Materia entity)
    {
        var materia = await _context.Materias.FindAsync(entity.Id);
        if (materia == null)
        {
            return false;
        }

        _context.Entry(materia).CurrentValues.SetValues(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}