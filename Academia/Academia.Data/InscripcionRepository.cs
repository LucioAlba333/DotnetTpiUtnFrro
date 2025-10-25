using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class InscripcionRepository
{
    private readonly Context _context;

    public InscripcionRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(Inscripcion inscripcion)
    {
        await _context.Inscripciones.AddAsync(inscripcion);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var inscripcion = await _context.Inscripciones.FindAsync(id);
        if (inscripcion == null)
        {
            return false;
        }
        _context.Inscripciones.Remove(inscripcion);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Inscripcion?> Get(int id)
    {
        return await _context.Inscripciones
            .Include(i => i.Alumno)
            .Include(i => i.Curso)
            .FirstOrDefaultAsync(i => i.Id == id);
    }

    public async Task<IEnumerable<Inscripcion>> GetAll()
    {
        return await _context.Inscripciones
            .Include(i => i.Alumno)
            .Include(i => i.Curso)
            .ToListAsync();
    }

    public async Task<bool> Update(Inscripcion inscripcion)
    {
        var inscripcionToUpdate = await _context.Inscripciones.FindAsync(inscripcion.Id);
        if (inscripcionToUpdate == null)
        {
            return false;
        }
        _context.Entry(inscripcionToUpdate).CurrentValues.SetValues(inscripcion);
        await _context.SaveChangesAsync();
        return true;
    }
}