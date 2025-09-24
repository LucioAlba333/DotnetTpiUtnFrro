using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Data;

public class EspecialidadRepository
{
	private Context _context;
	public EspecialidadRepository(Context context)
	{
		_context = context;
	}

	public async Task Add(Especialidad entity)
	{
		_context.Especialidades.Add(entity);
		await _context.SaveChangesAsync();
	}

	public async Task<bool> Delete(int id)
	{
		var entity = await _context.Especialidades.FindAsync(id);
		if (entity == null)
		{
			return false;
		}
		_context.Especialidades.Remove(entity);
		await _context.SaveChangesAsync();
		return true;
	}

	public async Task<Especialidad?> Get(int id)
	{
		return await _context.Especialidades.FirstOrDefaultAsync(e  => e.Id == id);
	}

	public async Task<IEnumerable<Especialidad>> GetAll()
	{
		return await _context.Especialidades.OrderBy(e => e.Id).ToListAsync();
	}

	public async Task<bool> Update(Especialidad entity)
	{
		var especialidad = await _context.Especialidades.FindAsync(entity.Id);
		if (especialidad == null)
		{
			return false;
		}
		especialidad.SetDescripcion(entity.Descripcion);
		await _context.SaveChangesAsync();
		return true;
	}
	public async Task<bool> EspecialidadExists(string descripcion, int? excludeId = null)
	{
		var query = _context.Especialidades
			.Where(e => e.Descripcion.ToLower() == descripcion.ToLower());
		if (excludeId.HasValue)
		{
			query = query.Where(c => c.Id != excludeId.Value);
		}
		return await query.AnyAsync();
	}
}
