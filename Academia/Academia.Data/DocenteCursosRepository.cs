using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class DocenteCursosRepository
{
    private readonly Context _context;

    public DocenteCursosRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(DocenteCursos docenteCurso)
    {
        await _context.DocenteCursos.AddAsync(docenteCurso);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var docenteCurso = await _context.DocenteCursos.FindAsync(id);
        if (docenteCurso == null)
        {
            return false;
        }
        _context.DocenteCursos.Remove(docenteCurso);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<DocenteCursos?> Get(int id)
    {
        return await _context.DocenteCursos
            .Include(dc => dc.Docente)
            .Include(dc => dc.Curso)
            .FirstOrDefaultAsync(dc => dc.Id == id);
    }

    public async Task<IEnumerable<DocenteCursos>> GetAll()
    {
        return await _context.DocenteCursos
            .Include(dc => dc.Docente)
            .Include(dc => dc.Curso)
            .ToListAsync();
    }

    public async Task<bool> Update(DocenteCursos docenteCurso)
    {
        var existing = await _context.DocenteCursos.FindAsync(docenteCurso.Id);
        if (existing == null)
        {
            return false;
        }
        _context.Entry(existing).CurrentValues.SetValues(docenteCurso);
        await _context.SaveChangesAsync();
        return true;
    }
}