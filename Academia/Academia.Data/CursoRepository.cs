using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class CursoRepository
{
    private readonly Context _context;

    public CursoRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(Curso curso)
    {
        await _context.Cursos.AddAsync(curso);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var curso = await _context.Cursos.FindAsync(id);
        if (curso == null)
        {
            return false;
        }
        _context.Cursos.Remove(curso);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Curso?> Get(int id)
    {
        return await _context.Cursos
            .Include(c => c.Materia)
            .Include(c => c.Comision)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Curso>> GetAll()
    {
        return await _context.Cursos
            .Include(c => c.Materia)
            .Include(c => c.Comision)
            .ToListAsync();
    }

    public async Task<bool> Update(Curso curso)
    {
        var cursoToUpdate = await _context.Cursos.FindAsync(curso.Id);
        if (cursoToUpdate == null)
        {
            return false;
        }
        _context.Entry(cursoToUpdate).CurrentValues.SetValues(curso);
        await _context.SaveChangesAsync();
        return true;
    }
}