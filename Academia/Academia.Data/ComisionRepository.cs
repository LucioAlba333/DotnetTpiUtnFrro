using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class ComisionRepository
{
    private readonly Context _context;

    public ComisionRepository(Context context)
    {
        _context = context;
    }
    public async Task Add(Comision comision)
    {
        await _context.Comisiones.AddAsync(comision);
        await _context.SaveChangesAsync();
    }
    public async Task<bool> Delete(int id)
    {
        var comision = await _context.Comisiones.FindAsync(id);
        if(comision == null) 
        {
            return false;
        }
        _context.Remove(comision);
        await _context.SaveChangesAsync();
        return true;
    }
    public async Task<Comision?> Get(int id)
    {
        return await _context.Comisiones
            .Include(e => e.Plan)
            .FirstOrDefaultAsync(e => e.Id == id);
    }
    public async Task<IEnumerable<Comision>> GetAll()
    {
        return await _context.Comisiones
            .Include(e => e.Plan)
            .ToListAsync();
    }
    public async Task<bool> Update(Comision comision)
    {
        var comisionToUpdate = await _context.Comisiones.FindAsync(comision.Id);
        if(comisionToUpdate == null)
        {
            return false;
        }
        _context.Entry(comisionToUpdate).CurrentValues.SetValues(comision);
        await _context.SaveChangesAsync();
        return true;
    }
}

