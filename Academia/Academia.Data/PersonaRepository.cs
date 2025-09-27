using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class PersonaRepository
{
    private readonly Context _context;

    public PersonaRepository(Context context)
    {
        _context = context;
    }

    public async Task Add(Persona persona)
    {
        _context.Personas.Add(persona);
        await _context.SaveChangesAsync();
    }

    public async Task<bool> Delete(int id)
    {
        var persona = await _context.Personas.FindAsync(id);
        if (persona == null)
            return false;
        _context.Personas.Remove(persona);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<Persona?> Get(int id)
    {
        return await _context.Personas.FirstOrDefaultAsync(e=>e.Id == id);
    }

    public async Task<IEnumerable<Persona>> GetAll()
    {
        return await _context.Personas
            .Include(e=>e.Plan)
            .OrderBy(e=>e.Id)
            .ToListAsync();
    }

    public async Task<bool> Update(Persona persona)
    {
        var personaToUpdate = await _context.Personas.FindAsync(persona.Id);
        if (personaToUpdate == null)
            return false;
        _context.Entry(personaToUpdate).CurrentValues.SetValues(persona);
        await _context.SaveChangesAsync();
        return true;
    }
}